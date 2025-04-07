using EasyAR;
using MOROPO.InfoTur.Camaguey.Rutas.Extensions;
using MOROPO.InfoTur.Camaguey.Rutas.Helpers;
using System;
using Urho;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Components
{
    public class EasyARUrhoComponent : Component
    {
        private bool paused;
        private readonly EasyARBackgroundUpdateHelper backgroundUpdater;
        private readonly EasyARSenseHelper easyARSenseHelper;
        public event Action<OutputFrame, CameraParameters, float, int> ARFrameUpdated;

        // Urho components for the background
        private Scene bgScene;
        private Camera bgCamera;
        private Zone bgZone;
        private Viewport bgViewport;

        private int previousInputFrameIndex = -1;

        [Preserve]
        public EasyARUrhoComponent()
        {
            ReceiveSceneUpdates = true;

            backgroundUpdater = new EasyARBackgroundUpdateHelper();

            easyARSenseHelper = new EasyARSenseHelper();
        }

        [Preserve]
        public EasyARUrhoComponent(IntPtr handle) : base(handle)
        {
            ReceiveSceneUpdates = true;

            backgroundUpdater = new EasyARBackgroundUpdateHelper();

            easyARSenseHelper = new EasyARSenseHelper();
        }

        /// <summary>
        /// Initializes the background scene, note that this required the foreground to be at viewport 1.
        /// </summary>
        /// <param name="node"></param>
        public override void OnAttachedToNode(Node node)
        {
            Application.Paused += OnPause;
            Application.Resumed += OnResume;

            bgScene = new Scene();

            bgScene.CreateComponent<Octree>();

            bgZone = bgScene.CreateComponent<Zone>();

            bgZone.AmbientColor = Urho.Color.White;

            var cameraNode = bgScene.CreateChild();

            cameraNode.Position = new Vector3(0, 0, 0);
            cameraNode.LookAt(new Vector3(0, 0, 1), new Vector3(0, 1, 0));

            bgCamera = cameraNode.CreateComponent<Camera>();

            bgViewport = new Viewport(Context, bgScene, bgCamera, null);

            bgViewport.SetClearColor(Urho.Color.Transparent);

            Application.Renderer.SetViewport(0, bgViewport);

            var bgNode = bgScene.CreateChild();

            bgNode.AddComponent(new EasyARBackgroundComponent(backgroundUpdater.Material));

            easyARSenseHelper.FrameCaptured += EasyARSenseHelper_FrameCaptured;

            easyARSenseHelper.Start();
        }

        /// <summary>
        /// Detects new output frames and updates the camera, then passes the output frame through an event to update the foreground
        /// </summary>
        /// <param name="timeStep"></param>
        protected override void OnUpdate(float timeStep)
        {
            if (paused)
            {
                return;
            }

            easyARSenseHelper.NextFrame();

            base.OnUpdate(timeStep);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            easyARSenseHelper.FrameCaptured -= EasyARSenseHelper_FrameCaptured;

            easyARSenseHelper.Dispose();
        }

        private void EasyARSenseHelper_FrameCaptured(OutputFrame frame)
        {
            Optional<InputFrame> optionalIframe = frame.inputFrame();

            if (optionalIframe.OnSome)
            {
                InputFrame iframe = optionalIframe.Some;

                var cameraParameters = iframe.cameraParameters();

                if (cameraParameters != null)
                {
                    EasyAR.Image image = iframe.image();

                    float aspectRatio = (float)(DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Height);

                    int rotation = 0;

                    switch (DeviceDisplay.MainDisplayInfo.Rotation)
                    {
                        case DisplayRotation.Rotation90:
                            rotation = 90;

                            break;

                        case DisplayRotation.Rotation180:
                            rotation = 180;

                            break;

                        case DisplayRotation.Rotation270:
                            rotation = 270;

                            break;
                    }

                    if (iframe.index() != previousInputFrameIndex)
                    {
                        Matrix44F ip = cameraParameters.imageProjection(aspectRatio, rotation, true, false);

                        Matrix4 iprj = ip.ToUrhoMatrix();

                        bgCamera.SetProjection(iprj);

                        EasyAR.Buffer buffer = image.buffer();

                        try
                        {
                            backgroundUpdater.UpdateTexture(Application, image.format(), image.width(), image.height(), buffer);
                        }
                        finally
                        {
                            buffer.Dispose();
                        }

                        previousInputFrameIndex = iframe.index();
                    }

                    ARFrameUpdated?.Invoke(frame, cameraParameters, aspectRatio, rotation);

                    image.Dispose();

                    cameraParameters.Dispose();
                }

                iframe.Dispose();
            }
        }

        void OnPause()
        {
            Console.WriteLine("Pausing AR Component.");

            paused = true;

            EasyAR.Engine.onPause();
        }

        void OnResume()
        {
            Console.WriteLine("Resuming AR Component.");

            paused = false;

            EasyAR.Engine.onResume();
        }
    }
}
