using System;
using System.Collections.Generic;
using System.Text;

namespace ShaNet
{
    public delegate void CardEvent(object sender, EventArgs e);

    public class Card
    {
        public string Name { get; set; }
        public Suit Suit {get;set;}
        public Color Color { get; set; }
        public int Number { get; set; }

        public event CardEvent DoPreAction;
        public event CardEvent OnUse;
        public event CardEvent Use;
        public event CardEvent OnEffect;
        public event CardEvent isCancelable;

        public virtual void UseCard(Player source,Player target,object UseArgs)
        {

        }

    }
    public enum Suit
    {
        Spade,
        Club,
        Heart,
        Diamond,
        NoSuitBlack,
        NoSuitRed,
        NoSuit,
        SuitToBeDecided = -1
    };
    public enum Color
    {
        Red,
        Black,
        Colorless
    };

}
