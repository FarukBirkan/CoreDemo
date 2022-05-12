using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace UILayer.Controllers
{
    public class LoginController : Controller
    {

        [AllowAnonymous] // Authorize işlemi dışında tutmak için
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(v=>v.WriterMail == p.WriterMail && v.WriterPassword == p.WriterPassword);  
            if (datavalue != null)
            {
                HttpContext.Session.SetString("UserName", p.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }
        }



        
    }
}
