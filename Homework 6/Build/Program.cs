using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team teamWorkers = new Team();
            TeamLeader leader = new TeamLeader();
            while(!house.IsFinished)
            {
                teamWorkers.Work(house);
                leader.Report(house);
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
