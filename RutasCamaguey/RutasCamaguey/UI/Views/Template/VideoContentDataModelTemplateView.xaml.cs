namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Views.Template
{
    public partial class VideoContentDataModelTemplateView : Xamarin.Forms.ContentView
    {
        public VideoContentDataModelTemplateView()
        {
            InitializeComponent();
        }

        protected override Xamarin.Forms.SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            HeightRequest = widthConstraint * 0.5625;

            return base.OnMeasure(widthConstraint, heightConstraint);
        }

        private void MainMediaElement_MediaOpened(object sender, System.EventArgs e)
        {
            MainMediaElement.Stop();
        }

        private void OverlayTapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            MainMediaElement.Source = ((sender as Xamarin.Forms.BindableObject).BindingContext as Models.Data.Content.VideoContentDataModel).MediaSource;

            ArtworkLayout.IsVisible = false;
        }

        private void MainMediaElement_MediaEnded(object sender, System.EventArgs e)
        {
            MainMediaElement.Source = null;

            ArtworkLayout.IsVisible = true;
        }
    }
}