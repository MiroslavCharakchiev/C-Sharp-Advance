using System;
using System.Net.Http.Headers;

namespace CardSuit
{
    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = rank;
            this.Suit = suit;
            this.Power = GetPower();
        }

        public string Rank { get; set; }

        public string Suit { get; set; }

        public int Power { get; private set; }

        private int GetPower()
        {
            return ((int)Enum.Parse(typeof(Deck), Rank) + ((int)Enum.Parse(typeof(Suits), Suit)));
        }

        public int CompareTo(Card other)
        {
            return this.Power - other.Power;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Card card = obj as Card;
           
            return this.Power.Equals(card.Power);
        }

        public override string ToString()
        {
            return $"{this.Rank} of {this.Suit}";
        }
    }
}