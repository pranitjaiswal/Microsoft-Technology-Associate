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

namespace WpfApplication8
{
    /// <summary>
    /// Interaction logic for csharpform.xaml
    /// </summary>
    public partial class csharpform : Window
    {
        public csharpform()
        {
            InitializeComponent();
        }

        private void main1_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel sp1 = new StackPanel();
            StackPanel sp2 = new StackPanel();
            Label lblName = new Label();
            Label lblAge = new Label();
            TextBox txtName = new TextBox();
            TextBox txtAge = new TextBox();
            Button btnsubmit = new Button();
            Button btnclear = new Button();

            sp1.Children.Add(lblName);
            sp1.Children.Add(txtName);

            sp2.Children.Add(lblAge);
            sp2.Children.Add(txtAge);

            main1.Children.Add(sp1);
            main1.Children.Add(sp2);
            main1.Children.Add(btnsubmit);
            main1.Children.Add(btnclear);

            lblName.Content = "Enter Name";
            lblAge.Content = "Enter Age";
            txtAge.Height = 25;
            txtName.Height = 25;
            btnsubmit.Content = "Submit";
            btnclear.Content = "Clear";
            btnclear.Height = 30;
            btnsubmit.Height = 30;

            Point pstrt = new Point(0, 0);
            Point pstop = new Point(1, 1);
            LinearGradientBrush lgb = new LinearGradientBrush(Colors.LightCoral, Colors.White, pstrt, pstop);
            main1.Background = lgb;

            Point pstrt1 = new Point(0, 0);
            Point pstop1 = new Point(1, 1);
            LinearGradientBrush lgb1 = new LinearGradientBrush(Colors.Red, Colors.White, pstrt1, pstop1);
            btnsubmit.Background = lgb1;

            RadialGradientBrush rgb = new RadialGradientBrush(Colors.SkyBlue, Colors.LightSlateGray);
            btnclear.Background = rgb;

        }
    }
}
