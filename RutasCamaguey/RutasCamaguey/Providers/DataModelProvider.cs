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
                },
                new Models.Data.PlaceDataModel
                {
                    // {B5A960E9-4C4C-490E-AF6F-752BB9EB98BD}
                    Id = new System.Guid(0xb5a960e9, 0x4c4c, 0x490e, 0xaf, 0x6f, 0x75, 0x2b, 0xb9, 0xeb, 0x98, 0xbd),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382229,
                    Long = -77.918687,
                    Title = "Plaza de los Trabajadores",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Cerrando un extremo de la plaza, y a continuación del convento, se encuentra la Asociación Cubana de Artesanos Artistas (ACAA), recinto que ofrece un espacio para exposiciones, simposios y talleres donde participan los artesanos locales."
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
                    Title = "Calle Mayor General Ignacio Agramonte y Loynaz, antiguamente Soledad.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "Desde la Plaza de la Soledad, siguiendo por la calle Ignacio Agramonte hasta Independencia, se ubica un paseo temático conocido por “Calle de los Cines” donde los establecimientos comerciales han sido nombrados con el título de clásicos de la filmografía mundial.",
                    Content = new Models.Data.Content.Contract.AbstractContentDataModel[]
                    {
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En ese tramo se encuentran instalaciones y proyectos, como el “Callejón de los Milagros” representativos de este universo artístico."
                        },
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "En el espacio de este último tiene su sede el Centro de información Turística, conocido como Infotur. De igual manera se encuentran en su cercanía las oficinas de varias agencias turísticas como Paradiso. "
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
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {CBF018EA-EF3E-45E0-94E8-090F4D9ADAE4}
                    Id = new System.Guid(0xcbf018ea, 0xef3e, 0x45e0, 0x94, 0xe8, 0x9, 0xf, 0x4d, 0x9a, 0xda, 0xe4),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382344,
                    Long = -77.918274,
                    Title = "Iglesia-convento de “Nuestra Señora de la Merced (1748)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {F7FC16C5-AF3A-43FA-B31A-C25ED9DA5D3C}
                    Id = new System.Guid(0xf7fc16c5, 0xaf3a, 0x43fa, 0xb3, 0x1a, 0xc2, 0x5e, 0xd9, 0xda, 0x5d, 0x3c),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379072,
                    Long = -77.918397,
                    Title = "Parque Ignacio Agramonte.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    Title = "Catedral Metropolitana (antigua Parroquial Mayor)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "Ubicada a un costado del Parque Agramonte desde su construcción hasta la actualidad, esta iglesia ha sido notablemente modificada.",
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
                    // {CDD68EB6-AE68-458A-97DF-EC41177D740B}
                    Id = new System.Guid(0xcdd68eb6, 0xae68, 0x458a, 0x97, 0xdf, 0xec, 0x41, 0x17, 0x7d, 0x74, 0xb),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.376025,
                    Long = -77.917560,
                    Title = "Conjunto, Plaza, Iglesia y Hospital San Juan de Dios.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {82E32A87-5728-4151-9C9E-443AAF5CA363}
                    Id = new System.Guid(0x82e32a87, 0x5728, 0x4151, 0x9c, 0x9e, 0x44, 0x3a, 0xaf, 0x5c, 0xa3, 0x63),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.380571,
                    Long = -77.919030,
                    Title = "Sede del Tribunal Provincial Popular. Antigua Real Audiencia de Santo Domingo.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "El edificio fue construido por la Orden de los Jesuitas con el propósito de establecer un colegio de la orden. Luego de la expulsión de la orden el estado español dispuso,a partir del 1800, como sede de la Real Audiencia de Santo Domingo, considerada la más antigua de América",
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
                    // {804EBD54-5ED9-4762-97F1-1D3042469829}
                    Id = new System.Guid(0x804ebd54, 0x5ed9, 0x4762, 0x97, 0xf1, 0x1d, 0x30, 0x42, 0x46, 0x98, 0x29),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379489,
                    Long = -77.918885,
                    Title = "Sede de la Asamblea municipal del Poder Popular en Camagüey.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379150,
                    Long = -77.918808,
                    Title = "Biblioteca Provincial Julio Antonio Mella - Camagüey. Calle Salvador Cisneros 177, Camagüey.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "El edificio actual fue inaugurado en la cuarta década del siglo XX, tras demolerse la antigua casona colonial.",
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
                },
                new Models.Data.PlaceDataModel
                {
                    // {B5A960E9-4C4C-490E-AF6F-752BB9EB98BD}
                    Id = new System.Guid(0xb5a960e9, 0x4c4c, 0x490e, 0xaf, 0x6f, 0x75, 0x2b, 0xb9, 0xeb, 0x98, 0xbd),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.382229,
                    Long = -77.918687,
                    Title = "Workers' Square",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                        new Models.Data.Content.TextContentDataModel
                        {
                            Text = "Closing one end of the plaza, and adjacent to the convent, is the Cuban Association of Artisan Artists (ACAA), a venue that offers space for exhibitions, symposiums, and workshops featuring local artisans."
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
                    Title = "General Ignacio Agramonte and Loynaz Street, formerly Soledad.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "From Plaza de la Soledad, continuing along Ignacio Agramonte Street to Independencia, there is a themed promenade known as “Cinema Street”, where commercial establishments have been named after world film classics.",
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
                    // {FD858121-66B5-4841-A044-79A8349BB903}
                    Id = new System.Guid(0xfd858121, 0x66b5, 0x4841, 0xa0, 0x44, 0x79, 0xa8, 0x34, 0x9b, 0xb9, 0x3),
                    Kind = Enumerations.PlaceKind.Hotel,
                    Lat = 21.388818,
                    Long = -77.915409,
                    Title = "Plaza Hotel",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {CBF018EA-EF3E-45E0-94E8-090F4D9ADAE4}
                    Id = new System.Guid(0xcbf018ea, 0xef3e, 0x45e0, 0x94, 0xe8, 0x9, 0xf, 0x4d, 0x9a, 0xda, 0xe4),
                    Kind = Enumerations.PlaceKind.Church,
                    Lat = 21.382344,
                    Long = -77.918274,
                    Title = "Church-convent of “Our Lady of Mercy (1748)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {F7FC16C5-AF3A-43FA-B31A-C25ED9DA5D3C}
                    Id = new System.Guid(0xf7fc16c5, 0xaf3a, 0x43fa, 0xb3, 0x1a, 0xc2, 0x5e, 0xd9, 0xda, 0x5d, 0x3c),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.379072,
                    Long = -77.918397,
                    Title = "Ignacio Agramonte Park.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    Title = "Metropolitan Cathedral (formerly the Major Parish)",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "Located next to Agramonte Park since its construction until today, this church has been significantly modified.",
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
                    // {CDD68EB6-AE68-458A-97DF-EC41177D740B}
                    Id = new System.Guid(0xcdd68eb6, 0xae68, 0x458a, 0x97, 0xdf, 0xec, 0x41, 0x17, 0x7d, 0x74, 0xb),
                    Kind = Enumerations.PlaceKind.Monument,
                    Lat = 21.376025,
                    Long = -77.917560,
                    Title = "Complex, Square, Church and Hospital San Juan de Dios.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    // {82E32A87-5728-4151-9C9E-443AAF5CA363}
                    Id = new System.Guid(0x82e32a87, 0x5728, 0x4151, 0x9c, 0x9e, 0x44, 0x3a, 0xaf, 0x5c, 0xa3, 0x63),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.380571,
                    Long = -77.919030,
                    Title = "Headquarters of the Provincial People's Court. Former Royal Court of Santo Domingo.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "The building was constructed by the Jesuit Order to establish a college for the order. After the order's expulsion, the Spanish government established it as the seat of the Royal Audience of Santo Domingo, considered the oldest in the Americas, starting in 1800.",
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
                    // {804EBD54-5ED9-4762-97F1-1D3042469829}
                    Id = new System.Guid(0x804ebd54, 0x5ed9, 0x4762, 0x97, 0xf1, 0x1d, 0x30, 0x42, 0x46, 0x98, 0x29),
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379489,
                    Long = -77.918885,
                    Title = "Headquarters of the Municipal Assembly of People's Power in Camagüey.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
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
                    Kind = Enumerations.PlaceKind.Distinguished,
                    Lat = 21.379150,
                    Long = -77.918808,
                    Title = "Julio Antonio Mella Provincial Library - Camagüey. Salvador Cisneros Street 177, Camagüey.",
                    FeatureImageSource = Xamarin.Forms.ImageSource.FromResource("MOROPO.InfoTur.Camaguey.Rutas.Resources.Images.06C3FEBB_04EC_4B5F_8939_2CCFA4C5E7E7.jpg"),
                    Summary = "The current building was inaugurated in the fourth decade of the 20th century, after the old colonial mansion was demolished.",
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
                }
            };
        }   
    }
}
