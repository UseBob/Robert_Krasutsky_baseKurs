using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Magazine : IPrintable
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public static int magazineCount = 0;
        public Magazine(string discription,string title) 
        {
            Title = title;
            Description = discription;
            magazineCount++;
        }
        public void Print()
        {
            Console.WriteLine($"Описание журнала {Title}: {Description}");
        }
        public static void PrintMagazine(IPrintable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Magazine)
                {
                    Console.WriteLine("Журнал:" + printable[i].Title);
                }
            }
        }
    }
}
