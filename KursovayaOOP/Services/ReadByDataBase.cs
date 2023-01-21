using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Services
{
	public class ReadByDataBase
	{
		public static void Read(string sql, Action<SqlDataReader> action)
		{
			using (var connection = Connection.Connect())
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sql, connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{

					while (reader.Read())
					{
						action(reader);
					}
				}
			}
		}
	}
}
