using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        // EfCategoryRepository _efCategoryRepository;
        ICategoryDal _categorydal;
       

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);

           
        }

        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);

        }

        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        public List<Category> GetAllCategories()
        {
           return _categorydal.GetListAll();
        }

        public Category GetCategoryById(int id)
        {
           return _categorydal.GetById(id);

        }
    }
}
