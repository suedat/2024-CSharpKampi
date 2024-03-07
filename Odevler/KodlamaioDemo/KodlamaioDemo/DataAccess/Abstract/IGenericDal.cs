using System;
namespace KodlamaioDemo.DataAccess.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Add(T t);
		void Update(T t);
		void Delete(T t);
		List<T> GetList();
	}
}

