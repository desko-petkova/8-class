using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1;i <= 100; i++)
            {
                if(i%3==0 && i % 7 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
