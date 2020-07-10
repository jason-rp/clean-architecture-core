using System;
using JLRP.Application.Interfaces;
using JLRP.Application.ViewModel;
using JLRP.Domain.Interfaces;

namespace JLRP.Application.Services
{
    public class BookService : IBookService
    {
        public IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public BookViewModel GetBooks()
        {
            return new BookViewModel
            {
                Books = _bookRepository.GetBooks()
            };
        }
    }
}
