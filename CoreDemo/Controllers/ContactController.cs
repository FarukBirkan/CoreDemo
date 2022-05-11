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
        public IActionResult Index(Contact contact)
        {
            System.Threading.Thread.Sleep(2000);
            //string ContextMail; string ContextSubject; string ContextMessage; string ContextUserName;
            Contact cnt = new Contact()
            {
                ContextUserName = contact.ContextMail,
                ContextSubject =contact.ContextSubject,
                ContextMessage = contact.ContextMessage,
                ContextMail = contact.ContextUserName,
                ContextDate = System.DateTime.Now,
                ContextStatus = true
            };


            ctm.ContactAdd(cnt);


            return View();
        }
    }
}
