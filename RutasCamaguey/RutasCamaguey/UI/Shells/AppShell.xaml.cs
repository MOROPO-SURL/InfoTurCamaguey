using Xamarin.Forms;

namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Shells
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, System.EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new Pages.VirtualTour1Page());
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
