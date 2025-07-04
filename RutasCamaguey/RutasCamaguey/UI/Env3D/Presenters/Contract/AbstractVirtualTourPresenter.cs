using Urho.Resources;
using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters.Contract
{
    public abstract class AbstractVirtualTourPresenter : Application
    {
        protected const float TOUCH_SENSITIVITY = 2;

        private float yaw;
        private float pitch;

        private Camera camera;

        [Preserve]
        public AbstractVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override void Start()
        {
            base.Start();

            var scene = new Scene();

            scene.CreateComponent<Octree>();

            // Create a directional light to the world. Enable cascaded shadows on it
            var lightNode = scene.CreateChild("DirectionalLight");

            lightNode.SetDirection(new Vector3(0.6f, -1.0f, 0.8f));

            var light = lightNode.CreateComponent<Light>();

            light.LightType = LightType.Directional;
            light.CastShadows = true;
            light.ShadowBias = new BiasParameters(0.00025f, 0.5f);
            // Set cascade splits at 10, 50 and 200 world units, fade shadows out at 80% of maximum shadow distance
            light.ShadowCascade = new CascadeParameters(10.0f, 50.0f, 200.0f, 0.0f, 0.8f);

            // Create skybox. The Skybox component is used like StaticModel, but it will be always located at the camera, giving the
            // illusion of the box planes being far away. Use just the ordinary Box model and a suitable material, whose shader will
            // generate the necessary 3D texture coordinates for cube mapping
            var skyNode = scene.CreateChild("Sky");

            skyNode.SetScale(500.0f); // The scale actually does not matter

            var skybox = skyNode.CreateComponent<Skybox>();

            skybox.Model = ResourceCache.GetModel("Models/Box.mdl");
            skybox.SetMaterial(GetSkyMaterial());

            // Create the camera. Limit far clip distance to match the fog. Note: now we actually create the camera node outside
            // the scene, because we want it to be unaffected by scene load / save
            var cameraNode = new Node();

            camera = cameraNode.CreateComponent<Camera>();

            camera.FarClip = 200.0f;

            // Set an initial position for the camera scene node above the floor
            cameraNode.Position = (new Vector3(0.0f, 5.0f, -20.0f));

            Renderer.SetViewport(0, new Viewport(Context, scene, cameraNode.GetComponent<Camera>(), null));
        }

        protected override void OnUpdate(float timeStep)
        {
            MoveCameraByTouches(timeStep);

            base.OnUpdate(timeStep);
        }

        protected abstract Material GetSkyMaterial();

        private void MoveCameraByTouches(float timeStep)
        {
            if (camera == null || Input.NumTouches <= 0) return;

            for (uint i = 0, num = Input.NumTouches; i < num; ++i)
            {
                var state = Input.GetTouch(i);

                if (state.TouchedElement != null) continue;

                if (!state.Delta.IsEmpty)
                {
                    yaw += TOUCH_SENSITIVITY * camera.Fov / Graphics.Height * state.Delta.X;

                    pitch += TOUCH_SENSITIVITY * camera.Fov / Graphics.Height * state.Delta.Y;

                    camera.Node.Rotation = new Quaternion(pitch, yaw, 0);
                }
                else
                {
                    var cursor = UI.Cursor;

                    if (cursor != null && cursor.Visible)
                    {
                        cursor.Position = state.Position;
                    }
                }
            }
        }
    }
}
