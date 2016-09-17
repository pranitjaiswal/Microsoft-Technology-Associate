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

namespace WpfApplication10
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
            fname.Text = "";
            mname.Text = "";
            lname.Text = "";
            address.Document.Blocks.Clear();
            mailid.Text = "";
            mno.Text = "";
            country.Text = "";
            state.Text = "";
            city.Text = "";
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Binding fname = new Binding();
            fname.Source = fname;
            fname.Path = new PropertyPath("Text");
            tarfname.SetBinding(TextBlock.TextProperty, fname);
        }
    }
}

