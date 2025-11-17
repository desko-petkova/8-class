namespace Students
{
    internal class Program
    {
        static void PrintStudentInfo(string name, int klas)
        {
            Console.WriteLine($"{name} is studying in {klas} grade");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter class:");
            int grade = int.Parse(Console.ReadLine());

            PrintStudentInfo(studentName, grade);
            PrintStudentInfo("Anna", 9);

        }
    }
}
