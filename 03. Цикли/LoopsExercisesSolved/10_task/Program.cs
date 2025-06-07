using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            while (sum < 500)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                    sum += num;
                    count++; 
            }
            double average = sum / count;
            Console.WriteLine($"Sum = {sum}, Average = {average:F2}");
        }
    }
}
