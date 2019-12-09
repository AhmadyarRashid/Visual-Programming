using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03
{
    class Program
    {
        static void Main(string[] args)
        {
            

            String[] daysOfWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            String[] arr = (daysOfWeek.Reverse()).ToArray(); //returns reversed collection object. Original array not changed

            // display original array 
            Arrays.display(daysOfWeek);

            Array.Reverse(daysOfWeek); //doesn't return array. Changes made in orginal array

            // display original reverse array
            Arrays.display(daysOfWeek);

            // display not display orginal reverse array , but diplay copy of original reversse array
            Arrays.display(arr);

            Days today = Days.Mon;

            String s = Enum.GetName(typeof(Days), today);
            //int i = Enum.GetValue(typeof(Days), today);

            //Console.WriteLine("{0}{1}", s, i);

            foreach (String g in Enum.GetNames(typeof(Days)))
                Console.WriteLine(g);

           // today++;

          //  Console.WriteLine((today+1));

            Console.ReadKey();
        }
    }

    class Arrays
    {
        static public void display(String[] arr){

            foreach (String a in arr)
                Console.WriteLine(a);

            Console.WriteLine("----");
        }
    }

    enum Days
    {
        Mon,
        Tues,
        Wed,
        Thur,
        Fri,
        Sat,
        Sun
    }
}
