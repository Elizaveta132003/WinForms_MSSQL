using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Services
{
	internal class Connection
	{
		public static SqlConnection Connect()
		{
			string connectionString = @"Server=(localdb)\mssqllocaldb;Database=Kursovaya;Trusted_Connection=True;";
			return new SqlConnection(connectionString);
		}
	}
}
