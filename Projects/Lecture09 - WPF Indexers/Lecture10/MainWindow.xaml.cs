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

namespace Lecture10 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        PhoneBook pb;

        public MainWindow() {
            InitializeComponent();

            pb = new PhoneBook(10);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            pb.add(Name.Text,int.Parse(Phone.Text));
            Name.Text = "";
            Phone.Text = "";
        }

        private void SByName_Click(object sender, RoutedEventArgs e) {
            int number = pb[Name.Text];
            lBox.Items.Add("Name:" + Name.Text + "\n Phone:" + number);
        }

        private void SByPhone_Click(object sender, RoutedEventArgs e) {
            String name = pb[int.Parse(Phone.Text)];
            lBox.Items.Add("Name:" + name + "\n Phone:" + Phone.Text);
        }
        


    }

    public class PhoneBook {
        int[] numbers;
        String[] names;
        int used;

        public PhoneBook(int size) {
            numbers = new int[size];
            names = new String[size];
            used = 0;
        }

        public void add(String name, int number) {
            numbers[used] = number;
            names[used] = name;
            used++;
        }

        public int this[String name] {

            get {

                int a = Array.IndexOf(names, name); //for loop. Returns index of passed value. If value doesn't exist returns -1

                if (a > -1)
                    return numbers[a];
                else
                    return 0;

            }

        }

        public String this[int number] {

            get {

                int a = Array.IndexOf(numbers, number); //for loop. Returns index of passed value. If value doesn't exist returns -1

                if (a > -1)
                    return names[a];
                else
                    return null;

                

            }

        }

    }
}
