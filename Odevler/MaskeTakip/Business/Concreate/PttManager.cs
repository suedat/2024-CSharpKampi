using System;
using Business.Abstract;
using Business.Concreate;
using Entities.Concreate;
namespace Business.Concreate
{
	//PersonManager'ı kullanmak istersek burada kullanabiliriz
	public class PttManager : ISupplierService
	{
		//fieldlar classın içinde _ ile yazılır
		//başka bir sınıfa ihtiyaç duyuyor newlemek yerine onun interfaceini yazıyoruz
		private IApplicantService _applicantService;

						//applicant service'e baağımlılık veriyoruz
		public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
		{
			_applicantService = applicantService;
		}

		public void GiveMask(Person person)
		{
			//newleyince PersonManager'a bağımlı olursun
			if (_applicantService.CheckPerson(person))
			{
				Console.WriteLine(person.FirstName + "için masker verildi");
			}
		}
	}
}

