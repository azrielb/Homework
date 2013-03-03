using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace War
{
    class Game
    {
        CardStock cardDeck;
        Player first, second;
        int stepCounter = 0;

        //Constructor:
        public Game(string firstPlayerName = "", string secondPlayerName = "")
        {
            first = new Player(string.IsNullOrWhiteSpace(firstPlayerName) ? "First player" : firstPlayerName.Trim());
            second = new Player(string.IsNullOrWhiteSpace(secondPlayerName) ? "Second player" : secondPlayerName.Trim());
            cardDeck = new CardStock(first, second);
        }

        //Reset the game
        public void reset(string firstPlayerName = "", string secondPlayerName = "")
        {
            if (!string.IsNullOrWhiteSpace(firstPlayerName))
                first = new Player(firstPlayerName.Trim());
            else if (first == null)
                first = new Player("First player");
            if (!string.IsNullOrWhiteSpace(secondPlayerName))
                second = new Player(secondPlayerName.Trim());
            else if (second == null)
                second = new Player("Second player");
            cardDeck = new CardStock(first, second);
        }
        //Check where won, if the game is not ended - return null;
        public string winner()
        {
            return first.lose() ? second.Name : (second.lose() ? first.Name : null);
        }
        //Check whether the game is ended
        public bool isEnded()
        {
            return first.lose() || second.lose();
        }
        //Make a step:
        public void makeStep()
        {
            if (++stepCounter > 1000) throw (new Exception("It has performed more than 1000 steps. Therefore the game has stopped."));
            Card fCard = first.popCard(), sCard = second.popCard();
            if (fCard > sCard) first.pushCard(fCard, sCard);
            else if (fCard < sCard) second.pushCard(sCard, fCard);
            else
            {
                List<Card> cards = new List<Card>();
                while (!isEnded())
                {
                    cards.Add(fCard);
                    cards.Add(sCard);
                    fCard = first.popCard();
                    sCard = second.popCard();
                    if (fCard > sCard)
                    {
                        first.pushCard(cards.ToArray());
                        first.pushCard(fCard, sCard);
                        return;
                    }
                    else if (fCard < sCard)
                    {
                        second.pushCard(cards.ToArray());
                        second.pushCard(fCard, sCard);
                        return;
                    }
                }
                if (first.lose() && second.lose()) reset(); // If the 2 players have the same card list - they both will be "lose" together!!!
            }

        }

        //Overridden function
        public override string ToString()
        {
            return string.Format("{0} has {2,2} cards and {1} has {3,2} cards", first.Name, second.Name, first.Count, second.Count);
        }

    }
}
