using System;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Concrete
{
	public class InstructorDal
	{
        List<Instructor> _instructors;
        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Engin",
                    LastName = "Demiroğ"
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Halit Enes",
                    LastName = "Kalaycı"
                },
                new Instructor()
                {
                    Id = 3,
                    FirstName = "Mustafa Murat",
                    LastName = "Coşkun"
                }
            };
        }
        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetList()
        {
            return _instructors;
        }

        public void Update(Instructor instructor)
        {
            foreach (Instructor updatedInstructor in _instructors)
            {
                if (updatedInstructor.Id == instructor.Id)
                {
                    updatedInstructor.FirstName = instructor.FirstName;
                    updatedInstructor.LastName = instructor.LastName;
                }
            }
        }
    }
}

