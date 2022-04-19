using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cM = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public JsonResult PartialAddComment(string Name, string Title, string Content, int id)
        {

            Comment cc = new Comment()
            {
                CommentName = Name,
                CommentTitle = Title,
                CommentContent = Content,
                CommentDate = System.DateTime.Now,
                CommentStatus = true,
                BlogId = 2
            };

            cM.CommentAdd(cc);

            return Json(cc);

        }
        public PartialViewResult PartialListComment(int id)

        {
            var values = cM.GetAllCommenties(id);
            return PartialView(values);

        }
    }
}
