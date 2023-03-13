using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Work_7_1
{
    internal class LibraryProvider
    {
        public event LibrariHandler FantasticAdded;
        public event LibrariHandler HorrorAdded;
        public event LibrariHandler DramaAdded;
        public event LibrariHandler ComedyAdded;
        public event LibrariHandler FictionAdded;
        public event LibrariHandler ScientificAdded;
        public void SubscribeToBook(List<Reader> readers)
        {
            foreach (Reader reader in readers)
            {
                switch (reader.FavoriteGenre)
                {
                    case GenreType.fantastic:
                        FantasticAdded += reader.GetBook;
                        break;
                    case GenreType.horror:
                        HorrorAdded+= reader.GetBook;
                        break;
                    case GenreType.drama:
                        DramaAdded+= reader.GetBook;
                        break;
                    case GenreType.comedy:
                        ComedyAdded+= reader.GetBook;
                        break;
                    case GenreType.fiction:
                        FictionAdded+= reader.GetBook;
                        break;
                    case GenreType.scientific:
                        ScientificAdded+= reader.GetBook;
                        break;
                    default:
                        break;
                }
            }
        }
        public void AddBook(List<Book> books)
        {
            foreach (var book in books)
            {
                switch(book.Genre)
                {
                    case GenreType.fantastic:
                        if (FantasticAdded!=null)
                        {
                            FantasticAdded(book);
                        }
                        break;
                    case GenreType.horror:
                        if (HorrorAdded != null)
                        {
                            HorrorAdded(book);
                        }
                        break;
                    case GenreType.drama:
                        if (DramaAdded != null)
                        {
                            DramaAdded(book);
                        }
                        break;
                    case GenreType.comedy:
                        if (ComedyAdded != null)
                        {
                            ComedyAdded(book);
                        }
                        break;
                    case GenreType.fiction:
                        if (FictionAdded != null)
                        {
                            FictionAdded(book);
                        }
                        break;
                    case GenreType.scientific:
                        if (ScientificAdded != null)
                        {
                            ScientificAdded(book);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
