namespace BookServer.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Services.Comment;

    public class CommentController : Controller
    {
        private readonly ICommentService commentService;
        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        public IActionResult Index()
        {
//            ssasa
            return this.View();
        }
    }
}
