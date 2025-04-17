using Mapsui;
using Mapsui.Extensions;
using Mapsui.Limiting;
using Mapsui.Projections;
using Mapsui.Utilities;
using System.Linq;

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

                mapView.Info += MapView_Info;

                mapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(new BruTile.MbTiles.MbTilesTileSource(new SQLite.SQLiteConnectionString(System.IO.Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "map.mbtiles"), true))));
                mapView.Map.Layers.Add(BuildPlacesLayer());

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

        private void MapView_Info(object sender, MapInfoEventArgs e)
        {
            var model = e.MapInfo.Feature[nameof(Models.Data.PlaceDataModel)] as Models.Data.PlaceDataModel;

            Navigation.PushModalAsync(new PlaceDetailPage(model));
        }

        protected override bool OnBackButtonPressed()
        {
            if (Xamarin.Forms.Shell.Current.FlyoutIsPresented)
            {
                Xamarin.Forms.Shell.Current.FlyoutIsPresented = false;
            }
            else
            {
                Xamarin.Forms.Shell.Current.GoToAsync("//StartPage");
            }

            return true;
        }

        private Mapsui.Layers.MemoryLayer BuildPlacesLayer()
        {
            return new Mapsui.Layers.MemoryLayer
            {
                Name = "Lugares",
                IsMapInfoLayer = true,
                Style = null,
                Features = Providers.DataModelProvider.Places.Select(model =>
                {
                    var result = new Mapsui.Layers.PointFeature(SphericalMercator.FromLonLat(model.Long, model.Lat).ToMPoint());

                    result[nameof(Models.Data.PlaceDataModel)] = model;

                    result.Styles.Add(BuildStyleByPlaceKind(model.Kind));

                    return result;
                }).ToArray(),
            };
        }

        private Mapsui.Styles.SymbolStyle BuildStyleByPlaceKind(Enumerations.PlaceKind kind)
        {
            int bitmapId = -1;

            switch (kind)
            {
                case Enumerations.PlaceKind.InfoturOffice:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-infotur.svg");

                    break;

                case Enumerations.PlaceKind.Museum:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-museum.svg");

                    break;

                case Enumerations.PlaceKind.Church:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-church.svg");

                    break;

                case Enumerations.PlaceKind.ArtGallery:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-gallery.svg");

                    break;

                case Enumerations.PlaceKind.Zoo:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-zoo.svg");

                    break;

                case Enumerations.PlaceKind.SportCenter:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-sportcenter.svg");

                    break;

                case Enumerations.PlaceKind.Library:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-library.svg");

                    break;

                case Enumerations.PlaceKind.Monument:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-monumnet.svg");

                    break;

                case Enumerations.PlaceKind.Distinguished:
                default:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-distinguished.svg");

                    break;  
            }

            return new Mapsui.Styles.SymbolStyle { BitmapId = bitmapId, SymbolScale = 0.36 };
        }
    }
}