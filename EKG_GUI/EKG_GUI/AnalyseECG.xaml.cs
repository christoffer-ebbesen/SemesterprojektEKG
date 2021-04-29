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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;


namespace EKG_GUI
{
    /// <summary>
    /// Interaction logic for AnalyseECG.xaml
    /// </summary>
    public partial class AnalyseECG : Window
    {
        public List<string> XvaluesAnalyseECG { get; set; }
        public List<double> YvaluesAnalyseECG { get; set; }


        public AnalyseECG()
        {
            InitializeComponent();
            LineSeries ecgLine = new LineSeries();

            ecgLine.Fill = Brushes.Transparent;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            XvaluesAnalyseECG = new List<string>();
            YvaluesAnalyseECG = new List<double>();

            XvaluesAnalyseECG.Add()
        }
    }
}
