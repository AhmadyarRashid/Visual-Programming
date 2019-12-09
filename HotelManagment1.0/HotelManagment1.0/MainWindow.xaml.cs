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
using System.Data;

namespace HotelManagment1._0
{

    public class Person
    {
        public String UserName { get; set; }
        public String Address { get; set; }
        public String Contact { get; set; }

        public Person(String name, String address, String contact)
        {
            this.UserName = name;
            this.Address = address;
            this.Contact = contact;
        }
    }

    public class CustomerInfo:Person
    {
        public String date { get; set; }
        public String Category { get; set; }
        public int Rooms { get; set; }
        public CustomerInfo(String name, String address, String contact, String date, String category, int rooms):base(name,address,contact)
        {
            this.date = date;
            this.Category = category;
            this.Rooms = rooms;
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        hmDataContext dc = new hmDataContext();
        public MainWindow()
        {
            InitializeComponent();
          
            try
            {
                loadAvailableData();
            }
            catch (Exception)
            {

            }
            
        }

        void loadAvailableData()
        {
            /*
            for (int i = 0; i < 5; i++)
            {
                Room room = new Room
                {
                    room_no = (100 + i + 5).ToString(),
                    room_type = "single",
                    price = "1200",
                    status = "available"

                };
                dc.Rooms.InsertOnSubmit(room);

                // MessageBox.Show(i + "insert sucessfull");
            }

            for (int i = 0; i < 5; i++)
            {
                Room room = new Room
                {
                    room_no = (200 + i + 5).ToString(),
                    room_type = "double",
                    price = "2200",
                    status = "available"

                };
                dc.Rooms.InsertOnSubmit(room);

                // MessageBox.Show(i + "insert sucessfull");
            }

            for (int i = 0; i < 5; i++)
            {
                Room room = new Room
                {
                    room_no = (300 + i + 5).ToString(),
                    room_type = "deluxe",
                    price = "3200",
                    status = "available"

                };
                dc.Rooms.InsertOnSubmit(room);

                // MessageBox.Show(i + "insert sucessfull");
            }

            */
            for (int i = 0; i < 9; i++)
            {
                ReservationRoom resroom = new ReservationRoom
                {
                    guest_name = "ali",
                    guest_address = "islamabad",
                    guest_contact = "03131539336" + i,
                    single = i.ToString(),
                    date_in = System.DateTime.Today.ToShortDateString(),
                    date_out = System.DateTime.Today.ToShortDateString()


                };
                dc.ReservationRooms.InsertOnSubmit(resroom);
            }
            dc.SubmitChanges();
            var res = from q in dc.ReservationRooms
                      select q;
            DG.ItemsSource = res;
            
         
        }

       

        private void delete_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                var resdel = (ReservationRoom)DG.SelectedItem;
                dc.ReservationRooms.DeleteOnSubmit(resdel);
                dc.SubmitChanges();
            }
            catch (Exception)
            {

            }
            //MessageBox.Show("delete button click");
            var res = from q in dc.ReservationRooms
                      select q;
            DG.ItemsSource = res;
        }

        private void update_btn(object sender, RoutedEventArgs e)
        {
            try
            {
            var user = name.Text;
            var userContact = contact.Text;
            var userAddress = address.Text;
            var userDeluxe = deluxe.Text;
            var userSingle = single.Text;
            var userDouble = doubleBed.Text;
            var userdateIn = dateIn.SelectedDate.Value.ToShortDateString();
            var userdateOut = dateOut.SelectedDate.Value.ToShortDateString();
            var userdays = days.Text;

           // MessageBox.Show(userdateIn);
            
                var res1 = (ReservationRoom)DG.SelectedItem;
                res1.booking_date = userdays;
                res1.guest_name = user;
                res1.guest_contact = userContact;
                res1.guest_address = userAddress;
                res1.single = userSingle;
                res1.@double = userDouble;
                res1.deluxe = userDeluxe;
                res1.date_in = userdateIn;
                res1.date_out = userdateOut;
                dc.SubmitChanges();
            }
            catch (Exception)
            {

            }
            var res = from q in dc.ReservationRooms
                      select q;
            DG.ItemsSource = res;
           // MessageBox.Show("update button click");
        }

        private void book_btn(object sender, RoutedEventArgs e)
        {
            var user = name.Text;
            var userContact = contact.Text;
            var userAddress = address.Text;
            var userDeluxe = deluxe.Text;
            var userSingle = single.Text;
            var userDouble = doubleBed.Text;
            var userdateIn = dateIn.SelectedDate.Value.ToShortDateString();
            var userdateOut = dateOut.SelectedDate.Value.ToShortDateString();
            var userdays = days.Text;

            ReservationRoom reservation = new ReservationRoom
            {
                guest_address = userAddress,
                guest_contact = userContact,
                guest_name = user,
                deluxe = userDeluxe,
                single = userSingle,
                @double = userDouble,
                date_in = userdateIn,
                date_out = userdateOut,
                booking_date = userdays

            };
            dc.ReservationRooms.InsertOnSubmit(reservation);
            dc.SubmitChanges();

            
            var getGuestId = (from q in dc.ReservationRooms
                             where q.guest_contact == userContact && q.guest_name == user
                             select new
                             {
                                 id = q.res_id
                             }).First();
            int guest_id = getGuestId.id;
            
       //     dc.SubmitChanges();

            // for single 
            var singleRoomStart = (from q in dc.Rooms
                                   where q.status == "available" && q.room_type == "single"
                                   select new { 
                                    roomNo = q.room_no
                                   }).First();
            
            
            int room1 = int.Parse(singleRoomStart.roomNo);
            for (int i = 0; i < int.Parse(userSingle); i++)
            {

                var res = (from q in dc.Rooms
                           where q.room_no == (room1 + i).ToString()
                           select q).SingleOrDefault();
                res.status = "booked";

                dc.SubmitChanges();


                // get room id
                var getRoomId = (from q in dc.Rooms
                                where q.room_no == (room1 + i).ToString()
                                select new
                                {
                                   roomId =  q.Id
                                }).SingleOrDefault();
                ReservedRoom reseved = new ReservedRoom 
                { 
                    res_id = guest_id,
                    type = "single",
                    roomNo = (room1+i).ToString(),
                    room_id = getRoomId.roomId
                    
                };
                dc.ReservedRooms.InsertOnSubmit(reseved);
                dc.SubmitChanges();
                
            }


            // for double room
            try
            {

                var doubleRoomStart = (from q in dc.Rooms
                                       where q.status == "available" && q.room_type == "double"
                                       select new
                                       {
                                           roomNo = q.room_no
                                       }).First();


                int roomd = int.Parse(doubleRoomStart.roomNo);
                for (int i = 0; i < int.Parse(userDouble); i++)
                {

                    var res = (from q in dc.Rooms
                               where q.room_no == (roomd + i).ToString()
                               select q).SingleOrDefault();
                    res.status = "booked";

                    dc.SubmitChanges();


                    // get room id
                    var getRoomId = (from q in dc.Rooms
                                     where q.room_no == (roomd + i).ToString()
                                     select new
                                     {
                                         roomId = q.Id
                                     }).SingleOrDefault();
                    ReservedRoom reseved = new ReservedRoom
                    {
                        res_id = guest_id,
                        type = "double",
                        roomNo = (roomd + i).ToString(),
                        room_id = getRoomId.roomId

                    };
                    dc.ReservedRooms.InsertOnSubmit(reseved);
                    dc.SubmitChanges();

                }

            }
            catch (Exception)
            {

            }
            // for deluxe


            var deluxeRoomStart = (from q in dc.Rooms
                                   where q.status == "available" && q.room_type == "deluxe"
                                   select new
                                   {
                                       roomNo = q.room_no
                                   }).First();


            int roomdeluxe = int.Parse(deluxeRoomStart.roomNo);
            for (int i = 0; i < int.Parse(userDeluxe); i++)
            {

                var res = (from q in dc.Rooms
                           where q.room_no == (roomdeluxe + i).ToString()
                           select q).SingleOrDefault();
                res.status = "booked";

                dc.SubmitChanges();


                // get room id
                var getRoomId = (from q in dc.Rooms
                                 where q.room_no == (roomdeluxe + i).ToString()
                                 select new
                                 {
                                     roomId = q.Id
                                 }).SingleOrDefault();
                ReservedRoom reseved = new ReservedRoom
                {
                    res_id = guest_id,
                    type = "deluxe",
                    roomNo = (roomdeluxe + i).ToString(),
                    room_id = getRoomId.roomId

                };
                dc.ReservedRooms.InsertOnSubmit(reseved);
                dc.SubmitChanges();

            }
       

            dc.SubmitChanges();




            int bill = int.Parse(userDeluxe) * 3000 + int.Parse(userSingle) * 1000 + int.Parse(userDouble) * 2000;
            MessageBox.Show("Total Bill = " + bill +  "");
            var resfinal = from q in dc.ReservationRooms
                      select q;
            DG.ItemsSource = resfinal;
            
       }

        private void editbtn(object sender, RoutedEventArgs e)
        {
           
        }

        private void datagridSelectedRow(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var reservation = (ReservationRoom)DG.SelectedItem;
                if (reservation != null)
                {
                    name.Text = reservation.guest_name;
                    address.Text = reservation.guest_address;
                    contact.Text = reservation.guest_contact;
                    deluxe.Text = reservation.deluxe;
                    single.Text = reservation.single;
                    dateIn.SelectedDate = DateTime.Parse(reservation.date_in);
                    dateOut.SelectedDate = DateTime.Parse(reservation.date_out);
                    doubleBed.Text = reservation.@double;
                    days.Text = reservation.booking_date;

                }
            }
            catch (Exception)
            {
                
            }

        }

        private void deluxelostfocuse(object sender, RoutedEventArgs e)
        {
            var countdeluxe = from q in dc.Rooms
                              group q by q.room_type
                              
                                  into tr
                                  from t in tr
                                  where t.room_type == "deluxe" && t.status == "available"
                                  select new
                                  {
                                     count =   tr.Count()
                                  };
            try
            {


                int ab = 0;
                foreach (var a in countdeluxe)
                {
                    ab = a.count;
                }
                var deluxeno = deluxe.Text;
                if (deluxeno == null)
                {
                    deluxeno = "0";
                }
                if (int.Parse(deluxeno) > ab)
                {
                    MessageBox.Show("Only " + ab + " Rooms are available");
                }
            }
            catch (Exception)
            {

            }
            //int deluxe = int.Parse();
            
        }

        private void singlelostfocus(object sender, RoutedEventArgs e)
        {
            var countdeluxe = from q in dc.Rooms
                              group q by q.room_type

                                  into tr
                                  from t in tr
                                  where t.room_type == "single" && t.status == "available"
                                  select new
                                  {
                                      count = tr.Count()
                                  };
            try
            {
                int ab = 0;
                foreach (var a in countdeluxe)
                {
                    ab = a.count;
                }
                var singleno = single.Text;
                if (singleno == null)
                {
                    singleno = "0";
                }
                if (int.Parse(singleno) > ab)
                {
                    book.IsEnabled = false;
                    MessageBox.Show("Only " + ab + " Rooms are available");
                }
               
            }
            catch (Exception)
            {

            }
        }

        private void doubleLostfocus(object sender, RoutedEventArgs e)
        {
            var countdeluxe = from q in dc.Rooms
                              group q by q.room_type

                                  into tr
                                  from t in tr
                                  where t.room_type == "double" && t.status == "available"
                                  select new
                                  {
                                      count = tr.Count()
                                  };
            try
            {
                int ab = 0;
                foreach (var a in countdeluxe)
                {
                    ab = a.count;
                }
                var doublebed = doubleBed.Text;
                if (doublebed == null)
                {
                    doublebed = "0";
                }
                if (int.Parse(doublebed) > ab)
                {
                    book.IsEnabled = false;
                    MessageBox.Show("Only " + ab + " Rooms are available");
                }
               
            }
            catch (Exception)
            {

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // to search btn click
            // open search.xaml.cs
            search search = new search();
            search.Show();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // click available room btn and goes to availabilty.xmal
            Availablity availableroom = new Availablity();
            availableroom.Show();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // click reserved room btn and goes to reservedDetail.xml
            reservedDetail reserved = new reservedDetail();
            reserved.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

       
       
        

        



    }

    
}
