namespace Cat
{
    internal class Program
    {
        static void PrintCat(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("^-^");
                Console.WriteLine("o o");
                Console.WriteLine(">:<");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            PrintCat(a);
        }
    }
}
