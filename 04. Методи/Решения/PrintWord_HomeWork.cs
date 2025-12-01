namespace Letter
{
    internal class Program
    {
        // Реализиран по двата начина, които ми показахте в домашните:
        // 1) чрез променлива result
        // 2) чрез директно отпечатване с Console.Write()
        static void PrintWord(string str) // Подаваме думата "cat" като стойност на променливата str
        {
            string result = ""; // Създаваме променлива за резултата със стойност празен символен низ ""

            for (int i = 0; i < str.Length; i++) // str.Length е дължината на символния низ — в случая думата cat се състои от 3 символа (str.Length = 3)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'o' || str[i] == 'u' || str[i] == 'i') // Условието връща true на втора итерация
                {
                    Console.Write(str[i]); // Втора итерация: Отпечатваме "a" на същия ред до "*" от първа итерация
                    result += str[i];      // Втора итерация: ("*" + "a") — result = "*a"
                }
                else // Изпълнява се на първа и трета итерация
                {
                    Console.Write("*"); // Първа итерация: Отпечатваме "*" |===| Трета итерация: Отпечатваме "*" на същия ред до "a" от втора итерация
                    result += "*";      // Първа итерация: ("" + "*") — result = "*" |===| Трета итерация: ("*a" + "*") — result = "*a*"
                }
            }
            Console.WriteLine();       // Нов ред
            Console.WriteLine(result); // Отпечатва стойността на резултата "*a*"
        }
        // i = 0: отпечатано на екрана: "*",   result = "*"
        // i = 1: отпечатано на екрана: "*a",  result = "*a"
        // i = 2: отпечатано на екрана: "*a*", result = "*a*"

        static void Main(string[] args)
        {
            Console.WriteLine("Enter word: ");
            string input = Console.ReadLine(); 
            PrintWord(input);
        }

       
    }
}
