using Urho;
using Xamarin.Essentials;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
    public partial class GuideARPage : Xamarin.Forms.ContentPage
    {
        private Env3D.Presenters.GuideARPresenter env3DPresenter;

        public GuideARPage()
        {
            InitializeComponent();

            BindingContext = new SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel();
        }

        private SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel ConcreteBindingContext => BindingContext as SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel;

        protected override void OnAppearing()
        {
            Content.BackgroundColor = Xamarin.Forms.Color.White;

            GetPermissions().ContinueWith(task =>
            {
                Dispatcher.BeginInvokeOnMainThread(() =>
                {
                    if (!task.Result)
                    {
                        DisplayAlert("Aviso", "Es necesario brindar permisos de uso de la cámara a esta aplicación par asu correcto funcionamiento.", "Aceptar");
                    }
                    else
                    {
                        ConcreteBindingContext.IsBusy = true;

                        System.Threading.Tasks.Task.Delay(500).ContinueWith(_ =>
                        {
                            Dispatcher.BeginInvokeOnMainThread(() =>
                            {
                                ConcreteBindingContext.IsBusy = false;

                                var urhoSurface = new Urho.Forms.UrhoSurface();

                                var urhoApplicationOptions = new Urho.ApplicationOptions()
                                {
                                    ResourcePaths = new[] { "UrhoData" },
                                    Orientation = Urho.ApplicationOptions.OrientationType.LandscapeAndPortrait
                                };

                                (Content as Xamarin.Forms.Grid).Children.Insert(0, urhoSurface);

                                urhoSurface.Show<Env3D.Presenters.GuideARPresenter>(urhoApplicationOptions).ContinueWith(task =>
                                {
                                    env3DPresenter = task.Result;

                                    env3DPresenter.PlaceTarget += GuideARPresenter_PlaceTarget;
                                });
                            });
                        });
                    }
                });
            });
        }

        protected override void OnDisappearing()
        {
            env3DPresenter.PlaceTarget -= GuideARPresenter_PlaceTarget;

            env3DPresenter = null;

            (Content as Xamarin.Forms.Grid).Children.RemoveAt(0);

            Urho.Forms.UrhoSurface.OnDestroy();

            base.OnDisappearing();
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

        private void GuideARPresenter_PlaceTarget(object sender, Env3D.Presenters.GuideARPresenterPlaceTargetEventArg eventArg)
        {
            Content.BackgroundColor = Xamarin.Forms.Color.Black;

            Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new PlaceDetailPage(eventArg.Place)) { BackgroundColor = Xamarin.Forms.Color.Transparent });
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