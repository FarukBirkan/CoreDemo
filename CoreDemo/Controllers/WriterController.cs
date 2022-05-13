using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class WriterController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
         

    }
}
