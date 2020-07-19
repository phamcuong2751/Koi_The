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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KoiThe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Change_Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Percent_Sugar.Text = S_Choses_Sugar.Value.ToString() + "%  Sugar";
            var temp = S_Choses_Sugar.Value;
            Price_Drink.Text = (25000 * (1 + temp / 1000)).ToString() + "VNĐ";
        }
    }
}
