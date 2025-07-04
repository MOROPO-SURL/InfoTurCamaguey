using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class VirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        [Preserve]
        public VirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/VirtualTour1_Material.xml");
        }
    }
}
