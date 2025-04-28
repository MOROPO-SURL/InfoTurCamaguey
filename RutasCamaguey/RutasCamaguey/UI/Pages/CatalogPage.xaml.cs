namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class CatalogPage : Xamarin.Forms.ContentPage
    {
        public CatalogPage()
        {
            InitializeComponent();

            BindingContext = new Models.Page.CatalogPageModel();

            IsEnabled = false;
        }

        private Models.Page.CatalogPageModel ConcreteBindingContext => BindingContext as Models.Page.CatalogPageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (IsEnabled) return;

            ConcreteBindingContext.IsBusy = true;

            System.Threading.Tasks.Task.Delay(200).ContinueWith(_ => 
            {
                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    foreach (var item in Providers.DataModelProvider.Places)
                    {
                        ConcreteBindingContext.Items.Add(item);
                    }

                    ConcreteBindingContext.IsBusy = false;
                });
            });

            IsEnabled = true;
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

        private void PlaceFrameTapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var model = (sender as Xamarin.Forms.BindableObject).BindingContext as Models.Data.PlaceDataModel;

            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new PlaceDetailPage(model)) { BackgroundColor = Xamarin.Forms.Color.Transparent });
        }
    }
}