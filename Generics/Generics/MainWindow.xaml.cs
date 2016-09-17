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

namespace Generics
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

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            List<faculty> alltraier = new List<faculty>();
            alltraier.Add(new faculty { Name = "Pranit", Age = 19, FavColor = "White"});
            alltraier.Add(new faculty { Name = "Sneha", Age = 19, FavColor = "Red" });
            alltraier.Add(new faculty { Name = "Eldridge", Age = 19, FavColor = "Black" });
            alltraier.Add(new faculty { Name = "Aniket", Age = 19, FavColor = "Peach" });
            alltraier.Add(new faculty { Name = "Neethu", Age = 26, FavColor = "Pink" });
            alltraier.Add(new faculty { Name = "Sejal", Age = 19, FavColor = "Red" });
            this.DataContext = alltraier;

        }
    }
}
