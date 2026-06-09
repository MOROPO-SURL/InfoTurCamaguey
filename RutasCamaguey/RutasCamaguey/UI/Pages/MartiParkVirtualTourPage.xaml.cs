namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class MartiParkVirtualTourPage : Xamarin.Forms.ContentPage
    {
        public MartiParkVirtualTourPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var urhoSurface = new Urho.Forms.UrhoSurface();

            var urhoApplicationOptions = new Urho.ApplicationOptions()
            {
                ResourcePaths = new[] { "UrhoData" },
                Orientation = Urho.ApplicationOptions.OrientationType.LandscapeAndPortrait
            };

            (Content as Xamarin.Forms.Grid).Children.Insert(0, urhoSurface);

            await urhoSurface.Show<Env3D.Presenters.MartiParkVirtualTourPresenter>(urhoApplicationOptions);
        }

        protected override void OnDisappearing()
        {
            Urho.Forms.UrhoSurface.OnDestroy();

            base.OnDisappearing();
        }

        private void CloseButton_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}