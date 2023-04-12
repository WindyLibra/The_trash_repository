using System;

namespace klinika
{
    public class Windy
    {
        public static void Main(string[] args)
        {
            //string petname = Console.ReadLine();
            string petname = "Astra";

            PetProp theDog = new PetProp(petname);

            int days = 1;
            bool isRetired = false;

            Console.WriteLine("Welcome to Tamagotchi Lite. Game is started. Write \"help\" for commands");
            theDog.Help();

            while (theDog.hunger>0 && theDog.happiness>0)
            {

                Console.WriteLine($"Day {days}");

                Schedule(theDog);


                theDog.hunger -= 10;
                theDog.happiness -= 10;
                days++;

                if (isRetired == true)
                {
                    Console.WriteLine();
                    break;
                }

            }

            switch (theDog.BadOwner())
            {
                case "happiness":
                    Console.WriteLine($"{theDog.name} is in depression because of your bad beahaviour! Shame on you!");
                    break;
                case "hunger":
                    Console.WriteLine($"{theDog.name} is starving!!! You are such a bad owner!");
                    break;
            }



            Console.WriteLine("Game Over");

        }

        public static void Schedule(PetProp theDog)
        {
            Console.WriteLine($"Good morning. Time is 10:00. {theDog.name} is also awake.\nYour actions?");
            theDog.InputManager();
            theDog.hunger -= 4;


            Console.WriteLine($"Good afternoon. Time is 15:00. {theDog.name} is watching TV.\nYour actions?");
            theDog.InputManager();
            theDog.hunger -= 4;


            Console.WriteLine($"Good evening. Time is 19:00. {theDog.name} is lying in bed.\nYour actions?");
            theDog.InputManager();
            theDog.hunger -= 4;


            Console.WriteLine($"Good night?. Time is 23:00. {theDog.name} is sleepy.\nYour actions?");
            theDog.InputManager();
            theDog.hunger -= 4;
            
        }

    }

}
