using Microsoft.Win32.SafeHandles;

namespace Week5bIGME201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Yuri";
            string heroLastName = "Korolev";
            string heroFullName = heroFirstName + " " + heroLastName;

            string villainTitle = "Count ";
            string villainName = "Dracula";
            string minionTitle = "Baby ";
            string minion1Name = "Jimmothy";
            string minion2Name = "Taxidermy";

            int heroHealth = 100;
            int heroStrength = 50; 
            int bossHealth = 100; 
            int bossStrength = 25; 
            int minion1Health = 50; 
            int minion2Health = 50; 
            int minionStrength = 5;


            Console.WriteLine("Behold the glorious hero: " + heroFullName + "!");
            //Console.WriteLine(heroFullName);

            Console.WriteLine(heroFullName + "'s nemesis is " + villainTitle + villainName);
            Console.WriteLine(villainTitle + villainName + " is assisted by: " + minionTitle + minion1Name + " and " + minionTitle + minion2Name);
            //Evil encounter
            Console.WriteLine("The mighty foes finally encounter each other.");
            Console.WriteLine("Hero's Health: " + heroHealth);
            Console.WriteLine("Boss's Health: " + bossHealth);
            Console.WriteLine("Minion 1's Health: " + minion1Health);
            Console.WriteLine("Minion 2's Health " + minion2Health);

            //The fight begins
            Console.WriteLine(villainTitle + villainName + " attacks " + heroFullName + " for " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            if (heroHealth < 0) heroHealth = 0;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health.");
            Console.WriteLine("Time for the minions to attack!");
            Console.WriteLine(minionTitle + minion1Name + " attacks for " + minionStrength + " damage!");
            Console.WriteLine(minionTitle + minion2Name + " attacks for " + minionStrength + " damage!");
            heroHealth -= 2 * minionStrength;
            if (heroHealth < 0) heroHealth = 0;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health.");

            Console.WriteLine("Time for the hero to attack! " + heroFullName + " attacks each opponent for " + heroStrength + " damage.");
            bossHealth -= heroStrength;
            minion1Health -= heroStrength;
            minion2Health -= heroStrength;

        
            if (bossHealth < 0) bossHealth = 0;
            if (minion1Health < 0) minion1Health = 0;
            if (minion2Health < 0) minion2Health = 0;

            Console.WriteLine(villainTitle + villainName + " has: " + bossHealth + " health remaining!");
            Console.WriteLine(minionTitle + minion1Name + " has: " + minion1Health + " health remaining!");
            Console.WriteLine(minionTitle + minion2Name + " has: " + minion2Health + " health remaining!");

            if (minion1Health <= 0)
            {
                Console.WriteLine(minionTitle + minion1Name + " has been defeated!");
            }
            if (minion2Health <= 0)
            {
                Console.WriteLine(minionTitle + minion2Name + " has been defeated!");
            }

            Console.WriteLine(heroFullName + " has: " + heroHealth + " health remaining!");
            Console.WriteLine(heroFullName + " eats an energy bar to regain 5 HP.");
            heroHealth++;
            heroHealth += 4;
            Console.WriteLine(heroFullName + " now has: " + heroHealth + " HP.");


            Console.WriteLine(villainTitle + villainName + " attacks " + heroFullName + " for " + bossStrength + " damage!");
            heroHealth -= bossStrength;
            if (heroHealth < 0) heroHealth = 0;

            Console.WriteLine(heroFullName + " has " + heroHealth + " health remaining!");
            if (heroHealth <= 0)
            {
                Console.WriteLine(heroFullName + " has been lost the fight...");
            }

            Console.WriteLine("Time for the hero to attack! " + heroFullName + " attacks each opponent for " + heroStrength + " damage.");
            bossHealth -= heroStrength;
            if (bossHealth < 0) bossHealth = 0;
            Console.WriteLine(villainTitle + villainName + " has: " + bossHealth + " health remaining!");


            
            if (bossHealth <= 0)
            {
                Console.WriteLine(villainTitle + villainName + " has been defeated!");
            }

            if (bossHealth <= 0 && minion1Health <= 0 && minion2Health <= 0)
            {
                Console.WriteLine(heroFullName + " is victorious!");
                Console.WriteLine("Cheers to the hero!");
            }
            

        }

    }
}
