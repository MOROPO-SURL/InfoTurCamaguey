using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class IgnacioAgramonteParkVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        public IgnacioAgramonteParkVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/IgnacioAgramontePark_Material.xml");
        }
    }
}
