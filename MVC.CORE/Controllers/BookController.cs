using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JLRP.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MVC.CORE.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            var model = _bookService.GetBooks();
            return View(model);
        }
    }
}
