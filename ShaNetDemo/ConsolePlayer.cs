using System;
using System.Collections.Generic;
using System.Text;

using ShaNet;

namespace ShaNetDemo
{
    public class ConsolePlayer : Player
    {
        public override void UseCard()
        {
            bool over = false;
            while (over == false)
            {
                Console.WriteLine("now is turn of " + this.General.Name+" hp: "+this.General.hp);

                int i = 0;
                foreach(var c in this.HandCards.Cards)
                {
                    Console.WriteLine("" + i + " : " + c.Name + " " + c.Suit + " " + c.Number);
                    i++;
                }
                Console.WriteLine("Please input the index of card used");
                i = Convert.ToInt32(Console.ReadLine());

                int j = 0;
                foreach(var p in (this.room as TwoPlayerRoom).Players)
                {
                    Console.WriteLine("" + j + " : " + p.General.Name + " " + p.General.hp);
                    j++;
                }
                Console.WriteLine("Please input the index of target");
                j = Convert.ToInt32(Console.ReadLine());

                this.HandCards.Cards[i].UseCard(this, (this.room as TwoPlayerRoom).Players[j], null);

                this.HandCards.Cards.RemoveAt(i);

                over = true;
            }
        }
    }
}
