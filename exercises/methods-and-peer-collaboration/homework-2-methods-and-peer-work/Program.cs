/*
 * Partner A: Yuri
 * Partner B: Nick
 * IGME 201.01 - Interactive Des & Alg Prob Sol III
 * Due: 10/13/2024
 */
namespace homework_2_methods_and_peer_work
{
    internal class Program
    {

        //Partner A Function
        /// <summary>
        /// Adds two functions
        /// </summary>
        /// <param name="num1"> first number to add </param>
        /// <param name="num2"> second number to add </param>
        /// <returns> sum of num 1 and num 2 </returns>
        static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
        static void Main(string[] args)
        {
            

            //Variables
            int sum;
            int result;
            int nickFavoriteNumber;
            int yuriFavoriteNumber;



            //Initialize
            sum = 0;
            result = 0;
            nickFavoriteNumber = 37;
            yuriFavoriteNumber = 16;



            //Partner B function
            int Subtract(int num1, int num2)
            {
                int answer = 0;
                answer = num1 - num2;

                return answer;
            }

            //Start of the actual program
            Console.WriteLine("Nick's favorite number is : " + nickFavoriteNumber);
            Console.WriteLine("Yuri's favorite number is : " + yuriFavoriteNumber);

            //Console.WriteLine("About to call Partner B's subtract method.");
            //Console.WriteLine("When we subtract " + yuriFavoriteNumber + " from " + nickFavoriteNumber + " we get : " + result);
            //Console.WriteLine("When we subtract " + 3 + " from " + nickFavoriteNumber + " we get : " + result);

            sum = Add(nickFavoriteNumber, yuriFavoriteNumber);
            result = Subtract(yuriFavoriteNumber, nickFavoriteNumber);

            Console.WriteLine("When we add our favorite numberes together we get: " + sum);
            Console.WriteLine("When we subtract our favorite numbers from each other we get: " + result);
            

        }

    }
}
