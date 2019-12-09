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

namespace localdb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        db1DataContext dc = new db1DataContext();
        public MainWindow()
        {
            InitializeComponent();
            var res = from r in dc.Patients
                      select new { 
                      Id = r.Pid,
                      Name = r.PName ,
                      Address = r.PAddress};
            DG.ItemsSource = res;
        }
    }
}
