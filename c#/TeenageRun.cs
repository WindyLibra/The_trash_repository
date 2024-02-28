using System;
using System.Collections.Generic;

//List<string> stl = new List<string>();

namespace Program
{
    class Programma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Daily Teenage Run.\nWhat would you like?\n\nFor help, you can type \"help\" without brackets.");
            List<string> Titles = new List<string>();
            string[] Ttl = { "Detergent", "Eren cosplaying Hitler", "Need for woman touching", "You're my special" };

            bool doStuff = true;

            while (doStuff)
            {
                Console.WriteLine();
                string userInput = Console.ReadLine();

                if (userInput == "menu")
                {
                    Console.WriteLine("Here is our menu:");
                    ShowTitles(Ttl);
                }

                else if (userInput == "help")
                {
                    Console.WriteLine("Here is the list of commands that you can use here:");
                    Console.WriteLine("\"menu\" - shows our titles.");
                    Console.WriteLine("\"add\" - adds an item to the cart.");
                    Console.WriteLine("\"remove\" - removes an item from your cart.");
                    Console.WriteLine("\"exit\" - exits from shop.");
                    Console.WriteLine("\"cart\" - shows your cart.");
                    Console.WriteLine("\"help\" - shows you list of commands.");
                }

                else if (userInput == "add")
                {
                    Console.WriteLine("Enter your item's number: ");
                    int itemSelect = Convert.ToInt32(Console.ReadLine());
                    Titles.Add(Ttl[itemSelect - 1]);
                    Console.WriteLine("Item successfully added.");
                    //ShowCart(Titles);
                }

                else if (userInput == "cart")
                {
                    Console.WriteLine("Here's your cart: ");
                    ShowCart(Titles);
                }

                else if (userInput == "remove")
                {
                    ShowCart(Titles);
                    Console.WriteLine("Select which one you want to remove(by number of selection):");
                    int userRemove = Convert.ToInt32(Console.ReadLine());
                    Titles.RemoveAt(userRemove-1);
                    Console.WriteLine("Item successfully removed.");
                }

                else if (userInput == "exit")
                {
                    Console.WriteLine("See you next time. Bye)");
                    break;
                }

            }
        }

        public static void ShowTitles(string[] arr)
        {
            int count = 1;
            foreach (string i in arr)
            {
                Console.WriteLine($"{count}) {i}");
                count++;
            }
        }
        public static void ShowCart(List<string> cart)
        {
            int count = 1;
            foreach (string i in cart)
            {
                Console.WriteLine($"{count}) {i}");
                count++;
            }
        }

    }
}
