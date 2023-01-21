using KursovayaOOP.Modals;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace KursovayaOOP.Services
{
	public class CollectionEmployees : IEnumerable
	{
		private List<Employee> _listOfEmployees;

		public CollectionEmployees()
		{
			_listOfEmployees = new List<Employee>();
		}

		public List<Employee> Get => _listOfEmployees;

		private void ReadByDataBasee(SqlDataReader reader)
		{
			Employee employee = null;

			if (reader.GetInt32(6) == 3)
			{
				employee = new Economist();
			}
			else if (reader.GetInt32(6) == 4)
			{
				employee = new CommodityExpert();
			}
			else if (reader.GetInt32(6) == 6)
			{
				employee = new Dispatcher();
			}
			else if (reader.GetInt32(6) == 7)
			{
				employee = new Administrator();
			}
			else if (reader.GetInt32(6) == 8)
			{
				employee = new Director();
			}

			employee.PhoneNumber = reader.GetString(1);
			employee.Password = reader.GetString(2);
			employee.LastName = reader.GetString(3);
			employee.FirstName = reader.GetString(4);
			employee.MiddleName = reader.GetString(5);
			employee.PositionCode = reader.GetInt32(6);
			employee.Id = reader.GetInt32(0);

			_listOfEmployees.Add(employee);
		}

		public Employee[] arr =
		{
			new Economist(),
			new CommodityExpert(),
			new Dispatcher(),
			new Administrator(),
			new Director()
		};


		public void ReadByDataBaseUsers() => ReadByDataBase.Read("SELECT * FROM Employees", ReadByDataBasee);

		public IEnumerator GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}
}
