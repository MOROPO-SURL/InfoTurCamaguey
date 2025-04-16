namespace MOROPO.InfoTur.Camaguey.Rutas.Providers
{
    public sealed class DataModelProvider
    {
        private static DataModelProvider instance;

        public static Models.Data.PlaceDataModel[] Places => instance.places;

        private Models.Data.PlaceDataModel[] places;

        public static void ReInitialize()
        {
            if (instance == null) instance = new DataModelProvider();

            if (AppResources.Culture.TwoLetterISOLanguageName == "es")
            {
                instance.PrimaryInitialization();
            }
            else
            {
                instance.SecoundaryInitialization();
            }
        }

        private void PrimaryInitialization()
        {
            places = new Models.Data.PlaceDataModel[]
            {
                new Models.Data.PlaceDataModel
                {
                    Kind = Enumerations.PlaceKind.InfoturOffice,
                    Lat = 21.382494,
                    Long = -77.917155,
                    Title = "Oficina Infotur Camagüey",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                },
                new Models.Data.PlaceDataModel
                {
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.381959,
                    Long = -77.918301,
                    Title = "Museo Casa Natal Ignacio Agramonte",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-carmen.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                }
            };
        }

        private void SecoundaryInitialization()
        {
            places = new Models.Data.PlaceDataModel[]
            {
                new Models.Data.PlaceDataModel
                {
                    Kind = Enumerations.PlaceKind.InfoturOffice,
                    Lat = 21.382494,
                    Long = -77.917155,
                    Title = "Infotur Camagüey Office",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajadores.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                },
                new Models.Data.PlaceDataModel
                {
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.381959,
                    Long = -77.918301,
                    Title = "Casa Natal Ignacio Agramonte Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.museo-san-juan-de-dios.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                }
            };
        }   
    }
}
