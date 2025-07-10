using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcls_cs
{
    internal abstract class Person
    {
        public abstract void name();
        public void greet()
        {
            Console.WriteLine("Hello everyone!");
        }
    }
}
