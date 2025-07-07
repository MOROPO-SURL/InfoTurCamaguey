namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class ConfigurationPage : Xamarin.Forms.ContentPage
    {
        public ConfigurationPage()
        {
            InitializeComponent();

            BindingContext = new Models.Page.ConfigurationPageModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            (BindingContext as Models.Page.ConfigurationPageModel).LoadSavedValues();
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

        private void SaveButton_Clicked(object sender, System.EventArgs eventArgs)
        {
            (sender as Xamarin.Forms.Button).IsEnabled = false;

            Xamarin.Forms.Application.Current.Properties[Providers.ConstantProvider.CONFIGURATION_MAPBASE_KEY] = (BindingContext as Models.Page.ConfigurationPageModel).SelectedMapMase.Id;
            Xamarin.Forms.Application.Current.Properties[Providers.ConstantProvider.CONFIGURATION_AR_MODE_KEY] = (BindingContext as Models.Page.ConfigurationPageModel).SelectedARMode.Id;

            Xamarin.Forms.Application.Current.SavePropertiesAsync().ContinueWith(_ => Dispatcher.BeginInvokeOnMainThread(() => (sender as Xamarin.Forms.Button).IsEnabled = true));
        }
    }
}