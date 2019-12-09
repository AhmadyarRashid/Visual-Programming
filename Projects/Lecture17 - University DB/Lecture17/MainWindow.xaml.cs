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

namespace Lecture17 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        UniversityDataClassesDataContext dc = new UniversityDataClassesDataContext();


        public MainWindow() {
            InitializeComponent();
            notAssignedToAnyStudent();
        }

        public void coursesWithNoPreReq() {

            var res = from q in dc.Courses
                      where !(from r in dc.PreReqs select r.CourseNumber).Contains(q.CourseNumber) //select CourseNumber from 
                                                                                                   //prereq where PreReq.CourseNumber 
                                                                                                   //!= Courses.CourseNumber

                      select new {
                          Course = q.CourseName
                      };
                     
            dg.ItemsSource = res;
        }

        public void coursesTaughtByTeacher() {
            var res = from q in dc.CourseOfferings
                      where q.Instructor == "Shehla Saif" && q.Year == "2018"
                      select new {
                          Instructor = q.Instructor,
                          Year = q.Year,
                          Course = q.Course.CourseName
                      };

            dg.ItemsSource = res;

        }

        public void studentsAssignedCourse() {
            var res = from s in dc.GradeReports
                      select new {
                          StudentName = s.Student.Name,
                          CourseName = s.CourseOffering.Course.CourseName
                      };

            dg.ItemsSource = res;
        }

        public void notAssignedCourse() {

            var res = from q in dc.GradeReports
                      where q.OfferingId == null
                      select new {
                          StudentName = q.Student.Name
                      };

            dg.ItemsSource = res;
        }

        public void notAssignedToAnyStudent() {

            var res = from c in dc.CourseOfferings
                      where !(from g in dc.GradeReports select g.OfferingId).Contains(c.OfferingId)
                      select new {
                        CourseName = c.Course.CourseName
                      };
            dg.ItemsSource = res;

        }


    }
}
