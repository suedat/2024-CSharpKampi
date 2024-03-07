using System;
namespace KodlamaioDemo.Entities.Concrete
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
        public List<Course> Courses { get; } = new List<Course>();
    }
}

