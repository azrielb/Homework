using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War
{
    class Player
    {
        //Fields
        private readonly string name;
        private Queue<Card> myCards;

        //Properties
        public string Name
        {
            get { return name; }
        }
        public void pushCard(params Card[] cards)
        {
            foreach (Card card in cards)
                if (card != null)
                    myCards.Enqueue(card);
        }
        public Card popCard()
        {
            return myCards.Count > 0 ? myCards.Dequeue() : null;
        }
        public int Count
        {
            get { return myCards.Count; }
        }

        //Overridden function
        public override string ToString()
        {
            string ret = string.Format("{0}: {1} cards:\t", name, myCards.Count);
            foreach (Card card in myCards)
            {
                ret += card.ToString() + "  ";
            }
            return ret.Trim();
        }

        //If the user has no cards - it is won;
        public bool lose()
        {
            return myCards.Count == 0;
        }

        //Operators
        public static Player operator +(Player player, Card card)
        {
            player.pushCard(card);
            return player;
        }
        public static Player operator --(Player player)
        {
            player.popCard();
            return player;
        }


        //Constructor
        public Player(string n)
        {
            name = n;
            myCards = new Queue<Card>();
        }
    }
}
