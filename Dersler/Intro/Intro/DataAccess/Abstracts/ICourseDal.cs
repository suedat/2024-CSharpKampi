using System;
using Intro.Entities;

namespace Intro.DataAccess.Abstracts
{
	public interface ICourseDal //bunu implemente eden alttakileri kullanmak zorunda
	{
		List<Course> GetAll();

		void Add(Course course);
	}
}

