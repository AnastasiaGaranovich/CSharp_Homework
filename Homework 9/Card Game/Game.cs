using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Game
    {
        private List<Card> _deck;
        private List<Player> _players;
        private static Random _rng = new Random();

        public Game()
        {
            _deck = new List<Card>();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    _deck.Add(new Card(suit, rank));
                }
            }
            Console.WriteLine(_deck.Count);
        }
        public void Shuffle()
        {
            int n = _deck.Count;
            while (n > 1)
            {
                n--;
                int k = _rng.Next(n + 1);
                Card value = _deck[k];
                _deck[k] = _deck[n];
                _deck[n] = value;
            }
        }

    }
}
