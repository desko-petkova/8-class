namespace ConsoleApp1
{
    internal class Program
    {
        static void Star(int h, int w)
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Entre height: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter widht: ");
            int w = int.Parse(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for(int j = 1; j <= w; j++)
                {
                    if(i == 1 || i == h || j == 1 || j == w)
                    Console.Write("*");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
