using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal class Ogre : Unit, IHeavyStrike
    {
        public bool TwoHandedWeapon { get ; set ; }
        public override int BaseDamage { get; set; } = 7;

        public double HeavyStrikeMult { get; set; }=1.75;

        public Ogre(bool twoHandedWeapon) 
        {
            TwoHandedWeapon = twoHandedWeapon;
        }
        public override int Attack()
        {
            HeavyStrike();
            int hit = (int)(BaseDamage * HeavyStrikeMult);
            Console.WriteLine($"Противник потерял {hit} жизней");
            return hit;
        }
        public void HeavyStrike()
        {
            if (TwoHandedWeapon)
            {
                Console.WriteLine("Вы наносите сокрушительный удра по противнику");
            }
            else 
            {
                Console.WriteLine("Для удара необхожиом двуручное оружие");
            }
        }
    }
}
