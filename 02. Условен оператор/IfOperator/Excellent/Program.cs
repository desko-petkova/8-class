using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excellent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter grade:");
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("Not Excellent!");
            }
        }
    }
}
