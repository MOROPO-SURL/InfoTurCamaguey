using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Components
{
    public class EasyARBackgroundComponent : Component
    {
        private Material material;

        public EasyARBackgroundComponent(Material material)
        {
            this.material = material;
        }

        public override void OnAttachedToNode(Node node)
        {
            var geometry = node.CreateComponent<CustomGeometry>();

            geometry.BeginGeometry(0, PrimitiveType.TriangleFan);
            geometry.DefineVertex(new Vector3(-1, -1, 0));
            geometry.DefineTexCoord(new Vector2(0.0f, 1.0f));
            geometry.DefineVertex(new Vector3(1, -1, 0));
            geometry.DefineTexCoord(new Vector2(1.0f, 1.0f));
            geometry.DefineVertex(new Vector3(1, 1, 0));
            geometry.DefineTexCoord(new Vector2(1.0f, 0.0f));
            geometry.DefineVertex(new Vector3(-1, 1, 0));
            geometry.DefineTexCoord(new Vector2(0.0f, 0.0f));
            geometry.Commit();

            geometry.SetMaterial(material);

            geometry.CastShadows = false;

            node.Translate(new Vector3(0, 0, 1));

            base.OnAttachedToNode(node);
        }
    }
}
