using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи височина:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Въведи ширина:");
            int w = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                     Console.Write("*");
                }
                Console.WriteLine();


            }
        }
    }
}
