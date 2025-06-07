using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи височината на елхата: ");
            int height = int.Parse(Console.ReadLine());
            Random rand = new Random();
            for (int row = 0; row < height; row++)
            {
                // Печатаме празни места (за центриране)
                for (int space = 0; space < height - row - 1; space++)
                {
                    Console.Write(" ");
                }

                // Печатаме звездички
                for (int star = 0; star < 2 * row + 1; star++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(); 
            }
            //// Частта с пънчето (1 или 2 реда)
            //int trunkHeight = height / 3; // пънчето да е 1/3 от височината
            //if (trunkHeight == 0) trunkHeight = 1; // поне 1 ред

            //int trunkWidth = height / 3;
            //if (trunkWidth % 2 == 0) trunkWidth++; // нечетна ширина за центриране
            //if (trunkWidth == 0) trunkWidth = 1;

            //for (int row = 0; row < trunkHeight; row++)
            //{
            //    // Празни места за центриране
            //    for (int space = 0; space < height - trunkWidth / 2 - 1; space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Пънчето (също със звездички)
            //    for (int star = 0; star < trunkWidth; star++)
            //    {
            //        Console.Write("*");
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
