using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1_TRAILING_ZEROS_QUESTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value of n: ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            int divisor = 5;

            int quotient = n / divisor;

            while (quotient > 0)
            {
                count += quotient;
                divisor *= 5;
                quotient = n / divisor;
            }

            Console.WriteLine("The number of trailing zeroes in " + n + "! is: " + count);
            Console.ReadLine();
        }
    }
}
