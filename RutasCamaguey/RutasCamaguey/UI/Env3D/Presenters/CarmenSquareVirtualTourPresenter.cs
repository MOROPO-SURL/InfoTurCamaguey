using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class CarmenSquareVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        [Preserve]
        public CarmenSquareVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/CarmenSquare_Material.xml");
        }
    }
}
