namespace StringRepeat
{
    internal class Program
    {

        static string RepeatText(string text, int n)
        {
           string result = "";

            for (int i = 0; i < n; i++)
            {
                result += text;
            }
            return result;
        }

       
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter repeat string: ");
            int count = int.Parse(Console.ReadLine());
            string repeatedString = RepeatText(input, count);
            Console.WriteLine(repeatedString);


        }
    }
}
