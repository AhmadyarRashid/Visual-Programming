using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture04 {

    class Program {
        static void Main(string[] args) {

            Employee e1 = new Employee();

            e1.name = "Mahad";

            e1.Salary = 2000;

            e1.Rank = 2;

            e1.display();

            DateStruct today = DateStruct.getDate();

            Console.WriteLine(today.day + "-" + today.month + "-" + today.year);

            e1.date.display();

            Console.ReadKey();
        }
    }

    public struct DateStruct { //created in stack. All datamembers public by default.
        public int day;
        public int month;
        public int year;

        public DateStruct(int d, int m, int y){
            day = d;
            month = m;
            year = y;
        }

       // public DateStruct() {
            // STRUCTURE CAN NEVER HAVE A ZERO ARGUMENT CONSTRUCTOR, it is made by default
       // }

        public static DateStruct getDate() {
            DateStruct temp;
            temp.day = System.DateTime.Now.Day;
            temp.month = System.DateTime.Now.Month;
            temp.year = System.DateTime.Now.Year;

            return temp;

        }

        public void display() {
            Console.WriteLine(day + "-" + month + "-" + year);
        }
    }

    public class Employee { //created in heap. All datamembers private by default.

        public DateStruct date;


        //Properties are special kind of class members, In Properties we use predefined Set or Get method.
        //They use accessors through which we can read, written or change the values of the private fields.
        //C#'s effecient way of implementing getters and setters

        //private int var;

        //public int Var {
	
        //    get{
        //        return var;
        //    }

        //    set{
        //        var = value;
        //    }
        //}

        // this is equivalent to:
        //private int var{get; set;}

        public String name {get; set;} //property
        String desg = "default";


        private float salary = 0.0f;

        public float Salary {
            get {
                return salary;
            }
            set {
                if (value < 10000)
                    salary = 10000;
                else
                    salary = value;
            }
        }

        private int rank = 0;

        public int Rank {
            get {
                return rank;
            }

            set {
                rank = value;
                if (rank < 17)
                    rank = 17;
                if (rank > 21)
                    rank = 21;
            }
        }

        public Employee() {
            date = DateStruct.getDate();
        }

        public void display() {
            Console.WriteLine("Name: {0}, Designation: {1}, Salary: {2}, Rank: {3}", name, desg, salary, rank);
        }



    }
}
