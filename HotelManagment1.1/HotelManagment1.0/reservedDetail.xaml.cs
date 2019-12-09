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
    /// Interaction logic for reservedDetail.xaml
    /// </summary>
    public partial class reservedDetail : Window
    {
        hmDataContext dc = new hmDataContext();
        public reservedDetail()
        {
            InitializeComponent();
            var res = from q in dc.ReservedRooms
                      select new 
                      {
                        q.ReservationRoom.guest_name,
                        q.roomNo,
                        q.Room.room_type
                      };
            reservedDG.ItemsSource = res;
        }
    }
}
