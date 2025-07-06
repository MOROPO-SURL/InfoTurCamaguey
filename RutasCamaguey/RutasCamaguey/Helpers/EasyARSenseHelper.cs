using EasyAR;
using System.Collections.Generic;
using System;

namespace MOROPO.InfoTur.Camaguey.Rutas.Helpers
{
    public class EasyARSenseHelper : IDisposable
    {
        private DelayedCallbackScheduler scheduler;
        private CameraDevice camera;
        private ImageTracker tracker;
        private Dictionary<int, ImageTarget> trackedTargets;
        private InputFrameThrottler throttler;
        private OutputFrameFork outputFrameFork;
        private OutputFrameBuffer outputFrameBuffer;
        private InputFrameToFeedbackFrameAdapter i2FAdapter;

        public event Action<OutputFrame> FrameCaptured;

        public EasyARSenseHelper()
        {
            trackedTargets = new Dictionary<int, ImageTarget>();

            Initialize();
        }

        private void LoadFromImage(ImageTracker tracker, string path, string name)
        {
            var imageTarget = ImageTarget.createFromImageFile(path, StorageType.Assets, name, string.Empty, string.Empty, 1f);

            if (imageTarget.OnNone)
            {
                System.Diagnostics.Debug.WriteLine("create {0} imagetarget failed", name);

                return;
            }

            tracker.loadTarget(imageTarget.Value, scheduler, (t, status) =>
            {
                System.Diagnostics.Debug.WriteLine("load target ({0}): {1} ({2})", status, t.name(), t.runtimeID());
            });
        }

        private void Initialize()
        {
            scheduler = new DelayedCallbackScheduler();
            camera = CameraDeviceSelector.createCameraDevice(CameraDevicePreference.PreferObjectSensing);
            throttler = InputFrameThrottler.create();
            i2FAdapter = InputFrameToFeedbackFrameAdapter.create();
            outputFrameFork = OutputFrameFork.create(2);
            outputFrameBuffer = OutputFrameBuffer.create();

            if (!camera.openWithPreferredType(CameraDeviceType.Back)) { throw new PlatformNotSupportedException(); }

            camera.setSize(new Vec2I(1280, 960));

            camera.setBufferCapacity(10);

            tracker = ImageTracker.create();

            tracker.setSimultaneousNum(8);

            LoadFromImage(tracker, "AR/Targets/guide-target-1.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_1);
            LoadFromImage(tracker, "AR/Targets/guide-target-2.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_2);
            LoadFromImage(tracker, "AR/Targets/guide-target-3.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_3);
            LoadFromImage(tracker, "AR/Targets/guide-target-4.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_4);
            LoadFromImage(tracker, "AR/Targets/guide-target-5.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_5);
            LoadFromImage(tracker, "AR/Targets/guide-target-6.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_6);
            LoadFromImage(tracker, "AR/Targets/guide-target-7.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_7);
            LoadFromImage(tracker, "AR/Targets/guide-target-8.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_8);
            LoadFromImage(tracker, "AR/Targets/guide-target-9.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_9);
            LoadFromImage(tracker, "AR/Targets/guide-target-10.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_10);
            LoadFromImage(tracker, "AR/Targets/guide-target-11.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_11);
            LoadFromImage(tracker, "AR/Targets/guide-target-12.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_12);
            LoadFromImage(tracker, "AR/Targets/guide-target-13.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_13);
            LoadFromImage(tracker, "AR/Targets/guide-target-14.jpg", Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_14);

            using (var ar = new AutoRelease())
            {
                camera.inputFrameSource().AddToAutoRelease(ar).connect(throttler.input().AddToAutoRelease(ar));
                throttler.output().AddToAutoRelease(ar).connect(i2FAdapter.input().AddToAutoRelease(ar));
                i2FAdapter.output().AddToAutoRelease(ar).connect(tracker.feedbackFrameSink().AddToAutoRelease(ar));
                tracker.outputFrameSource().AddToAutoRelease(ar).connect(outputFrameFork.input().AddToAutoRelease(ar));
                outputFrameFork.output(0).AddToAutoRelease(ar).connect(outputFrameBuffer.input().AddToAutoRelease(ar));

                outputFrameBuffer.signalOutput().AddToAutoRelease(ar).connect(throttler.signalInput().AddToAutoRelease(ar));
                outputFrameFork.output(1).AddToAutoRelease(ar).connect(i2FAdapter.sideInput().AddToAutoRelease(ar));
            }
        }

        public void Dispose()
        {
            foreach (var t in trackedTargets)
            {
                t.Value.Dispose();
            }

            Stop();

            trackedTargets.Clear();
            tracker.Dispose();
            camera.Dispose();

            outputFrameBuffer.Dispose();
            outputFrameFork.Dispose();
            i2FAdapter.Dispose();
            throttler.Dispose();

            scheduler.Dispose();
        }

        public bool Start()
        {
            bool status = true;

            status &= camera.start();

            camera.setFocusMode(CameraDeviceFocusMode.Continousauto);

            tracker.start();

            return status;
        }

        public void Stop()
        {
            camera.stop();

            tracker.stop();

            foreach (var t in trackedTargets)
            {
                t.Value.Dispose();
            }

            trackedTargets.Clear();
        }

        public void NextFrame()
        {
            using (var ar = new AutoRelease())
            {
                while (scheduler.runOne()) ;

                var oFrame = outputFrameBuffer.peek();

                if (oFrame.OnNone)
                {
                    return;
                }

                var frame = oFrame.Value.AddToAutoRelease(ar);

                FrameCaptured?.Invoke(frame);
            }
        }
    }

    public class AutoRelease : IDisposable
    {
        private List<Action> actions;

        public void Add(Action deleter)
        {
            if (actions == null) { actions = new List<Action>(); }
            actions.Add(deleter);
        }
        public T Add<T>(T p, Action<T> deleter)
        {
            if (p.Equals(default(T))) { return p; }

            if (actions == null) { actions = new List<Action>(); }

            actions.Add(() => deleter(p));

            return p;
        }

        public void Dispose()
        {
            if (actions != null)
            {
                foreach (var a in actions)
                {
                    a();
                }

                actions = null;
            }
        }
    }

    public static class AutoReleaseUtil
    {
        public static T AddToAutoRelease<T>(this T t, AutoRelease ar) where T : IDisposable
        {
            if (t == null) { return default; }

            ar.Add(() => t.Dispose());

            return t;
        }
        public static Optional<T> AddToAutoRelease<T>(this Optional<T> ot, AutoRelease ar) where T : IDisposable
        {
            if (ot.OnNone) { return Optional<T>.Empty; }

            var t = ot.Value;

            ar.Add(() => t.Dispose());

            return t;
        }
        public static IEnumerable<T> AddToAutoRelease<T>(this IEnumerable<T> e, AutoRelease ar) where T : IDisposable
        {
            foreach (var t in e)
            {
                if (t == null) { continue; }

                ar.Add(() => t.Dispose());
            }

            return e;
        }
        public static IEnumerable<Optional<T>> AddToAutoRelease<T>(this IEnumerable<Optional<T>> e, AutoRelease ar) where T : IDisposable
        {
            foreach (var ot in e)
            {
                if (ot.OnNone) { continue; }

                var t = ot.Value;

                ar.Add(() => t.Dispose());
            }

            return e;
        }
    }
}
