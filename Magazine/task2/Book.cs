using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Book : IPrintable
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public static int bookCount = 0;

        public Book(string title, string description)
        {
            Title = title;
            Description = description;
            int bookCount = 0;
        }

        public void Print()
        {
            Console.WriteLine($"Описание книги {Title}: {Description}");
        }
        public static void PrintBook(IPrintable[] printable)
        {
            for (int i = 0; i < printable.Length; i++)
            {
                if (printable[i] is Book)
                {
                    Console.WriteLine("Книга:"+printable[i].Title);
                }
            }
        }
    }
}
