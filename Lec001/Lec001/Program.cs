using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec001
{
    public class person
    {
        string name, address, gender;
        public person()
        {

        }
        public person(string n, string a, string g)
        {
            name = n;
            address = a;
            gender = g;
        }

    }

    public class employee:person
    {
        string designation;
        dateStruct hiredate;

        public employee()
        {
            hiredate = dateStruct.getDate();
        }

        public void showRecord()
        {
            Console.WriteLine("new employee");
            Console.WriteLine(hiredate.day+"/"+hiredate.month+"/"+hiredate.year);
        }
    }
    public struct dateStruct
    {
        public int day, month, year;
        public dateStruct(int d , int m , int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public static dateStruct getDate()
        {
            dateStruct temp;
            temp.day = System.DateTime.Now.Day;
            temp.month = System.DateTime.Now.Month;
            temp.year = System.DateTime.Now.Year;
            return temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
          //  int a = int.Parse(Console.ReadLine());
          //  int b =  int.Parse(Console.ReadLine());
            
          
          //  int c = Add(a,b);
          //  Console.WriteLine("Sum of {0} and {1} is {2}",a,b,c);

          //  Rectangular r1 = new Rectangular();
          //  r1.display();
          //  Rectangular r2 = new Rectangular(2);
          //  r2.display();
          //  Rectangular r3 = new Rectangular(3, 4);
          //  r3.display();


            dateStruct d = dateStruct.getDate();
            Console.WriteLine("{0} / {1} / {2}",d.day,d.month,d.year);
            employee e = new employee();
            e.showRecord();
            Console.ReadKey();
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Rectangular
    {
        int width, length;
        readonly int tax;
        const float pi = 3.14f;
        public Rectangular()
        {
            width = 0;
            length = 0;
            tax = 10;
           
        }
        public Rectangular(int length)
        {
            this.length = length;
            tax = 20;
        }
        public Rectangular(int length, int width):this(length)
        {
            this.width = width;
            tax = 30;
        }

        public void display()
        {
            Console.WriteLine("length is {0} and width is {1} and tax is {2} " , length , width, tax);
        }
    }
}
