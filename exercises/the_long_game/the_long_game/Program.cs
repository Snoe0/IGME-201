using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using static System.Formats.Asn1.AsnWriter;

namespace the_long_game
{

    internal class Program
    {

        private static string filePath = "scores.txt";
        private static int score = 0;

        static void Main()
        {
            string name = "Guest";
            Console.WriteLine("Please enter your name. If you would not like to enter your name, enter Guest.");
            name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Your inputted name is either null or empty");
                Console.Write("\nEnter username: ");
                name = Console.ReadLine();
            }

            //pull previous score from file if available
            LoadScore(name.ToLower());

            Console.WriteLine($"Your current score is {score}");
            while (true)
            {
                var keyInfo = Console.ReadKey(intercept:true); // Capture key press without displaying it
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Ending game!");
                    Console.WriteLine($"Final score is {score}");
                    SaveScore(name, score);
                    break; // Exit loop if 'Esc' is pressed
                }
                if (keyInfo.Key != ConsoleKey.Enter) 
                { 
                    score++; 
                    Console.WriteLine($"New Score: {score}"); 
                }

            }
        }


        private static void SaveScore(string username, int score)
        {
            bool found = false;
            // Read all entries into a list
            var entries = new List<string>();
            if (File.Exists(filePath))
            {
                entries = File.ReadAllLines(filePath).ToList();
            }

            // Check if the username already exists
            for (int i = 0; i < entries.Count; i++)
            {
                var parts = entries[i].Split(',');
                if (parts[0] == "guest")
                {
                    // Enter the score for the guest user as 0
                    entries[i] = ($"{username},0");
                    found = true;
                }
                else if (parts[0] == username)
                {
                    // Update the score for the existing user
                    entries[i] = ($"{username},{score}");
                    found = true;
                    Console.WriteLine($"Score saved under {username}");
                }
            }
            if (!found)
            {
                entries.Add($"{username},{score}");
                Console.WriteLine($"Score saved under {username}");
            }
            File.WriteAllLines(filePath, entries);
        }

        private static void LoadScore(string username)
        {
            bool found = false;

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 2 && parts[0] == "guest")
                            {
                                score = 0;
                                found = true;
                                Console.WriteLine("Starting guest score: 0");
                            }
                            else if (parts.Length == 2 && parts[0] == username)
                            {
                                score = int.Parse(parts[1]);
                                found = true;
                                Console.WriteLine($"Found score for {username}: {parts[1]}");
                            }
                        }
                        if (!found) Console.WriteLine("No score found.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading score: {ex.Message}");
            }
        }
    }
}

