using System;
using Business.Abstract;
using Entities.Concreate;

namespace Business.Concreate
{
    public class ForeignManager : IApplicantService
    {
        //Sonarqube <- yazılım kalitesini ölçer
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}

