﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    enum Suit
    {
        Diamonds,
        Hearts,
        Spades,
        Clubs
    }

    enum Rank
    {
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }

    internal class Card
    {
        private Suit _cardSuit;
        private Rank _cardRank;

        public Rank Rank => _cardRank;
        public Card(Suit suit, Rank rank)
        {
            _cardSuit = suit;
            _cardRank = rank;
        }
        public static string SuitToString(Suit suit)
        {
            switch(suit)
            {
                case Suit.Diamonds:
                    return "Diamonds";
                case Suit.Hearts:
                    return "Hearts";
                case Suit.Spades:
                    return "Spades";
                case Suit.Clubs:
                    return "Clubs";
                default:
                    return "Invalid suit";
            }
        }

        public static string RankToString(Rank rank)
        {
            switch (rank)
            {
                case Rank.Ace:
                    return "Ace";
                case Rank.King:
                    return "King";
                case Rank.Queen:
                    return "Queen";
                case Rank.Jack:
                    return "Jack";
                case Rank.Ten:
                    return "Ten";
                case Rank.Nine:
                    return "Nine";
                case Rank.Eight:
                    return "Eight";
                case Rank.Seven:
                    return "Seven";
                case Rank.Six:
                    return "Six";
                default:
                    return "Invalid rank";
            }
        }
        public override string ToString()
        {
            return $"Suit {SuitToString(_cardSuit)} Rank {RankToString(_cardRank)}";
        }
        public static bool operator ==(Card card1, Card card2)
        {
            return (card1._cardSuit == card2._cardSuit
                        && card1._cardRank == card2._cardRank);
        }
        public static bool operator !=(Card card1, Card card2)
        {
            return (card1._cardSuit != card2._cardSuit
                        && card1._cardRank != card2._cardRank);
        }
    }
}
