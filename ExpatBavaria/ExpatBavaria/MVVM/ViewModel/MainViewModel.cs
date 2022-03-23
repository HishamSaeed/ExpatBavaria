using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpatBavaria.MVVM.ViewModel
{
    class MainViewModel : ObservableObjects
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand WandernViewCommand { get; set; }

        public RelayCommand CitiesViewCommand { get; set; }

        public RelayCommand TripViewCommand { get; set; }

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

        public MainViewModel()
        {
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
        }
    }
}
