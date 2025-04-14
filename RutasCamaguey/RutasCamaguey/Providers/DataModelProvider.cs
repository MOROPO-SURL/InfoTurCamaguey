namespace MOROPO.InfoTur.Camaguey.Rutas.Providers
{
    public sealed class DataModelProvider
    {
        private static DataModelProvider instance;

        public static DataModelProvider Instance
        {
            get
            {
                instance ??= new DataModelProvider();

                return instance;
            }
        }

        private DataModelProvider()
        {
            Places = new Models.Data.PlaceDataModel[] 
            { 
                new Models.Data.PlaceDataModel 
                { 
                    Kind = Enumerations.PlaceKind.InfoturOffice, 
                    Title = "Infotur Camagüey" 
                },
                new Models.Data.PlaceDataModel 
                {
                    Kind = Enumerations.PlaceKind.Museum,
                    Title = "Museo Casa Natal Ignacio Agramonte"
                }
            };
        }

        public Models.Data.PlaceDataModel[] Places { get; private set; }        
    }
}
