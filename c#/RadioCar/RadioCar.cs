using System;
using System.Collections.Generic;
using System.Text;

namespace asdf
{
    public class RadioCar
    {
        public int batteryCharge = 100;
        public string horn;
        public int distance = 0;

        public void Drive()
        {
            if (batteryCharge == 0)
            {
                Console.WriteLine("The battery is out of charge. Cannot drive any longer");
                return;
            }

            batteryCharge -= 1;
            distance += 5;
            Console.WriteLine($"Car drove 5 meters. The distance now is {distance} meters");
            Console.WriteLine($"The car is at {batteryCharge}%");
        }

        public void Beep()
        {
            Console.WriteLine($"{horn}\n");
        }

        public void Recharge()
        {
            while(batteryCharge<100)
            {
                batteryCharge += 15;
                if (batteryCharge > 100)
                    batteryCharge = 100;
                Console.WriteLine($"The car is charging. Battery charge is now {batteryCharge}%\n");
            }
  
        }


    }

}
