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
using Microsoft.Win32;

namespace assignment_1
{
    /// <summary>
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        UserInfo updateInfo;
        string img;

        public Edit()
        {
            InitializeComponent();
        }

        public Edit(UserInfo u)
        {
            
            InitializeComponent();
            updateInfo = u;

           // enum countrycode {"+92" , "+93" , "+94"};

            countrycode.Items.Add("+92");
            countrycode.Items.Add("+93");
            countrycode.Items.Add("+94");
            countrycode.Items.Add("+95");
            countrycode.Items.Add("+96");
            countrycode.Items.Add("+97");
            countrycode.Items.Add("+98");
            countrycode.Items.Add("+99");
            countrycode.Items.Add("+100");
            countrycode.Items.Add("+101");


            fname.Text = u.firstName;
            lname.Text = u.lastName;
            address.Text = u.address;
            company.Text = u.company;
            jobtitle.Text = u.jobTitle;
            email.Text = u.email;
            mobile.Text =u.phoneNo.ToString();
            pic.Text = u.photo;
            countrycode.SelectedItem = u.country.ToString();



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            updateInfo.firstName = fname.Text;
            updateInfo.lastName = lname.Text;
            updateInfo.email = email.Text;
            updateInfo.address = address.Text;
            updateInfo.photo = pic.Text;
            updateInfo.phoneNo = long.Parse(mobile.Text);
            updateInfo.company = company.Text;
            updateInfo.jobTitle = jobtitle.Text;
            updateInfo.country = countrycode.SelectedValue.ToString();

            Window1 w = new Window1(updateInfo);
            w.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1(updateInfo);
            w.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
            dlg.InitialDirectory = @"C:\";
            if (dlg.ShowDialog() == true)
            {
                img = dlg.FileName;
            }
            pic.Text = img.ToString();
        }
    }
}
