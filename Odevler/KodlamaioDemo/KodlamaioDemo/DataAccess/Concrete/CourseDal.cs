using System;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {

        public CourseDal()
        {
            _courses = new List<Course>();
        }
        List<Course> _courses;

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetList()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            foreach (Course updatedCourse in _courses)
            {
                if (course.Id == updatedCourse.Id)
                {
                    updatedCourse.Name = course.Name;
                    updatedCourse.Description = course.Description;
                    updatedCourse.Instructor = course.Instructor;
                }
            }
        }
    }
}