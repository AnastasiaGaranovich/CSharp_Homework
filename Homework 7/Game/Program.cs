using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] carArray = new Car[4];
            carArray[0] = new SportCar("SSC Tuatara");
            carArray[1] = new PassengerCar("Volkswagen Polo");
            carArray[2] = new Bus("Ikarus");
            carArray[3] = new Track("Volvo");

            Game game = new Game();
            for(int i = 0; i < carArray.Length; i++)
            {
                game.AddRace(carArray[i]);
            }
            game.OnStart();
            game.Go();

            Console.ReadKey();
        }
    }
}
