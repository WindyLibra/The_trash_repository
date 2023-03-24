using System;
using System.Collections.Generic;


namespace Program
{
    class Programma
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wordguessr. Today's theme: Villains\n");
            Random rng = new Random();
            string[] tvari = { "makima", "diavolo", "nintendo", "bezos", "pizzaface", "afton", "aizen", "sqaureenix", "vector", "eggman", "bowser", "devil", "nutdealer" };
            string theword = tvari[rng.Next(tvari.Length)];

            string theguess = "";
            for (int i = 0;i<theword.Length;i++)
            {
                theguess+="-";
            }
            Console.WriteLine(theguess + "\n");

            bool guessed = false;

            while (!guessed)
            {

                string thechar = Console.ReadLine();
                Console.WriteLine();


                if(thechar == theword)
                {
                    Console.WriteLine("You guessed the word. Victory!!!");
                    guessed = true;
                    break;
                }

                else if (thechar.Length > 1)
                {
                    Console.WriteLine("No");
                }

                else if (theword.Contains(thechar))
                {
                    for (int i = 0;i < theword.Length;i++)
                    {
                        if (thechar == theword[i].ToString())
                            theguess = theguess.Remove(i, 1).Insert(i, thechar);
                    }
                    Console.WriteLine(theguess + "\n");
                }
                else
                {
                    Console.WriteLine("Wrong one. Try again");
                    Console.WriteLine(theguess + "\n");
                }

                if(theword==theguess)
                {
                    Console.WriteLine("Victory!!!");
                    guessed = true;
                    break;
                }

            }


        }

    }
}
