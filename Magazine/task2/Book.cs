using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Book : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Книга о войне");
        }
    }
}
