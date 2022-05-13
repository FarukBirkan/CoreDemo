using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
         IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            
            _blogDal.Delete(blog);  
        }

        public void BlogUpdate(Blog blog)
        {
           _blogDal.Update(blog);
        }

        public List<Blog> GetAllBlog()
        {
            return _blogDal.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }


        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListCategory22()
        {
            
                return _blogDal.GetListWithCategory2();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetListAll(x => x.BlogId == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
          return _blogDal.GetListAll(x=>x.WriterId == id);  
        }
    }
}
