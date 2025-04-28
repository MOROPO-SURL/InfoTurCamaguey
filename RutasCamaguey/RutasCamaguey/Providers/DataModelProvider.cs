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
                    Summary = "La Agencia Infotur es la Oficina de Información Turística en Camagüey, Cuba. Su objetivo principal es proporcionar información y asistencia a los turistas que nos visitan, facilitando su experiencia y ayudándoles a descubrir los atractivos de Camagüey.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.VideoContentDataModel
                        {
                            ArtWorkImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            MediaSource = Xamarin.CommunityToolkit.Core.MediaSource.FromUri("ms-appx:///promo.mp4")
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Servicios que ofrece Infotur en Camagüey:"
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Información turística general: proporcionan detalles sobre destinos, atracciones, actividades, eventos y puntos de interés en la ciudad de Camagüey y sus alrededores."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Soportes informativos gratuitos: ofrecen materiales impresos y digitales, como mapas, guíastemáticas y folletos, para ayudar a los visitantes a planificar y disfrutar su estancia."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Venta de materiales turísticos: mapas, guías especializadas y libros sobre la región y Cuba en general."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Asistencia y consejos: el personal puede ofrecer recomendaciones personalizadas, responder preguntas y ayudar a los turistas con sus necesidades de viaje."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Promoción del destino: trabajan en dar a conocer los atractivos turísticos de Camagüey a través de diversos medios, incluyendo redes sociales y su sitio web."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Información sobre servicios: pueden proporcionar información sobre alojamiento, transporte, restaurantes y otros servicios turísticos disponibles en la zona."
                        },
                        new Models.Data.Content.ContactInformationGroupContentDataModel
                        {
                            Header = "Ubicaciones y Contacto:",
                            Items = new System.Collections.Generic.Dictionary<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>
                            {
                                {
                                    "Oficina Principal",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        Address = "Ignacio Agramonte No.426 e/ República y Lope Recio.",
                                        Phones = "(+53) 32256794"
                                    }
                                },
                                {
                                    "Oficina en el Aeropuerto Internacional de Camagüey",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        Address = "Oficina 4, Zona 4, Aeropuerto Internacional Ignacio Agramonte, Ave. Finlay km 71/2.",
                                        Phones = "(+53) 32265807"
                                    }
                                }
                            }
                        },
                        new Models.Data.Content.ContactInformationGroupContentDataModel
                        {
                            Header = "Presencia digital:",
                            Items = new System.Collections.Generic.Dictionary<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>
                            {
                                {
                                    "Sitio Web Oficial",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.infotur.cu"
                                    }
                                },
                                {
                                    "Portal Oficial de Turismo Cubano",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.cuba.travel"
                                    }
                                },
                                {
                                    "Perfil Oficial en Facebook",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.facebook.com/camaguey.travel"
                                    }
                                },
                                {
                                    "Sitio Oficial de Mapas de Cuba",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.cubamaps.cu"
                                    }
                                }
                            }
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
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.219C0EF3_B075_4D76_B348_610B560CCA13.jpg"),
                    Summary = "En la casa museo, poseedora de valores representativos de la arquitectura colonial del siglo XVIII (23 de diciembre de 1841), se exhiben documentos y pertenencias de la figura histórica más trascendental del Camagüey, a quien José Martí, Héroe nacional de Cuba, describiera como “ diamante con alma de beso” Igualmente se muestran muebles y objetos tanto de la familia como representativos de los siglos XVIII y XIX. En 1978 la casa le fue acreditada la condición de Monumento Nacional.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {06C3FEBB-04EC-4B5F-8939-2CCFA4C5E7E7}
                    Id = new System.Guid(0x6c3febb, 0x4ec, 0x4b5f, 0x89, 0x39, 0x2c, 0xcf, 0xa4, 0xc5, 0xe7, 0xe7),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.389157,
                    Long = -77.915734,
                    Title = "Museo Ferroviario",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.museo-san-juan-de-dios.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-carmen.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajadores.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {ACCD344C-AFF9-4B20-A161-EF7B4FA2D5C3}
                    Id = new System.Guid(0xaccd344c, 0xaff9, 0x4b20, 0xa1, 0x61, 0xef, 0x7b, 0x4f, 0xa2, 0xd5, 0xc3),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.390498,
                    Long = -77.916565,
                    Title = "Museo Provincial",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.ACCD344C_AFF9_4B20_A161_EF7B4FA2D5C3.jpg"),
                    Summary = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat. Lorem ipsum dolor sit ameticle consectetur adipiscing elit. Amet consectetur adipiscing elit quisque faucibus ex sapien. Quisque faucibus ex sapien vitae pellentesque sem placerat. Vitae pellentesque sem placerat."
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
