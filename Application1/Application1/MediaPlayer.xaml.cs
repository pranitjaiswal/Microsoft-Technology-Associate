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
    /// Interaction logic for MediaPlayer.xaml
    /// </summary>
    public partial class MediaPlayer : Window
    {
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, RoutedEventArgs e)
        {
            vlcplayer.Play();
            MessageBox.Show("Event created");
        }

        private void btnstop_Click(object sender, RoutedEventArgs e)
        {
            vlcplayer.Pause();
        }

        private void btnexit_Click(object sender, RoutedEventArgs e)
        {
            vlcplayer.Stop();
            this.Close();
        }
    }
}
