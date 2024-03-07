using System;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Abstract
{
    public interface ICourseDal : IGenericDal<Course>
    {
        void Delete(int id);
    }
}

