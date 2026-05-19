using EnergyVisualize.Helpers;
using System.Windows.Controls;
using System.Windows.Input;

namespace EnergyVisualize.ViewModels
{
    public class UsageEnergyViewModel
    {
        public ICommand CheckChangedCommand { get; }
        public ICommand CheckCommand { get; }

        public UsageEnergyViewModel()
        {
            CheckChangedCommand = new RelayCommand(OnCheckChanged!);
            //CheckCommand = new RelayCommand(_ => { System.Windows.MessageBox.Show("Click work"); });
            CheckCommand = new RelayCommand(OnCheckChanged!);

        }

        private void OnCheckChanged(object parameter)
        {
            var chk = parameter as CheckBox;
            if (chk != null)
            {
                string name = chk.Tag?.ToString() ?? "Unknown";
                bool isChecked = chk.IsChecked == true;

                System.Diagnostics.Debug.WriteLine($"Checkbox '{name}' is now {(isChecked ? "checked" : "unchecked")}");
                if (isChecked)
                {
                    // do something
                }
                else
                {
                    // do something
                }
            }

        }


    }


}