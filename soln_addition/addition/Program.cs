using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addition
{
    class math
    {
        public int add(int n1, int n2)
        {
            return n1 + n2;
        }

        public void sum(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int number1 = 10;
            int number2 = 20;
            math mathss = new math();
            int result;
            result = mathss.add(number1, number2);
            Console.WriteLine("Final result is " + result);

            Console.WriteLine("Another sum is ");
            int a = 60;
            int b = 70;
            math mathh = new math();
            mathh.sum(a, b);
        }   
    }
}



