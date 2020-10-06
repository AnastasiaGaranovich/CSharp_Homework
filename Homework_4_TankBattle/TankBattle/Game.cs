using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    internal class Game
    {
        private readonly int countTanks;
        private Tank[] _tanksSovet;
        private Tank[] _tanksGermany;
        public Game(int countTanks)
        {
            if(countTanks < 1)
            {
                throw new ArgumentException("the number of rival tanks is less than one pair");
            }
            _tanksSovet = new Tank[countTanks];
            _tanksGermany = new Tank[countTanks];

            for (int i = 0; i < countTanks; i++)
            {
                _tanksSovet[i] = new Tank("T-34");
                _tanksGermany[i] = new Tank("Panther");
            }

            this.countTanks = countTanks;
        }

        public void Run()
        {
            for (int i = 0; i < countTanks; i++)
            {
                Console.WriteLine("Rivals  Ammunition  Armor  Speed");
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Battle {i + 1}--------------------------------");
                Console.WriteLine(_tanksGermany[i].Discription());
                Console.WriteLine(_tanksSovet[i].Discription());
                Console.WriteLine("-------------------------------------------");
            }
            for (int i = 0; i < countTanks; i++)
            {
                Console.WriteLine($"Battle{i + 1}  Winner {(_tanksSovet[i] ^ _tanksGermany[i]).Name}");
            }
        }
    }
}
