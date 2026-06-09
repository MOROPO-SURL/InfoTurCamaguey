using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class MartiParkVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        public MartiParkVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/MartiPark_Material.xml");
        }
    }
}
