using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wM = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Index(Writer p)
        {

            WriterValidator valida = new WriterValidator();

            ValidationResult result = valida.Validate(p);
            if (result.IsValid)
            {
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Test";
            wM.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
        return View();

           

        }
    }
}
