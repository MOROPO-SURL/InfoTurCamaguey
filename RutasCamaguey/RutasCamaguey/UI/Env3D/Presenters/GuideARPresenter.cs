using EasyAR;
using MOROPO.InfoTur.Camaguey.Rutas.Extensions;
using MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class GuideARPresenter : Application
    {
        private Scene foregroundScene;
        private Octree foregroundOctree;
        private Camera urhoCameraComponent;
        private EasyARUrhoComponent easyARUrhoComponent;

        private readonly System.Collections.Generic.Dictionary<string, Node> targetIdentitficationNodes;

        [Preserve]
        public GuideARPresenter(ApplicationOptions options) : base(options)
        {
            targetIdentitficationNodes = new System.Collections.Generic.Dictionary<string, Node>();
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
                var target = result.Value.Drawable as IPlaceDataBindable;

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

                        System.Diagnostics.Debug.WriteLine($"XXXXXXXX>>>> Target Count: {targetInstances.Count}");

                        var targetKeys = new List<string>();

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

                                        targetKeys.Add(imageTarget.name());

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

                        var targetIdentitficationNodeKeys = targetIdentitficationNodes.Keys.ToArray();

                        foreach (var key in targetIdentitficationNodeKeys)
                        {
                            if (targetKeys.Any(item => item == key)) continue;

                            targetIdentitficationNodes.Remove(key, out var node);

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

            var calloutNodes = new List<Node>();

            var targetName = target.name();

            if (targetIdentitficationNodes.ContainsKey(targetName))
            {
                rootNode = targetIdentitficationNodes[targetName];
            }
            else
            {
                rootNode = foregroundScene.CreateChild();

                var targetNode = rootNode.CreateChild();

                System.Diagnostics.Debug.WriteLine($"YYYYYYYY>>>> targetName: {targetName}");

                switch (targetName)
                {
                    case Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_1:
                    case Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_2:
                        targetNode.Position = new Vector3(0.0f, 0.0f, -0.5f);

                       // var infoTourPlaceNode = targetNode.CreateChild();

                       // calloutNodes.Add(ConfigureMarkerNode(infoTourPlaceNode, Providers.DataModelProvider.Places[5], 0.275f, 0.1f, false));

                       // var natalHouseMuseumPlaceNode = targetNode.CreateChild();

                       // calloutNodes.Add(ConfigureMarkerNode(natalHouseMuseumPlaceNode, Providers.DataModelProvider.Places[6], -0.09f, -0.15f, false));

                       // var churchConventOurLadyOfMercyPlaceNode = targetNode.CreateChild();

                       // calloutNodes.Add(ConfigureMarkerNode(churchConventOurLadyOfMercyPlaceNode, Providers.DataModelProvider.Places[7], -0.02f, 0.05f, true));

                        var workersSquarePlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(workersSquarePlaceNode, Providers.DataModelProvider.Places[8], -0.25f, 0.03f, true));

                        var churchOurLadyOfSolitudePlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(churchOurLadyOfSolitudePlaceNode, Providers.DataModelProvider.Places[3], 0.570f, 0.17f, false));

                        var ignacioAgramonteStreetPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(ignacioAgramonteStreetPlaceNode, Providers.DataModelProvider.Places[4], 0.275f, 0.0f, false));

                        break;

                    case Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_3:
                    case Providers.ConstantProvider.GUIDE_SEGMENT_TARGET_4:
                        targetNode.Position = new Vector3(0.0f, 0.0f, -0.5f);

                        var railwayMuseumTourPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(railwayMuseumTourPlaceNode, Providers.DataModelProvider.Places[1], 0.0375f, -0.125f, false));

                        var stateMuseumMuseumPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(stateMuseumMuseumPlaceNode, Providers.DataModelProvider.Places[0], -0.125f, 0.25f, true));

                        var plazaHotelPlaceNode = targetNode.CreateChild();

                        calloutNodes.Add(ConfigureMarkerNode(plazaHotelPlaceNode, Providers.DataModelProvider.Places[2], 0.0875f, -0.250f, true));

                        break;
                }

                targetIdentitficationNodes.Add(targetName, rootNode);
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
            var calloutBodyWidth = 1.2f;
            var calloutBodyWeight = 0.025f;

            var calloutNode = markerNode.CreateChild();

            var calloutNodePositionX = (calloutBodyWidth + pinHeadNode.Scale.X) / 2.0f;

            if (calloutLeftSide) calloutNodePositionX *= -1;

            calloutNode.Position = new Vector3(calloutNodePositionX, 0, pinHeadNode.Position.Z);
            calloutNode.Rotation = new Quaternion(65.0f, 0.0f, 0.0f);

            var calloutBodyNode = calloutNode.CreateChild();

            var calloutBodyNodePositionX = pinHeadNode.Scale.X / 2;

            if (calloutLeftSide) calloutBodyNodePositionX *= -1;

            calloutBodyNode.Position = new Vector3(calloutBodyNodePositionX, 0, 0);
            calloutBodyNode.Scale = new Vector3(calloutBodyWidth, calloutBodyWeight, calloutBodyHeight);

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

            var calloutFeatureImageSpriteNode = calloutNode.CreateChild();

            calloutFeatureImageSpriteNode.Position = new Vector3(calloutBodyNode.Position.X - calloutBodyWidth / 2.0f + calloutBodyHeight / 2.0f, calloutBodyNode.Position.Y - calloutBodyWeight, calloutBodyNode.Position.Z);
            calloutFeatureImageSpriteNode.Scale = new Vector3(0.05f, 0.05f, 1.0f);
            calloutFeatureImageSpriteNode.Rotation = new Quaternion(90.0f, 0, 180.0f);

            var calloutFeatureImageSpriteComponent = calloutFeatureImageSpriteNode.CreateComponent<PlaceFeatureImageSprite>();

            calloutFeatureImageSpriteComponent.Place = dataModel;
            calloutFeatureImageSpriteComponent.Sprite = Current.ResourceCache.GetSprite2D($"Sprites/{dataModel.Id.ToString().ToUpperInvariant()}.jpg");

            var calloutTextNode = calloutNode.CreateChild();

            calloutTextNode.Position = new Vector3(calloutBodyNode.Position.X - calloutBodyWidth / 6.0f, calloutBodyNode.Position.Y - calloutBodyWeight, calloutBodyNode.Position.Z);
            calloutTextNode.Rotation = new Quaternion(-90.0f, 0, 0);

            var calloutTextComponent = calloutTextNode.CreateComponent<PlaceName3DText>();

            calloutTextComponent.Place = dataModel;
            calloutTextComponent.Text = dataModel.Title;
            calloutTextComponent.Wordwrap = true;
            calloutTextComponent.Width = 100;
            calloutTextComponent.HorizontalAlignment = Urho.Gui.HorizontalAlignment.Left;
            calloutTextComponent.VerticalAlignment = Urho.Gui.VerticalAlignment.Center;

            calloutTextComponent.SetFont(ResourceCache.GetFont("Fonts/OpenSans-Regular.ttf"), 8);
            calloutTextComponent.SetColor(Color.White);

            return calloutNode;
        }

        //private void RotateNodeRelativeToCamera(Node objectNode)
        //{
        //    if (urhoCameraComponent == null || objectNode == null) return;

        //    objectNode.Rotation = urhoCameraComponent.Node.Rotation * new Quaternion(1, 0, 0, 0);
        //}

        private interface IPlaceDataBindable
        {
            public Models.Data.PlaceDataModel Place { get; }
        }

        private class Place3DModel : StaticModel, IPlaceDataBindable
        {
            public Models.Data.PlaceDataModel Place { get; set; }
        }

        private class PlaceName3DText : Urho.Gui.Text3D, IPlaceDataBindable
        {
            public Models.Data.PlaceDataModel Place { get; set; }
        }

        private class PlaceFeatureImageSprite : Urho.Urho2D.StaticSprite2D, IPlaceDataBindable
        {
            public Models.Data.PlaceDataModel Place { get; set; }
        }
    }

    public class GuideARPresenterPlaceTargetEventArg : System.EventArgs
    {
        public Models.Data.PlaceDataModel Place { get; set; }
    }
}
