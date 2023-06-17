using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_phase_WEEK_1__17_06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the points required to qualify: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of matches: ");
            int Y = int.Parse(Console.ReadLine());

            int winsneeded;

            if (X >= Y)
                winsneeded = X - Y;

            else
                winsneeded = 0;

            Console.WriteLine("The minimum number of wins needed to qualify: " + winsneeded );

            Console.ReadLine();
        }
    }
}
