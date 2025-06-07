using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 100; i >=n; i--)
            {
                if (i % 12 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
