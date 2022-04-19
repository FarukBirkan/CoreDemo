using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cM = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cM.GetAllCategories();
            return View(values);    
          
        }
    }
}
