using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Player
    {
        private string _name;
        private List<Card> _cards;

        public Player(string name)
        {
            _name = name;
            List<Card> _cards = new List<Card>();
        }
        public void CardOutput()
        {
            Console.WriteLine($"Player {_name}");
            foreach (Card card in _cards)
            {
                Console.WriteLine(card);
            }
        }

    }
}
