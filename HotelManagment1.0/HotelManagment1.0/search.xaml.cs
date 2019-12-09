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
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Window
    {
        hmDataContext dc = new hmDataContext();
        public search()
        {
            InitializeComponent();
        }

        private void searchByName(object sender, KeyEventArgs e)
        {
            var name = searchBN.Text;
            if (name != null)
            {
                var res = from q in dc.ReservationRooms
                          where q.guest_name.Contains(name)
                          select new
                          {
                              Name = q.guest_name,
                              Contact = q.guest_contact,
                              Address = q.guest_address,
                              Deluxe = q.deluxe,
                              SingleRoom = q.single,
                              DoubleRoom = q.@double
                          };
                SearchDG.ItemsSource = res;
            }
            else
            {
                var res = from q in dc.ReservationRooms
                          select new
                          {
                              Name = q.guest_name,
                              Contact = q.guest_contact,
                              Address = q.guest_address,
                              Deluxe = q.deluxe,
                              SingleRoom = q.single,
                              DoubleRoom = q.@double
                          };
                SearchDG.ItemsSource = res;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // when search button click
            var name = searchBN.Text;
            if (name != null)
            {
                var res = from q in dc.ReservationRooms
                          where q.guest_name.Contains(name)
                          select new
                          {
                              Name = q.guest_name,
                              Contact = q.guest_contact,
                              Address = q.guest_address,
                              Deluxe = q.deluxe,
                              SingleRoom = q.single,
                              DoubleRoom = q.@double
                          };
                SearchDG.ItemsSource = res;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // when back btn click and goes to main window
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
