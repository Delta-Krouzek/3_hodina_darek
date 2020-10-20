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
using System.Windows.Threading;

namespace _3_hodina_darek
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int score;
        DispatcherTimer casovac = new DispatcherTimer();

        public MainWindow()
        {

            casovac.Interval = new TimeSpan(0, 0, 0, 1);

            InitializeComponent();
        }

        private void strom_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void darek_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
