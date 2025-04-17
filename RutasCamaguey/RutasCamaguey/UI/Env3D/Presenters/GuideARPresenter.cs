using EasyAR;
using MOROPO.InfoTur.Camaguey.Rutas.Extensions;
using MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Components;
using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class GuideARPresenter : Application
    {
        private Scene foregroundScene;
        private Octree foregroundOctree;
        private Camera urhoCameraComponent;
        private EasyARUrhoComponent easyARUrhoComponent;

        private readonly System.Collections.Generic.List<Node> targetIdentitficationNodes;

        [Preserve]
        public GuideARPresenter(ApplicationOptions options) : base(options)
        {
            targetIdentitficationNodes = new System.Collections.Generic.List<Node>();
        }

        public System.EventHandler<GuideARPresenterPlaceTargetEventArg> PlaceTarget;

        protected override void Start()
        {
            base.Start();

            Renderer.NumViewports = 2;

            Init3DScene();
        }

        protected override void Stop()
        {
            base.Stop();

            Input.TouchEnd -= Input_TouchEnd;

            easyARUrhoComponent.ARFrameUpdated -= OnARFrameUpdated;

            easyARUrhoComponent.Dispose();
        }

        private void Init3DScene()
        {
            foregroundScene = new Scene();

            foregroundOctree = foregroundScene.CreateComponent<Octree>();

            var zoneComponent = foregroundScene.CreateComponent<Zone>();

            zoneComponent.AmbientColor = Color.White * 0.25f;

            var cameraNode = foregroundScene.CreateChild();

            cameraNode.Position = new Vector3(0, 0, 0);

            cameraNode.LookAt(new Vector3(0, 0, 1), new Vector3(0, 1, 0));

            urhoCameraComponent = cameraNode.CreateComponent<Camera>();

            var lightNode = foregroundScene.CreateChild();

            lightNode.Position = new Vector3(0, 0, -10);

            var lightComponent = lightNode.CreateComponent<Light>();

            lightComponent.LightType = LightType.Directional;
            lightComponent.SpecularIntensity = 0.5f;

            var foregroundViewport = new Viewport(Context, foregroundScene, urhoCameraComponent, null);

            foregroundViewport.RenderPath = foregroundViewport.RenderPath.Clone();
            foregroundViewport.RenderPath.RemoveCommand(0);

            foregroundViewport.SetClearColor(Color.Transparent);

            easyARUrhoComponent = foregroundScene.CreateComponent<EasyARUrhoComponent>();

            easyARUrhoComponent.ARFrameUpdated += OnARFrameUpdated;

            Input.TouchEnd += Input_TouchEnd;

            Renderer.SetViewport(1, foregroundViewport);
        }

        public void Input_TouchEnd(TouchEndEventArgs eventArgs)
        {
            var cameraRay = urhoCameraComponent.GetScreenRay((float)eventArgs.X / Application.Current.Graphics.Width, (float)eventArgs.Y / Application.Current.Graphics.Height);

            var result = foregroundOctree.RaycastSingle(cameraRay);

            if (result != null)
            {
                var target = result.Value.Drawable as Place3DModel;

                if (target != null && PlaceTarget != null)
                {
                    Xamarin.Forms.Device.BeginInvokeOnMainThread(delegate
                    {
                        PlaceTarget.Invoke(this, new GuideARPresenterPlaceTargetEventArg { Place = target.Place });
                    });
                }
            }
        }

        protected void OnARFrameUpdated(OutputFrame oFrame, CameraParameters cameraParameters, float aspectRatio, int rotation)
        {
            var far = 100f;
            var near = 0.01f;

            Matrix44F easyARCameraProjection = cameraParameters.projection(near, far, aspectRatio, rotation, true, false);

            foreach (var unTypedResult in oFrame.results())
            {
                if (unTypedResult.OnSome)
                {
                    if (unTypedResult.Some is ImageTrackerResult result)
                    {
                        int targetIndex = 0;

                        var targetInstances = result.targetInstances();

                        foreach (TargetInstance targetInstance in targetInstances)
                        {
                            TargetStatus status = targetInstance.status();

                            if (status == TargetStatus.Tracking)
                            {
                                Optional<Target> optionalTarget = targetInstance.target();

                                if (optionalTarget.OnSome)
                                {
                                    Target target = optionalTarget.Some;

                                    if (target is ImageTarget imageTarget)
                                    {
                                        var images = imageTarget.images();

                                        var targetImage = images[0];

                                        var urhoCameraProjection = easyARCameraProjection.ToUrhoMatrix();

                                        urhoCameraProjection.M34 /= 2f;
                                        urhoCameraProjection.M33 = far / (far - near);
                                        urhoCameraProjection.M43 *= -1;

                                        urhoCameraComponent.SetProjection(urhoCameraProjection);

                                        var convertedPoseMatrix = targetInstance.pose().ToUrhoMatrix();

                                        var scale = new Vector3(imageTarget.scale(), imageTarget.scale() * targetImage.height() / targetImage.width(), 1);

                                        UpdateARScene(target, targetIndex, convertedPoseMatrix, scale);

                                        foreach (Image targetImageToRelease in images)
                                        {
                                            targetImageToRelease.Dispose();
                                        }
                                    }

                                    target.Dispose();
                                }
                            }

                            targetInstance.Dispose();

                            targetIndex++;
                        }

                        // Remove any targets that can no longer be located
                        while (targetIdentitficationNodes.Count > targetIndex)
                        {
                            Node node = targetIdentitficationNodes[targetIndex];

                            targetIdentitficationNodes.RemoveAt(targetIndex);

                            node.Remove();
                        }
                    }

                    unTypedResult.Some.Dispose();
                }
            }
        }

        private void UpdateARScene(Target target, int index, Matrix4 poseMatrix, Vector3 scale)
        {
            Node rootNode;

            var calloutNodes = new System.Collections.Generic.List<Node>();

            if (targetIdentitficationNodes.Count > index)
            {
                rootNode = targetIdentitficationNodes[index];
            }
            else
            {
                rootNode = foregroundScene.CreateChild();

                var targetNode = rootNode.CreateChild();

                // The box is a unit cube cenered a (0,0) we need to shift it a little or cube will be partially behind the target and look wrong.
                var targetName = target.name();

                switch (targetName)
                {
                    case Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_1:
                        targetNode.Position = new Vector3(0.0f, 0.0f, -0.5f);

                        var infoTourPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(infoTourPlaceNode, Providers.DataModelProvider.Places[0], 0.275f, 0.1f, false));

                        //infoTourPlaceNode.Position = new Vector3(0.275f, 0.1f, 0.0f);
                        //infoTourPlaceNode.Scale = new Vector3(0.025f, 1.0f, 0.025f);                        
                        //infoTourPlaceNode.Rotation = new Quaternion(90.0f, 0.0f, 0.0f);

                        //var infoTurPlaceModel = infoTourPlaceNode.CreateComponent<Urho.Shapes.Cylinder>();

                        //infoTurPlaceModel.Color = Color.Yellow;

                        var natalHouseMuseumPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(natalHouseMuseumPlaceNode, Providers.DataModelProvider.Places[1], -0.1f, -0.2f, true));

                        //natalHouseMuseumPlaceNode.Position = new Vector3(-0.1f, -0.2f, 0.0f);
                        //natalHouseMuseumPlaceNode.Scale = new Vector3(0.025f, 1.0f, 0.025f);
                        //natalHouseMuseumPlaceNode.Rotation = new Quaternion(90.0f, 0.0f, 0.0f);

                        //var natalHouseMuseumPlaceModel = natalHouseMuseumPlaceNode.CreateComponent<Urho.Shapes.Cylinder>();

                        //natalHouseMuseumPlaceModel.Color = Color.Yellow;

                        break;
                }

                targetIdentitficationNodes.Add(rootNode);
            }

            // Flatten out the cube
            //scale.Z *= 0.5f;

            // Reverse handedness of pose's rotation
            var rotation = poseMatrix.Rotation;

            rotation.Z *= -1;
            rotation.W *= -1;

            var pos = poseMatrix.Column3;

            rootNode.Position = new Vector3(pos.X, pos.Y, -pos.Z); // Reverse handedness of the poses position
            rootNode.Rotation = rotation;
            rootNode.Scale = scale;

            //foreach (var node in calloutNodes)
            //{
            //    RotateNodeRelativeToCamera(node);
            //}
        }

        private Node ConfigureMarkerNode(Node markerNode, Models.Data.PlaceDataModel dataModel, float traslationX, float traslationY, bool calloutLeftSide)
        {
            var primaryColor = Color.FromHex("1D184B");
            var secoundarColor = Color.FromHex("FDE443");

            markerNode.Position = new Vector3(traslationX, traslationY, 0.0f);

            var pinBodyNode = markerNode.CreateChild();

            pinBodyNode.Scale = new Vector3(0.05f, 1.0f, 0.05f);
            pinBodyNode.Rotation = new Quaternion(90.0f, 0.0f, 0.0f);

            var pinBodyComponent = pinBodyNode.CreateComponent<Urho.Shapes.Cylinder>();

            pinBodyComponent.Color = secoundarColor;

            var pinHeadNode = markerNode.CreateChild();

            pinHeadNode.Position = new Vector3(0, 0, -0.5f);
            pinHeadNode.Scale = new Vector3(0.125f, 0.125f, 0.125f);

            var pinHeadComponent = pinHeadNode.CreateComponent<Urho.Shapes.Sphere>();

            pinHeadComponent.Color = primaryColor;

            var calloutBodyHeight = 0.4f;
            var calloutBodyWidth = 0.75f;

            var calloutNode = markerNode.CreateChild();

            var calloutNodePositionX = (calloutBodyWidth + pinHeadNode.Scale.X) / 2.0f;

            if (calloutLeftSide) calloutNodePositionX *= -1;

            calloutNode.Position = new Vector3(calloutNodePositionX, 0, pinHeadNode.Position.Z);
            calloutNode.Rotation = new Quaternion(45.0f, 0.0f, 0.0f);

            var calloutBodyNode = calloutNode.CreateChild();

            var calloutBodyNodePositionX = pinHeadNode.Scale.X / 2;

            if (calloutLeftSide) calloutBodyNodePositionX *= -1;

            calloutBodyNode.Position = new Vector3(calloutBodyNodePositionX, 0, 0);
            calloutBodyNode.Scale = new Vector3(calloutBodyWidth, 0.025f, calloutBodyHeight);

            var calloutBodyComponent = calloutBodyNode.CreateComponent<Place3DModel>();

            calloutBodyComponent.Place = dataModel;
            calloutBodyComponent.Model = CoreAssets.Models.Box;
            calloutBodyComponent.Material = Material.FromColor(primaryColor);

            var calloutChevronNode = calloutNode.CreateChild();

            var calloutChevronNodePositionX = calloutBodyWidth / 2.0f - pinHeadNode.Scale.X / 2.0f;

            if (!calloutLeftSide) calloutChevronNodePositionX *= -1;

            calloutChevronNode.Position = new Vector3(calloutChevronNodePositionX, 0, 0);
            calloutChevronNode.Scale = new Vector3(calloutBodyHeight * 0.25f, 0.025f, calloutBodyHeight * 0.25f);
            calloutChevronNode.Rotation = new Quaternion(0, 45.0f, 0);

            var calloutChevronComponent = calloutChevronNode.CreateComponent<Urho.Shapes.Box>();

            calloutChevronComponent.Color = primaryColor;

            return calloutNode;
        }

        private void RotateNodeRelativeToCamera(Node objectNode)
        {
            if (urhoCameraComponent == null || objectNode == null) return;

            objectNode.Rotation = urhoCameraComponent.Node.Rotation * new Quaternion(1, 0, 0, 0);
        }

        private class Place3DModel : StaticModel
        {
            public Models.Data.PlaceDataModel Place { get; set; }
        }
    }

    public class GuideARPresenterPlaceTargetEventArg : System.EventArgs
    {
        public Models.Data.PlaceDataModel Place { get; set; }
    }
}
