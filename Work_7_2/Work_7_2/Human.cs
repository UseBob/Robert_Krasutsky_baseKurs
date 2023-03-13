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

        public Human(bool dualWielding, string unitSex, string unitClass) : base(unitSex, unitClass)
        {
            DualWielding=dualWielding;

            UnitSex = unitSex;

            UnitClass = unitClass;

            UnitRace = "Human";
        }
        public override int Attack()
        {
            DualHit();
            int hit = (int)(BaseDamage * DualStrikeMult);
            Console.WriteLine($"Противник потерял {hit} жизней");
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
