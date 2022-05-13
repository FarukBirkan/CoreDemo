using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

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
        public  async Task<IActionResult> Index(Writer p)
        {

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(v=>v.WriterMail == p.WriterMail && v.WriterPassword == p.WriterPassword);  
            if(datavalue == null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };
                var useridentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            //Context c = new Context();
            //var datavalue = c.Writers.FirstOrDefault(v=>v.WriterMail == p.WriterMail && v.WriterPassword == p.WriterPassword);  
            //if (datavalue != null)
            //{
            //    HttpContext.Session.SetString("UserName", p.WriterMail);
            //    return RedirectToAction("Index", "Writer");
            //}
            //else
            //{
            //    return View();
            //}
        }




    }
}
