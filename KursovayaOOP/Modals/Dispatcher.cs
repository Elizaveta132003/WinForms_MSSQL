using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaOOP.Modals
{
	public class Dispatcher : Employee
	{
		public Dispatcher(int id, int positionCode, string phoneNumber, string password, string lastName, string firstName, string middleName) : base(id, positionCode, phoneNumber, password, lastName, firstName, middleName)
		{
		}


		public Dispatcher() : base() { }

		public void UpdateInDataGridView(int idOrder)
		{
			string query = $"UPDATE Orders SET Status = @status, IdEmployee = @idEmployee WHERE Id={idOrder} AND Status='Unformulated'";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter parameter = new SqlParameter("@idEmployee", Id);
			SqlParameter sqlParameter = new SqlParameter("@status", "Formulated");

			command.Parameters.Add(parameter);
			command.Parameters.Add(sqlParameter);

			command.ExecuteNonQuery();
			connect.Close();
		}

		public void ProductionPlan()
		{

		}
	}
}
