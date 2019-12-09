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

namespace HotelManagment1._0
{
    /// <summary>
    /// Interaction logic for Availablity.xaml
    /// </summary>
    public partial class Availablity : Window
    {
        hmDataContext dc = new hmDataContext();
        public Availablity()
        {
            InitializeComponent();
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                var res = from q in dc.Rooms
                          where q.status == "Available"
                          select q;
                availablityDG.ItemsSource = res;
            }
            catch (Exception)
            {

            }
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            var res = from q in dc.Rooms
                      where q.status == "Available" && q.room_type == "single"
                      select q;
            availablityDG.ItemsSource = res;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            var res = from q in dc.Rooms
                      where q.status == "Available" && q.room_type == "double"
                      select q;
            availablityDG.ItemsSource = res;
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            var res = from q in dc.Rooms
                      where q.status == "Available" && q.room_type == "deluxe"
                      select q;
            availablityDG.ItemsSource = res;
        }

       
    }
}
