﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter username: ");
            string user = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            //----------------------------------------
            string word = Console.ReadLine();
            while (word != password)
            {
                Console.WriteLine("Please try again!");
                word = Console.ReadLine();
            }
            Console.WriteLine("Welcome,"+ user+"!");
        }
    }
}
