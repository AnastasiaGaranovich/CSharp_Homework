using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal sealed class Track: Car
    {
        override public int Speed
        {
            get
            {
                return 5;
            }
        }
        public Track(string name): base(name) { 
        }
    }
}
