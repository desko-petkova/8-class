namespace Letter
{
    internal class Program
    {
        static void CountLetter(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'o' || str[i] == 'u' || str[i] == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
                
        }
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word 1: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter word 2: ");
            string b = Console.ReadLine();
            LongestString(a, b);
            CountLetter(a);
        }

        static void LongestString(string strA, string strB)
        {
            if(strA.Length < strB.Length)
                Console.WriteLine(strB);
            else Console.WriteLine(strA);
        }
    }
}
