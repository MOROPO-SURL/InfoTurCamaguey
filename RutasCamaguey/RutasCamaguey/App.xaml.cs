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

            var configChanged = false;

            if (!Current.Properties.ContainsKey(Providers.ConstantProvider.CONFIGURATION_MAPBASE_KEY))
            {
                Current.Properties[Providers.ConstantProvider.CONFIGURATION_MAPBASE_KEY] = Providers.ConstantProvider.CONFIGURATION_MAPBASE_BUILDIN;

                configChanged = true;
            }

            if (!Current.Properties.ContainsKey(Providers.ConstantProvider.CONFIGURATION_AR_MODE_KEY))
            {
                Current.Properties[Providers.ConstantProvider.CONFIGURATION_AR_MODE_KEY] = Providers.ConstantProvider.CONFIGURATION_AR_EXTENDED;

                configChanged = true;
            }

            if (configChanged) Current.SavePropertiesAsync();

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
