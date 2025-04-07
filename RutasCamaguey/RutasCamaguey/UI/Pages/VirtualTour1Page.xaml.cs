using Urho;
using Xamarin.Forms;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class VirtualTour1Page : Xamarin.Forms.ContentPage
    {
        public VirtualTour1Page()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var urhoSurface = new Urho.Forms.UrhoSurface();

            var urhoApplicationOptions = new ApplicationOptions()
            {
                ResourcePaths = new[] { "UrhoData" },
                Orientation = ApplicationOptions.OrientationType.LandscapeAndPortrait
            };

            Content = urhoSurface;

            await urhoSurface.Show<Env3D.Presenters.VirtualTourPresenter>(urhoApplicationOptions);
        }

        protected override void OnDisappearing()
        {
            Urho.Forms.UrhoSurface.OnDestroy();

            base.OnDisappearing();
        }
    }
}