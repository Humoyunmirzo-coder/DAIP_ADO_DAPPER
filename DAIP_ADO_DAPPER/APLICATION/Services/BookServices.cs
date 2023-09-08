using APLICATION.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APLICATION.Services
{
    public class BookServices : IBookServise
    {
        public readonly IBookReposity _bookreposity;
        public BookServices(IBookReposity bookreposity)
        {
            _bookreposity = bookreposity;
        }
        public void AddBook (BookServices book)
        {
            _bookreposity.AddBook(book);
        }
        public void AddBook(IBookReposity book)
        {
        //    throw new NotImplementedException();
        }
    }
}
