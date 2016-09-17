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
    /// Interaction logic for SimpleSlider.xaml
    /// </summary>
    public partial class SimpleSlider : Window
    {
        public SimpleSlider()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            Binding mybinding = new Binding();
            mybinding.Source = sldsource;
            mybinding.Path = new PropertyPath("Value");
            tbtarget.SetBinding(TextBlock.TextProperty, mybinding);
        }
    }
}
