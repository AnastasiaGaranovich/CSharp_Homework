using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Console.WriteLine("How many players are going to play?");
            int playerCount = Convert.ToInt32(Console.ReadLine());
            if(playerCount < 2 && playerCount > 6)
            {
                Console.WriteLine("Invalid players count");
                return;
            }
            for(int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("Enter players name");
                string name = Console.ReadLine();
                game.AddPlayer(new Player(name));
            }
            game.DealCards();


            Console.ReadKey();
        }
    }
}
