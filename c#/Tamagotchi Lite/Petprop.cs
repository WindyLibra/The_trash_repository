using System;

namespace klinika
{
    public class PetProp
    {
        public int happiness = 50;
        public int hunger = 20;
        public string name = "";

        public PetProp(string Name)
        {
            name = Name;
        }

        public void Pet()
        {
            happiness += 10;
            Console.WriteLine($"{name} is smiling, just look at her!");
        }

        public void Play()
        {
            happiness += 20;
            hunger -= 15;
            Console.WriteLine($"{name} is playing with you. Very cute.");
        }

        public void Feed()
        {
            hunger += 30;
            happiness += 5;
            if (hunger > 100) hunger = 100;
            Console.WriteLine($"{name} is eating. Delicious!");
        }

        public void Info()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Hunger: {hunger}%");
            Console.WriteLine($"Happiness: {happiness}%");
        }

        public bool Retire(bool yes)
        {
            return true;
        }

        public void InputManager()
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "play":
                    Play();
                    break;
                case "feed":
                    Feed();
                    break;
                case "pet":
                    Pet();
                    break;
                case "info":
                    Info();
                    break;
                case "help":
                    Help();
                    break;
                case "retire":
                    Retire();
                    break;
            }
        }

        public string BadOwner()
        {
            string reasonOfLoss = "";
            if (happiness <= 0) reasonOfLoss = "happiness";
            else if (hunger <= 0) reasonOfLoss = "hunger";
            return reasonOfLoss;
        }

        public void Help()
        {
            Console.WriteLine("Here is list of commands: play, info, feed, pet, retire, help");
        }

    }

}

