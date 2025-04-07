using Mapsui.Extensions;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class MapPage : Xamarin.Forms.ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            BindingContext = new SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel();

            IsEnabled = false;

            //using var connection = new SQLite.SQLiteConnection(connectionString);

            //var info = connection.GetTableInfo("metadata");

            //MainMapView.Map.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
            //MainMapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(BruTile.Predefined.KnownTileSources.Create(BruTile.Predefined.KnownTileSource.BingHybrid)) { Name = "Bing Aerial" });
            //MainMapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(new BruTile.MbTiles.MbTilesTileSource(connectionString)));
            //MainMapView.Map.CRS = "EPSG:3795";
            //MainMapView.Map.Home = n => n.CenterOnAndZoomTo(Mapsui.Projections.SphericalMercator.FromLonLat(-77.9184, 21.3792).ToMPoint(), n.Resolutions[15]);
        }

        private SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel ConcreteBindingContext => BindingContext as SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (IsEnabled) return;

            ConcreteBindingContext.IsBusy = true;

            System.Threading.Tasks.Task.Delay(200).ContinueWith(_ => 
            {
                var mapView = new Mapsui.UI.Forms.MapView();

                mapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(new BruTile.MbTiles.MbTilesTileSource(new SQLite.SQLiteConnectionString(System.IO.Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "map.mbtiles"), true))));
                //mapView.Map.CRS = "EPSG:3795";
                //mapView.Map.Navigator.OverrideZoomBounds = new Mapsui.MMinMax(15, 18);
                mapView.Map.Widgets.Add(new Mapsui.Widgets.ScaleBar.ScaleBarWidget(mapView.Map) 
                { 
                    TextAlignment = Mapsui.Widgets.Alignment.Center, 
                    HorizontalAlignment = Mapsui.Widgets.HorizontalAlignment.Left, 
                    VerticalAlignment = Mapsui.Widgets.VerticalAlignment.Bottom 
                });
                mapView.Map.Home = n => n.CenterOnAndZoomTo(Mapsui.Projections.SphericalMercator.FromLonLat(-77.917516107770112, 21.382514975314585).ToMPoint(), n.Resolutions[16]);

                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    (Content as Xamarin.Forms.Grid).Children.Insert(0, mapView);

                    ConcreteBindingContext.IsBusy = false;
                });
            });

            IsEnabled = true;
        }
    }
}