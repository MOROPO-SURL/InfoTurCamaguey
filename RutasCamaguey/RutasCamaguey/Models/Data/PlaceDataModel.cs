namespace MOROPO.InfoTur.Camaguey.Rutas.Models.Data
{
    public class PlaceDataModel
    {
        public Enumerations.PlaceKind Kind { get; set; }

        public Content.Contract.AbstractFeatureContentDataModel FeatureContent { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public Content.Contract.AbstractContentDataModel[] Content { get; set; }
    }
}
