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

            double dryingTime = 15.0;
            double fastModeTime = 25.5;
            double temperature = 45.9;

            dishwashers[0].EcoMode();
            dishwashers[2].DryingMode(dryingTime);
            dishwashers[4].EveryDayMode();
            dishwashers[3].FastMode(fastModeTime, ref temperature);
            Console.WriteLine($"Water temperature in fast mode {temperature}");

            Console.WriteLine(dishwashers[2].MaxLoading);

            Console.ReadKey();
        }
    }
}
