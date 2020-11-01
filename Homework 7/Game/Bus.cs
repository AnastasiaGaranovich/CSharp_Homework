using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal sealed class Bus: Car
    {
        override public int Speed
        {
            get
            {
                return 6;
            }
        }
        public Bus(string name): base(name)
        {

        }
    }
}
