using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace UILayer.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {

        BlogManager bM = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {

            var result = bM.GetBlogListByWriter(1);
            return View(result);

        }

    }
}
