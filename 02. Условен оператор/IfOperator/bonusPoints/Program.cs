using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter points:");
            int points = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonus = points * 0.2;
            }
            else
            {
                bonus = points * 0.1;
            }

            if (points % 2 == 0)
            {
                bonus++;
            }
            if (points % 10 == 5)
            {
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
