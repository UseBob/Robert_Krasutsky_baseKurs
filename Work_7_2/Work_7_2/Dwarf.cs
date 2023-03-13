using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal class Dwarf : Unit, IShot
    {
        public int BulletCount { get; set; }
        public override int BaseDamage { get; set; } = 3;

        public double ShotMult { get; set; } = 1.3;

        public Dwarf(int bulletCount, double shotMult)
        {
            BulletCount = bulletCount;
        }

        public override int Attack()
        {
            Shot();
            int hit = (int)(BaseDamage * ShotMult);
            Console.WriteLine($"Противник потерял {hit} жизней");
            BulletCount--;
            return hit;
        }

        public void Shot()
        {
            if (BulletCount!=0)
            {
                Console.WriteLine("Ваше ружьё никогда не даёт осечки, цель поражена прямо в лоб");
            }
            else
            {
                Console.WriteLine("Кажется вам нужно проверить карманы,стрелять то больше нечем");
            }
        }
    }
}
