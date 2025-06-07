using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine().ToLower();
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e'|| 
                    word[i] == 'i' || word[i] == 'o'|| word[i] == 'u')
                {
            //Използваме метода Console.Write(), който не преминава на нов ред
                    Console.Write("*");
                }
                else
                {
                    Console.Write(word[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
