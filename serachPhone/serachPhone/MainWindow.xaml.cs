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

namespace serachPhone
{
    public class PhoneBook{
        string[] name;
        long[] phone;
        int count;

        public PhoneBook(int size)
        {
            name = new string[size];
            phone = new long[size];
            count = 0;
        }

        public void AddContact(string n , long p){
            name[count] = n;
            phone[count] = p;
            count++;
        }

        public string getName(long p)
        {
            int index = Array.IndexOf(phone, p);
            return name[index];
        }
        public long getNumber(string n)
        {
            int index = Array.IndexOf(name, n);
            return phone[index];
        }
    }
    

   
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PhoneBook ph;
        public MainWindow()
        {
            InitializeComponent();
            ph = new PhoneBook(10);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ph.AddContact(tbname.Text.ToString(), long.Parse(tbphone.Text));
            result.Text = "data insert sucessfully";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           long res = ph.getNumber(tbname.Text);
           result.Text = res.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            result.Text = ph.getName(long.Parse(tbphone.Text));
        }


    }
}
