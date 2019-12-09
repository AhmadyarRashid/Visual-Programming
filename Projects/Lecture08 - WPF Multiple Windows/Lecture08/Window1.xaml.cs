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
using System.Windows.Shapes;

namespace Lecture08 {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {

        public Window1() {
            InitializeComponent();
        }

        public Window1(Employee e1) {
            InitializeComponent();

            fText1.Text = e1.fName;
            lText1.Text = e1.lName;
            Age1.Text = e1.Age.ToString();
            Department1.Text = e1.department;
            Gender.Text = e1.gender;

        }
    }
}
