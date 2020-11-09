using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Card_Game
{
    internal class Game
    {
        private List<Card> _deck;
        private List<Card> _table;
        private List<Player> _players;
        private static Random _rng = new Random();
        private int _moveCount = 0;

        public Game()
        {
            _deck = new List<Card>();
            _table = new List<Card>();
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
        private Player MoveWinner()
        { 
            int maxIndex = 0;
            int max = (int)_table[0].Rank;
            for (int i = 1; i < _table.Count; ++i)
            {
                if ((int)_table[i].Rank > max)
                {
                    max = (int)_table[i].Rank;
                    maxIndex = i;
                }
            }
            List<Player> disputePlayers = DisputePlayers(_table[maxIndex]);

            if(disputePlayers.Count < 2)
            {
                return _players[maxIndex];
            }
            List<Card> disputeTable = new List<Card>();
            foreach (Player player in disputePlayers)
            {
                disputeTable.Add(player.MakeMove());
            }
            maxIndex = 0;
            max = (int)disputeTable[0].Rank;
            for (int i = 1; i < disputeTable.Count; ++i)
            {
                if ((int)disputeTable[i].Rank > max)
                {
                    max = (int)disputeTable[i].Rank;
                    maxIndex = i;
                }
            }
            _moveCount++;
            return disputePlayers[maxIndex];
        }
        private List<Player> DisputePlayers(Card card)
        {
            List<Player> result = new List<Player>();
            for(int i = 0; i < _table.Count; i++)
            {
                if(_players[i].IsLoser)
                {
                    continue;
                }
                if(_table[i].Rank == card.Rank)
                {
                    result.Add(_players[i]);
                }
            }
            return result;
        }
        public void OneStep()
        {
            foreach(Player player in _players)
            {
                _table.Add(player.MakeMove());
            }

            Player moveWinnerPlayer = MoveWinner();
            foreach(Card card in _table)
            {
                moveWinnerPlayer.AddCard(card);
            }
            _table.Clear();
            DeleteLosers();
            Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
            Thread.Sleep(10);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        } 
        public void StartGame()
        {
            while(_players.Count != 1)
            {
                OneStep();
                _moveCount++;
            }
            Console.WriteLine($"{_players[0].Name} is winner!");
            Console.WriteLine($"Per game was done {_moveCount} moves");
        }
        private void DeleteLosers()
        {
            List<Player> losers = new List<Player>();
            foreach (Player player in _players)
            {
                if (player.IsLoser)
                {
                    Console.WriteLine($"Player with name: {player.Name} lost");
                    losers.Add(player);
                }
            }
            foreach (Player loser in losers)
            {
                Console.WriteLine($"Player with name: {loser.Name} make {loser.Move} moves");
                _players.Remove(loser);
            }
        }
    }
}
