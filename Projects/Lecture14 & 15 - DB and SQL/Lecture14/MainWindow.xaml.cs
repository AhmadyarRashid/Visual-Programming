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

namespace Lecture14
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DBClassesDataContext dc = new DBClassesDataContext();

        public MainWindow()
        {
            InitializeComponent();

            display();

            //methods to remember: datacontext.tablelist.InsertOnSubmit(dataobject)
            //                     datacontext.SubmitChanges()
            //                     dc.tablelist.DeleteOnSubmit()
            //                     dc.tableList.SubmitChanges()

        }

        public void display()
        {
            var res1 = from q in dc.Doctors
                       select q;

            DG1.ItemsSource = res1;
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            Doctor d = new Doctor()
            {
                DName = nametxt.Text,
                Designation = specialtxt.Text,
                Specialization = designationtxt.Text
            };

            dc.Doctors.InsertOnSubmit(d);
            dc.SubmitChanges();

            display();
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var res2 = (Doctor) DG1.SelectedItem;

            //var res = (from q in dc.Doctors
            //           where q.DName == res2.DName
            //           select q).SingleOrDefault();

            dc.Doctors.DeleteOnSubmit(res2);
            dc.SubmitChanges();

            display();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {

            var res2 = (Doctor)DG1.SelectedItem;
      
            res2.DName = nametxt.Text;
            res2.Designation = designationtxt.Text;
            res2.Specialization = specialtxt.Text;
            
            dc.SubmitChanges();

            display();

            nametxt.Text = "";
            specialtxt.Text = "";
            designationtxt.Text = "";
            UpdateBtn.Visibility = Visibility.Hidden;
            EditBtn.Visibility = Visibility.Visible;
            InsertBtn.Visibility = Visibility.Visible;
            
         
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            
            var res2 = (Doctor)DG1.SelectedItem;

            if (res2 != null)
            {
                nametxt.Text = res2.DName;
                specialtxt.Text = res2.Specialization;
                designationtxt.Text = res2.Designation;

                UpdateBtn.Visibility = Visibility.Visible;
                EditBtn.Visibility = Visibility.Collapsed;
                InsertBtn.Visibility = Visibility.Hidden;
            }
            

            
        }
    }
}
