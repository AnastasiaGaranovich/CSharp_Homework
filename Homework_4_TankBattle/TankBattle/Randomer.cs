using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    internal class Randomer
    {
        private static Random _rnd;
        static Randomer()
        {
            _rnd = new Random();
        }
        public static int GetValue(int min, int max)
        {
            //todo: реализовать проверку
            return _rnd.Next(min, max);
        }
    }
}
