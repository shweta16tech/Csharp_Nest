using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_cs
{
    internal class Phone
    {
        public string model;
        public int laun_yr;
        public int price;
        // create a class constructor
        public Phone(string pmodel,int plaun_yr,int pprice)
        {
            model= pmodel;
            laun_yr = plaun_yr;
            price = pprice;
        }
        static void Main(string[] args)
        {
            Phone Iphone = new Phone("iPhone 16 Pro", 2024, 1236);
            Console.WriteLine(Iphone.model + " is released in " + Iphone.laun_yr + ".It's price is $" + Iphone.price);
        }
    }
}
