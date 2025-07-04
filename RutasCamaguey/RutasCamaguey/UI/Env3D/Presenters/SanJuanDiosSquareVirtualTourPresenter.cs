using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class SanJuanDiosSquareVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        [Preserve]
        public SanJuanDiosSquareVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/SanJuanDiosSquare_Material.xml");
        }
    }
}
