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
        private int _move;

        public int Move => _move;
        public string Name => _name;
        public List<Card> Cards => _cards;
        public bool IsLoser => _cards.Count == 0;
        public Player(string name)
        {
            _name = name;
            _cards = new List<Card>();
        }
        public void CardOutput()
        {
            Console.WriteLine($"Player {_name}");
            foreach (Card card in _cards)
            {
                Console.WriteLine(card);
            }
        }
        public void AddCard(Card card) 
        {
            _cards.Add(card);
        }
        public Card MakeMove()
        {
            Card cardOnTable = _cards[0];
            _cards.RemoveAt(0);
            _move++;
            return cardOnTable;
        }
    }
}
