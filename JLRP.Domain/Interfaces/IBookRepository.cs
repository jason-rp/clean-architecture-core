using System.Collections.Generic;
using JLRP.Domain.Models;

namespace JLRP.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
