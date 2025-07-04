using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class BirthplaceMuseumVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        [Preserve]
        public BirthplaceMuseumVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/BirthplaceMuseum_Material.xml");
        }
    }
}
