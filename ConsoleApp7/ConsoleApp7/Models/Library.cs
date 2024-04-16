using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    public class Library
    {
        Book[] _books = new Book[0];
        public Book[] books 
        {
            get
            { return _books; } 
        }
        public Book this[int index]
        {
            get
            {
                foreach (Book book in _books)
                {
                    if (book.Id == index)
                    {
                        return book;
                    }

                }
                return null;
            }
        }
        public void AddBook(Book book)

        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }
    }
}
