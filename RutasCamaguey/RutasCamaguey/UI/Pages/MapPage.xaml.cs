using Mapsui;
using Mapsui.Extensions;
using Mapsui.Limiting;
using Mapsui.Projections;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class MapPage : Xamarin.Forms.ContentPage
    {
        public MapPage()
        {
            InitializeComponent();

            BindingContext = new SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel();

            IsEnabled = false;
        }

        private SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel ConcreteBindingContext => BindingContext as SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (IsEnabled) return;

            ConcreteBindingContext.IsBusy = true;

            System.Threading.Tasks.Task.Delay(50).ContinueWith(_ => 
            {
                var (minX, minY) = SphericalMercator.FromLonLat(-77.907921107860716, 21.395448941431319);
                var (maxX, maxY) = SphericalMercator.FromLonLat(-77.927111107679508, 21.369581009197852);
                
                var mapView = new Mapsui.UI.Forms.MapView();

                mapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(new BruTile.MbTiles.MbTilesTileSource(new SQLite.SQLiteConnectionString(System.IO.Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "map.mbtiles"), true))));
                
                mapView.Map.Navigator.Limiter = new ViewportLimiterKeepWithinExtent();
                mapView.Map.Navigator.OverridePanBounds = new MRect(minX, minY, maxX, maxY);
                
                mapView.Map.Widgets.Add(new Mapsui.Widgets.ScaleBar.ScaleBarWidget(mapView.Map)
                {
                    TextAlignment = Mapsui.Widgets.Alignment.Center,
                    HorizontalAlignment = Mapsui.Widgets.HorizontalAlignment.Left,
                    VerticalAlignment = Mapsui.Widgets.VerticalAlignment.Bottom
                });
                
                mapView.Map.Home = map => map.CenterOnAndZoomTo(SphericalMercator.FromLonLat(-77.917516107770112, 21.382514975314585).ToMPoint(), map.Resolutions[16]);

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