using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace MOROPO.InfoTur.Camaguey.Rutas.Droid
{
    [Activity(Label = "Rutas Camagüey", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ScreenOrientation = ScreenOrientation.SensorPortrait, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            // Initialize the EasyAR Engine
            if (!EasyAR.Engine.initialize(this, Providers.ConstantProvider.EASYAR_KEY))
            {
                string message = $"Failed intializing EasyAR: {EasyAR.Engine.errorMessage()}.";

                throw new System.InvalidOperationException(message);
            }

            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}