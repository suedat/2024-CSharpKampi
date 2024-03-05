using System;
namespace KodlamaioDemo.Entities.Concrete
{
	public class Instructor
	{
		public string Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public List<Course> Courses { get; } = new List<Course>();
    }
}

