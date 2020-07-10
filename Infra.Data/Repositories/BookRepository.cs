using System;
using System.Collections.Generic;
using System.Text;
using Infra.Data.Context;
using JLRP.Domain.Interfaces;
using JLRP.Domain.Models;

namespace Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        public LibraryDbContext _context;

        public BookRepository(LibraryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}
