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

namespace Binding
{
    public class person
    {
        public string name { get; set; }
        public string title { get; set; }

        public person()
        {

        }
        public person(string n , string t)
        {
            name = n;
            title = t;
        }
    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        person p1;
        List<person> list = new List<person>();
        public MainWindow()
        {
            InitializeComponent();

            // for row 1 and column 2
            p1 = new person("Ahmad","AYR");
            personName.DataContext = p1;
            personTitle.DataContext = p1;

            // for row 1 and column 1
            list.Add(p1);
            list.Add(new person("shaharyar", "MSY"));
            list.Add(new person() { name = "ali", title = "khan" });

            personList.ItemsSource = list;
           
          
        }
    }
}
