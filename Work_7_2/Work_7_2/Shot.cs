using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_2
{
    internal interface IShot
    {
         int BulletCount { get; set; }

          double ShotMult { get; set; }
        void Shot();
    }
}
