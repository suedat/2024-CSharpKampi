using System;
namespace Intro.Entities
{
	//bireysel müşteri
    public class IndividualCustomer:BaseCustomer 
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NationalIdentity { get; set; }
	}
}