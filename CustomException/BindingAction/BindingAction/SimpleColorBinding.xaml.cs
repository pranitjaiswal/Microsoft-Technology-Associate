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

namespace BindingAction
{
    /// <summary>
    /// Interaction logic for SimpleColorBinding.xaml
    /// </summary>
    public partial class SimpleColorBinding : Window
    {
        public SimpleColorBinding()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Binding mybinding1 = new Binding();
            mybinding1.Source = txtName;
            mybinding1.Path = new PropertyPath("Text");
            tbtarget.SetBinding(TextBlock.TextProperty, mybinding1);

            Binding mybinding2 = new Binding();
            mybinding2.Source = txtColor;
            mybinding2.Path = new PropertyPath("Text");
            tbtarget.SetBinding(TextBlock.BackgroundProperty, mybinding2);
        }
    }
}
