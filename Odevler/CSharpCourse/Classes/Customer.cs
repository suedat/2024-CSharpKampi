using System;
namespace Classes
{
	class Customer
	{

		//field
		private string _firstName;

		//property
		public int Id { get; set; }
		public string FirstName{
			get { return "Mrs." + _firstName; }
			set { _firstName = value; }
		}
		public string LastName { get; set; }
	}
}

