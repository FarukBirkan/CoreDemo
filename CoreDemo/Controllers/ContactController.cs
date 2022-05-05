using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class ContactController : Controller
    {
        ContactManager ctm = new ContactManager(new EfContactRepository());


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(string ContextMail, string ContextSubject, string ContextMessage, string ContextUserName)
        {

            Contact nL = new Contact()
            {
                ContextUserName = ContextUserName,
                ContextSubject = ContextSubject,
                ContextMessage = ContextMessage,
                ContextMail = ContextMail,
                ContextDate = System.DateTime.Now,
                ContextStatus = true
            };


            ctm.ContactAdd(nL);


            return Json(nL);
        }
    }
}
