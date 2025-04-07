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
    }
}