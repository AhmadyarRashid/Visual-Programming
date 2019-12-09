using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05 {
    class Program {
        static void Main(string[] args) {

            Employee e1 = new Employee();
            e1.display();
            Console.ReadKey();
        }
    }

    public class Person{
        public String fname {get; set;}
        public String lname {get; set;}

        public Person() { }
        public Person(String lname):this()
        {
            this.fname = "MR.";
            this.lname = lname; 
        }
        public Person(String fname , String lname):this(lname)
        {
            this.fname = fname;
        }

        public virtual void display() { //baseclass -> virtual. If you want a child class to override
                                        //a method, you have to set it as virtual
            Console.WriteLine("hello");
        }
    }

    public class Employee:Person {  //Employee is a person

        DateTime hiredate;
        public Employee() {
            fname = "";
        }

        public Employee(String fname , String lname):base(fname,lname)
        {

        }

        public Employee(String fname , String lname , DateTime hire):base(fname,lname)
        {
            this.hiredate = hire;
        }

        public override void display() { //derived class -> override 
                                         //overriding the super class method. 
            base.display(); //super.display()
        }

       
    }
}
