using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_pri_pub
{
    class Product
    {
        private int pid;
        public int PID
        {
            get { return pid; }
            set { pid = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            int a;
            a= p1.PID = 101;
            Console.WriteLine("Product ID is: " + a);
        }
    }
}
