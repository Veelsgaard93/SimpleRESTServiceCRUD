using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRESTServiceCRUD
{
    interface IBook
    {
        [OperationContract]
        List<Book> GetAllBooks();

        [OperationContract]
        Book GetBookById(int id);

        [OperationContract]
        Book AddNewBook(Book item);

        [OperationContract]
        bool DeleteABook(int id);

        [OperationContract]
        bool UpdateABook(Book item);
    }
}
