using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre username:");
            string user = Console.ReadLine();

            Console.WriteLine("Entre possword:");
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome " + user + "!");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
    }
}
