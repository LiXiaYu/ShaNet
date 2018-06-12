using System;

using ShaNet;
using ShaNet.GenernalPackage;

namespace ShaNetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TwoPlayerRoom room = new TwoPlayerRoom();

            for(int i=0;i<50;i++)
            {
                room.Cards.Push(new Slash() { Number = i % 13 + 1, Suit = (Suit)(i%4) });
            }

            room.Players.Add(new ConsolePlayer());
            room.Players.Add(new ConsolePlayer());
            room.Start();



            Console.ReadKey();
        }
    }
}
