namespace GetMax
{
    internal class Program
    {
        static void GetMax(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine(x);
                Console.WriteLine("A is bigger");
            }
            else if (x < y)
            {
                Console.WriteLine(y);
            }
            else Console.WriteLine("equal");
        }

        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            GetMax(a, b); 


        }
    }
}
