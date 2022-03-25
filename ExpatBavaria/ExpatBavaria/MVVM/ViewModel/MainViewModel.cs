using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExpatBavaria.MVVM.ViewModel
{
    class MainViewModel : ObservableObjects
    {
        private Window mainWindow;

        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand WandernViewCommand { get; set; }

        public RelayCommand CitiesViewCommand { get; set; }

        public RelayCommand TripViewCommand { get; set; }

        public RelayCommand CloseButtonCommand { get; set; }

        public RelayCommand MinimizeButtonCommand { get; set; }
     
        public HomeViewModel HomeVM { get; set; }

        public WandernViewModel WandernVM { get; set; }

        public CitiesViewModel CitiesVM { get; set; }

        public TripViewModel TripVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel(Window window)
        {
            this.mainWindow = window;

            HomeVM = new HomeViewModel();
            WandernVM = new WandernViewModel();
            CitiesVM = new CitiesViewModel();
            TripVM = new TripViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            WandernViewCommand = new RelayCommand(o =>
            {
                CurrentView = WandernVM;
            });

            CitiesViewCommand = new RelayCommand(o =>
            {
                CurrentView = CitiesVM;
            });

            TripViewCommand = new RelayCommand(o =>
            {
                CurrentView = TripVM;
            });

            CloseButtonCommand = new RelayCommand(o =>
            {
                System.Windows.Application.Current.Shutdown();
            });

            MinimizeButtonCommand = new RelayCommand(o =>
           {
               this.mainWindow.WindowState = WindowState.Minimized;
           });

            

        }
    }
}
