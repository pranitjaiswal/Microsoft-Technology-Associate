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

namespace WpfApplication8
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
            Window obj1 = new Window();
            obj1.Height = 500;
            obj1.Width = 500;
            obj1.Title = "Solid Colour Window";
            SolidColorBrush scb = new SolidColorBrush(Colors.Red);
            obj1.Background = scb;
            obj1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window obj2 = new Window();
            obj2.Height = 200;
            obj2.Width = 200;
            obj2.Title = "LINEAR GRADIENT BRUSH WINDOW";
            Point pstrt = new Point(0, 0);
            Point pstop = new Point(1, 1);
            LinearGradientBrush lgb = new LinearGradientBrush(Colors.Red,Colors.Black,pstrt,pstop);
            obj2.Background = lgb;
            obj2.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window obj3 = new Window();
            obj3.Height = 200;
            obj3.Width = 200;
            RadialGradientBrush rgb = new RadialGradientBrush(Colors.Black, Colors.Red);
            obj3.Background = rgb;
            obj3.Show();
        }
    }
}
