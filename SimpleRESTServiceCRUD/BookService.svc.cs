using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpleRESTServiceCRUD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static IBookRepository repository = new BookRepository1();

        public List<Book> GetBookList()
        {
            return repository.GetAllBooks();
        }

        public Book GetBookById(string id)
        {
            return repository.GetBookById(int.Parse(id));
        }

        public string CreateBook(string id, Book book)
        {
            Book newbook = repository.AddNewBook(book);
            return "id = " + newbook.BookId;
        }

        public string UpdateBook(string id, Book book)
        {
            bool updated = repository.UpdateABook(book);
            if (updated)
                return "Book with id = " + id + " Updated successfully";
            else
                return "Unable to update book with id: + " + id;
        }

        public string DeleteBook(string id, Book book)
        {
            bool deleted = repository.DeleteBook(int.Parse(id));
            if (deleted)
                return "Book with id = " + id + " Deleted successfully";
            else
                return "Unable to delete book with id: + " + id;
        }
    }
}
