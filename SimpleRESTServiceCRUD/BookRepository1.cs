using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleRESTServiceCRUD
{
    public class BookRepository1 : IBook
    {
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public Book AddNewBook(Book item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteABook(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateABook(Book item)
        {
            throw new NotImplementedException();
        }
    }
}