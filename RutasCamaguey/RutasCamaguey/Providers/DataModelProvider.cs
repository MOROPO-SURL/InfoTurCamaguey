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
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.C0CE5B94-9B41-46E9-B752-1DC4A208B793.jpg"),
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
                            Text = "En el interior se proyecta la planta en forma de C con un balcón corrido con pie derecho desde el que se domina el patio central. En este último se ubican cinco tinajones y un aljibe con brocal de mármol blanco. Por medio del acceso principal o zaguán se accede a su interior y puede dirigirse hacia el patio y antiguas habitaciones secundarias o subir por una escalera que conduce al entresuelo de la antigua servidumbre y a los aposentos y puede dirigirse hacia el patio y antiguas habitaciones secundarias o subir por principales de la casa."
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
                    Summary = "Ocupa el edificio y exteriores, de la estación ferroviaria inaugurada en 1912, importante edificación de la arquitectura en la ciudad agramontina.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Al recorrer sus salas y áreas exteriores los visitantes se familiarizan con el patrimonio y el quehacer ferroviario de la provincia y el país."
                        },
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-4.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-5.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El uso de las nuevas tecnologías convierten a este museo en un espacio interactivo y virtual muy agradable e informativo para toda la familia. De visitantes a viajeros las personas tienen la posibilidad de participar en un recorrido imaginario concebido a través de varias «estaciones», en cada una de las cuales conocerá una etapa diferente de la historia del ferrocarril; una cronología precisa del devenir histórico del ferrocarril. "
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Las labores de restauración y conservación de la edificación y el patrimonio que resguarda, lideradas por la Oficina del Historiador de la Ciudad, fueron distinguidas, entre otros lauros, con el Premio Nacional de Conservación y Restauración de Monumentos."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El acceso al museo se realiza desde un agradable bulevar que lo separa, y une, con el Hotel Plaza."
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
                    Title = "Museo Provincial Ignacio Agramonte",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.ACCD344C_AFF9_4B20_A161_EF7B4FA2D5C3.jpg"),
                    Summary = "La edificación en la que actualmente funciona el museo fue en sus inicios, en 1848, el Cuartel de Caballería del ejército español. Al terminar la dominación española, y luego de un proceso de transformación, se ubicó en el lugar el Hotel Camagüey función que mantuvo hasta el 23 de diciembre del año 1955 cuando, en un aniversario del natalicio del patriota Ignacio Agramonte, se inauguró el actual museo.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-4.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "De acuerdo al contenido y diversidad de las colecciones que atesora, el museo se clasifica como una institución de tipo general. Consta de varias salas expositivas: pintura, artes decorativas, de historia natural, entre otras. Se distingue la sala de pintura cubana, considerada como la segunda colección en importancia en el país, con obras de varios artistas de renombre nacional e internacional como Menocal, Romañach, Carlos Enríquez, Amelia Peláez, Wifredo Lam y Fidelio Ponce, este último nacido en la provincia."
                        },
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-4.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-5.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-6.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La belleza y tranquilidad de su patio interior, en el que se conservan elementos arquitectónicos, decorativos y funcionales de las épocas colonial y republicana, es custodiada por ejemplares de la flora cubana."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En la parte trasera de la edificación se ubica la escuela de artes Vicentina de la Torre, institución donde se forman niños y jóvenes talentos del ballet, artes escénicas y visuales."
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
                    // {C0CE5B94-9B41-46E9-B752-1DC4A208B793}
                    Id = new System.Guid(0xc0ce5b94, 0x9b41, 0x46e9, 0xb7, 0x52, 0x1d, 0xc4, 0xa2, 0x8, 0xb7, 0x93),
                    Kind = Enumerations.PlaceKind.InfoturOffice,
                    Lat = 21.382494,
                    Long = -77.917155,
                    Title = "Infotur Camagüey Office",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.C0CE5B94-9B41-46E9-B752-1DC4A208B793.jpg"),
                    Summary = "The Infotur Agency is the Tourist Information Office in Camagüey, Cuba. Its main objective is to provide information and assistance to tourists visiting our country, facilitating their experience and helping them discover Camagüey's attractions.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.VideoContentDataModel
                        {
                            ArtWorkImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            MediaSource = Xamarin.CommunityToolkit.Core.MediaSource.FromUri("ms-appx:///promo.mp4")
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Services offered by Infotur in Camagüey:"
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "General tourist information: provides details on destinations, attractions, activities, events, and points of interest in and around Camagüey."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Free informational resources: Offering printed and digital materials, such as maps, topic guides, and brochures, to help visitors plan and enjoy their stay."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Sale of tourist materials: maps, specialized guides, and books about the region and Cuba in general."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Assistance and advice: Staff can offer personalized recommendations, answer questions, and assist travelers with their travel needs."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Destination promotion: They work to promote Camagüey's tourist attractions through various media, including social media and their website."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Service Information: They can provide information on accommodation, transportation, restaurants, and other tourist services available in the area."
                        },
                        new Models.Data.Content.ContactInformationGroupContentDataModel
                        {
                            Header = "Locations and Contact:",
                            Items = new System.Collections.Generic.Dictionary<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>
                            {
                                {
                                    "Main Office",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        Address = "Ignacio Agramonte No.426 e/ República y Lope Recio.",
                                        Phones = "(+53) 32256794"
                                    }
                                },
                                {
                                    "Office at Camagüey International Airport",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        Address = "Office 4, Zone 4, Ignacio Agramonte International Airport, Finlay Ave. km 7.5.",
                                        Phones = "(+53) 32265807"
                                    }
                                }
                            }
                        },
                        new Models.Data.Content.ContactInformationGroupContentDataModel
                        {
                            Header = "Digital presence:",
                            Items = new System.Collections.Generic.Dictionary<string, Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem>
                            {
                                {
                                    "Official Website",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.infotur.cu"
                                    }
                                },
                                {
                                    "Official Cuban Tourism Portal",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.cuba.travel"
                                    }
                                },
                                {
                                    "Official Facebook Profile",
                                    new Models.Data.Content.ContactInformationGroupContentDataModel.ContactInformationItem
                                    {
                                        WebSite = "www.facebook.com/camaguey.travel"
                                    }
                                },
                                {
                                    "Official Maps Site of Cuba",
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
                    Title = "Ignacio Agramonte Birthplace Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.219C0EF3_B075_4D76_B348_610B560CCA13.jpg"),
                    Summary = "The house museum, which houses representative values ​​of 18th-century colonial architecture (December 23, 1841), displays documents and belongings of Camagüey's most important historical figure. He was described by José Martí, Cuba's national hero, as \"a diamond with the soul of a kiss.\" Furniture and objects belonging to the family, as well as objects representing the 18th and 19th centuries, are also on display. In 1978, the house was declared a National Monument.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-gallo.jpg"),
                            VirtualVisitContentPage = new UI.Pages.VirtualTour1Page()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The interior has a C-shaped floor plan with a continuous balcony with a vertical base overlooking the central courtyard. The latter houses five large earthenware jars and a cistern with a white marble rim. The interior is accessed through the main entrance or hall, leading to the courtyard and former secondary rooms, or ascending a staircase that leads to the mezzanine of the former servants' quarters and the chambers. The main entrance leads to the courtyard and former secondary rooms, or ascending through the main rooms of the house."
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
                    Title = "Railway Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "It occupies the building and exterior of the railway station inaugurated in 1912, an important architectural building in the city of Agramonte.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "By touring its halls and outdoor areas, visitors become familiar with the province's and country's railway heritage and activities."
                        },
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-4.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.railway-museum-5.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The use of new technologies turns this museum into a highly enjoyable and informative interactive virtual space for the whole family. Visitors and travelers alike have the opportunity to participate in an imaginary journey through several \"stations,\" at each of which they will learn about a different stage in the history of the railroad; a precise chronology of the historical development of the railroad."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The restoration and conservation efforts on the building and the heritage it houses, led by the City Historian's Office, were recognized, among other awards, with the National Prize for the Preservation and Restoration of Monuments."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The museum is accessed from a pleasant boulevard that separates and connects it to the Plaza Hotel."
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
                    Title = "Ignacio Agramonte Provincial Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.ACCD344C_AFF9_4B20_A161_EF7B4FA2D5C3.jpg"),
                    Summary = "The building that currently houses the museum was originally the Spanish Army Cavalry Barracks in 1848. At the end of Spanish rule, and following a process of transformation, the Hotel Camagüey was located on the site, serving until December 23, 1955, when the current museum was inaugurated on the anniversary of the birth of patriot Ignacio Agramonte.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-legancy-4.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Based on the content and diversity of its collections, the museum is classified as a general institution. It consists of several exhibition halls: painting, decorative arts, natural history, among others. The Cuban painting hall is considered the second most important collection in the country, featuring works by several nationally and internationally renowned artists such as Menocal, Romañach, Carlos Enríquez, Amelia Peláez, Wifredo Lam, and Fidelio Ponce, the latter born in the province."
                        },
                        new Models.Data.Content.PictureGalleryContentDataModel
                        {
                            Items = new Xamarin.Forms.ImageSource[]
                            {
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-1.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-2.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-3.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-4.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-5.jpg"),
                                Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.state-museum-nature-6.jpg")
                            }
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The beauty and tranquility of its interior courtyard, which preserves architectural, decorative, and functional elements from the colonial and republican eras, is preserved by specimens of Cuban flora."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "At the rear of the building is the Vicentina de la Torre School of Arts, an institution that trains talented children and young people in ballet, performing arts, and visual arts."
                        }
                    }
                }
            };
        }   
    }
}
