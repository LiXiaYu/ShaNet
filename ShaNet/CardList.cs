using System;
using System.Collections.Generic;
using System.Text;

namespace ShaNet
{
    public class CardList
    {
        public List<Card> Cards { get; set; }

        public CardList()
        {
            this.Cards = new List<Card>();
        }

        public void RandomRank()
        {
            Random random = new Random();
            List<Card> newList = new List<Card>();
            foreach (Card item in this.Cards)
            {
                newList.Insert(random.Next(newList.Count + 1), item);
            }

            Cards = newList;
        }

        public Card Pop()
        {
            Card result= this.Cards[this.Cards.Count - 1];
            this.Cards.RemoveAt(this.Cards.Count - 1);

            return result;
        }

        public void Push(Card card)
        {
            this.Cards.Add(card);
        }
    }
}
