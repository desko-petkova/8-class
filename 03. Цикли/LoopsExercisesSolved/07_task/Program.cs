using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Max = int.MinValue;
            Console.WriteLine("Enter first number:");
            string input = Console.ReadLine();//Входните данни са от тип стринг,
            while (input != "Stop")// за да можем да правим тази проверка
            {
                int a = int.Parse(input);//Преобразуваме стринга input в число
                if (Max < a)
                {
                    Max = a;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(Max);
        }
    }
}
