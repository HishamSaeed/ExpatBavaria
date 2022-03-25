using ExpatBavaria.MVVM.ViewModel;
using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExpatBavaria
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        // TODO make theme for close,maximize and minimze button
        // change picture of close,maximize and minimze button
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainViewModel(this);
        }

        private void DragWithHeader(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
                DragMove();
        }
    }
}
