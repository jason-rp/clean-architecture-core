using System.Collections.Generic;
using JLRP.Domain.Models;

namespace JLRP.Application.ViewModel
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
