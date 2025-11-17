namespace Sign
{
    internal class Program
    {
        static string GetSign(int n)
        {
            if (n < 0) { return "negative"; }
            else if (n > 0) { return "positive"; }
            else return "zero";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number:");
            int a = int.Parse(Console.ReadLine());
            string result = GetSign(a);
            Console.WriteLine(result);
            Console.WriteLine(GetSign(-6));
            Console.WriteLine(GetSign(7));
            Console.WriteLine(GetSign(0));

        }
    }
}
