using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = Rectangle.calculateArea(4, 5);
            Console.WriteLine(area);

            Rectangle r1 = new Rectangle(2, 3);
            r1.calculateArea();
            r1.display();


            Rectangle r2 = new Rectangle(5);
            r2.calculateArea();
            r2.display();

            Console.ReadKey();
        }
    }

    class Rectangle
    {
        int width , length , area;

        const float pi = 3.14f;
        static int obj_count;
        readonly int x = 3;
        

        Rectangle()
        {
           
            width = 0;
            length = 0;
        }

        public Rectangle(int length):this()
        {
            x = 4;
            width = 0;
            this.length = length;
        }

        public Rectangle(int length, int width): this(length)
        {
            x = 5;
            this.width = width;
          
        }

        public void display()
        {
            Console.WriteLine("Length: {0}, Width: {1}, Area: {2}", length, width, area);
            Console.WriteLine(x);
        }

        public int calculateArea()
        {
            return area = length * width;
        }

        public static int calculateArea(int l, int w)
        {  
            obj_count++;
            return l*w;
        }

    }
}
