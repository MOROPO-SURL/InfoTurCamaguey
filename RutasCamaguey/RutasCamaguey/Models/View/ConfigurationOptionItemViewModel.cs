namespace MOROPO.InfoTur.Camaguey.Rutas.Models.View
{
    public class ConfigurationOptionItemViewModel : SmartSolucionesCuba.XFToolKit.Mvvm.Models.BaseBindableModel
    {
        private bool selected;

        public bool Selected { get => selected; set => SetProperty(ref selected, value); }

        public System.Guid Id { get; set; }

        public string Title { get; set; }
    }
}
