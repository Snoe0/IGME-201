/*
 * Yuri Korolev
 * IGME 201-01
 * Due: 10/13/2024
*/
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variables
            string studentName;
            int[] grades = {100, 92, 87, 200, -20, 52, 82, 75, 67, 88};
            float avg;

            studentName = "Yuri";
            avg = 0;
            


            Console.WriteLine($"Welcome {studentName}!");
            Console.WriteLine("Here are your grades:");
            foreach (int i in grades)
            {
                Console.WriteLine(i);
                if (i <= 100 && i >= 90)
                {
                    Console.WriteLine("This grade is an A!");
                    if (i == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (i <= 89 && i >= 80)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (i <= 79 && i >= 70)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (i <= 69 && i >= 65)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (i <= 64)
                {
                    Console.WriteLine("This grade is an F.");
                }
                else
                {
                    Console.WriteLine("This grade isn't in the range 1 - 100.");
                }
            }

            foreach (int i in grades)
            {
                avg = avg + i;
            }
            avg = avg / grades.Length;

            Console.WriteLine($"Your average grade is {avg}");
            Console.WriteLine($"Displayed all grades for {studentName}");
        }
    }
}
