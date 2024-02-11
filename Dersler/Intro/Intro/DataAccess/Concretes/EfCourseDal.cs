using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes //Somut
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;

        public EfCourseDal() //veri tabanımız varmış gibi olsun diye bunu kullanıyoruz
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "JavaScript";
            course1.Description = ".NET 8";
            course1.Price = 0;


            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "Java";
            course2.Description = "Java 17";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "Python";
            course3.Description = "Python 3.12";
            course3.Price = 20;

            //arrayde kullandığımız gibi listeye böyle ekleyebiliyoruz
            courses = new List<Course> { course1, course2, course3 };

        }
        //arrayler sabittir o yüzden şimdi List ile çalışacağız
        public List<Course> GetAll()
        {
            //burada database işlemleri yapılır
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

    }
}

