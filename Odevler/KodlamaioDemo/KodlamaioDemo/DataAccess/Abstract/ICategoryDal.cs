using System;
using KodlamaioDemo.Entities;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Abstract
{
	public interface ICategoryDal : IGenericDal<Category>
    {
		void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        List<Category> GetList();
        void Delete(int id);
    }
}

