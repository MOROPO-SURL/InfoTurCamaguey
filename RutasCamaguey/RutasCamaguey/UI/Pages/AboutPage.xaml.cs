namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class AboutPage : Xamarin.Forms.ContentPage
    {
        public AboutPage()
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