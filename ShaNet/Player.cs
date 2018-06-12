using System;
using System.Collections.Generic;
using System.Text;

namespace ShaNet
{
    public class Player
    {
        public Room room;

        public General General { get; set; }

        public CardList HandCards { get; set; }

        public Player()
        {
            this.HandCards = new CardList();
        }

        public virtual void UseCard()
        {
            bool over = false;
            while(over==false)
            {

            }
        }
    }
}
