using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Magazine : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Магазин с книгами");
        }
        static void PrintMagazine(IPrintable[] printable)
        {

        }
    }
}
