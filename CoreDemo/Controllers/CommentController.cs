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
        //public PartialViewResult PartialAddComment(Comment p)
        //{
        //    p.CommentDate = System.DateTime.Now;
        //    p.CommentStatus = true;

        //    return  PartialView();

        //}
        public JsonResult PartialAddComment(Comment p, string CommentName, string CommentTitle, string CommentContent )
        {
            p.CommentName = CommentName;
            p.CommentContent = CommentContent;
            p.CommentTitle = CommentTitle;
            p.CommentDate = System.DateTime.Now;
            p.CommentStatus = true;
            p.BlogId = 1;
            //Comment cc = new Comment()
            //{
            //    CommentName = CommentName,
            //    CommentTitle = CommentTitle,
            //    CommentContent = CommentContent,
            //    CommentDate = System.DateTime.Now,
            //    CommentStatus = true,
            //    BlogId = 2
            //};

            cM.CommentAdd(p);

            return Json(p);

        }
        public PartialViewResult PartialListComment(int id)

        {
            var values = cM.GetAllCommenties(id);
            return PartialView(values);

        }
    }
}
