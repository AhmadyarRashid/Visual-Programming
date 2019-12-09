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

namespace portalAssign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        portalDataContext dc = new portalDataContext();
        public MainWindow()
        {
            InitializeComponent();
           // withOutPreReq();
           // instructorCourses("saneeha amir",2000);

        }

        private void stdCourse()
        {
           // var res = from q in dc.sections join a in dc.students 
                                           // on q.semester = a.std_class
                                           // select new{
                                           //     course = q.course.course_name
                                           // };
        }

        private void serachstd(String std)
        {
            var res = from q in dc.students
                      where q.std_name == std
                      select new
                      {
                          Name = q.std_name,
                          Class = q.std_class,
                          Major = q.std_major
                      };
            DG.ItemsSource = res;
        }

        private void serachCourse(String course)
        {
            var res = from q in dc.courses
                      where q.course_name == course
                      select new
                      {
                          Name = q.course_name,
                          credit_hrs = q.credit_hrs
                      };
            DG.ItemsSource = res;
        }

        private void instructorCourses(String instructor , int year)
        {
            var res = from q in dc.sections
                      where q.year == year && q.instructor == instructor
                      select new
                      {
                          course_id = q.course_id,
                          course_name = q.course.course_name
                      };
            DG.ItemsSource = res;
        }

        private void withOutPreReq()
        {
            var res = from q in dc.preReqs
                      where q.pre_id == null
                      select new
                      {
                          course_id = q.course_id,
                          course_name = q.course.course_name
                          
                      };
            DG.ItemsSource = res;
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            serachstd(name.Text.ToString());
        }

        private void searchCourse_Click(object sender, RoutedEventArgs e)
        {
            serachCourse(course.Text.ToString());
        }
    }
}
