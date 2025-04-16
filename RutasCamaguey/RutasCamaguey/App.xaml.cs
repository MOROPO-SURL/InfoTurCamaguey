namespace MOROPO.InfoTur.Camaguey.Rutas
{
    public partial class App : Xamarin.Forms.Application
    {

        public App()
        {
            InitializeComponent();

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.InstalledUICulture.TwoLetterISOLanguageName);

            AppResources.Culture = System.Threading.Thread.CurrentThread.CurrentUICulture;

            Providers.DataModelProvider.ReInitialize();

            MainPage = new UI.Shells.AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
