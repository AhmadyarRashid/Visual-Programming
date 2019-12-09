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

namespace WpfApplication1
{
    public class Employee
    {
        public string fname
        {
            get;
            set;
        }
        public  string lname
        {
            get;
            set;
        }
        public int Age ;
        int age
        {
            get{
                return Age;
            }
            set{
                if (value < 18) {
                    Age = 18;
                }else{
                    Age = value;
                }
            }
        
        }


        public string designation
        {
            set;
            get;
        }

        public Employee(string f, string l, int a, string desi)
        {
            fname = f;
            lname = l;
            age = a;
            designation = desi;
        }



    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee e1;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            e1 = new Employee(tbfname.Text , tblname.Text , int.Parse(tbage.Text) , tbdesig.Text);
            showresult.Text = e1.fname + "\n" + e1.lname + "\n" + e1.Age + "\n" + e1.designation;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            e1 = new Employee(tbfname.Text, tblname.Text, int.Parse(tbage.Text), tbdesig.Text);
            showResult s = new showResult(e1);
            s.Show();
            this.Close();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
     
    }
}
