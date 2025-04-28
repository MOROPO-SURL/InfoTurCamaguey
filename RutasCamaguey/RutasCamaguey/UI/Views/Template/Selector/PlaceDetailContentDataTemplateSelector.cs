namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Views.Template.Selector
{
    public class PlaceDetailContentDataTemplateSelector : Xamarin.Forms.DataTemplateSelector
    {
        public Xamarin.Forms.DataTemplate TextContentDataTemplate { get; set; }

        public Xamarin.Forms.DataTemplate PictureContentDataTemplate { get; set; }

        public Xamarin.Forms.DataTemplate ContactInformationGroupContentDataTemplate { get; set; }

        public Xamarin.Forms.DataTemplate VideoContentDataTemplate { get; set; }

        public Xamarin.Forms.DataTemplate VirtualVisitContentDataTemplate { get; set; }

        public Xamarin.Forms.DataTemplate PictureGalleryContentDataTemplate { get; set; }

        protected override Xamarin.Forms.DataTemplate OnSelectTemplate(object item, Xamarin.Forms.BindableObject container)
        {
            if (item is Models.Data.Content.TextContentDataModel)
            {
                return TextContentDataTemplate;
            }

            if (item is Models.Data.Content.PictureContentDataModel)
            {
                return PictureContentDataTemplate;
            }

            if (item is Models.Data.Content.ContactInformationGroupContentDataModel)
            {
                return ContactInformationGroupContentDataTemplate;
            }

            if (item is Models.Data.Content.VideoContentDataModel)
            {
                return VideoContentDataTemplate;
            }

            if (item is Models.Data.Content.VirtualVisitContentDataModel)
            {
                return VirtualVisitContentDataTemplate;
            }

            if (item is Models.Data.Content.PictureGalleryContentDataModel)
            {
                return PictureGalleryContentDataTemplate;
            }

            throw new System.InvalidOperationException();
        }
    }
}
