using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter count of tanks pairs: ");
                int userCountTanks = Convert.ToInt32(Console.ReadLine());
                Game game = new Game(userCountTanks);
                game.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
