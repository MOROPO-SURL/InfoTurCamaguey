namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Views.Template
{
    public partial class VirtualVisitContentDataModelTemplateView : Xamarin.Forms.ContentView
    {
        public VirtualVisitContentDataModelTemplateView()
        {
            InitializeComponent();
        }

        private void OverlayTapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(((sender as Xamarin.Forms.BindableObject).BindingContext as Models.Data.Content.VirtualVisitContentDataModel).VirtualVisitContentPage);
        }
    }
}