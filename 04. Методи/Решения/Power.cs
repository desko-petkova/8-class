namespace Power
{
    internal class Program
    {
        static double RaisedToPower(double num, int power)
        {
           
            double result = Math.Pow(num, power);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base:");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter power:");
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaisedToPower(num, power));

        }
    }
}
