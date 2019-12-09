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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Available.xaml
    /// </summary>
    public partial class Available : Window
    {
        hmDataContext dc = new hmDataContext();
        public Available()
        {
            InitializeComponent();
            
            var res = from q in dc.Rooms
                      where q.Status == "Available"
                      select q;
            availableRoomDG.ItemsSource = res;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // all
            var res = from q in dc.Rooms
                      where q.Status == "Available"
                      select q;
            availableRoomDG.ItemsSource = res;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            // single
            var res = from q in dc.Rooms
                      where q.Type == "Single" && q.Status == "Available"
                      select q;
            availableRoomDG.ItemsSource = res;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            // double
            var res = from q in dc.Rooms
                      where q.Type == "Double" && q.Status == "Available"
                      select q;
            availableRoomDG.ItemsSource = res;
        }
    }
}
