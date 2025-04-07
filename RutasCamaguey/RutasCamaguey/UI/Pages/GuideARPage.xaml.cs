using Urho;
using Xamarin.Essentials;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class GuideARPage : Xamarin.Forms.ContentPage
    {
        public GuideARPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var permissionStatus = await GetPermissions();

            if (!permissionStatus)
            {
                await DisplayAlert("Aviso", "Es necesario brindar permisos de uso de la cámara a esta aplicación par asu correcto funcionamiento.", "Aceptar");

                return;
            }

            var urhoSurface = new Urho.Forms.UrhoSurface();

            var urhoApplicationOptions = new ApplicationOptions()
            {
                ResourcePaths = new[] { "UrhoData" },
                Orientation = ApplicationOptions.OrientationType.LandscapeAndPortrait
            };

            (Content as Xamarin.Forms.Grid).Children.Insert(0, urhoSurface);

            await urhoSurface.Show<Env3D.Presenters.GuideARPresenter>(urhoApplicationOptions);
        }

        protected override void OnDisappearing()
        {
            Urho.Forms.UrhoSurface.OnDestroy();

            base.OnDisappearing();
        }

        private async System.Threading.Tasks.Task<bool> GetPermissions()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.Camera>();

            if (status == PermissionStatus.Denied && DeviceInfo.Platform == DevicePlatform.iOS)
            {
                // Prompt the user to turn on in settings
                // On iOS once a permission has been denied it may not be requested again from the application
                return false;
            }

            if (Permissions.ShouldShowRationale<Permissions.Camera>())
            {
                // Prompt the user with additional information as to why the permission is needed
            }

            status = await Permissions.RequestAsync<Permissions.Camera>();

            return status == PermissionStatus.Granted;
        }
    }
}