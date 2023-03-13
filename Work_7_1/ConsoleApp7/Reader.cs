using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_1
{
    public class Reader
    {
        public Reader(GenreType favoriteGenre,string name) 
        {
            Name= name;
            FavoriteGenre = favoriteGenre;
        }

        public string Name { get; set; }

        public GenreType FavoriteGenre { get; set; }

        public void GetBook(Book book)
        {
            Console.WriteLine($"Reader {Name} got a {book.Genre} with count page: {book.PageCount}");
        }
    }
}

