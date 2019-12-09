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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        hmDataContext dc = new hmDataContext();
        public Search()
        {
            InitializeComponent();
        }

        private void searchByName_KeyUp(object sender, KeyEventArgs e)
        {
           var name = searchByName.Text;

           var res = from q in dc.Customers
                     where q.Name.Contains(name)
                     select q;
           searchDG.ItemsSource = res;
        }

       
    }
}
