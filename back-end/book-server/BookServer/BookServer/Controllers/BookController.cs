namespace BookServer.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Book;

    public class BookController : Controller
    {
        private readonly IBookService bookService;
        public BookController(IBookService bookService)
        {
            this.bookService = bookService;
        }

        public IActionResult Index()
        {
            return this.View();
        }
    }
}
