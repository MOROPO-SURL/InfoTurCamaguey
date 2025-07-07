using System.Collections.Generic;
using System.Linq;

namespace MOROPO.InfoTur.Camaguey.Rutas.Models.Page
{
    public class ConfigurationPageModel : SmartSolucionesCuba.XFToolKit.Mvvm.Models.Page.BasePageModel
    {
        private View.ConfigurationOptionItemViewModel selectedMapMase;
        private View.ConfigurationOptionItemViewModel selectedARMode;

        public ConfigurationPageModel()
        {
            SelectMapBaseCommand = new Xamarin.Forms.Command<View.ConfigurationOptionItemViewModel>(item =>
            {
                SelectedMapMase = item;

                UpdateSelection(MapBaseConfigurationItems, item);
            });
            SelectARModeCommand = new Xamarin.Forms.Command<View.ConfigurationOptionItemViewModel>(item =>
            {
                SelectedARMode = item;

                UpdateSelection(ARModeConfigurationItems, item);
            });
        }

        public System.Windows.Input.ICommand SelectMapBaseCommand { get; }
        public System.Windows.Input.ICommand SelectARModeCommand { get; }

        public List<View.ConfigurationOptionItemViewModel> MapBaseConfigurationItems { get; } = new List<View.ConfigurationOptionItemViewModel>
        {
            new View.ConfigurationOptionItemViewModel
            {
                Id = Providers.ConstantProvider.CONFIGURATION_MAPBASE_BUILDIN,
                Title = "Mapa InforTur (offline, sin internet)"
            },
            new View.ConfigurationOptionItemViewModel
            {
                Id = Providers.ConstantProvider.CONFIGURATION_MAPBASE_BING_SATELLITAL,
                Title = "Mapa Bing Aerial (con conexión a internet)"
            }
        };

        public List<View.ConfigurationOptionItemViewModel> ARModeConfigurationItems { get; } = new List<View.ConfigurationOptionItemViewModel>
        {
            new View.ConfigurationOptionItemViewModel
            {
                Id = Providers.ConstantProvider.CONFIGURATION_AR_ESSENTIAL,
                Title = "Esencial (elementos principales)"
            },
            new View.ConfigurationOptionItemViewModel
            {
                Id = Providers.ConstantProvider.CONFIGURATION_AR_EXTENDED,
                Title = "Extendido (incluye elementos adicionales)"
            },
            new View.ConfigurationOptionItemViewModel
            {
                Id = Providers.ConstantProvider.CONFIGURATION_AR_FULL,
                Title = "Completo (incluye todos los elementos)"
            }
        };

        public View.ConfigurationOptionItemViewModel SelectedMapMase { get => selectedMapMase; set => SetProperty(ref selectedMapMase, value); }

        public View.ConfigurationOptionItemViewModel SelectedARMode { get => selectedARMode; set => SetProperty(ref selectedARMode, value); }

        public void LoadSavedValues()
        {
            if (Xamarin.Forms.Application.Current.Properties.TryGetValue(Providers.ConstantProvider.CONFIGURATION_MAPBASE_KEY, out var mapBaseId))
            {
                SelectedMapMase = MapBaseConfigurationItems.FirstOrDefault(t => t.Id == (System.Guid)mapBaseId);
            }
            else
            {
                SelectedMapMase = MapBaseConfigurationItems[0];
            }

            if (Xamarin.Forms.Application.Current.Properties.TryGetValue(Providers.ConstantProvider.CONFIGURATION_AR_MODE_KEY, out var arModeId))
            {
                SelectedARMode = ARModeConfigurationItems.FirstOrDefault(n => n.Id == (System.Guid)arModeId);
            }
            else
            {
                SelectedARMode = ARModeConfigurationItems[0];
            }

            UpdateSelection(MapBaseConfigurationItems, SelectedMapMase);
            UpdateSelection(ARModeConfigurationItems, SelectedARMode);
        }

        private void UpdateSelection(List<View.ConfigurationOptionItemViewModel> options, View.ConfigurationOptionItemViewModel selected)
        {
            foreach (var option in options)
            {
                option.Selected = option == selected;
            }
        }
    }
}
