namespace logic_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string playerName = "adventurer";
            string userChoice = "NONE";


            //Program Start
            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I actually don't know your name");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name and then press ENTER on your keyboard]");

            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName + "!");

            Console.WriteLine(
                "We approach a clearing in the jungle\n" +
                "There seems to be a trail to the left...\n" +
                "and a cave entrance to the right."
                );

            Console.WriteLine("Which path will you go down?");
            Console.WriteLine("[Type left or right to choose a path.]");

            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice + "\n");

            //if (userChoice == "left") 
            //{
            //    Console.WriteLine("You go left, beginning your journey down the unknown trail.");
            //}
            //else if (userChoice == "right")
            //{
            //    Console.WriteLine("You go right, into the mouth of the dark cave.");
            //}
            //else
            //{
            //    
            //    while (userChoice != "left" && userChoice != "right" && userChoice != "up")
            //    {
            //        Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
            //        userChoice = Console.ReadLine();
            //        Console.WriteLine("\nYou chose: " + userChoice + "\n");
            //    }
            //    if (userChoice == "left")
            //    {
            //        //Go to the left
            //    }
            //    else if (userChoice == "right")
            //    {
            //        //Go to the right
            //    }
            //    else if (userChoice == "up")
            //    {
            //        //Easter Egg
            //        Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips keyboard** CLOSE THE PROGRAM!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("I honestly don't know how you got here. Congrats.");
            //    }
            //}

            switch (userChoice)
            {
                case "left":
                    Console.WriteLine("You go left, beginning your journey down the unknown trail.");
                    break;
                case "right":
                    Console.WriteLine("You go right, into the mouth of the dark cave.");
                    break;
                default:
                    while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                    {
                        Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                        userChoice = Console.ReadLine();
                        Console.WriteLine("\nYou chose: " + userChoice + "\n");
                    }
                    if (userChoice == "left")
                    {
                        //Go to the left
                    }
                    else if (userChoice == "right")
                    {
                        //Go to the right
                    }
                    else if (userChoice == "up")
                    {
                        //Easter Egg
                        Console.WriteLine("'up' seriously? 'up'!? How can we go up? UP YOURS! |_(O_O)_/ **Flips keyboard** CLOSE THE PROGRAM!");
                    }
                    else
                    {
                        Console.WriteLine("I honestly don't know how you got here. Congrats.");
                    }
                    break;
            

            }

        }
    }
}
