using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();   // 1-ви ред: име на ученика

            int currentClass = 1;    // започваме от 1-ви клас
            double gradesSum = 0.0;  // сума на успешно взетите годишни оценки
            bool remains = false;

            // Продължаваме, докато ученикът не мине 12-ти клас И не е изключен
            while (currentClass <= 12 && !remains)
            {
                double yearlyGrade = double.Parse(Console.ReadLine());   // следващ ред: годишна оценка

                if (yearlyGrade >= 3.0)
                {
                    gradesSum += yearlyGrade;
                    currentClass += 1;          // преминава в следващ клас
                }
                else                            // оценка < 3.00  → повтаря текущия клас
                {
                    remains = true;            // маркираме, че е изключен
                }
            }

            // Край на обучението – два възможни изхода
            if (!remains)        // успешно завършен 12-ти клас
            {
                double average = gradesSum / 12;                      // 12 оценки
                Console.WriteLine($"{studentName} graduated. Average grade: {average:F2}");
            }
            else     // изключен (остава в класа, където е отпаднал)
            {
                Console.WriteLine($"{studentName} remains in {currentClass} grade");
            }

        }
    }
}
