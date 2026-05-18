using EnergyVisualize.Helpers;
using EnergyVisualize.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EnergyVisualize.ViewModels
{
    internal class MainViewModel:INotifyPropertyChanged
    {

        private object? _currentView;
        public object? CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }
        public ICommand ShowUsageEnergyCommand { get; }
        public ICommand ShowPowerPeakCommand { get; }
        public MainViewModel()
        {
          

            ShowUsageEnergyCommand = new RelayCommand(_ => CurrentView = new UsageEnergyView());
            ShowPowerPeakCommand = new RelayCommand(_ => CurrentView = new PowerPeakView());
            CurrentView = new UsageEnergyView(); // เริ่มต้นด้วยหน้า UsageEnergyView
        }
        public event PropertyChangedEventHandler ? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
