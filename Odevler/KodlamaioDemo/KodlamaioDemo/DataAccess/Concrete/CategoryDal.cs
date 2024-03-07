using System;
using KodlamaioDemo.Entities.Concrete;
using KodlamaioDemo.DataAccess.Abstract;
namespace KodlamaioDemo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public CategoryDal()
        {
            _categories = new List<Category>();
        }
        List<Category> _categories;

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            _categories.Remove(category);
            //int ile bağlantısına tekrar bakıp Remove'u Delete'e çevir
        }

        public List<Category> GetList()
        {
            return _categories;
        }

        public void Update(Category category)
        {
            foreach (Category updatedCategory in _categories)
            {
                if (updatedCategory.Id == category.Id)
                {
                    updatedCategory.Name = category.Name;
                }
            }
        }
    }
}