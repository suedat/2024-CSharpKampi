using System;
using Intro.DataAccess.Concretes;
using Intro.Entities;
using Intro.DataAccess.Abstracts;
namespace Intro.Business //veri işleri Businessın işi değil
{
    public class CourseManager
    {
        //dependency injection 
        private readonly ICourseDal _courseDal;

        //eğer constructor koyarsak default yerine bu kabul edilir
        public CourseManager(ICourseDal courseDal) //newlersen ICourseDal courseDal vermen gerek diyoruz
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {
            //business rules
            //CourseDal courseDal = new CourseDal(); //böyle koyarsak buna bağımlı oluruz. yöntem değişince patlarız
 
            return _courseDal.GetAll();
        }
    }
}

