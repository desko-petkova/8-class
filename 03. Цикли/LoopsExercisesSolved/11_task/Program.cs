using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int count = 0;
            double average = 0.0;
            int min = int.MaxValue;
            while (average <= 50)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                sum += num;
                count++;
                average = sum / count;
                if (min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Average = {average:F2}, Min = {min}");
        }
    }
}
