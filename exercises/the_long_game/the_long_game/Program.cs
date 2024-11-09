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
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            //while (string.IsNullOrEmpty(name))
            //{
            //    Console.Write("\nEnter username: ");
            //    name = Console.ReadLine();
            //}

            //pull previous score from file if available
            LoadScore(name);

            Console.WriteLine($"Your current score is {score}");
            while (true)
            {
                var keyInfo = Console.ReadKey(); // Capture key press without displaying it
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Ending game!");
                    break; // Exit loop if 'Esc' is pressed
                }
                if (keyInfo.Key != ConsoleKey.Enter) { score++; Console.WriteLine($"New Score: {score}"); }

            }
            
            SaveScore(name, score);
        }


        private static void SaveScore(string username, int score)
        {
            // Read all entries into a list
            username = username.ToLower();
            var entries = new List<string>();
            if (File.Exists(filePath))
            {
                entries = File.ReadAllLines(filePath).ToList();
            }

            // Check if the username already exists
            bool userFound = false;
            for (int i = 0; i < entries.Count; i++)
            {
                var parts = entries[i].Split(',');
                if (parts[0] == username)
                {
                    // Update the score for the existing user
                    entries[i] = $"{username},{score}";
                    userFound = true;
                    break;
                }
            }
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
                            if (parts.Length == 2 && parts[0] == username)
                            {
                                Console.WriteLine($"Found score for {username}: {parts[1]}");
                                score = parts[1];
                                found = true;
                                break;
                            }
                        }
                        else Console.WriteLine("No score found.");
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

