using System;

public class Program
{
    public static void Main(string[] args)
    {
        string question_code = "destiny";
        Console.WriteLine("Write your question:");
        string question_user = Console.ReadLine();
        question_user = question_user.Trim();
        string mean;
        if (question_user.Contains(question_code))
        {
            Console.WriteLine("What do you mean by destiny?");
            mean = Console.ReadLine();

            switch (mean)
            {
                case "game":
                    Console.WriteLine("Destiny is an online-only multiplayer first-person shooter video game developed by Bungie and previously published by Activision.");
                    break;
                case "jojo":
                    Console.WriteLine("Destiny is the concept of a predetermined course of events and plays a major role throughout the JoJo's Bizarre Adventure series. It may be conceived as a predetermined future, whether in general or that of an individual.");
                    break;
                case "general":
                    Console.WriteLine("The events that will necessarily happen to a particular person or thing in the future.");
                    break;
            };

        }


    }
}
