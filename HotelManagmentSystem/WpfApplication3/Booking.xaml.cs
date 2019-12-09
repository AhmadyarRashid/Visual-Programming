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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        hmDataContext dc = new hmDataContext();
        public Booking()
        {
            InitializeComponent();
            var res = from q in dc.ReservedRooms
                      select q;
            BookingDG.ItemsSource = res;
        }
        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }



        private void book_Click(object sender, RoutedEventArgs e)
        {
            // click on booking btn
            var Bname = name.Text;
            var Bage = age.Text;
            var Bcontact = contact.Text;
            var Bsingle = int.Parse(single.Text);
            var Bdouble = int.Parse(doubleBed.Text);
            var nights = days.Text;



            Customer customer = new Customer
            {
                Name = Bname,
                Age = Bage,
                Contact = Bcontact

            };
            dc.Customers.InsertOnSubmit(customer);
            dc.SubmitChanges();


            // get customer id
            var newId = (from q in dc.Customers
                         where q.Name == Bname && q.Contact == Bcontact
                         select new
                         {
                             CusId = q.CustomerID
                         }).First();
            var customerId = newId.CusId;

            var totalSingle = (from q in dc.Rooms
                               group q by q.Type == "Single"
                                   into tr
                                   select new
                                   {
                                       tr = tr.Count()
                                   }).First();


            var totalDouble = (from q in dc.Rooms
                               group q by q.Type == "Double"
                                   into tr
                                   select new
                                   {
                                       tr = tr.Count()
                                   }).First();


            if (Bsingle < totalSingle.tr && Bdouble < totalDouble.tr)
            {
                // get single room avaiable
                var singleRoom = (from q in dc.Rooms
                                  where q.Type == "Single" && q.Status == "Available"
                                  select q).First();
                for (int i = 0; i < Bsingle; i++)
                {
                    ReservedRoom reserved = new ReservedRoom
                    {
                     
                        CustomerID = customerId,
                        Nights = nights,
                        RoomID = (singleRoom.RoomID + i)

                    };
                    dc.ReservedRooms.InsertOnSubmit(reserved);


                    dc.SubmitChanges();

                    var room = (from q in dc.Rooms
                               where q.RoomID == singleRoom.RoomID + i
                               select q).First();
                    room.Status = "Booked";
                    dc.SubmitChanges();
                    

                }
             




                // get double room avaiable
                var doubleRoom = (from q in dc.Rooms
                                  where q.Type == "Double" && q.Status == "Available"
                                  select q).First();

                for (int i = 0; i < Bdouble; i++)
                {
                    ReservedRoom reserved = new ReservedRoom
                    {
                       
                        CustomerID = customerId,
                        Nights = nights,
                        RoomID = doubleRoom.RoomID + i

                    };
                    dc.ReservedRooms.InsertOnSubmit(reserved);
                    dc.SubmitChanges();

                    var room = (from q in dc.Rooms
                                where q.RoomID == doubleRoom.RoomID + i
                                select q).First();
                    room.Status = "Booked";
                    dc.SubmitChanges();
                }


                var res = from q in dc.ReservedRooms
                          select q;
                BookingDG.ItemsSource = res;
                
                MessageBox.Show(Bsingle* 1000 + Bdouble*2000 +"");

            }



            name.Text = "";
            contact.Text = "";
            age.Text = "";
            single.Text = "";
            days.Text = "";
            doubleBed.Text = "";
          


                       
        }

    

    
        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // when search button click
          //  MessageBox.Show("search click");
            Search search = new Search();
            search.Show();
      
        }

      

      

        private void Button_GotMouseCapture(object sender, MouseEventArgs e)
        {
            // avalable room click
       //     MessageBox.Show("available room clicked");
             Available av = new Available();
             av.Show();
        }

        private void Button_GotMouseCapture_1(object sender, MouseEventArgs e)
        {
            // search room clicked
            // when search button click
            MessageBox.Show("search click");
            Search search = new Search();
            search.Show();
        }

        private void Button_GotMouseCapture_2(object sender, MouseEventArgs e)
        {
            // reserved button clicked
            Reserved res = new Reserved();
            res.Show();
        }

        private void Button_GotMouseCapture_3(object sender, MouseEventArgs e)
        {
            // signout click
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // UPDATE BTN CLICK
                var res = (ReservedRoom)BookingDG.SelectedItem;
                if (res != null)
                {
                    var cname = name.Text;
                    var cage = age.Text;
                    var ccontact = contact.Text;
                    var roomid = single.Text;
                    var nights = days.Text;

                    var updateCus = (from q in dc.Customers
                                     where q.CustomerID == res.CustomerID
                                     select q).First();

                    updateCus.Name = cname;
                    updateCus.Age = cage;
                    updateCus.Contact = ccontact;

                    dc.SubmitChanges();

                    var updateReserved = (from q in dc.ReservedRooms
                                          where q.ResID == res.ResID
                                          select q).First();
                    updateReserved.Nights = nights;
                    dc.SubmitChanges();

                   
                }
                else
                {
                    MessageBox.Show("Not Row selected");
                }


            }
            catch (Exception)
            {

            }
            finally
            {
                name.Text = "";
                contact.Text = "";
                age.Text = "";
                single.Text = "";
                days.Text = "";
                doubleBed.Text = "";
            }



             
        }

        private void edit_Click_1(object sender, RoutedEventArgs e)
        {
            // edit btn click
            try
            {

                var res = (ReservedRoom)BookingDG.SelectedItem;

                if (res != null)
                {
                    name.Text = res.Customer.Name;
                    contact.Text = res.Customer.Contact;
                    age.Text = res.Customer.Age;
                    single.Text = res.Room.RoomID.ToString();
                    days.Text = res.Nights;

                }
                else
                {
                    MessageBox.Show("Not Any Selected");
                }

            }
            catch (Exception)
            {

            }
        }

        private void delete_Click_1(object sender, RoutedEventArgs e)
        {
            // delete btn click
            try
            {
                var res = (ReservedRoom)BookingDG.SelectedItem;
                if (res != null)
                {
                    dc.ReservedRooms.DeleteOnSubmit(res);
                    dc.SubmitChanges();

                    var res2 = from q in dc.ReservedRooms
                               select q;
                    BookingDG.ItemsSource = res2;

                }
                else
                {
                    MessageBox.Show("Not Row selected");
                }

                
            }
            catch (Exception)
            {

            }
        }



       
    }
}
