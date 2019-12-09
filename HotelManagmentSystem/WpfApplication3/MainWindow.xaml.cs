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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        hmDataContext dc = new hmDataContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var emailtxt = email.Text;
            var passtxt = pass.Password;

            if (emailtxt != null || passtxt != null)
            {
                
                try
                {
                    var checkPass = (from q in dc.Receptionists
                                     where q.Name == emailtxt && q.RecID == int.Parse(passtxt)
                                     select q).First();
                    if (checkPass != null)
                    {
                        Booking booking = new Booking();
                        booking.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email ur Password are invalid");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Email ur Password are invalid");
                }
                finally
                {
                    email.Text = "";
                    pass.Password = "";
                }

               
            }

           
        }
    }
}
