using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    internal class Tank
    {
        private readonly string _name;
        public string Name => _name;

        private int _armor;
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        private int _speed;
        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private int _ammunition;
        public int Ammunition
        {
            get { return _ammunition; }
            set { _ammunition = value; }
        }

        public Tank(string name)
        {
            _name = name;
            _armor = Randomer.GetValue(0, 100);
            _speed = Randomer.GetValue(0, 100);
            _ammunition = Randomer.GetValue(0, 100);
        }

        public string Discription()
        {
            return $"{Name}  {Ammunition}  {Armor}  {Speed}";
        }

        public static Tank operator ^(Tank tankSovet, Tank tankGermany)
        {
            int sovetScore = 0;
            if(tankSovet._ammunition > tankGermany._ammunition)
            {
                sovetScore++;
            }
            if(tankSovet._armor > tankGermany._armor)
            {
                sovetScore++;
            }
            if (tankSovet._speed > tankGermany._speed)
            {
                sovetScore++;
            }

            return sovetScore > 1 ? tankSovet : tankGermany;
        }
    }
}
