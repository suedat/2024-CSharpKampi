using System;

using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;
namespace KodlamaioDemo.Business.Concrete
{
	public class CourseManager : ICourseService
	{
		private readonly ICourseDal _courseDal;

		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

		public void Add(Course course)
		{
			_courseDal.Add(course);
		}

		public void Delete(int Id)
		{
			_courseDal.Delete(Id);
		}

		public void Update(Course course)
		{
			_courseDal.Update(course);
		}
        public List<Course> GetList()
        {
            return _courseDal.GetList();
        }
    }
}

