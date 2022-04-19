using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UILayer.Models;

namespace UILayer.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentlist = new List<UserComment>
            {
                new UserComment
                {
                    Id=1,
                    UserName ="Faruk" 
                },
                new UserComment
                {
                    Id=2,
                    UserName ="Faruk"
                },
                new UserComment
                {
                    Id=3,
                    UserName ="Faruk"
                }
            };
            return View(commentlist);
        }
    }
}
