using System;
namespace maths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string msg = "This is C# programming";
            Console.WriteLine(msg.ToUpper());
            Console.WriteLine(msg.ToLower());

            // string interpolation
            string firstName = "Shweta";
            string lastName = "Neupane";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);

            // C# Math
            Console.WriteLine("Maximum number is "+Math.Max(45, 88));
            Console.WriteLine("Minimum number is "+Math.Min(99,11));
            Console.WriteLine("Square root of 100 is "+Math.Sqrt(100));
            Console.Write("Absolute values are "+Math.Abs(-9.2)+ " and ");
            Console.WriteLine(Math.Round(5.66));
            // string length
            string flower = "marigold";
            Console.WriteLine("The length of the flower is " + flower.Length);  
        }
    }
}
