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

namespace color_resources
{
    /// <summary>
    /// Interaction logic for nestedstackpanel.xaml
    /// </summary>
    public partial class nestedstackpanel : Window
    {
        public nestedstackpanel()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Data submitted");
            txtName.Text = "";
            txtAge.Text = "";
        }

       
    }
}
