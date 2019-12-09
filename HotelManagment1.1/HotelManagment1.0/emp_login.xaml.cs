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
    /// Interaction logic for emp_login.xaml
    /// </summary>
    public partial class emp_login : Window
    {
        hmDataContext dc = new hmDataContext();
        public emp_login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // employee login button
            String user_email = email.Text;
            String user_pass = password.Text;

            var result = from q in dc.Employees
                         where q.emp_email == user_email && q.emp_password == user_pass
                         select q;
            if (result.Count() > 0)
            {
                var res = (result).SingleOrDefault();
                MainWindow main = new MainWindow(res.emp_name);
                main.Show();
                this.Close();
            }
            else
            {
                hint.Content = "Invalid Email and Password";
            }

        }

        private void getEmailFocus(object sender, RoutedEventArgs e)
        {
            // email focus
            email.Text = "";

        }

        private void getPasswordFocus(object sender, RoutedEventArgs e)
        {
            // password focus
            password.Text = "";
        }
    }
}
