using Urho;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Env3D.Presenters
{
    public class WorkersSquareVirtualTourPresenter : Contract.AbstractVirtualTourPresenter
    {
        [Preserve]
        public WorkersSquareVirtualTourPresenter(ApplicationOptions options) : base(options)
        {
        }

        protected override Material GetSkyMaterial()
        {
            return ResourceCache.GetMaterial("Materials/WorkersSquare_Material.xml");
        }
    }
}
