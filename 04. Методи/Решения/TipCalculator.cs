namespace tip
{
    internal class Program
    {
        static double CalcTip(double bill, int tip)
        {
            return  bill * tip / 100.0;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter bill: ");
            double bill = double.Parse(Console.ReadLine());
            Console.Write("Enter tip: ");
            int tip = int.Parse(Console.ReadLine());
            double tipValue = CalcTip(bill, tip);
            Console.WriteLine($"Tip: {tipValue}");
            Console.WriteLine($"Totla: {tipValue+bill}");
        }
    }
}
