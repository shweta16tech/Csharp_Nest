using System;
namespace multipleinher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            plaster p = new plaster();
            p.cementreq();
            p.sandreq();
            p.waterreq();
        }
    }
    interface Icement
    {
        void cementreq();
    }
    interface Isand
    {
        void sandreq();
    }
    interface Iwater
    {
        void waterreq();
    }
    class plaster : Icement, Isand, Iwater
    {
        public void cementreq()
        {
            Console.WriteLine(" Cement is required for plastering.");
        }
        public void sandreq()
        {
            Console.WriteLine(" Sand is required for plastering.");
        }
        public void waterreq()
        {
            Console.WriteLine(" Water is required for plastering.");
        }
    }
}
