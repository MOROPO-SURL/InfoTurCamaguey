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
                    // {C0CE5B94-9B41-46E9-B752-1DC4A208B793}
                    Id = new System.Guid(0xc0ce5b94, 0x9b41, 0x46e9, 0xb7, 0x52, 0x1d, 0xc4, 0xa2, 0x8, 0xb7, 0x93),
                    Kind = Enumerations.PlaceKind.InfoturOffice,
                    Lat = 21.382494,
                    Long = -77.917155,
                    Title = "Oficina Infotur Camagüey",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {219C0EF3-B075-4D76-B348-610B560CCA13}
                    Id = new System.Guid(0x219c0ef3, 0xb075, 0x4d76, 0xb3, 0x48, 0x61, 0xb, 0x56, 0xc, 0xca, 0x13),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.381959,
                    Long = -77.918301,
                    Title = "Museo Casa Natal Ignacio Agramonte",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-carmen.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
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
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.381959,
                    Long = -77.918301,
                    Title = "Casa Natal Ignacio Agramonte Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.museo-san-juan-de-dios.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
                }
            };
        }   
    }
}
