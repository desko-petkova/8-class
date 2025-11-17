namespace RectangleArea
{
    internal class Program
    {
        static int GetRectangleArea(int a, int b)
        {
            return a * b;
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter leght: ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Enter wight: ");
            int w = int.Parse(Console.ReadLine());
            int result = GetRectangleArea(l, w);
            Console.WriteLine(result);
        }
    }
}
