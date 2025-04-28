namespace MOROPO.InfoTur.Camaguey.Rutas.Models.Data.Content
{
    public class ContactInformationGroupContentDataModel : Contract.AbstractContentDataModel
    {
        public string Header { get; set; }

        public System.Collections.Generic.Dictionary<string, ContactInformationItem> Items { get; set; }

        public class ContactInformationItem
        {
            public string Address { get; set; }

            public string WebSite { get; set; }

            public string Phones { get; set; }
        }
    }
}
