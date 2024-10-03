namespace Week5aIGME201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumberOne = 7;
            int myNumberTwo = 27;
            ProfName();
            Console.WriteLine("Hello, professor!");
            Console.WriteLine(myNumberOne);
            Console.WriteLine(myNumberTwo);
            Console.WriteLine(Sum(myNumberOne, myNumberTwo));
            
        }

        static void ProfName()
        {
            string profName = "Nick Buonarota";
            Console.WriteLine(profName);
        }

        static int Sum(int num1, int num2)
        {
            return(num1 + num2);
        }
    }
}
