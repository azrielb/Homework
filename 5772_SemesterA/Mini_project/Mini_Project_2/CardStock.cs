using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace War
{
    class CardStock : IEnumerable
    {
        private List<Card> Cards;

        //Constructors
        public CardStock(params Player[] players)
        {
            Cards = new List<Card>();
            for (int number = 2; number <= 14; ++number)
            {
                Cards.Add(new Card(E_color.Blue, number));
                Cards.Add(new Card(E_color.Red, number));
            }
            distribute(players);
        }
        public CardStock(Card card)
        {
            Cards = new List<Card>();
            Cards.Add(card);
        }

        //Mix the whole card stock
        public void mixer()
        {
            Random rand = new Random();
            for (int number = 26 * 4; number >= 0; --number)
            {
                int left = number % 26, right = rand.Next(25);
                Card temp = Cards[left];
                Cards[left] = Cards[right];
                Cards[right] = temp;
            }
        }

        //This function distributes the card to the all players.
        public void distribute(params Player[] players)
        {
            if (players.Length < 2) return;
            mixer();
            int cardsPerPlayer = Cards.Count / players.Length;
            foreach (Player player in players)
            {
                for (int a = 0; a < cardsPerPlayer; ++a)
                {
                    player.pushCard(Cards[0]);
                    Cards.RemoveAt(0);
                }
            }
        }
        //sorting by numbers
        public void sort()
        {
            Cards.Sort();
        }


        //Overridden function
        public override string ToString()
        {
            string ret = string.Format("The stock has {0} cards:\t", Cards.Count);
            foreach (Card card in Cards)
                ret += card.ToString() + ' ';
            return ret.Trim();
        }

        //Operators
        public static CardStock operator +(CardStock cardStock, Card card)
        {
            cardStock.Cards.Add(card);
            return cardStock;
        }
        public static CardStock operator -(CardStock cardStock, Card card)
        {
            cardStock.Cards.Remove(card);
            return cardStock;
        }
        public static explicit operator CardStock(Card card)
        {
            return new CardStock(card);
        }

        //Indexers
        public Card this[string name, E_color color]
        {
            get
            {
                foreach (Card card in Cards)
                    if (card.CardName == name && card.Color == color)
                        return card;
                return null;
            }
        }
        public Card this[string name]
        {
            get
            {
                foreach (Card card in Cards)
                    if (card.CardName == name)
                        return card;
                return null;
            }
        }

        //This class can be a parameter of foreach
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)Cards;
        }
    }
}
