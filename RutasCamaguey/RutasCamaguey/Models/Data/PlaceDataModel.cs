namespace MOROPO.InfoTur.Camaguey.Rutas.Models.Data
{
    public class PlaceDataModel
    {
        public Enumerations.PlaceKind Kind { get; set; }

        public Xamarin.Forms.ImageSource FeatureImageSource { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public Content.Contract.AbstractContentDataModel[] Content { get; set; }
    }
}
