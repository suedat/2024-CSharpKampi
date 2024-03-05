using System;
using KodlamaioDemo.Entities.Abstract;

namespace KodlamaioDemo.Entities.Concrete
{
    public class Course : IEntity
    {
        public string Id { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; } = null!;
        public Instructor Instructor { get; set; } = null!;
    }
}

