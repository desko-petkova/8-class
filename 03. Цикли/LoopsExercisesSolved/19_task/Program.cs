using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи височината на триъгълника: ");
            int height = int.Parse(Console.ReadLine());

            for (int row = 0; row < height; row++)
            {
                // Празни места за центриране
                for (int space = 0; space < height - row - 1; space++)
                {
                    Console.Write(" ");
                }

                // Звездички и празноти
                for (int col = 0; col < 2 * row + 1; col++)
                {
                    // Ако сме на първия ред, или първата/последната звезда от реда, или на последния ред
                    if (row == height - 1 || col == 0 || col == 2 * row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" "); // вътрешността е празна
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
