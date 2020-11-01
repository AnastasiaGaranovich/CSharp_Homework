using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal sealed class SportCar : Car
    {
        override public int Speed 
        { 
            get
            {
                return 15;
            }
        }
        public SportCar(string name) : base(name)
        {

        }
    }
}
