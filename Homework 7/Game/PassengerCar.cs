using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal sealed class PassengerCar: Car
    {
        public override int Speed
        {
            get
            {
                return 9;
            }
        }
        public PassengerCar(string name): base(name)
        {

        }
    }
}
