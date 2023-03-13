using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_1
{
    public delegate void LibrariHandler(Book book);
    public enum GenreType
    {
        fantastic = 1,
        horror,
        drama,
        comedy,
        fiction,
        scientific
    }
           
    public class Book
    {
        public int PageCount { get; set; }
        public string Title { get; set; }

        public GenreType Genre { get; set; }
        public Book(string title) 
        {
            PageCount = new Random().Next(1,99);
            Title = title;
            Genre =(GenreType)new Random().Next(1,7);
        }
    }

}
