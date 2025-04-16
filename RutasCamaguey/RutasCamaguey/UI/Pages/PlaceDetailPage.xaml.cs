namespace MOROPO.InfoTur.Camaguey.Rutas.UI.Pages
{
	public partial class PlaceDetailPage : Xamarin.Forms.ContentPage
	{
		public PlaceDetailPage (Models.Data.PlaceDataModel model)
		{
			InitializeComponent ();

			BindingContext = model;
		}

        protected override bool OnBackButtonPressed()
        {
			Navigation.PopModalAsync();

            return true;
        }
    }
}