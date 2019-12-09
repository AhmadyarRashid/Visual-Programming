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

namespace Lecture_16 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        DataClasses1DataContext dc = new DataClasses1DataContext();

        public MainWindow() {
            InitializeComponent();

            loadData3();
        }

        public void loadData() {

            var allAppointments = from a in dc.Appointments
                                  select a; //this query will also return doctor and patients
                                            //objects since appointments has a foreign key
                                            //to them

            dg.ItemsSource = allAppointments;


        }

        public void loadData2() {

            var res = from d in dc.Doctors
                      join a in dc.Appointments
                      on d.DId equals a.DId
                      select new {
                          a.ATime,
                          a.ADate,
                          d.DName,
                    
                      };

            //can also use

            var res2 = from a in dc.Appointments
                       select new {
                           DoctorName = a.Doctor.DName,
                           AppointmentTime = a.ATime,
                           AppointmentDate = a.ADate,
                           PatientName = a.Patient.PName

                       };

            dg.ItemsSource = res2;

            

        }

        void loadData3() {  //sort by

            var res = from a in dc.Appointments
                      orderby a.ADate
                      select new {
                          DoctorName = a.Doctor.DName,
                          AppointmentTime = a.ATime,
                          AppointmentDate = a.ADate,
                          PatientName = a.Patient.PName

                      };
            dg.ItemsSource = res;
        }

        void loadData4() {  //group by


            var res = from a in dc.Appointments
                      group a by a.ADate // can use group a by new {a.Doctor.Dname, a.Doctor.DId}
                          into tr //temporary table reference
                          from t in tr
                          select new {
                              DoctorName = t.Doctor.DName,
                              PatientName = t.Patient.PName,
                              AppointmentDate = t.ADate
                          };

          }

        
    }
}
