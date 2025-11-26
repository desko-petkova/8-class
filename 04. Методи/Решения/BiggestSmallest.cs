namespace BiggestSmallest
{
    internal class Program
    {
        static int Biggest(int a, int b, int c)
        {
            int max = int.MinValue;
            if (max < a) max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            return max;
        }

        static int Smallest(int a, int b, int c)
        {
            int min= int.MaxValue;
            if (min > a) min = a;
            if (min > b) min = b;
            if (min > c) min = c;
            return min;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first namber: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second namber: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter therd namber: ");
            int c = int.Parse(Console.ReadLine());
            int max = Biggest(a, b, c);
            int min = Smallest(a, b, c);

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");

        }
       

    }
}
