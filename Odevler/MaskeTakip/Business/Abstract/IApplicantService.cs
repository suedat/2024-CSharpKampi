using System;
using Entities.Concreate;

namespace Business.Abstract
{
	//interfacede sadece imza
	public interface IApplicantService
	{
		void ApplyForMask(Person person);

		List<Person> GetList();

		bool CheckPerson(Person person);

	}
}

