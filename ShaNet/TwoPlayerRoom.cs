using System;
using System.Collections.Generic;
using System.Text;

namespace ShaNet
{
    public class TwoPlayerRoom:Room
    {
        public List<Player> Players { get; set; }

        public CardList Cards { get; set; }

        public event RoomEvent BeginGame;
        public event RoomEvent SelectGeneral;
        public event RoomEvent DealCard;

        public event RoomEvent BeginRound;

        public event RoomEvent BeginPlayer;
        public event RoomEvent JudgePlayer;
        public event RoomEvent DealCardPlayer;
        public event RoomEvent UseCardPlayer;
        public event RoomEvent DisCardPlayer;
        public event RoomEvent EndPlayer;

        public event RoomEvent EndRound;

        public TwoPlayerRoom():base()
        {
            this.Players = new List<Player>();
            this.Cards = new CardList();
        }


        public void Start()
        {
            bool over = false;
            while(over==false)
            {
                foreach(var p in this.Players)
                {
                    p.room = this;
                }
                //this.Players.Add(new Player());
                //this.Players.Add(new Player());

                if (this.BeginGame!=null)
                {
                    this.BeginGame(this,null);
                }

                this.Players[0].General = new General() { Name = "Baiban1", hp = 4 };
                this.Players[1].General = new General() { Name = "Baiban2", hp = 4 };

                if (this.SelectGeneral != null)
                {
                    this.SelectGeneral(this, null);
                }

                foreach(var p in this.Players)
                {
                    for(int i=0;i<4;i++)
                    {
                        p.HandCards.Push(this.Cards.Pop());
                    }
                }

                if (this.DealCard != null)
                {
                    this.DealCard(this, null);
                }

                while(over==false)
                {
                    if (this.BeginRound != null)
                    {
                        this.BeginRound(this, null);
                    }

                    foreach(var p in this.Players)
                    {
                        if (this.BeginPlayer != null)
                        {
                            this.BeginPlayer(p, null);
                        }


                        if (this.JudgePlayer != null)
                        {
                            this.JudgePlayer(p, null);
                        }

                        p.HandCards.Push(this.Cards.Pop());
                        p.HandCards.Push(this.Cards.Pop());
                        if (this.DealCardPlayer != null)
                        {
                            this.DealCardPlayer(p, null);
                        }

                        p.UseCard();
                        if (this.UseCardPlayer != null)
                        {
                            this.UseCardPlayer(p, null);
                        }

                        if (this.DisCardPlayer != null)
                        {
                            this.DisCardPlayer(p, null);
                        }


                        if (this.EndPlayer != null)
                        {
                            this.EndPlayer(this, null);
                        }
                    }

                    if (this.EndRound != null)
                    {
                        this.EndRound(this, null);
                    }
                }

            }
        }
    }
}
