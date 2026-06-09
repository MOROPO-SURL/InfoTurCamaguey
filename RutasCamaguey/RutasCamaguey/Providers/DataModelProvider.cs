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
                },
                new Models.Data.PlaceDataModel
                {
                    // {06C3FEBB-04EC-4B5F-8939-2CCFA4C5E7E7}
                    Id = new System.Guid(0x6c3febb, 0x4ec, 0x4b5f, 0x89, 0x39, 0x2c, 0xcf, 0xa4, 0xc5, 0xe7, 0xe7),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.389157,
                    Long = -77.915734,
                    Title = "Museo Ferroviario",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.museo-ferroviario.jpg"),
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
                    // {FD858121-66B5-4841-A044-79A8349BB903}
                    Id = new System.Guid(0xfd858121, 0x66b5, 0x4841, 0xa0, 0x44, 0x79, 0xa8, 0x34, 0x9b, 0xb9, 0x3),
                    Kind = Enumerations.PlaceKind.Hotel,
                    Lat = 21.388818,
                    Long = -77.915409,
                    Title = "Hotel Plaza",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-hotel.jpg"),
                    Summary = "Inaugurado en los comienzos del siglo XX, este es el más antiguo de los hoteles camagüeyanos en funcionamiento.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Aún conserva la mayor parte de sus características arquitectónicas originales y atesora entre sus múltiples hechos relevantes, el paso de la poetisa chilena Gabriela Mistral, Premio Nobel de Literatura en 1945, y la salida al aire de la primera emisora de radio fuera de la capital cubana."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Íntimo y acogedor, se caracteriza por el trato familiar de sus empleados y su excelente ubicación geográfica, justo en la confluencia de las principales vías de acceso a la ciudad (línea férrea, aeropuerto y carretera) y a pocos metros de la zona comercial."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {39D4C52D-07E7-4D85-871B-C3121837D363}
                    Id = new System.Guid(0x39d4c52d, 0x7e7, 0x4d85, 0x87, 0x1b, 0xc3, 0x12, 0x18, 0x37, 0xd3, 0x63),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382699, 
                    Long = -77.916316,
                    Title = "Iglesia de Nuestra Señora de la Soledad.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Iglesia-Soledad.jpg"),
                    Summary = "La Iglesia de Nuestra Señora de la Soledad es un emblemático templo católico ubicado en Camagüey, Cuba, en la intersección de las calle República e Ignacio Agramonte.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Construida durante el siglo XVIII se destaca por su pintoresca torre de color crema y terracota que se erige como un punto de referencia distintivo en el horizonte de la ciudad. La iglesia es un ejemplo del estilo colonial cubano con influencias mudéjares evidentes en elementos como el techo de la nave central, lo que la convierte en una joya arquitectónica."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En su interior el templo alberga detallados frescos barrocos y la pila bautismal sagrada donde fue bautizado en 1841 el héroe cubano Ignacio Agramonte. También fue el lugar donde Agramonte y Amalia Simoni contrajeron matrimonio. Debajo del presbiterio, existe una cripta."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La Iglesia de la Soledad no solo es un símbolo de devoción para los católicos locales sino también una atracción turística que permite apreciar la arquitectura colonial cubana y sumergirse en la historia de la ciudad."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {7C2C3B41-760D-4471-994F-1A7BC974EA23}
                    Id = new System.Guid(0x7c2c3b41, 0x760d, 0x4471, 0x99, 0x4f, 0x1a, 0x7b, 0xc9, 0x74, 0xea, 0x23),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382359,
                    Long = -77.917110,
                    Title = "Calle Ignacio Agramonte y Loynaz.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.camaguey-Ignacio-Agramonte-Street.jpg"),
                    Summary = "Desde la Plaza de la Soledad, siguiendo por la calle Ignacio Agramonte (antiguamente Soledad) hasta Independencia, se ubica un paseo temático conocido por “Calle de los Cines” donde los establecimientos comerciales han sido nombrados con el título de clásicos de la filmografía mundial.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En ese tramo se encuentran instalaciones y proyectos, como el “Callejón de los Milagros” representativos de este universo artístico."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En el espacio de este último tiene su sede el Centro de información Turística, conocido como Infotur. De igual manera se encuentran en su cercanía las oficinas de varias agencias turísticas como Paradiso."
                        }
                    }
                },
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
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.219C0EF3_B075_4D76_B348_610B560CCA13.jpg"),
                            VirtualVisitContentPage = new UI.Pages.BirthplaceMuseumVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En el interior se proyecta la planta en forma de C con un balcón corrido con pie derecho desde el que se domina el patio central. En este último se ubican cinco tinajones y un aljibe con brocal de mármol blanco. Por medio del acceso principal o zaguán se accede a su interior y puede dirigirse hacia el patio y antiguas habitaciones secundarias o subir por una escalera que conduce al entresuelo de la antigua servidumbre y a los aposentos y puede dirigirse hacia el patio y antiguas habitaciones secundarias o subir por principales de la casa."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {CBF018EA-EF3E-45E0-94E8-090F4D9ADAE4}
                    Id = new System.Guid(0xcbf018ea, 0xef3e, 0x45e0, 0x94, 0xe8, 0x9, 0xf, 0x4d, 0x9a, 0xda, 0xe4),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382344,
                    Long = -77.918274,
                    Title = "Iglesia-convento “Nuestra Señora de la Merced” (1748)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.iglesia-merced.jpg"),
                    Summary = "Ubicada en el centro de la ciudad la referida edificación es la más grande de tipo religioso de la provincia.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La iglesia consta de tres naves y una torre central, debajo de su altar mayor se encuentran sus antiguas criptas donde se resguardan reliquias religiosas como una lápida sepulcral, que según referencias conocidas hasta el momento es el monumento funerario más antiguo de la provincia. Anexo se edificó el convento que tuvo varios usos durante la etapa colonial."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A partir del siglo XVIII la iglesia estuvo estrechamente relacionada con las procesiones durante la Semana Santa y el recorrido del Santo Sepulcro. Este último constituye, desde la etapa colonial, uno de los muebles religiosos más valioso y objeto de una de las leyendas de la tradición local."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {B5A960E9-4C4C-490E-AF6F-752BB9EB98BD}
                    Id = new System.Guid(0xb5a960e9, 0x4c4c, 0x490e, 0xaf, 0x6f, 0x75, 0x2b, 0xb9, 0xeb, 0x98, 0xbd),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382229,
                    Long = -77.918687,
                    Title = "Plaza de los Trabajadores",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajaaodres.jpg"),
                    Summary = "Constituye uno de los conjuntos plaza-iglesia más importantes de la ciudad",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La plaza de trazado irregular es custodiada, a lo largo de la calle Charles A. Dana, por la iglesia-convento de “Nuestra Señora de la Merced”."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En su entorno se ubican la emisora provincial Radio Cadena Agramonte; el Centro de Convenciones Santa Cecilia; la oficina central de Correos de Cuba y dos instalaciones del Banco de Crédito y Comercio."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajaaodres.jpg"),
                            VirtualVisitContentPage = new UI.Pages.WorkersSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Cerrando un extremo de la plaza, y a continuación del convento, se encuentra la Asociación Cubana de Artesanos Artistas (ACAA), recinto que ofrece un espacio para exposiciones, simposios y talleres donde participan los artesanos locales."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {82E32A87-5728-4151-9C9E-443AAF5CA363}
                    Id = new System.Guid(0x82e32a87, 0x5728, 0x4151, 0x9c, 0x9e, 0x44, 0x3a, 0xaf, 0x5c, 0xa3, 0x63),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.380571,
                    Long = -77.919030,
                    Title = "Sede del Tribunal Provincial Popular.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Tribunal-Provincial-Popular.jpg"),
                    Summary = "Antigua Real Audiencia de Santo Domingo. El edificio fue construido por la Orden de los Jesuitas con el propósito de establecer un colegio de la orden. Luego de la expulsión de la orden el estado español dispuso,a partir del 1800, como sede de la Real Audiencia de Santo Domingo, considerada la más antigua de América",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A partir de ese momento la entonces Villa experimentó una gran animación judicial y resultó foro de muchos abogados."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Al momento de su traslado a Puerto Príncipe la Audiencia tenía jurisdicción sobre la isla de Cuba, la Luisiana, la Florida y la Capitanía General de Puerto Rico. Permaneció en Puerto Príncipe hasta 1808 cuando se trasladó a La Habana, volviendo luego a Puerto Príncipe."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Un real decreto del 18 de agosto de 1838 limitó su jurisdicción a los departamentos Oriental y Central de la isla de Cuba. Suprimida en 1853 la edificación sirvió como Cuartel de Artillería y del Cuerpo de Ingenieros. En el año 1868 fue restablecida como Real Audiencia de Camagüey."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A inicios del siglo XX pasó a ser Palacio de Justicia y hoy acoge el Tribunal Popular Provincial, con igual objeto social de impartir justicia."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La edificación acogió transformaciones en 1910, incorporó elementos antiguos y con una decoración sobria en la fachada y en el interior, en tanto se conservan sus antiguos arcos y columnas coloniales en la planta baja, entre los que asciende una elegante escalera de mármol de doble vuelta adicionada entonces."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {4A29185E-DAED-4F8A-9CAD-F7FBBD727E64}
                    Id = new System.Guid(0x4a29185e, 0xdaed, 0x4f8a, 0x9c, 0xad, 0xf7, 0xfb, 0xbd, 0x72, 0x7e, 0x64),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379911,
                    Long = -77.923515,
                    Title = "Plaza e Iglesia del Carmen. Monasterio de las Ursulinas",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Plaza-Del-Carmen.jpg"),
                    Summary = "Este conjunto, conformado por la Plaza del Carmen, la Iglesia del Carmen y el antiguo Convento de las Ursulinas, representa uno de los núcleos coloniales mejor conservados y más significativos de Camagüey, ofreciendo un testimonio vivo de la historia y la arquitectura de la ciudad.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La Plaza del Carmen es un espacio de gran valor histórico y arquitectónico. Su creación data de las primeras décadas del siglo XIX, y, a diferencia de otras plazas, se distingue por su arquitectura popular, irregulares y de fachadas sencillas, lo que le confiere un encanto singular. Tras una importante restauración, la plaza fue embellecida con tinajones de arcilla, faroles encantadores y esculturas de tamaño real que representan escenas de la vida cotidiana camagüeyana, convirtiéndola en una de las plazas más bellas de la ciudad."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Plaza-Del-Carmen.jpg"),
                            VirtualVisitContentPage = new UI.Pages.CarmenSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La Iglesia de Nuestra Señora del Carmen, construida en 1825, domina gran parte de la plaza con su imponente belleza barroca. Es la única iglesia en Camagüey que posee dos torres. Su majestuosa fachada presenta tres accesos, lo que a primera vista podría sugerir que está compuesta por tres naves, aunque en realidad cuenta con una sola planta de tamaño modesto que incluye vestíbulo, coro, presbiterio y sacristía. Este templo forma parte de un conjunto arquitectónico invaluable del siglo XIX, compartiendo espacio con el antiguo Monasterio de las Ursulinas."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El edificio que albergó el Convento de las Ursulinas es otra de las joyas arquitectónica de la primera mitad del siglo XIX que se encuentra a un costado de la plaza. El edificio actual fue terminado en 1829, y a lo largo de su historia ha sufrido varias rehabilitaciones. Originalmente, el convento y su colegio se fundaron para educar a niñas, incluso aquellas de escasos recursos. "
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En la actualidad la edificación aloja la sede de la Oficina del Historiador de la ciudad y, en su otra mitad, la filial de la Universidad de las Artes en la provincia con aulas especializadas para música, danza y artes audiovisuales. A pesar de los años, el inmueble conserva su singular distribución de puertas y ventanas exteriores, enmarcadas por 70 arcos."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A escasos metros de la Plaza del Carmen, y sirviendo de antesala en el recorrido desde el centro de la ciudad, se encuentra la plazoleta de Bedoya resultado de la intersección irregular de varias calles y sitio tradicional de fiestas populares como el San Juan Camagüeyano."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {804EBD54-5ED9-4762-97F1-1D3042469829}
                    Id = new System.Guid(0x804ebd54, 0x5ed9, 0x4762, 0x97, 0xf1, 0x1d, 0x30, 0x42, 0x46, 0x98, 0x29),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379489,
                    Long = -77.918885,
                    Title = "Asamblea Municipal del Poder Popular.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.AsambleaMunicipal-PoderPopular.jpg"),
                    Summary = "Antiguo Ayuntamiento de la ciudad.Situado en la calle Cisneros (antigua Mayor) esquina a Martí (antigua San Diego), y colindante con el parque Agramonte.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El edificio ha mantenido durante más de 200 años similares funciones como sede de las autoridades locales desde la etapa colonial hasta la actualidad: originalmente Cabildo, Casa Consistorial, Ayuntamiento, y en el período revolucionario se ubicó aquí la Junta Central de Ejecución e Inspección (JCEI), el Poder Local y en la actualidad la Asamblea Municipal del Poder Popular."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Inaugurado en 1775 la edificación ha sido remodelada en varias ocasiones, entre ellas se destaca la de su fachada a principios del siglo XX de carácter ecléctico con detalles Art Nouveau en sus balcones y remates de ventanas y puertas."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {DF7336B4-248C-416B-8D3B-7D124E415045}
                    Id = new System.Guid(0xdf7336b4, 0x248c, 0x416b, 0x8d, 0x3b, 0x7d, 0x12, 0x4e, 0x41, 0x50, 0x45),
                    Kind = Enumerations.PlaceKind.Library,
                    Lat = 21.379150,
                    Long = -77.918808,
                    Title = "Biblioteca Provincial Julio Antonio Mella. ",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.0626-BIBLIOTECA_02.jpg"),
                    Summary = "El edificio actual fue inaugurado en la cuarta década del siglo XX, tras demolerse la antigua casona colonial. Sito en Calle Salvador Cisneros 177, Camagüey.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La edificación presenta un estilo neocolonial con influencias coloniales tradicionales. Destacan sus dos niveles, un portal jerarquizado con tres arcos de medio punto, y un patio interior con arcos mixtilíneos isabelinos, vitrales y persianas francesas. La cubierta está hecha con tejas criollas en excelente estado."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Anteriormente funcionaron en el lugar la Sociedad Filarmónica de Puerto Príncipe, el Casino Español y el Liceo de Camagüey. Desde 1963, es sede de la Biblioteca Provincial Julio Antonio Mella. La biblioteca es sede de eventos literarios y culturales como el Encuentro de Escritores camagüeyanos y la Feria Internacional del Libro en Camagüey, fomentando la cultura local y nacional."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {F7FC16C5-AF3A-43FA-B31A-C25ED9DA5D3C}
                    Id = new System.Guid(0xf7fc16c5, 0xaf3a, 0x43fa, 0xb3, 0x1a, 0xc2, 0x5e, 0xd9, 0xda, 0x5d, 0x3c),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379072,
                    Long = -77.918397,
                    Title = "Parque Ignacio Agramonte.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.agramonte-park.jpg"),
                    Summary = "Comprende el área que ya desde la segunda década del siglo XVII se estableció como el centro político administrativo y comercial de la localidad.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Recibiendo diferentes denominaciones en el transcurso de los años hasta el cese de la soberanía española cuando se le distinguió con el nombre actual."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Desde los primeros años de su existencia se fueron nucleando a su alrededor importantes instituciones como la Iglesia Parroquial Mayor, hoy Catedral Metropolitana y que fuera categorizada hace poco años como Basílica Menor; igualmente el edificio del Cabildo hoy día sede de la Asamblea Municipal del Poder Popular."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Actualmente se encuentran a su alrededor un grupo de edificaciones que albergan instituciones importantes como la Biblioteca Provincial Julio Antonio Mella, la Casa de la Trova, la Casa de la Diversidad cultural y el Centro de Interpretación del Patrimonio, lugar donde se ubica la maqueta del Centro Histórico. Les acompañan instalaciones de servicios y gastronomía."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.agramonte-park.jpg"),
                            VirtualVisitContentPage = new UI.Pages.IgnacioAgramonteParkVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Al centro del parque se encuentra la estatua al Mayor General Ignacio Agramonte develada en 1912. Fundida en bronce en su parte delantera le acompaña la figura que representa la libertad. Forma parte del conjunto escultórico las placas que rinden homenaje a una de las hazañas más importantes dirigida por el Mayor: el rescate del Brigadier Sanguily."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Otro elemento distintivo del parque son las cuatro palmas reales que le escoltan y que, desde su belleza y simbolismo nacional, rinden homenaje a los cuatro primeros mártires camagüeyanos de la gesta independentista."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Espacio de encuentro y descanso del camagüeyano, y sus visitantes, el parque Agramonte es centro de homenajes e inicios de eventos. Una tarja, situada en uno de sus costados, recuerda la declaración oficial del Centro Histórico de la ciudad como Patrimonio Cultural de la Humanidad."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {A5E6FDA4-C96B-4F33-86AB-6BCACCC36BFB}
                    Id = new System.Guid(0xa5e6fda4, 0xc96b, 0x4f33, 0x86, 0xab, 0x6b, 0xca, 0xcc, 0xc3, 0x6b, 0xfb),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.378678,
                    Long = -77.918258,
                    Title = "Catedral Metropolitana.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.catedral-nuestra-camaguey.jpg"),
                    Summary = "La antigua Parroquial Mayor, ubicada a un costado del Parque Agramonte desde su construcción hasta la actualidad, esta iglesia ha sido notablemente modificada.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La primitiva iglesia parroquial que existió en este sitio se construyó en 1617, con una sola nave y sin torre, y fue reedificada a finales del siglo XVII."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La torre actual se levantó en la década de 1790 luego que la antigua se derrumbara. En los años 60 del siglo XIX se edifican las dos naves laterales. En 1875 se le añadió un cuerpo más a la torre."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La imagen del Cristo Rey, que hoy día corona su torre, fue colocada en 1937. Se le denominó Parroquial Mayor hasta 1912, año en que fue consagrada Catedral, con la creación del Obispado de Camagüey. En 1998, al erigirse Camagüey como Arquidiócesis, el Papa Juan Pablo II la declara como Catedral Metropolitana."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Finalmente y por decreto pontificio del Papa Francisco en vísperas de la celebración de los 500 años de la fundación de Santa María del Puerto del Príncipe, hoy Camagüey, se le otorgó el título de Basílica Menor."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {F105B083-7691-4CC3-A613-9644C811D437}
                    Id = new System.Guid(0xf105b083, 0x7691, 0x4cc3, 0xa6, 0x13, 0x96, 0x44, 0xc8, 0x11, 0xd4, 0x37),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.378733,
                    Long = -77.918690,
                    Title = "Casa de la Diversidad Cultural.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Casa-de-la-Diversidad.jpg"),
                    Summary = "La Casa de la Diversidad Cultural en Camagüey es un espacio vibrante y significativo dedicado a preservar, promover y celebrar el rico conjunto de identidades que conforman la cultura cubana.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Más que un simple museo, funciona como un centro dinámico que fomenta el diálogo intercultural y el entendimiento mutuo."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Ubicada en el corazón de esta histórica ciudad, la Casa de la Diversidad Cultural se erige como un testimonio de la compleja mezcla de influencias africanas, europeas y aborígenes que han moldeado la idiosincrasia del pueblo cubano."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A través de sus exposiciones permanentes y temporales, el visitante puede adentrarse en las expresiones artísticas, las tradiciones religiosas, las costumbres culinarias y las narrativas históricas de las diversas comunidades que han confluido en la isla."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Este centro cultural no solo exhibe piezas y documentos, sino que también organiza talleres, conferencias, presentaciones artísticas y eventos comunitarios. Es un punto de encuentro para investigadores, artistas, estudiantes y el público en general, ofreciendo una plataforma para la reflexión sobre la diversidad como una fortaleza y un motor para el desarrollo social."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En la Casa de la Diversidad Cultural, la historia se entrelaza con el presente, y la herencia se proyecta hacia el futuro, reafirmando el valor incalculable de la pluralidad en la identidad cubana."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {CDD68EB6-AE68-458A-97DF-EC41177D740B}
                    Id = new System.Guid(0xcdd68eb6, 0xae68, 0x458a, 0x97, 0xdf, 0xec, 0x41, 0x17, 0x7d, 0x74, 0xb),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.376025,
                    Long = -77.917560,
                    Title = "Conjunto, Plaza, Iglesia y Hospital San Juan de Dios.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-museo-san-juan-de-dios.jpg"),
                    Summary = "Declarado como Monumento Nacional el 10 de octubre de 1978, el conjunto arquitectónico Plaza, Iglesia y Hospital del siglo XVIII, debe su designación al antiguo convento-hospital de San Juan de Dios que se da como concluido en 1728.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "De estilo barroco con influencia mudéjar en el patio interior es uno de los entornos arquitectónicos coloniales mejor conservado. En el altar mayor de la Iglesia se encuentra la única representación conservada en Cuba de la Santísima Trinidad en forma de tres figuras humanas."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Dentro de lo que fuera el antiguo hospital fue expuesto por las tropas españolas el cuerpo sin vida del Mayor General Ignacio Agramonte, caído en combate. El Padre José Olallo Valdés se encargó de asearlo y rendirle honores. El Padre Olallo, de la Orden de San Juan de Dios, fue beatificado en el año 2008 y sus cenizas se guardan dentro de la iglesia. Olallo dedicó más de cincuenta años de su vida a la obra benéfica como enfermero en el mencionado hospital."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El local que ocupaba el antiguo hospital es ahora la ubicación del Museo San Juan de Dios, dedicado a la fundación de la villa, la arquitectura de la ciudad y a recrear la etapa de hospital pediátrico. En esta edificación también tiene su sede el Centro Provincial de Patrimonio Cultural."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En la parte posterior del edificio de la iglesia-convento se inauguró hace unos años el hotel San Juan de Dios, un encantador establecimiento que fusiona la tradición de la arquitectura colonial con las comodidades contemporáneas."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-museo-san-juan-de-dios.jpg"),
                            VirtualVisitContentPage = new UI.Pages.SanJuanDiosSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Vista como un amplio espacio trapezoidal, la plaza se enmarca por un conjunto de edificaciones coloniales con diversos usos socioculturales. En el entorno de la plaza se encuentran varias galerías de arte destacándose, entre otras, la de los artistas locales Joel Jover, Ileana Sánchez, Eduardo Rosales, Magdiel García, José Gutiérrez y Yanel Hernández."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Otras edificaciones acogen restaurantes como La Campana de Toledo, el Parador de los Tres Reyes y el 1800 , todas ejemplos de casas coloniales camagüeyanas con techos a dos aguas y un pasillo en forma de corredor para aliviar las cálidas tardes de verano. Son restaurantes donde los visitantes pueden encontrar el placer de la comida camagüeyana, cubana e internacional."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La casa del balcón es otra de las edificaciones significativas en la plaza pues el cuarto encima del zaguán, con un balconcillo, recuerda las típicas construcciones andaluzas."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {9DBC1AE1-6FC6-485E-94E5-A6F9D7CFFC67}
                    Id = new System.Guid(0x9dbc1ae1, 0x6fc6, 0x485e, 0x94, 0xe5, 0xa6, 0xf9, 0xd7, 0xcf, 0xfc, 0x67),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.375521,
                    Long = -77.914508,
                    Title = "Palacio de los Matrimonios.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Palacio-de-los-Matrimonios.jpg"),
                    Summary = "Es una institución dedicada a la celebración de uniones civiles, siendo el lugar donde muchas parejas formalizan su matrimonio.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Este inmueble situado al inicio de la Avenida de la Caridad, importante arteria comercial y cultural de la ciudad, se encuentra en el antiguo palacete de una de las familias más prominentes y adineradas de Camagüey en el siglo XIX."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El edificio no solo funciona como una oficina de registro, sino que también ofrece un ambiente especial para las ceremonias nupciales, haciendo del acto de casarse una experiencia memorable para los contrayentes y sus familias. Es un símbolo de amor y compromiso para la comunidad."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El palacio suele tener una arquitectura que lo distingue, con elementos históricos que le confieren un toque de solemnidad y elegancia a las bodas que allí se celebran."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {E06A57B3-B738-4146-84CB-F02AAC82A5D4}
                    Id = new System.Guid(0xe06a57b3, 0xb738, 0x4146, 0x84, 0xcb, 0xf0, 0x2a, 0xac, 0x82, 0xa5, 0xd4),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.376340,
                    Long = -77.911804,
                    Title = "Casino Campestre.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.casino-campestre1.jpg"),
                    Summary = "Es el parque urbano más grande de Camagüey y uno de los más extensos de Cuba.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Situado a la orilla del río Hatibonico, y su convergencia con el arroyo Juan del Toro, la existencia de este parque se remonta a los años 50 del siglo XIX. Fue concebido como un espacio para ferias y exposiciones agrícolas e industriales, así como para el recreo, la expansión social y cultural."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Colinda con el Centro Histórico de Camagüey, declarado Patrimonio de la Humanidad, ofreciendo a locales y visitantes un espacio para el descanso, el deporte y la apreciación artística y natural."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A lo largo de su historia, el parque ha sido escenario de diversas remodelaciones y se ha convertido en un importante pulmón verde para la ciudad. En 1916 se le otorgó el nombre de Gonzalo de Quesada en homenaje al patriota local, aunque la denominación popular de \"Casino Campestre\" ha persistido."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En su interior se encuentran situados varios monumentos que rinden tributo a personalidades relevantes de la historia local y nacional como Salvador Cisneros Betancourt figura importante en la configuración de la nación cubana y sus luchas independentistas, el Libertador Desconocido y a los aviadores españoles Barberán y Collar, protagonistas del primer vuelo trasatlántico sin escalas de España (Sevilla) a Cuba (Camagüey)."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El parque también es notable por haber sido uno de los primeros lugares en Cuba donde se exhibieron animales en el siglo XVIII, hoy alberga el zoológico de Camagüey."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {8EDCCBD2-3DE1-4528-B475-06D6EFA42A84}
                    Id = new System.Guid(0x8edccbd2, 0x3de1, 0x4528, 0xb4, 0x75, 0x6, 0xd6, 0xef, 0xa4, 0x2a, 0x84),
                    Kind = Enumerations.PlaceKind.Zoo,
                    Lat = 21.377194,
                    Long = -77.912609,
                    Title = "Zoológico de Camagüey.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.zoologico-entrada.jpg"),
                    Summary = "Es un espacio dedicado a la conservación y exhibición de diversas especies animales, ofreciendo a los visitantes la oportunidad de aprender sobre la fauna local e internacional.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Entre las principales especies que se muestran al público se encuentran el león, el tigre, el jaguar, varias especies de monos, aves exóticas, y reptiles. Se encuentra en un entorno natural que busca replicar el hábitat de los animales, proporcionando un ambiente adecuado para su bienestar."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Es un lugar popular para familias y grupos escolares, que buscan una experiencia educativa y recreativa en contacto con la naturaleza. Además de su función educativa, el zoológico también cumple un rol en la investigación y reproducción de especies, contribuyendo a programas de conservación."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {867B5594-062A-4A96-BDEC-D500DBDEF956}
                    Id = new System.Guid(0x867b5594, 0x62a, 0x4a96, 0xbd, 0xec, 0xd5, 0x0, 0xdb, 0xde, 0xf9, 0x56),
                    Kind = Enumerations.PlaceKind.SportCenter,
                    Lat = 21.378802,
                    Long = -77.911177,
                    Title = "Estadio Cándido González.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.estadio-Camaguey.jpg"),
                    Summary = "Es un recinto deportivo de gran relevancia en Camagüey, principalmente conocido por ser el hogar del equipo de béisbol de la provincia, los Toros de Camagüey.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Es el escenario de numerosos partidos de béisbol a nivel nacional, congregando a miles de aficionados que acuden a apoyar a su equipo."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "El estadio no solo es un centro para el deporte, sino también un punto de encuentro social y cultural para la comunidad, especialmente durante la temporada de béisbol."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {29E4AC5F-30D7-4216-BDF8-6AB1273CF0D2}
                    Id = new System.Guid(0x29e4ac5f, 0x30d7, 0x4216, 0xbd, 0xf8, 0x6a, 0xb1, 0x27, 0x3c, 0xf0, 0xd2),
                    Kind = Enumerations.PlaceKind.SportCenter,
                    Lat = 21.377154,
                    Long = -77.908806,
                    Title = "Sala Polivalente Rafael Fortún.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.sala-Polivalente.jpg"),
                    Summary = "Importante complejo deportivo y de eventos en Camagüey, diseñado para albergar una amplia variedad de actividades bajo techo.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Su carácter \"polivalente\" se debe a la capacidad de sus instalaciones para adaptarse a diferentes disciplinas deportivas como baloncesto, voleibol, balonmano, entre otras, así como para la realización de conciertos, ferias y otros eventos masivos. Es un espacio crucial para el desarrollo deportivo y cultural de la provincia."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Este recinto no solo sirve como sede para competiciones y entrenamientos deportivos, sino que también es un punto de reunión para la comunidad, ofreciendo opciones de entretenimiento y esparcimiento. Su diseño permite una gran flexibilidad en la configuración de sus espacios, lo que la convierte en una de las instalaciones más versátiles de la ciudad."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {EEC8965A-FA25-488F-BE14-F3D6C1264FD1}
                    Id = new System.Guid(0xeec8965a, 0xfa25, 0x488f, 0xbe, 0x14, 0xf3, 0xd6, 0xc1, 0x26, 0x4f, 0xd1),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379324,
                    Long = -77.908776,
                    Title = "Plaza de la Revolución Ignacio Agramonte.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-revolucion-camaguey.jpg"),
                    Summary = "Dedicada al Mayor General Ignacio Agramonte, figura clave en la independencia de Cuba, la plaza es un lugar de encuentro cívico y político, donde se realizan importantes actos conmemorativos, desfiles y concentraciones populares. Su inauguración oficial fue en julio de 1989.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Fruto de la creación de los arquitectos Souto y Balmaseda y los artistas Reynaldo Miranda y Herminio Escalona, con el asesoramiento del historiador Gustavo Sed Nieves, su diseño monumental incluye elementos escultóricos y arquitectónicos que rinden homenaje a la historia y a los héroes de la nación."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Es conocida internacionalmente su imagen, pues recorrió el mundo el 23 de enero de 1998, cuando el Papa Juan Pablo II celebró una Santa Misa. En la base del Monumento también existe un Salón de Protocolo, que hace honor a otro de los grandes de Camagüey y de Cuba, el poeta nacional Nicolás Guillén."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Ese recinto está dedicado a actividades solemnes y protocolares. El 1 de diciembre de 2016, el séquito fúnebre que trasladaba las cenizas del líder histórico de la revolución cubana, Fidel Castro Ruz detuvo su marcha y sus restos pernoctaron en el salón Jimaguayú, en la base del Monumento al Mayor General Ignacio Agramonte y Loynaz."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "La plaza no solo es un punto de referencia para eventos oficiales, sino que también es un lugar de esparcimiento y reflexión para los ciudadanos. A su alrededor se encuentran edificios de interés y es un punto de partida para explorar otras zonas de la ciudad."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {81318423-46AC-4ACA-ABCC-6A99799B6D1C}
                    Id = new System.Guid(0x81318423, 0x46ac, 0x4aca, 0xab, 0xcc, 0x6a, 0x99, 0x79, 0x9b, 0x6d, 0x1c),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379477,
                    Long = -77.915251,
                    Title = "Parque José Martí",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.81318423-46AC-4ACA-ABCC-6A99799B6D1C.jpg"),
                    Summary = "En torno al parque existen edificios de diversas épocas y estilos arquitectónicos: barroco, colonial, neoclásico, ecléctico, art-noveau y racionalista.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Entre las edificaciones sobresalen el Convento de San Francisco con un patio central y sus arcadas de origen colonial. Encontramos también el edificio que en la actualidad ocupa una institución de salud conocida como policlínico centro. En este inmueble con grado de protección uno, debido a su alto valor patrimonial, radicó la casa de Tomás Pío Betancourt, primer historiador de la ciudad, y en otro momento fue el colegio de las Salesianas para niñas pobres."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En las cercanías del parque se encuentra el Callejón de Funda del Catre, considerado entre los más estrechos del país. Hoy es sólo vía para ciclos."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.81318423-46AC-4ACA-ABCC-6A99799B6D1C.jpg"),
                            VirtualVisitContentPage = new UI.Pages.MartiParkVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "También está cerca la Plazuela de Triana, barriada que ha conservado las tradiciones populares afrocubanas de raíz conga; y en cuyas inmediaciones se encuentra la esquinera casa de Pobres y Triana (por las calles), representativa de nuestra arquitectura."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Por la calle Avellaneda, que nace frente al parque, se encuentra la estatua dedicada a la poetisa Gertrudis Gómez de Avellaneda, la Divina Tula, una de las grandes mujeres de letras de la lengua castellana. En la misma calle y un poco más adelante su casa natal."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {52A423A8-ABF1-4BA1-8BA4-B91DF209C820}
                    Id = new System.Guid(0x52a423a8, 0xabf1, 0x4ba1, 0x8b, 0xa4, 0xb9, 0x1d, 0xf2, 0x9, 0xc8, 0x20),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.379075,
                    Long = -77.915154,
                    Title = "Iglesia del Sagrado Corazón de Jesús",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.52A423A8-ABF1-4BA1-8BA4-B91DF209C820.jpg"),
                    Summary = "Se erige a un costado del parque Martí. Fue edificada en las primeras décadas del pasado siglo luego de ser demolida la anterior iglesia franciscana.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "De estilo neogótico catalán constituye uno de los más hermosos templos religiosos de la ciudad."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Consta de una planta rectangular de tres naves terminada en un ábside poligonal, la fachada principal está conformada por un portal de tres arcos apuntados y tres torres octogonales rematadas por pináculos piramidales."
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
                },
                new Models.Data.PlaceDataModel
                {
                    // {06C3FEBB-04EC-4B5F-8939-2CCFA4C5E7E7}
                    Id = new System.Guid(0x6c3febb, 0x4ec, 0x4b5f, 0x89, 0x39, 0x2c, 0xcf, 0xa4, 0xc5, 0xe7, 0xe7),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.389157,
                    Long = -77.915734,
                    Title = "Railway Museum",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.museo-ferroviario.jpg"),
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
                    // {FD858121-66B5-4841-A044-79A8349BB903}
                    Id = new System.Guid(0xfd858121, 0x66b5, 0x4841, 0xa0, 0x44, 0x79, 0xa8, 0x34, 0x9b, 0xb9, 0x3),
                    Kind = Enumerations.PlaceKind.Hotel,
                    Lat = 21.388818,
                    Long = -77.915409,
                    Title = "Plaza Hotel",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-hotel.jpg"),
                    Summary = "Opened at the beginning of the 20th century, this is the oldest of the Camagüey hotels still in operation.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "It still retains most of its original architectural features and, among its many significant events, treasures the visit of Chilean poet Gabriela Mistral, Nobel Prize winner for Literature in 1945, and the launch of the first radio station outside the Cuban capital."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Intimate and welcoming, it is characterized by the friendly service of its employees and its excellent geographical location, right at the confluence of the main access routes to the city (railway, airport, and highway) and just a few meters from the commercial area."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {39D4C52D-07E7-4D85-871B-C3121837D363}
                    Id = new System.Guid(0x39d4c52d, 0x7e7, 0x4d85, 0x87, 0x1b, 0xc3, 0x12, 0x18, 0x37, 0xd3, 0x63),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382699,
                    Long = -77.916316,
                    Title = "Church of Our Lady of Solitude.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Iglesia-Soledad.jpg"),
                    Summary = "The Church of Our Lady of Solitude is an emblematic Catholic temple located in Camagüey, Cuba, at the intersection of República and Ignacio Agramonte streets.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Built during the 18th century, it stands out for its picturesque cream and terracotta tower, which stands as a distinctive landmark on the city skyline. The church is an example of the Cuban colonial style with Mudejar influences evident in elements such as the ceiling of the central nave, making it an architectural gem."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Inside, the church houses detailed Baroque frescoes and the sacred baptismal font where Cuban hero Ignacio Agramonte was baptized in 1841. It was also the place where Agramonte and Amalia Simoni were married. There is a crypt beneath the presbytery."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The Church of La Soledad is not only a symbol of devotion for local Catholics but also a tourist attraction that allows visitors to appreciate Cuban colonial architecture and immerse themselves in the city's history."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {7C2C3B41-760D-4471-994F-1A7BC974EA23}
                    Id = new System.Guid(0x7c2c3b41, 0x760d, 0x4471, 0x99, 0x4f, 0x1a, 0x7b, 0xc9, 0x74, 0xea, 0x23),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382359,
                    Long = -77.917110,
                    Title = "Ignacio Agramonte and Loynaz Street.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.camaguey-Ignacio-Agramonte-Street.jpg"),
                    Summary = "From Plaza de la Soledad, continuing along Ignacio Agramonte Street (formerly Soledad) to Independencia, there is a themed promenade known as “Cinema Street”, where commercial establishments have been named after world film classics.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "In this section, you'll find installations and projects, such as the “Alley of Miracles”, representative of this artistic universe."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The Tourist Information Center, known as Infotur, is located in the latter space. Also nearby are the offices of several travel agencies, such as Paradiso."
                        }
                    }
                },
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
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.219C0EF3_B075_4D76_B348_610B560CCA13.jpg"),
                            VirtualVisitContentPage = new UI.Pages.BirthplaceMuseumVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The interior has a C-shaped floor plan with a continuous balcony with a vertical base overlooking the central courtyard. The latter houses five large earthenware jars and a cistern with a white marble rim. The interior is accessed through the main entrance or hall, leading to the courtyard and former secondary rooms, or ascending a staircase that leads to the mezzanine of the former servants' quarters and the chambers. The main entrance leads to the courtyard and former secondary rooms, or ascending through the main rooms of the house."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {CBF018EA-EF3E-45E0-94E8-090F4D9ADAE4}
                    Id = new System.Guid(0xcbf018ea, 0xef3e, 0x45e0, 0x94, 0xe8, 0x9, 0xf, 0x4d, 0x9a, 0xda, 0xe4),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382344,
                    Long = -77.918274,
                    Title = "Church-convent of “Our Lady of Mercy (1748)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.iglesia-merced.jpg"),
                    Summary = "Located in the city center, the aforementioned building is the largest religious building in the province.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The church consists of three naves and a central tower. Beneath its main altar are ancient crypts housing religious relics, such as a tombstone, which, according to known sources, is the oldest funerary monument in the province. A convent was built adjacent to it, which had several uses during the colonial period."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Beginning in the 18th century, the church was closely associated with Holy Week processions and the procession of the Holy Sepulchre. Since the colonial era, the latter has been one of the most valuable religious artifacts and the subject of one of the legends in local tradition."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {B5A960E9-4C4C-490E-AF6F-752BB9EB98BD}
                    Id = new System.Guid(0xb5a960e9, 0x4c4c, 0x490e, 0xaf, 0x6f, 0x75, 0x2b, 0xb9, 0xeb, 0x98, 0xbd),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382229,
                    Long = -77.918687,
                    Title = "Workers' Square",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajaaodres.jpg"),
                    Summary = "It constitutes one of the most important square-church complexes in the city.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The irregularly shaped plaza is guarded, along Charles A. Dana Street, by the church-convent of “Our Lady of Mercy”."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The provincial radio station Radio Cadena Agramonte is located nearby; the Santa Cecilia Convention Center; the Cuban Post Office headquarters; and two Banco de Crédito y Comercio facilities."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-trabajaaodres.jpg"),
                            VirtualVisitContentPage = new UI.Pages.WorkersSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Closing one end of the plaza, and adjacent to the convent, is the Cuban Association of Artisan Artists (ACAA), a venue that offers space for exhibitions, symposiums, and workshops featuring local artisans."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {82E32A87-5728-4151-9C9E-443AAF5CA363}
                    Id = new System.Guid(0x82e32a87, 0x5728, 0x4151, 0x9c, 0x9e, 0x44, 0x3a, 0xaf, 0x5c, 0xa3, 0x63),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.380571,
                    Long = -77.919030,
                    Title = "Headquarters of the Provincial People's Court.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Tribunal-Provincial-Popular.jpg"),
                    Summary = "Former Royal Court of Santo Domingo. The building was constructed by the Jesuit Order to establish a college for the order. After the order's expulsion, the Spanish government established it as the seat of the Royal Audience of Santo Domingo, considered the oldest in the Americas, starting in 1800.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "From that moment on, the then-villa experienced a great deal of judicial activity and became a forum for many lawyers."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "At the time of its transfer to Port-au-Prince, the Audiencia had jurisdiction over the island of Cuba, Louisiana, Florida, and the Captaincy General of Puerto Rico. It remained in Port-au-Prince until 1808, when it moved to Havana, later returning to Port-au-Prince."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A royal decree of August 18, 1838, limited its jurisdiction to the Eastern and Central departments of the island of Cuba. Suppressed in 1853, the building served as an Artillery Barracks and the Engineering Corps. In 1868, it was reestablished as the Royal Court of Camagüey."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "At the beginning of the 20th century, it became the Palace of Justice and today houses the Provincial People's Court, with the same social purpose of administering justice."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building underwent renovations in 1910, incorporating antique elements and a sober decoration on the façade and interior. Its old colonial arches and columns remain on the ground floor, and ascend to an elegant double-turn marble staircase added at that time."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {4A29185E-DAED-4F8A-9CAD-F7FBBD727E64}
                    Id = new System.Guid(0x4a29185e, 0xdaed, 0x4f8a, 0x9c, 0xad, 0xf7, 0xfb, 0xbd, 0x72, 0x7e, 0x64),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379911,
                    Long = -77.923515,
                    Title = "Plaza and Church of Carmen. Ursuline Monastery.", // TODO TRADUCIR TEXTOS
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Plaza-Del-Carmen.jpg"),
                    Summary = "This complex, comprised of the Plaza del Carmen, the Iglesia del Carmen, and the former Ursuline Convent, represents one of Camagüey's best-preserved and most significant colonial centers, offering a living testament to the city's history and architecture.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The Plaza del Carmen is a space of great historical and architectural value. Its creation dates back to the early decades of the 19th century, and, unlike other squares, it is distinguished by its popular architecture, irregular shapes, and simple facades, giving it a unique charm. After a major restoration, the square was embellished with clay jars, charming lanterns, and life-size sculptures depicting scenes from everyday life in Camagüey, making it one of the city's most beautiful squares."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Plaza-Del-Carmen.jpg"),
                            VirtualVisitContentPage = new UI.Pages.CarmenSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The Church of Our Lady of Carmen, built in 1825, dominates much of the plaza with its imposing Baroque beauty. It is the only church in Camagüey with two towers. Its majestic façade features three entrances, which at first glance might suggest it is composed of three naves, although in reality it consists of a single, modestly sized floor that includes the vestibule, choir stalls, presbytery, and sacristy. This church is part of an invaluable 19th-century architectural complex, sharing space with the former Ursuline Monastery."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building that housed the Ursuline Convent is another architectural gem from the first half of the 19th century, located on one side of the square. The current building was completed in 1829 and has undergone several renovations throughout its history. Originally, the convent and its school were founded to educate girls, including those from low-income backgrounds."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building currently houses the headquarters of the City Historian's Office and, on the other side, the provincial branch of the University of the Arts, with specialized classrooms for music, dance, and audiovisual arts. Despite the passing of time, the building retains its unique layout of exterior doors and windows, framed by 70 arches."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Just a few meters from Plaza del Carmen, and serving as a prelude to the journey from the city center, is the Bedoya square, the result of the irregular intersection of several streets and a traditional site for popular festivals such as San Juan Camagüeyano."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {804EBD54-5ED9-4762-97F1-1D3042469829}
                    Id = new System.Guid(0x804ebd54, 0x5ed9, 0x4762, 0x97, 0xf1, 0x1d, 0x30, 0x42, 0x46, 0x98, 0x29),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379489,
                    Long = -77.918885,
                    Title = "Municipal Assembly of People's Power.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.AsambleaMunicipal-PoderPopular.jpg"),
                    Summary = "Old City Hall. Located on Cisneros Street (formerly Mayor) at the corner of Martí Street (formerly San Diego Street), and adjacent to Agramonte Park.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building has served similar functions as the seat of local authorities for over 200 years, from the colonial era to the present day: originally the Town Hall, City Council, and during the revolutionary period, the Central Board of Execution and Inspection (JCEI), the Local Authority, and currently the Municipal Assembly of People's Power, were located here.\r\n"
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Inaugurated in 1775, the building has been remodeled several times, including the eclectic design of its façade at the beginning of the 20th century, with Art Nouveau details on its balconies and window and door trim."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {DF7336B4-248C-416B-8D3B-7D124E415045}
                    Id = new System.Guid(0xdf7336b4, 0x248c, 0x416b, 0x8d, 0x3b, 0x7d, 0x12, 0x4e, 0x41, 0x50, 0x45),
                    Kind = Enumerations.PlaceKind.Library,
                    Lat = 21.379150,
                    Long = -77.918808,
                    Title = "Julio Antonio Mella Provincial Library. ",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.0626-BIBLIOTECA_02.jpg"),
                    Summary = "The current building was inaugurated in the fourth decade of the 20th century, after the old colonial mansion was demolished. Located at 177 Salvador Cisneros Street, Camagüey.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building features a neocolonial style with traditional colonial influences. Its two levels, a hierarchical portal with three semicircular arches, and an interior courtyard with Elizabethan mixed-arches, stained-glass windows, and French shutters are notable. The roof is made of Creole tiles in excellent condition."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The Puerto Príncipe Philharmonic Society, the Spanish Casino, and the Camagüey Lyceum previously operated here. Since 1963, it has housed the Julio Antonio Mella Provincial Library. The library hosts literary and cultural events such as the Camagüey Writers' Meeting and the Camagüey International Book Fair, promoting local and national culture."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {F7FC16C5-AF3A-43FA-B31A-C25ED9DA5D3C}
                    Id = new System.Guid(0xf7fc16c5, 0xaf3a, 0x43fa, 0xb3, 0x1a, 0xc2, 0x5e, 0xd9, 0xda, 0x5d, 0x3c),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379072,
                    Long = -77.918397,
                    Title = "Ignacio Agramonte Park.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.agramonte-park.jpg"),
                    Summary = "It includes the area that was established as the political, administrative and commercial center of the town since the second decade of the 17th century.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Receiving different names over the years until the cessation of Spanish sovereignty when it was distinguished with its current name."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "From the earliest years of its existence, important institutions were built around it, such as the Major Parish Church, now the Metropolitan Cathedral and recently categorized as a Minor Basilica; and the Town Hall building, now the headquarters of the Municipal Assembly of People's Power."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Currently, a group of buildings surround it, housing important institutions such as the Julio Antonio Mella Provincial Library, the Casa de la Trova, the Casa de la Diversidad Cultural (House of Cultural Diversity), and the Heritage Interpretation Center, which houses a model of the Historic Center. These are also accompanied by service and dining facilities."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.agramonte-park.jpg"),
                            VirtualVisitContentPage = new UI.Pages.IgnacioAgramonteParkVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "At the center of the park is the statue of Major General Ignacio Agramonte, unveiled in 1912. Cast in bronze, it is flanked by a figure representing liberty. The sculptural ensemble includes plaques that pay tribute to one of the most important feats led by the Major: the rescue of Brigadier Sanguily."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Another distinctive element of the park are the four royal palm trees that flank it and, through their beauty and national symbolism, pay tribute to the first four Camagüeyan martyrs of the independence struggle."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A meeting and relaxation space for Camagüeyans and visitors alike, Agramonte Park is a center for tributes and events. A plaque on one side commemorates the official declaration of the city's Historic Center as a World Heritage Site."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {A5E6FDA4-C96B-4F33-86AB-6BCACCC36BFB}
                    Id = new System.Guid(0xa5e6fda4, 0xc96b, 0x4f33, 0x86, 0xab, 0x6b, 0xca, 0xcc, 0xc3, 0x6b, 0xfb),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.378678,
                    Long = -77.918258,
                    Title = "Metropolitan Cathedral.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.catedral-nuestra-camaguey.jpg"),
                    Summary = "The former Major Parish Church, located next to Agramonte Park, has been significantly modified since its construction.\r\n",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The original parish church that stood on this site was built in 1617, with a single nave and no tower, and was rebuilt at the end of the 17th century."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The current tower was built in the 1790s after the old one collapsed. The two side aisles were built in the 1860s. In 1875, another section was added to the tower."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The image of Christ the King, which today crowns its tower, was placed in 1937. It was called the Major Parish Church until 1912, when it was consecrated as a Cathedral, with the creation of the Diocese of Camagüey. In 1998, when Camagüey was established as an Archdiocese, Pope John Paul II declared it a Metropolitan Cathedral."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Finally, by papal decree of Pope Francis on the eve of the 500th anniversary of the founding of Santa María del Puerto del Príncipe, now Camagüey, it was granted the title of Minor Basilica."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {F105B083-7691-4CC3-A613-9644C811D437}
                    Id = new System.Guid(0xf105b083, 0x7691, 0x4cc3, 0xa6, 0x13, 0x96, 0x44, 0xc8, 0x11, 0xd4, 0x37),
                    Kind = Enumerations.PlaceKind.Museum,
                    Lat = 21.378733,
                    Long = -77.918690,
                    Title = "House of Cultural Diversity.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Casa-de-la-Diversidad.jpg"),
                    Summary = "The House of Cultural Diversity in Camagüey is a vibrant and meaningful space dedicated to preserving, promoting, and celebrating the rich set of identities that make up Cuban culture.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "More than just a museum, it functions as a dynamic center that fosters intercultural dialogue and mutual understanding."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Located in the heart of this historic city, the House of Cultural Diversity stands as a testament to the complex mix of African, European, and indigenous influences that have shaped the ethos of the Cuban people."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Through its permanent and temporary exhibitions, visitors can delve into the artistic expressions, religious traditions, culinary customs, and historical narratives of the diverse communities that have come together on the island."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "This cultural center not only exhibits artifacts and documents but also organizes workshops, conferences, artistic presentations, and community events. It is a meeting point for researchers, artists, students, and the general public, offering a platform for reflection on diversity as a strength and a driving force for social development."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "At the House of Cultural Diversity, history is intertwined with the present, and heritage is projected into the future, reaffirming the incalculable value of diversity in Cuban identity."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {CDD68EB6-AE68-458A-97DF-EC41177D740B}
                    Id = new System.Guid(0xcdd68eb6, 0xae68, 0x458a, 0x97, 0xdf, 0xec, 0x41, 0x17, 0x7d, 0x74, 0xb),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.376025,
                    Long = -77.917560,
                    Title = "Complex, Square, Church and Hospital San Juan de Dios.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-museo-san-juan-de-dios.jpg"),
                    Summary = "Declared a National Monument on October 10, 1978, the 18th-century Plaza, Church and Hospital architectural complex owes its designation to the former convent-hospital of San Juan de Dios, which was completed in 1728.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Built in the Baroque style with a Mudejar influence in the interior courtyard, it is one of the best-preserved colonial architectural settings. The main altar of the church houses the only surviving representation of the Holy Trinity in the form of three human figures."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The body of Major General Ignacio Agramonte, who had fallen in combat, was displayed by Spanish troops inside what was once the old hospital. Father José Olallo Valdés was responsible for cleaning and honoring him. Father Olallo, a member of the Order of Saint John of God, was beatified in 2008, and his ashes are kept in the church. Olallo dedicated more than fifty years of his life to charitable work as a nurse at the aforementioned hospital."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The former hospital building is now home to the San Juan de Dios Museum, dedicated to the founding of the town, the city's architecture, and recreating the city's pediatric hospital era. This building also houses the Provincial Cultural Heritage Center."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "A few years ago, the San Juan de Dios Hotel opened at the rear of the church-convent building. It is a charming establishment that blends traditional colonial architecture with contemporary comforts."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-museo-san-juan-de-dios.jpg"),
                            VirtualVisitContentPage = new UI.Pages.SanJuanDiosSquareVirtualTourPage()
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Viewed as a large trapezoidal space, the plaza is framed by a group of colonial buildings with diverse sociocultural uses. The plaza's surroundings feature several art galleries, including those of local artists Joel Jover, Ileana Sánchez, Eduardo Rosales, Magdiel García, José Gutiérrez, and Yanel Hernández."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Other buildings house restaurants such as La Campana de Toledo, Parador de los Tres Reyes, and 1800, all examples of Camagüey colonial houses with gabled roofs and a corridor-like walkway to cool off on warm summer evenings. These restaurants serve Camagüey, Cuban, and international cuisine."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The balcony house is another significant building in the square, as the room above the entrance hall, with its small balcony, is reminiscent of typical Andalusian buildings."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {9DBC1AE1-6FC6-485E-94E5-A6F9D7CFFC67}
                    Id = new System.Guid(0x9dbc1ae1, 0x6fc6, 0x485e, 0x94, 0xe5, 0xa6, 0xf9, 0xd7, 0xcf, 0xfc, 0x67),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.375521,
                    Long = -77.914508,
                    Title = "Palace of Marriages.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.Palacio-de-los-Matrimonios.jpg"),
                    Summary = "It is an institution dedicated to the celebration of civil unions, being the place where many couples formalize their marriage.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "This property, located at the beginning of Avenida de la Caridad, an important commercial and cultural artery in the city, is located in the former mansion of one of Camagüey's most prominent and wealthy families in the 19th century."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The building not only functions as a registry office but also provides a special setting for wedding ceremonies, making the act of getting married a memorable experience for the bride and groom and their families. It is a symbol of love and commitment to the community."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The palace often boasts distinctive architecture, with historical elements that lend a touch of solemnity and elegance to the weddings held there."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {E06A57B3-B738-4146-84CB-F02AAC82A5D4}
                    Id = new System.Guid(0xe06a57b3, 0xb738, 0x4146, 0x84, 0xcb, 0xf0, 0x2a, 0xac, 0x82, 0xa5, 0xd4),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.376340,
                    Long = -77.911804,
                    Title = "Country Casino.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.casino-campestre1.jpg"),
                    Summary = "It is the largest urban park in Camagüey and one of the largest in Cuba.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Located on the banks of the Hatibonico River, where it meets the Juan del Toro Stream, this park dates back to the 1950s. It was conceived as a space for agricultural and industrial fairs and exhibitions, as well as for recreation and social and cultural expansion."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "It borders the Historic Center of Camagüey, declared a World Heritage Site, offering locals and visitors a space for relaxation, sports, and artistic and natural appreciation."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Throughout its history, the park has undergone various renovations and has become an important green space for the city. In 1916, it was named after Gonzalo de Quesada in honor of the local patriot, although the popular name \"Casino Campestre\" has persisted."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Inside there are several monuments that pay tribute to important figures in local and national history, such as Salvador Cisneros Betancourt, an important figure in the formation of the Cuban nation and its independence struggles, the Unknown Liberator, and the Spanish aviators Barberán and Collar, protagonists of the first non-stop transatlantic flight from Spain (Seville) to Cuba (Camagüey)."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The park is also notable for having been one of the first places in Cuba where animals were exhibited in the 18th century; today it houses the Camagüey Zoo."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {8EDCCBD2-3DE1-4528-B475-06D6EFA42A84}
                    Id = new System.Guid(0x8edccbd2, 0x3de1, 0x4528, 0xb4, 0x75, 0x6, 0xd6, 0xef, 0xa4, 0x2a, 0x84),
                    Kind = Enumerations.PlaceKind.Zoo,
                    Lat = 21.377194,
                    Long = -77.912609,
                    Title = "Camagüey Zoo.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.zoologico-entrada.jpg"),
                    Summary = "It is a space dedicated to the conservation and exhibition of various animal species, offering visitors the opportunity to learn about local and international fauna.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Among the main species on display are lions, tigers, jaguars, several species of monkeys, exotic birds, and reptiles. It is located in a natural setting that seeks to replicate the animals' habitat, providing an environment conducive to their well-being."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "It's a popular spot for families and school groups seeking an educational and recreational experience in close contact with nature. In addition to its educational function, the zoo also plays a role in research and species breeding, contributing to conservation programs."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {867B5594-062A-4A96-BDEC-D500DBDEF956}
                    Id = new System.Guid(0x867b5594, 0x62a, 0x4a96, 0xbd, 0xec, 0xd5, 0x0, 0xdb, 0xde, 0xf9, 0x56),
                    Kind = Enumerations.PlaceKind.SportCenter,
                    Lat = 21.378802,
                    Long = -77.911177,
                    Title = "Candido Gonzalez Stadium.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.estadio-Camaguey.jpg"),
                    Summary = "It is a major sports venue in Camagüey, primarily known for being the home of the province's baseball team, the Camagüey Bulls.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "It is the venue for numerous baseball games nationwide, attracting thousands of fans who come to support their team."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The stadium is not only a center for sports, but also a social and cultural meeting point for the community, especially during baseball season."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {29E4AC5F-30D7-4216-BDF8-6AB1273CF0D2}
                    Id = new System.Guid(0x29e4ac5f, 0x30d7, 0x4216, 0xbd, 0xf8, 0x6a, 0xb1, 0x27, 0x3c, 0xf0, 0xd2),
                    Kind = Enumerations.PlaceKind.SportCenter,
                    Lat = 21.377154,
                    Long = -77.908806,
                    Title = "Rafael Fortún Multipurpose Room.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.sala-Polivalente.jpg"),
                    Summary = "An important sports and events complex in Camagüey, designed to host a wide variety of indoor activities.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Its \"multipurpose\" nature is due to the ability of its facilities to adapt to different sports such as basketball, volleyball, handball, among others, as well as to host concerts, fairs, and other mass events. It is a crucial space for the sporting and cultural development of the province."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "This venue not only serves as a venue for sports competitions and training, but is also a meeting point for the community, offering entertainment and leisure options. Its design allows for great flexibility in the configuration of its spaces, making it one of the most versatile facilities in the city."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {EEC8965A-FA25-488F-BE14-F3D6C1264FD1}
                    Id = new System.Guid(0xeec8965a, 0xfa25, 0x488f, 0xbe, 0x14, 0xf3, 0xd6, 0xc1, 0x26, 0x4f, 0xd1),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379324,
                    Long = -77.908776,
                    Title = "Ignacio Agramonte Revolution Square.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.plaza-revolucion-camaguey.jpg"),
                    Summary = "Dedicated to Major General Ignacio Agramonte, a key figure in Cuba's independence, the plaza is a civic and political meeting place, hosting important commemorative events, parades, and popular gatherings. Its official inauguration took place in July 1989.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The brainchild of architects Souto and Balmaseda and artists Reynaldo Miranda and Herminio Escalona, ​​with the advice of historian Gustavo Sed Nieves, its monumental design includes sculptural and architectural elements that pay tribute to the nation's history and heroes."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Its image is internationally known, as it traveled the world on January 23, 1998, when Pope John Paul II celebrated Mass. At the base of the monument, there is also a Protocol Hall, which honors another of Camagüey's and Cuba's greats, the national poet Nicolás Guillén."
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "This space is dedicated to solemn and formal activities. On December 1, 2016, the funeral procession carrying the ashes of the historic leader of the Cuban Revolution, Fidel Castro Ruz, halted its procession, and his remains spent the night in the Jimaguayú Hall, at the base of the Monument to Major General Ignacio Agramonte y Loynaz."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "The square is not only a focal point for official events, but also a place of recreation and reflection for citizens. Surrounding it are interesting buildings, it serves as a starting point for exploring other areas of the city."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {81318423-46AC-4ACA-ABCC-6A99799B6D1C}
                    Id = new System.Guid(0x81318423, 0x46ac, 0x4aca, 0xab, 0xcc, 0x6a, 0x99, 0x79, 0x9b, 0x6d, 0x1c),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379477,
                    Long = -77.915251,
                    Title = "José Martí Park",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.81318423-46AC-4ACA-ABCC-6A99799B6D1C.jpg"),
                    Summary = "Around the park there are buildings from various periods and architectural styles: baroque, colonial, neoclassical, eclectic, art nouveau, and rationalist.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Among the buildings, the Convent of San Francisco stands out, with its central courtyard and arcades of colonial origin. We also find the building that currently houses a health institution known as the Polyclinic Center. This building, with protection class one due to its high heritage value, was the home of Tomás Pío Betancourt, the city's first historian, and at one time served as the Salesian school for poor girls."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Near the park is Funda del Catre Alley, considered one of the narrowest in the country. Today, it is used only for bicycles."
                        },
                        new Models.Data.Content.VirtualVisitContentDataModel
                        {
                            PreviewImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.81318423-46AC-4ACA-ABCC-6A99799B6D1C.jpg"),
                            VirtualVisitContentPage = new UI.Pages.MartiParkVirtualTourPage()
                        },
                         new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Also nearby is the Plazuela de Triana, a neighborhood that has preserved Afro-Cuban folk traditions rooted in conga music; and nearby is the corner house of Pobres y Triana (for the streets), representative of our architecture."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "On Avellaneda Street, which begins opposite the park, stands a statue dedicated to the poet Gertrudis Gómez de Avellaneda, known as the Divine Tula, one of the great literary figures of the Spanish language. Her birthplace is located on the same street and a little further on."
                        }
                    }
                },
                new Models.Data.PlaceDataModel
                {
                    // {52A423A8-ABF1-4BA1-8BA4-B91DF209C820}
                    Id = new System.Guid(0x52a423a8, 0xabf1, 0x4ba1, 0x8b, 0xa4, 0xb9, 0x1d, 0xf2, 0x9, 0xc8, 0x20),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.379075,
                    Long = -77.915154,
                    Title = "Church of the Sacred Heart of Jesus",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.52A423A8-ABF1-4BA1-8BA4-B91DF209C820.jpg"),
                    Summary = "It stands next to Martí Park. It was built in the early decades of the last century after the demolition of the previous Franciscan church.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Built in Catalan neo-Gothic style, it is one of the most beautiful religious temples in the city."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "It consists of a rectangular floor plan with three naves ending in a polygonal apse. The main façade is made up of a portal with three pointed arches and three octagonal towers topped by pyramidal pinnacles."
                        }
                    }
                }
            };
        }   
    }
}
