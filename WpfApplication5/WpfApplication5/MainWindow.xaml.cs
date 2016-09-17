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

namespace WpfApplication5
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data successfully submitted");

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtfname.Text = "";
            txtmname.Text = "";
            txtlname.Text = "";
            txtage.Text = "";
            txtgender.Text = "";
            txtmno.Text = "";
        }

        private void txtgender_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
