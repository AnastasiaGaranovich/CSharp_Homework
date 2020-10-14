using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    internal class TeamLeader
    {
        public void Report(House house)
        {
            if(house.IsFinished)
            {
                Console.WriteLine("House is finished");
            }
            Console.WriteLine($"Basement: {house.Basement.BuildProgress} %");
            for(int i = 0; i < house.Walls.Length; i++)
            {
                Console.WriteLine($"Walls: {house.Walls[i].BuildProgress} %");
            }
            for (int i = 0; i < house.Windows.Length; i++)
            {
                Console.WriteLine($"Windows: {house.Windows[i].BuildProgress} %");
            }
            Console.WriteLine($"Door: {house.Door.BuildProgress} %");
            Console.WriteLine($"Roof: {house.Roof.BuildProgress} %");
        }
    }
}
