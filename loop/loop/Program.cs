using System;
namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Foreach LOOP ");
            string[] flowers = { " Lily", " Rose", " Lotus", " Marigold", " Hibiscus" };
            foreach (string i in flowers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("        Arrays      ");
            string[] fruits = { "  Mango", "  Jackfruit", "  Litchi", "  Pineapple", "  Grapes" };
            Console.WriteLine(" Index 0th item is: " + fruits[0]);
            Console.WriteLine(" Index 4th item is: " + fruits[4]);
            Console.WriteLine("   Changing the elements of an array");
            fruits[0] = "  Orange";
            Console.WriteLine(" Index 0th item is: " + fruits[0]);
            Console.WriteLine(" The length of an array is: " + fruits.Length);
            Console.WriteLine("Displaying all the array elements using for loop");
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }
            Console.WriteLine("After sorting an string array ");
            Array.Sort(fruits);
            foreach (string i in fruits)
            {
                Console.WriteLine(i);
            }
        }
    }
}