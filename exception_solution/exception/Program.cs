using System;
namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] nums = { 45, 11, 90, 82, 30 };
                Console.WriteLine(nums[7]);
            }
            catch(Exception e)
            {
                Console.WriteLine(" Oops! Something went wrong.");
            }
            finally
            {
                Console.WriteLine(" The try catch is finished here.");
            }
        }
    }
}
