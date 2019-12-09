using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface MineMath
    {
        int add(int firstValue, int secondValue);
        int sub(int firstValue, int secondValue);
        int mul(int firstValue, int secondValue);
        int div(int firstValue, int secondValue);
    }

    public class SimpleCal : MineMath
    {

        public int add(int firstValue, int secondValue)
        {
           // throw new NotImplementedException();
            return firstValue + secondValue;
        }

        public int sub(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return firstValue - secondValue;
        }

        public int mul(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return firstValue * secondValue;
        }

        public int div(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return firstValue / secondValue;
        }
    }

    public class ProxyCal : MineMath
    {
        SimpleCal cal = new SimpleCal();
        public int add(int firstValue, int secondValue)
        {
           // throw new NotImplementedException();
           return cal.add(firstValue, secondValue);
        }

        public int sub(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return cal.sub(firstValue, secondValue);
        }

        public int mul(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return cal.mul(firstValue, secondValue);
        }

        public int div(int firstValue, int secondValue)
        {
            // throw new NotImplementedException();
            return cal.div(firstValue, secondValue);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProxyCal calculator = new ProxyCal();
            Console.WriteLine(calculator.add(4,5));
            Console.WriteLine(calculator.sub(4, 5));
            Console.WriteLine(calculator.mul(4, 5));
            Console.WriteLine(calculator.div(4, 5));

            Console.ReadKey();
        }
    }
}
