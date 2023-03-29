using System;
using System.Collections.Generic;

namespace asdf
{
    class Programma
    {
        public static void Main(string[] args)
        {
            RadioCar zztop = new RadioCar();

            zztop.horn = "Beep BEEEEEEEEEP!!!!!";
            zztop.Beep();
            Console.WriteLine("Here I go mfers@@@$%#@!#$!@!\n");
            for (int i = 0; i < 101; i++)
            {
                zztop.Drive();
                Console.WriteLine("");
            }
            zztop.Beep();
            Console.WriteLine("Oh no, anyway\n");
            zztop.Recharge();
            for (int i = 0; i < 7; i++)
            {
                zztop.Drive();
                Console.WriteLine("");
            }
            zztop.Beep();
            Console.WriteLine("What a ride!(smokes a cigerette)");

        }


    }

}
