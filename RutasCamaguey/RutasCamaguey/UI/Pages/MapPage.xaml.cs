using Mapsui;
using Mapsui.Extensions;
using Mapsui.Limiting;
using Mapsui.Nts;
using Mapsui.Nts.Extensions;
using Mapsui.Projections;
using Mapsui.Utilities;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using System.Linq;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class MapPage : Xamarin.Forms.ContentPage
    {
        private System.Guid currentMapBaseConfigOptionId = default;

        public MapPage()
        {
            InitializeComponent();

            BindingContext = new SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel();
        }

        private SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel ConcreteBindingContext => BindingContext as SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var mapBaseConfigOptionId = (System.Guid)Xamarin.Forms.Application.Current.Properties[Providers.ConstantProvider.CONFIGURATION_MAPBASE_KEY];

            if (mapBaseConfigOptionId == currentMapBaseConfigOptionId) return;

            currentMapBaseConfigOptionId = mapBaseConfigOptionId;

            ConcreteBindingContext.IsBusy = true;

            System.Threading.Tasks.Task.Delay(50).ContinueWith(_ => 
            {
                var (minX, minY) = SphericalMercator.FromLonLat(-77.907921107860716, 21.395448941431319);
                var (maxX, maxY) = SphericalMercator.FromLonLat(-77.927111107679508, 21.369581009197852);
                
                var mapView = new Mapsui.UI.Forms.MapView
                {
                    IsMyLocationButtonVisible = false
                };

                mapView.Info += MapView_Info;

                if (currentMapBaseConfigOptionId == Providers.ConstantProvider.CONFIGURATION_MAPBASE_BUILDIN)
                {
                    mapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(new BruTile.MbTiles.MbTilesTileSource(new SQLite.SQLiteConnectionString(System.IO.Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "map.mbtiles"), true))));
                }
                else
                {
                    mapView.Map.Layers.Add(new Mapsui.Tiling.Layers.TileLayer(BruTile.Predefined.KnownTileSources.Create(BruTile.Predefined.KnownTileSource.BingAerial))
                    {
                        Name = "Bing Aerial"
                    });
                }
                mapView.Map.Layers.Add(BuildPathLayer());
                mapView.Map.Layers.Add(BuildPlacesLayer());

                mapView.Map.Navigator.Limiter = new ViewportLimiterKeepWithinExtent();
                mapView.Map.Navigator.OverridePanBounds = new MRect(minX, minY, maxX, maxY);
                
                mapView.Map.Widgets.Add(new Mapsui.Widgets.ScaleBar.ScaleBarWidget(mapView.Map)
                {
                    TextAlignment = Mapsui.Widgets.Alignment.Center,
                    HorizontalAlignment = Mapsui.Widgets.HorizontalAlignment.Left,
                    VerticalAlignment = Mapsui.Widgets.VerticalAlignment.Bottom
                });
                
                mapView.Map.Home = map => map.CenterOnAndZoomTo(SphericalMercator.FromLonLat(-77.917516107770112, 21.382514975314585).ToMPoint(), map.Resolutions[15]);

                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    if ((Content as Xamarin.Forms.Grid).Children.Count > 1)
                    {
                        (Content as Xamarin.Forms.Grid).Children.RemoveAt(0);
                    }

                    (Content as Xamarin.Forms.Grid).Children.Insert(0, mapView);

                    ConcreteBindingContext.IsBusy = false;
                });
            });

            IsEnabled = true;
        }

        private void ConfigurationToolbarItem_Clicked(object sender, System.EventArgs eventArgs)
        {
            Xamarin.Forms.Shell.Current.GoToAsync("//ConfigPage");
        }

        private void MapView_Info(object sender, MapInfoEventArgs e)
        {
            var model = e.MapInfo.Feature[nameof(Models.Data.PlaceDataModel)] as Models.Data.PlaceDataModel;

            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new PlaceDetailPage(model)) { BackgroundColor = Xamarin.Forms.Color.Transparent });
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

        private Mapsui.Layers.MemoryLayer BuildPathLayer()
        {
            var lineString1 = new WKTReader().Read("LINESTRING(-77.9171227675219 21.3826122737857,-77.9170950376072 21.3823970972297,-77.9181302877574 21.3820355999032,-77.9185277498687 21.3820442069928,-77.9188235356259 21.3812781740377,-77.9189529418947 21.3805723873165,-77.9189806718094 21.3802883502364,-77.9186848860522 21.3789542293031,-77.9182689373311 21.3774049123127,-77.9184722900392 21.3766646772945,-77.9189529418946 21.375545710277,-77.9179731515738 21.3758900087319,-77.917529472938 21.3757178596057,-77.9162908700797 21.3762687360969,-77.9158656780537 21.3760621576556,-77.9154219994179 21.3763720252082,-77.914774968074 21.3759588683257,-77.9145161555365 21.3758211491057,-77.9139800438515 21.3759072236334,-77.9136287982648 21.3761998766489,-77.9133699857273 21.376458099412,-77.9136472848747 21.3768884696715,-77.9139430706319 21.3767163217195,-77.9143128028284 21.37737048286,-77.9143128028284 21.3777492063945,-77.9142018831694 21.3779041384671,-77.9146085885856 21.3783517190889,-77.9145531287561 21.3786787963701,-77.9148304279035 21.379660023828,-77.916050544152 21.3794706646554,-77.9173630934496 21.3795050936141,-77.9179916381837 21.3803830293244,-77.9175479595479 21.3813298168349,-77.9164942227878 21.38251759614,-77.9165496826173 21.3846177040714,-77.9166421156664 21.390504731186)");

            var geometry1 = new LineString(lineString1.Coordinates.Select(v => SphericalMercator.FromLonLat(v.X, v.Y).ToCoordinate()).ToArray());

            var lineString2 = new WKTReader().Read("LINESTRING(-77.9179916381837 21.3803486005722,-77.9190084017241 21.3803141718119,-77.9200621384842 21.3800731702633,-77.9221696120043 21.3794706646554,-77.9235006479118 21.3799870981855)");

            var geometry2 = new LineString(lineString2.Coordinates.Select(v => SphericalMercator.FromLonLat(v.X, v.Y).ToCoordinate()).ToArray());

            return new Mapsui.Layers.MemoryLayer
            {
                Features = new[] { new GeometryFeature { Geometry = geometry1 }, new GeometryFeature { Geometry = geometry2 } },
                Name = "Ruta",
                Style = new Mapsui.Styles.VectorStyle
                {
                    Fill = null,
                    Outline = null,
                    Line = { Color = Mapsui.Styles.Color.FromString("#1D184B"), Width = 6 }
                }
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
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-monument.svg");

                    break;

                case Enumerations.PlaceKind.Hotel:
                    bitmapId = GetType().LoadSvgId("Resources.Vectors.symbol-hotel.svg");

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