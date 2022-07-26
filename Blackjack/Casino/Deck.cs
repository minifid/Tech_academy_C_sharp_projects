using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        //Deck is a constructor
        public Deck()
        {
            Cards = new List<Card>();

            //creates a deck with all 52 cards i=face j=suit            
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.face = (Card.Face)i;
                    card.suit = (Card.Suit)j;

                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        public void Shuffle(int times = 1)
        {
            //for loop for if you wanted to shuffle multiple times (only does once right now)
            for (int i = 0; i < times; i++)
            {
                //creates a new list and randomly starts moving 1 card at a time from the deck to the list
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                //puts the cards from the list back into the deck object
                Cards = TempList;
            }
        }
    }
}
