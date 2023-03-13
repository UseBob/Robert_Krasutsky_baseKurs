using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_1
{
    internal class Library
    {
      public List<Book> books=new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void BookInfo(int index)
        {
            Console.WriteLine($"Название книги:{books[index].Title} \nЖанр:{books[index].Genre}\nКоличесво страниц:{books[index].PageCount}" );
        }
        public void FullListBook()
        {
            foreach (var item in books)
            {
                Console.WriteLine($"{item.Title}-{item.Genre}");
            }
        }

    }
}
