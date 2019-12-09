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

namespace Lecture10___Binding {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        Person p1;
        List<Person> pList = new List<Person>();

        public MainWindow() {
            InitializeComponent();
            p1 = new Person("Mahad","Mr");

            nameText.DataContext = p1;
            titleText.DataContext = p1;

            pList.Add(p1);
            pList.Add(new Person("aas","ads"));
            pList.Add(new Person() {name= "saif", title="XYZ"}); //not a call to constructor, rather to properties

            list1.ItemsSource = pList;
        }
    }

    public class Person {
        public String name { get; set; }
        public String title { get; set; }

        public Person() {

        }

        public Person(String n, String t) {
            name = n;
            title = t;
        }
    }
}
