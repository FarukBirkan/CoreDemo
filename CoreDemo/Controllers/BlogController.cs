using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bM = new BlogManager(new EfBlogRepository());
        NewLetterManager nlM = new NewLetterManager(new EfNewLetterRepository());

        public IActionResult Index()
        {

            var values = bM.GetBlogListCategory22();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
          
            var values = bM.GetBlogById(id);

            return View(values);
        }


      

    }
}
