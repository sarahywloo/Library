//deleted using Library.Domain.Models;
using Library.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Presentation.Controllers
{
    public class BooksController : ApiController {

        private BookService _bookService;

        public BooksController(BookService bookService) {
            _bookService = bookService;
        }

        public IList<BookDTO> Get() {

            return _bookService.ListBooks();
        }
    }
}
