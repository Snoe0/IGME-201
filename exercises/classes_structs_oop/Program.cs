namespace classes_structs_oop
{
    internal class Program
    {
        public class Character
        {
            public string name;
            public int exp = 0;

            public Character()
            {
                Reset();
            }
            public Character(string name)
            {
                this.name = name;
            }

            public virtual void PrintStatsInfo()
            {
                Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
            }

            private void Reset()
            {
                this.name = "Not assigned";
                this.exp = 0;
            }
        }
        public class Paladin : Character
        {
            public Weapon weapon;
            public Paladin(string name, Weapon weapon): base(name)
            {
                this.weapon = weapon;
            }
            public override void PrintStatsInfo()
            {
                Console.WriteLine("Hail " + this.name + " - take up your " + this.weapon.name + "!");
            }
        }

        public struct Weapon
        {
            public string name;
            public int damage;

            public Weapon(string name, int damage)
            {
                this.name = name;
                this.damage = damage;
            }

            public void PrintWeaponStats()
            {
                Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            hero.PrintStatsInfo();

            Character heroine = new Character("Maria");
            heroine.PrintStatsInfo();

            Weapon crossbow = new Weapon("Crossbow", 105);
            crossbow.PrintWeaponStats();

            Character villain = hero;
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();

            villain.name = "Darquavius";
            hero.PrintStatsInfo();
            villain.PrintStatsInfo();



            Weapon sword = crossbow;
            crossbow.PrintWeaponStats();
            sword.PrintWeaponStats();

            sword.name = "Sword";
            sword.damage = 145;
            crossbow.PrintWeaponStats();
            sword.PrintWeaponStats();

            //hero.Reset();

            //Inheritance
            Paladin knight = new Paladin("Sir Senior Junior", sword);
            knight.PrintStatsInfo();


            Adventurer john = new Adventurer("John");
            john.PrintStatsInfo();

            Dude johnny = new Dude("Johnny");
            johnny.PrintStatsInfo();
        }
    }
}
