namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class ConfigurationPage : Xamarin.Forms.ContentPage
    {
        public ConfigurationPage()
        {
            InitializeComponent();
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
    }
}