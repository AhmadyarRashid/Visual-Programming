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

namespace ServiceConsumer {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        //add service reference by right clicking on referencing -> add service reference
        private void Button_Click(object sender, RoutedEventArgs e) {
            ServiceReference1.Service1Client sc = new ServiceReference1.Service1Client();
            MessageBox.Show(sc.getStudentName(2));

        }
    }
}
