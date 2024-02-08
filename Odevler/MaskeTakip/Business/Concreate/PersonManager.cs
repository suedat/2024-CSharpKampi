using Entities.Concreate;
using Business.Abstract;
namespace Business.Concreate
{
    //çıplak class kalmasın 
    public class PersonManager : IApplicantService
    {
                               //encapsulation
        public void ApplyForMask(Person person) 
        {   

        }
        public List<Person> GetList()
        {
            return null; 
        }

        //Doğrulama yapmak için
        public bool CheckPerson(Person person)
        {
            
            //mernis kontrolü yapılacak
            return true;
        }
    }
} 

//İş Kuralları
//daha önce maske almışsa vermeyeceğiz
//maske vermemiz için o kişinin kendisini doğrulaması gerekiyor

//SOLID yazılımın prensipleridir