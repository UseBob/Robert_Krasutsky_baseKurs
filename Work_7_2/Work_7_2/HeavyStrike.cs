using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal interface IHeavyStrike
    {
        bool TwoHandedWeapon { get; set; }

        double HeavyStrikeMult { get; set; }
        void HeavyStrike();
    }
}
