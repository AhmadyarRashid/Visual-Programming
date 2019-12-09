using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x =2, y =1;

            int z = x + y;
            Console.WriteLine(z);

            add(3, 5);

            //Console.WriteLine("Sum of " + x + " and " + y +": " + (x + y));

            /*
            Console.WriteLine("Sum of {0},{1} is {2}",x,y,z);

            String input = Console.ReadLine();

            int inputInt = int.Parse(input);

            Console.WriteLine(inputInt);

            Console.ReadKey();
             
            */
            Console.ReadKey();
        }


        static void add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("Sum of {0},{1} is {2}", x, y, x+y);
        }
    }

















}
