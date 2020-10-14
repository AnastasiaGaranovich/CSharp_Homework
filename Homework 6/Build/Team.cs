using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    internal class Team
    {
        private Worker[] _workers = new Worker[5];

        public Team()
        {
            for(int i = 0; i < _workers.Length; i++)
            {
                _workers[i] = new Worker();
            }      
        }
        public void Work(House house)
        {
            for(int i = 0; i < _workers.Length; i++)
            {
                if(house.IsFinished)
                {
                    return;
                }
                _workers[i].Build(house);
                
            }
        }
    }
}
