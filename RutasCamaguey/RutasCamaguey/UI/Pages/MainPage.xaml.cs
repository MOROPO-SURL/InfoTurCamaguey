namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class MainPage : Xamarin.Forms.ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel();
        }

        private SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel ConcreteBindingContext => BindingContext as SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel;

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var geoDataFileInfo = new System.IO.FileInfo(System.IO.Path.Combine(Xamarin.Essentials.FileSystem.AppDataDirectory, "map.mbtiles"));

            if (!geoDataFileInfo.Exists)
            {
                ConcreteBindingContext.IsBusy = true;

                System.Threading.Tasks.Task.Run(() =>
                {
                    System.Threading.Thread.Sleep(200);

                    using var resourceStream = GetType().Assembly.GetManifestResourceStream(@"MOROPO.InfoTur.Camaguey.Rutas.Resources.DBs.map.mbtiles");

                    using var fileStream = System.IO.File.Create(geoDataFileInfo.FullName);

                    resourceStream.CopyTo(fileStream);
                }).ContinueWith(task =>
                {
                    Dispatcher.BeginInvokeOnMainThread(() =>
                    {
                        if (!task.IsCompletedSuccessfully)
                        {
                            DisplayAlert("Aviso", "Error :( !!!", "Aceptar");
                        }

                        ConcreteBindingContext.IsBusy = false;
                    });
                });
            }
        }



        protected override bool OnBackButtonPressed()
        {
            if (Xamarin.Forms.Shell.Current.FlyoutIsPresented)
            {
                Xamarin.Forms.Shell.Current.FlyoutIsPresented = false;

                return true;
            }

            return false;
        }

        private void LanguageToolbarItem_Clicked(object sender, System.EventArgs eventArgs)
        {
            DisplayActionSheet(AppResources.PickLanguageHeader, AppResources.CancelText, null, AppResources.LanguageNameSpanish, AppResources.LanguageNameEnglish).ContinueWith(task =>
            {
                if (string.IsNullOrEmpty(task.Result) || task.Result.Equals(AppResources.CancelText)) return;

                if (task.Result.Equals(AppResources.LanguageNameSpanish))
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                }
                else if (task.Result.Equals(AppResources.LanguageNameEnglish))
                {
                    System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                }

                AppResources.Culture = System.Threading.Thread.CurrentThread.CurrentUICulture;

                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    ConcreteBindingContext.IsBusy = true;

                    System.Threading.Tasks.Task.Delay(200).ContinueWith(_ => Dispatcher.BeginInvokeOnMainThread(() =>
                    {
                        Providers.DataModelProvider.ReInitialize();

                        Xamarin.Forms.Application.Current.MainPage = new Shells.AppShell();
                    }));                  
                });
            });
        }

        private void PrimaryRecomendation_Tapped(object sender, System.EventArgs eventArgs)
        {
            Xamarin.Forms.Shell.Current.GoToAsync("//MapPage");
        }

        private void SecoundaryRecommendation_Tapped(object sender, System.EventArgs eventArgs) 
        {
            Xamarin.Forms.Shell.Current.GoToAsync("//GuideARPage");
        }

        private void AboutButton_Clicked(object sender, System.EventArgs e)
        {
            Xamarin.Forms.Shell.Current.GoToAsync("//AboutPage");
        }
    }
}