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

namespace Application1
{
    /// <summary>
    /// Interaction logic for StyleExample.xaml
    /// </summary>
    public partial class StyleExample : Window
    {
        public StyleExample()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double p = Convert.ToDouble(amnt.Text);
            double t = Convert.ToDouble(time.Text);
            double r = Convert.ToDouble(rate.Text);
            double i = (p * t * r) / 100;
            result.Text = i.ToString();            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            amnt.Text = "";
            time.Text = "";
            rate.Text = "";
            result.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            MessageBox.Show("Closing Calculator");
        }
    }
}
