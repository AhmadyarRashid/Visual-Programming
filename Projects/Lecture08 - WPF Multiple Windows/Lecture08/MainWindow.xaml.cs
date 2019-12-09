using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lecture08 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public Employee e1;
        public MainWindow() {
            InitializeComponent();

            //Console.WriteLine("hello");

            //Console.ReadKey();
        }

        private void submit_Click(object sender, RoutedEventArgs e) {

            String gender;

            if (mRadio.IsChecked == true)
                gender = "male";
            else
                gender = "female";

            e1 = new Employee(fText.Text, lText.Text, int.Parse(Age.Text), Department.Text, gender);
           /* 
            
            */
            Window1 w1 = new Window1(e1);

            this.Close();

            w1.Show();

        }

        private void fText_GotFocus(object sender, RoutedEventArgs e) {
            if((fText.Text.Equals("Name")) || (fText.Text.Equals("")) )
                fText.Text = "";
            lText.Text = "";
            Age.Text = "";
            Department.Text = "";
          
        }


    }

    public class Employee {
        public String fName{get; set;}
        public String lName { get; set;}
        public String gender { get; set; }

        public int age;


        public int Age {

            get {
                return age;
            }

            set {
                if (value < 18) //value is a keyword
                    age = 18;
                else
                    age = value;

            }

        }

        public String department { get; set; }

        public Employee() {

        }

        public Employee(String fName, String lName, int age, String department, String gender) {
            this.fName = fName;
            this.Age = 12;
            this.lName = lName;
            this.department = department;
            this.gender = gender;
        }


        
    }
}
