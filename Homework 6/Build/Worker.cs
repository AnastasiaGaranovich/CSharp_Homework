using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    internal class Worker : IWorker
    {
        public void Build(House house)
        {
            if(house.IsFinished)
            {
                Console.WriteLine("House is finished"); 
            }
            if(!house.Basement.BuildIsFinished)
            {
                house.Basement.Build();
                return;
            }
            for (int i = 0; i < house.Walls.Length; i++)
            {
                if (!house.Walls[i].BuildIsFinished)
                {
                    house.Walls[i].Build();
                    return;
                }
            }
            for (int i = 0; i < house.Windows.Length; i++)
            {
                if (!house.Windows[i].BuildIsFinished)
                {
                    house.Windows[i].Build();
                    return;
                }
            }
            if (!house.Door.BuildIsFinished)
            {
                house.Door.Build();
                return;
            }
            if (!house.Roof.BuildIsFinished)
            {
                house.Roof.Build();
                return;
            }
        }
    }
}
