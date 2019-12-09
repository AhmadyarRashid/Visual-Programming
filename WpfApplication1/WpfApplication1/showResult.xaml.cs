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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for showResult.xaml
    /// </summary>
    public partial class showResult : Window
    {
        public showResult()
        {
            InitializeComponent();
        }
        public showResult(Employee e1 )
        {
            InitializeComponent();
            showresult.Text = e1.fname + "\n" + e1.lname + "\n" + e1.Age + "\n" + e1.designation;
        }
    }
}
