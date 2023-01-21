using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	public class Director : Employee
	{


		public Director() : base() { }

		public Director(int id, int positionCode, string phoneNumber, string password, string lastName, string firstName, string middleName) : base(id, positionCode, phoneNumber, password, lastName, firstName, middleName)
		{
		}
	}
}
