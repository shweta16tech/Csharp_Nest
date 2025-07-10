using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List of countries: ");
            display(" Nepal");
            display(" France");
            display(" Germany");
            display(" China");
        }
        static void display(string sports)
        {
            Console.WriteLine(sports);
        }
    }
}
