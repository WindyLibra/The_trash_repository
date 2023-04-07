using System;

namespace klinika
{
    public class Petprop
    {
        int happiness = 50;
        int thirst = 20;
        int hunger = 20;
        string name = "";

        public Petprop(string Name)
        {
            name = Name;
        }

        public void Pet()
        {
            happiness+=15;
            Console.WriteLine($"{name} is smiling, just look at her!");
        }

        public void Play()
        {
            happiness+=20;
            hunger+=15;
            thirst+=10;
            Console.WriteLine($"{name} is playing with you. Very cute.");
        }

    }

}
