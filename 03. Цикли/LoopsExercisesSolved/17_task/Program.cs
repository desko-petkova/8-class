using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи височината на триъгълник: ");
            int height = int.Parse(Console.ReadLine());
            for (int i = height; i >= 0; i--)
            {
                for (int star = 0; star < i + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

            }
        }
    }
}
