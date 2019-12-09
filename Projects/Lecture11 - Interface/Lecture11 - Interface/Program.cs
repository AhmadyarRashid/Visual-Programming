using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture11___Interface {

    interface MyMath { //interface by default is public 

        int add(int x, int y);
        int sub(int x, int y);
        int mul(int x, int y);
        int div(int x, int y);

    }

    public class Maths: MyMath {

        public int add(int x, int y) {
            return x + y;
            //throw new NotImplementedException();

        }

        public int sub(int x, int y) {
            return x - y;
            //throw new NotImplementedException();
           
        }

        public int mul(int x, int y) {
            return x * y;
            //throw new NotImplementedException();
        }

        public int div(int x, int y) {
            return x / y;
            //throw new NotImplementedException();
        }
    }

    class Program {
        static void Main(string[] args) {

            ProxyClass p = new ProxyClass();
            Console.WriteLine(p.add(2, 2));
            Console.WriteLine(p.sub(2, 2));
            Console.WriteLine(p.mul(2, 2));
            try {
                Console.WriteLine(p.div(2, 0));
            }

            catch(Exception ex){
                Console.WriteLine("Attempted divide by zero");
                Console.WriteLine(ex.ToString());
            }

        }
    }

    public class ProxyClass:MyMath {

        Maths maths = new Maths();

        public int add(int x, int y) {
            return maths.add(x, y);
            //throw new NotImplementedException();
        }

        public int sub(int x, int y) {
            return maths.sub(x, y);
            //throw new NotImplementedException();
        }

        public int mul(int x, int y) {
            return maths.mul(x, y);
            //throw new NotImplementedException();
        }

        public int div(int x, int y) {
            return maths.div(x, y);
            //throw new NotImplementedException();
        }
    }
}
