using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи височина:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи ширина:");
            int w = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= w; j++)
                {
                    if (i == 1 || i == h  || j == 1 || j == w )
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();


            }
        }
    }
}
