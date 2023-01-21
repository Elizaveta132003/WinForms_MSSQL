namespace KursovayaOOP.Modals
{
	public abstract class Employee
	{
		public int Id { get; set; }
		public int PositionCode { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }

		protected Employee(int id, int positionCode, string phoneNumber, string password, string lastName, string firstName, string middleName)
		{
			Id = id;
			PositionCode = positionCode;
			PhoneNumber = phoneNumber;
			Password = password;
			LastName = lastName;
			FirstName = firstName;
			MiddleName = middleName;
		}

		public Employee() { }
	}
}
