using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal class Human : Unit, IDualStrike
    {
        public bool DualWielding { get ; set ; }

        public override int BaseDamage { get; set; } = 5;

        public double DualStrikeMult { get; set; } = 1.5;

        public Human(bool dualWielding)
        {
            DualWielding=dualWielding;
        }
        public override int Attack()
        {
            DualHit();
            int hit = (int)(BaseDamage * DualStrikeMult);
            return hit;
        }

        public void DualHit()
        {
            if (DualWielding) 
            {
                Console.WriteLine("Вы ловко орудуете парным оружием, противник не успевает отражать ваши удары");
            }
            else
            {
                Console.WriteLine("Необходимо экипировать парное оружие");
            }
        }
    }
}
