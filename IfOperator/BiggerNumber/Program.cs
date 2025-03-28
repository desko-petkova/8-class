using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B=");
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("The bigger number is " + a);
            }
            else if (a == b)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The bigger number is " + b);
            }
        }
    }
}
