using System.ComponentModel;

namespace Calc
{
    internal class Program
    {
        static void Add (int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (operation == "add")
            { Add(a, b); }
            else if (operation == "multy")
            { Multy(a, b); }
            else if (operation == "sub")
            { Sub(a, b); }
            else if (operation == "div")
            { Div(a, b); }
            else Console.WriteLine("Invalid input");
        }

        private static void Div(int a, int b)
        {
           if(b == 0)
            {
                Console.WriteLine("Can not divide by zero");
            }
           else Console.WriteLine(a/b);
        }

        private static void Sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        private static void Multy(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
