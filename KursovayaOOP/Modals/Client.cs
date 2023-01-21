using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	public class Client
	{
		public int Id { get; }
		public string NameOrganization { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }

		public Client(int id, string nameOrganization, string phoneNumber, string password)
		{
			Id = id;
			NameOrganization = nameOrganization;
			PhoneNumber = phoneNumber;
			Password = password;
		}
	}
}
