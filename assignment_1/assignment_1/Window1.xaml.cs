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

namespace assignment_1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        UserInfo user;
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(UserInfo u)
        {

            InitializeComponent();
            user = u;
            showResult.Text = "First Name = " + u.firstName + "\n" + "Last Name = " + u.lastName + "\n Email = " + u.email +
                "\n Address = " + u.address + "\n Company = " + u.company + "\n Job Title = " + u.jobTitle + "\n Pic = " + u.photo + 
                "\n Phone No = " + u.country + "-" + u.phoneNo;
            if (u.photo == "")
            {
                userImg.Source = new BitmapImage();
            }
            else
            {
                userImg.Source = new BitmapImage(new Uri(u.photo));
            }
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Edit editform = new Edit(user);
            editform.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
