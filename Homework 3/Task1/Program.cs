using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dishwasher[] dishwashers = new Dishwasher[5];
            dishwashers[0] = new Dishwasher("Bosch");
            dishwashers[1] = new Dishwasher("MAUNFELD");
            dishwashers[2] = new Dishwasher("Samsung", 8);
            dishwashers[3] = new Dishwasher("Samsung", 12);
            dishwashers[4] = new Dishwasher("Bosch", 10.2, 0.99);

            double operatingTimeForDry = 15.5;
            double operatingTimeForFast = 25.8;

            dishwashers[0].EcoMode();
            dishwashers[2].DryingMode(ref operatingTimeForDry);
            dishwashers[4].EveryDayMode();
            dishwashers[3].FastMode(ref operatingTimeForFast);

            Console.WriteLine(dishwashers[2].MaxLoading);
        }
    }
}
