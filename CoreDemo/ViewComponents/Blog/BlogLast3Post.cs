using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Blog
{
    public class BlogLast3Post : ViewComponent
    {
        BlogManager bM = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {

            var result = bM.GetLast3Blog();
            return View(result);

        }
    }
}
