using KursovayaOOP.Modals;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace KursovayaOOP.Services
{
	internal class CollectionUsers : IEnumerable
	{
		private List<Client> _listOfUsers;


		public CollectionUsers()
		{
			_listOfUsers = new List<Client>();
		}

		public List<Client> Get => _listOfUsers;

		public void Add(Client client)
		{
			_listOfUsers.Add(client);
		}

		private void ReadByDataBasee(SqlDataReader reader)
		{
			int id = reader.GetInt32(0);
			string nameOrganization = reader.GetString(1);
			string phoneNumber = reader.GetString(2);
			string password = reader.GetString(3);

			var client = new Client(id, nameOrganization, phoneNumber, password);
			_listOfUsers.Add(client);
		}

		public void ReadByDataBaseUsers() => ReadByDataBase.Read("SELECT * FROM Users", ReadByDataBasee);

		public IEnumerator GetEnumerator()
		{
			throw new System.NotImplementedException();
		}
	}
}

