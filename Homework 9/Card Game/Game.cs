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
            Shuffle();
            _players = new List<Player>();
        }
        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
        private void Shuffle()
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
        public void DealCards()
        {
            if(_players.Count == 5)
            {
                _deck.RemoveAt(0);
            }
            while(_deck.Count != 0)
            {
                foreach(Player player in _players)
                {
                    Card firstCard = _deck[0];
                    _deck.RemoveAt(0);
                    player.AddCard(firstCard);
                }
            }
        }
        public void StartGame()
        {
            foreach(Player player in _players)
            {

            }
        } 

    }
}
