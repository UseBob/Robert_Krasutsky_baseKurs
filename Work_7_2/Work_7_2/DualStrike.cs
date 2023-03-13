using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal interface IDualStrike
    {
         bool DualWielding { get; set; }
         double DualStrikeMult { get; set; }
        void DualHit();
    }
}
