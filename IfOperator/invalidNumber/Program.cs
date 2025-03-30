using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int num = int.Parse(Console.ReadLine());
            if(num >=100 &&  num <= 200 || num == 0)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
