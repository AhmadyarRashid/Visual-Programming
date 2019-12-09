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

namespace assignment_1
{

    public class person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { set; get; }
        public string email { set; get; }

        public person() { }
        public person(string f, string l, string a, string e)
        {
            this.firstName = f;
            this.lastName = l;
            this.address = a;
            this.email = e;
        }
    }

    public class UserInfo:person
    {
        
        public string company { get; set; }
        public string jobTitle { get; set; }
        public long phoneNo { get; set; }
        public string photo { set; get; }
        public string country {set;get;}

        public UserInfo(string f, string l, string a, string e, string com, string job, long phone, string pic, string country):base(f,l,a,e)
        {
            this.company = com;
            this.jobTitle = job;
            this.phoneNo = phone;
            this.photo = pic;
            this.country = country;
        }

        
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserInfo std;
        public MainWindow()
        {
            InitializeComponent();
            std = new UserInfo("ahmad" , "yar","islamabad", "ahmedyar61@gmail.com","ato","internship",3131539336,"","+92");


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = loginemail.Text;
            string pass = loginpassword.Text;

            if (email.Equals(std.email) && pass.Equals("123"))
            {
                Window1 showData = new Window1(std);
                showData.Show();
                this.Close();
            }
        }
    }
}
