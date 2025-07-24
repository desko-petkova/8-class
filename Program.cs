namespace Arr
{
    internal class Program
    {
        //--------------------------Начало методи задача 4.------------------------------//
        // Метод 1: Проверка за делимост
        static bool IsDivisibleBy(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return false;
            }

            return a % b == 0;
        }

        // Метод 2: Отпечатване на частното от делението
        static void PrintDivision(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return;
            }

            double result = (double)a / b;
            Console.WriteLine($"Division result: {a} / {b} = {result}");
        }
        //---------------------------Край методи задача 4.----------------------------//
        //---------------------------Начало методи задача 5.----------------------------//
        // a) Метод, който брои гласните букви в стринг
        static int GetVowelsCount(string input)
        {
           
            int count = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' 
                    || input[i] == 'o' || input[i] == 'u')
                {
                    count++;
                }
            }
           
            return count;
        }

        // b) Метод, който принтира първата буква главна
        static void PrintFirstUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty string!");
                return;
            }

            // Взимаме първата буква и я правим главна
            char firstChar = char.ToUpper(input[0]);

            Console.WriteLine($"First letter capitalized: {firstChar}");
        }
        //---------------------------Край методи задача 5.----------------------------//
        static void Main(string[] args)
        {
            //Задача 1. Сумиране на числа
            //А) Напиши програма, която използва цикъл while, за да събира цели числа,
            //въвеждани от потребителя, докато той не въведе числото 0.Накрая изведи общата сума.
            //Б) Модифицирай програмата така, че да извежда съобщение "Въведохте 0.
            //Край на програмата." преди да покаже крайната сума.
            int sum = 0;//Създава се променлива sum, която ще пази сумата от въведените числа.
            while (true)// Започва безкраен цикъл, който ще се изпълнява, докато не бъде прекъснат с break.
            {
                Console.Write("Enter number: ");//Подканя потребителя да въведе число.
                int num = int.Parse(Console.ReadLine());//Записва това число в променливата num.
                if (num == 0)//Проверява дали потребителят е въвел 0.
                {
                    Console.WriteLine("You enter 0. End of the Program.");//Извежда съобщение, че програмата прилючва.
                    break;//Използва се break, за да прекрати while цикъла.
                }
                else
                {
                    sum += num;//Ако потребителя е въвел число ралзично от 0, то се добавя към общата сума.
                }
            }// Затваряща скоба на тялото на цикала while. Тъй като условието му е винаги true, изпълнението на програмата отново се връща на ред 13 и преминава през всяка стъпка. 
            if (sum != 0)//Ако sum == 0, не се извежда нищо (възможно е потребителят да е въвел 0 като първо число).
            {
                Console.WriteLine($"Summary = {sum}");
            }
            //==========================================================================//
            //Задача 2.  Да се изведат всички числа от 10 до 90 през стъпка 10 кратни на 8.
            for (int i = 10; i <= 90; i += 10)//10, 20, 30, 40, 50, 60, 70, 80, 90
            {
                if (i % 8 == 0)//ако броячът i се дели точно на 8
                    Console.WriteLine(i);//се изпечатва стойността му
            }
            //===========================================================================//
            //Задача 3. Създайте конзолно приложение,
            //което реализира алгоритъм за определяне на оценка от тест,
            //където за всеки верен отговор се дава по една точка.
            Console.Write("Enter numbers of questions: ");
            int questions = int.Parse(Console.ReadLine());

            Console.Write("Enter numbers of correct answers: ");
            int correctAnswers=int.Parse(Console.ReadLine());
            if (correctAnswers > questions)//Проверява дали верните отговори са повече от общия брой въпроси
            {
                Console.WriteLine("The number of correct answers must be smaller or equal then the number of questions.");//извежда съобщение за грешка
                return;//и излиза от програмата
            }

            double result = ((double)correctAnswers / questions) * 100;//Изчислява колко процента са дадениете верни отговори от общия брой въпроси
            //Извежда оценка спрямо процента верни отговори
            if (result <= 100 && result >= 90)
                Console.WriteLine("Отличен(6)");
            else if (result < 90 && result >= 80)
                Console.WriteLine("Много добър(5)");
            else if (result < 80 && result >= 70)
                Console.WriteLine("Добър(4)");
            else if (result < 70 && result >= 60)
                Console.WriteLine("Среден(3)");
            else
                Console.WriteLine("Слаб(2)");
            //=======================================================================//
            //Задача 4.Проверка за делимост
            //Създайте метод IsDivisibleBy, който приема две цели числа и връща true, ако първото се дели на второто и false, ако има остатък от делението не е 0.
            //- Създайте втори метод PrintDivision, който отпечатва частното от делението на двете числа.
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (IsDivisibleBy(num1, num2))//Проверява дали върната булева стойност от метода е истина
            {
                Console.WriteLine($"{num1} is divisible by {num2}.");
            }
            else
            {
                Console.WriteLine($"{num1} is NOT divisible by {num2}.");
            }

            PrintDivision(num1, num2);
            //===================================================================//
            // Задача 5. Задача. Брой гласни букви
            //a)	Създайте метод GetVowelsCount, който получава един стринг и връща броя на гласните букви в него.
            //b)	Създайте метод PrintFirstUpper, който принтира първата буква на входния стринг главна. 
            Console.Write("Enter a string: ");
            string text = Console.ReadLine().ToLower();
            int vowelsCount = GetVowelsCount(text);
            Console.WriteLine($"Number of vowels: {vowelsCount}");
            PrintFirstUpper(text);
            //=============================================================================//
            //Задача 6. Напишете кода на програма, която създава масив от тип string,
            //с име myString.  Потребителят определя  дължината n  на масив и инициализира
            //елементите му от конзолата.  Като резултата да се изведе, колко пъти се повтаря
            //думата apple в масива, а ако я няма да се извежда съобщението „There are no apples”.
            Console.WriteLine("Enter number of array elements: ");// Извежда съобщение на потребителя да въведе броя елементи в масива.
            int n = int.Parse(Console.ReadLine());//Чете въведения от потребителя текст (като string) и го преобразува в цяло число (int), което се съхранява в променливата n. Това ще е броят на елементите в масива.
            string[] myString = new string[n]; //Създава масив от стрингове с n елемента (напр. string[5] ако потребителят е въвел 5).

            for (int i = 0; i < myString.Length; i++)//Започва for цикъл, който обхожда всеки индекс на масива myString.
            {
                //Извежда съобщение да се въведе стойност за текущия елемент (като брои от 1, затова е {i+1}).
                Console.Write($"Enter value of element {i + 1}: ");
                myString[i] = Console.ReadLine();//Чете въведената стойност и я записва в масива на съответната позиция i.          
            }
            //Отпечатва празен ред и разделителна линия 
            Console.WriteLine();
            Console.WriteLine("----------------");
            int count = 0;//Създава променлива count, която ще брои колко пъти се среща думата "apple" в масива.
            for (int i = 0; i < myString.Length; i++)//Нов for цикъл, който ще обхожда всички елементи в масива, за да преброи ябълките.
            {
                if (myString[i] == "apple")//Проверява дали елементът на текущата позиция е "apple". 
                {
                    count++;//Ако да — увеличава брояча count с 1.
                }
            }
            //Проверява колко пъти се среща думата "apple"
            //и го съобщава с правилно съгласувано съобщение.
            if (count > 0)
            {
                if (count == 1)
                {
                    Console.WriteLine($"There is {count} apple");
                }
                else
                {
                    Console.WriteLine($"There are {count} apples");
                }
            }
            else
            {
                Console.WriteLine("There are no apples");
            }
        }
    }
}
