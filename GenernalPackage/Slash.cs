using System;
using System.Collections.Generic;
using System.Text;

using ShaNet;

namespace ShaNet
{
    namespace GenernalPackage
    {
        public class Slash:Card
        {
            public Slash():base()
            {
                this.Name = "Slash";

            }

            public override void UseCard(Player source, Player target, object UseArgs)
            {
                target.General.hp -= 1;
            }
        }
    }
}