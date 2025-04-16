namespace MOROPO.InfoTur.Camaguey.Rutas.Models.Page
{
    public class CatalogPageModel : SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel
    {
        public System.Collections.ObjectModel.ObservableCollection<Data.PlaceDataModel> Items { get; set; } = new System.Collections.ObjectModel.ObservableCollection<Data.PlaceDataModel>();
    }
}
