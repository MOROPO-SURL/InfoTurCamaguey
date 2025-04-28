namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Views.Template
{
    public partial class PictureGalleryContentDataModelTemplateView : Xamarin.Forms.ContentView
    {
        public PictureGalleryContentDataModelTemplateView()
        {
            InitializeComponent();
        }

        protected override Xamarin.Forms.SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {
            HeightRequest = widthConstraint * 0.5625;

            return base.OnMeasure(widthConstraint, heightConstraint);
        }
    }
}