using System;

namespace asdf
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            int x, y, Rad=10;
            bool inCircle = false;
            Random rng = new Random();

            x = rng.Next(0,10);
            y = rng.Next(0,10);

            if (x * x + y * y <= Rad * Rad)
            {
                inCircle = true;
            }

                if (inCircle != true)
                {
                    Console.WriteLine("coordinates are OutOfBounds");
                }
                else
                {
                    if (x * x + y * y <= 1)
                    {
                        Console.WriteLine($"x={x},y={y}. 10 points. Wooooh!!! Can you marry me?");
                    }
                    else if (x * x + y * y <= 5 * 5 && x * x + y * y >= 1)
                    {
                        Console.WriteLine($"x={x},y={y}. 5 points. Not bad)");
                    }
                    else if (x * x + y * y <= 10 * 10 && x * x + y * y >= 5 * 5)
                    {
                        Console.WriteLine($"x={x},y={y}. 1 points. Errrm... Yeah?");
                    }
                    else
                    {
                        Console.WriteLine($"x={x},y={y}. Not valid coordinates. Test your skills another time");
                    }

                }

                Console.WriteLine($"Wanna play again?(y/n): ");
                string confirm = Console.ReadLine();
                confirm = confirm.ToLower();
                if (confirm == "n")
                {
                    Console.WriteLine($"Bye)))))))))))");
                    break;
                }


            }

        }
    }
}
