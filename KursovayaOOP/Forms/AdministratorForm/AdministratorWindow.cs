using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaOOP.Forms.AdministratorForm
{
	public partial class AdministratorWindow : Form
	{
		List<string[]> listCliens = new List<string[]>();
		List<string[]> listEmployees = new List<string[]>();
		List<(int, string)> listPosition = new List<(int, string)>();
		public Administrator administrator { get; set; }
		public AdministratorWindow()
		{
			InitializeComponent();
			ReadForDataBaseClients();
			AddingDataToDataGridView(listCliens, dataGridViewUsers);
			ReadForDataBaseEmloyees();
			AddingDataToDataGridView(listEmployees, dataGridViewEmployees);
		}

		private void ReadForDataBaseClients() => ReadByDataBase.Read("SELECT * FROM Users", InputInDateGridViewClients);

		private void InputInDateGridViewClients(SqlDataReader reader)
		{
			listCliens.Add(new string[3]);
			listCliens[listCliens.Count - 1][0] = reader[0].ToString();
			listCliens[listCliens.Count - 1][1] = reader[1].ToString();
			listCliens[listCliens.Count - 1][2] = reader[2].ToString();
		}
		private void AddingDataToDataGridView(List<string[]> list, DataGridView dataGridView)
		{
			foreach (string[] item in list)
			{
				dataGridView.Rows.Add(item);
			}
		}
		private void ReadForDataBaseEmloyees() => ReadByDataBase.Read("SELECT Employees.Id, Employees.PhoneNumber, Employees.LastName, Employees.FirstName, Employees.MiddleName, Positions.NamePosition, Employees.Hide FROM Employees INNER JOIN Positions ON PositionCode=Positions.Id", AddInDataGridViewEmloyees);
		private void AddInDataGridViewEmloyees(SqlDataReader reader)
		{
			listEmployees.Add(new string[7]);
			listEmployees[listEmployees.Count - 1][0] = reader[0].ToString();
			listEmployees[listEmployees.Count - 1][1] = reader[1].ToString();
			listEmployees[listEmployees.Count - 1][2] = reader[2].ToString();
			listEmployees[listEmployees.Count - 1][3] = reader[3].ToString();
			listEmployees[listEmployees.Count - 1][4] = reader[4].ToString();
			listEmployees[listEmployees.Count - 1][5] = reader[5].ToString();
			listEmployees[listEmployees.Count - 1][6] = reader[6].ToString();
		}

		private void buttonClients_Click(object sender, EventArgs e)
		{
			dataGridViewEmployees.Visible = false;
			dataGridViewUsers.Visible = true;
		}


		private void buttonEmployees_Click(object sender, EventArgs e)
		{
			dataGridViewUsers.Visible = false;
			dataGridViewEmployees.Visible = true;
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridViewUsers.Visible)
			{
				panelInputDataClient.Visible = true;
			}
			else if (dataGridViewEmployees.Visible)
			{
				panelInputDataEmloyee.Visible = true;
				comboBoxPosition.Items.Clear();
				AddPositions(comboBoxPosition);

			}

		}
		private void AddPositions(ComboBox comboBox)
		{
			CollectionPosition();

			foreach (var i in listPosition)
			{
				comboBox.Items.Add(i.Item2);
			}
		}
		private void CollectionPosition() => ReadByDataBase.Read("SELECT * FROM Positions", ReadPositions);
		private void ReadPositions(SqlDataReader reader)
		{
			listPosition.Add((reader.GetInt32(0), reader.GetString(1)));
		}
		private bool CheckingForPresenceOfSuchAccount(string sql, TextBox textBoxFirst, TextBox textBoxSecond)
		{
			using (var connect = Connection.Connect())
			{
				connect.Open();
				var command = new SqlCommand(sql, connect);
				SqlDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						if (reader.GetString(1) == textBoxFirst.Text
							&& reader.GetString(2) == textBoxSecond.Text)
						{
							return false;
						}
					}
				}
				reader.Close();
			}

			return true;
		}
		private void AddClient()
		{

			var nameOrganization = textBoxNameOrganization.Text;
			var phoneNumber = textBoxPhoneNumber.Text;
			var password = textBoxPassword.Text;

			var connect = Connection.Connect();
			connect.Open();
			string query = $"INSERT INTO Users (NameOrganization, PhoneNumber, Password) VALUES(@nameOrganization,@phoneNumber,@password)";

			SqlCommand command = new SqlCommand(query, connect);
			command.Parameters.Add("@nameOrganization", SqlDbType.VarChar).Value = nameOrganization;
			command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
			command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
			int number = command.ExecuteNonQuery();
			connect.Close();

		}

		private void buttonAddClient_Click(object sender, EventArgs e)
		{
			if (textBoxNameOrganization.Rules().CheckingNumberOfCharacters(3)
				&& textBoxPhoneNumber.Rules().CorrectnessOfEnteredPhoneNumber()
				&& textBoxPassword.Rules().CorrectnessPassword() && CheckingForPresenceOfSuchAccount("SELECT * FROM Users", textBoxNameOrganization, textBoxPhoneNumber))
			{
				AddClient();
				textBoxPhoneNumber.Clear();
				textBoxPassword.Clear();
				textBoxNameOrganization.Clear();
				panelInputDataClient.Visible = false;
				dataGridViewUsers.Rows.Clear();
				listCliens.Clear();
				ReadForDataBaseClients();
				AddingDataToDataGridView(listCliens, dataGridViewUsers);
			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так. Проверить ввод.");
			}
		}

		private void AddEmployee()
		{

			var phoneNumber = textBoxNumberPhoneEmloyee.Text;
			var password = textBoxPasswordEmloyee.Text;
			var name = textBoxNameEmployee.Text;
			var lastName = textBoxLastName.Text;
			var middleName = textBoxMiddleName.Text;
			var possition = comboBoxPosition.SelectedItem.ToString();
			var indexPositions = 0;

			foreach (var i in listPosition)
			{
				if (i.Item2 == possition)
				{
					indexPositions = i.Item1;
				}
			}

			var connect = Connection.Connect();
			connect.Open();
			string query = $"INSERT INTO Employees (PhoneNumber, Password, LastName, FirstName, MiddleName, PositionCode, Hide) VALUES(@phoneNumber,@password,@lastName, @firstName, @middleName, @positionCode, @hide)";

			SqlCommand command = new SqlCommand(query, connect);
			command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
			command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
			command.Parameters.Add("@lastName", SqlDbType.VarChar).Value = lastName;
			command.Parameters.Add("@firstName", SqlDbType.VarChar).Value = name;
			command.Parameters.Add("@middleName", SqlDbType.VarChar).Value = middleName;
			command.Parameters.Add("@positionCode", SqlDbType.Int).Value = indexPositions;
			command.Parameters.Add("@hide", SqlDbType.Int).Value = 1;
			int number = command.ExecuteNonQuery();
			connect.Close();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBoxNumberPhoneEmloyee.Rules().CorrectnessOfEnteredPhoneNumber() &&
				textBoxPasswordEmloyee.Rules().CorrectnessPassword() &&
				textBoxLastName.Rules().CheckingNumberOfCharacters(3) &&
				textBoxMiddleName.Rules().CheckingNumberOfCharacters(3) &&
				textBoxNameEmployee.Rules().CheckingNumberOfCharacters(3) &&
				CheckingForPresenceOfSuchAccount("SELECT * FROM Employees", textBoxPhoneNumber, textBoxPassword))
			{
				AddEmployee();
				textBoxNumberPhoneEmloyee.Clear();
				textBoxPasswordEmloyee.Clear();
				textBoxNameEmployee.Clear();
				textBoxLastName.Clear();
				textBoxMiddleName.Clear();
				comboBoxPosition.SelectedItem = null;
				panelInputDataEmloyee.Visible = false;
				dataGridViewEmployees.Rows.Clear();
				listEmployees.Clear();
				ReadForDataBaseEmloyees();
				AddingDataToDataGridView(listEmployees, dataGridViewEmployees);
			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так. Проверьте ввод.");
			}
		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridViewUsers.Visible)
			{
				MessageBox.Show("Данная функция недоступна.");
			}
			else if (dataGridViewEmployees.Visible)
			{
				for (int i = 0; i < dataGridViewEmployees.RowCount; i++)
				{
					if (dataGridViewEmployees[0, i].Selected && int.Parse(dataGridViewEmployees[6, i].Value.ToString()) == 0)
					{
						string query = $"UPDATE Employees SET Hide=@hide WHERE Id={int.Parse(dataGridViewEmployees[0, i].Value.ToString())}";
						var connect = Connection.Connect();
						connect.Open();
						SqlCommand command = new SqlCommand(query, connect);
						SqlParameter parameter = new SqlParameter("@hide", 1);

						command.Parameters.Add(parameter);


						command.ExecuteNonQuery();
						connect.Close();
					}
				}
				dataGridViewEmployees.Rows.Clear();
				listEmployees.Clear();
				ReadForDataBaseEmloyees();
				AddingDataToDataGridView(listEmployees, dataGridViewEmployees);
			}
		}

		private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridViewEmployees.Visible)
			{
				for (int i = 0; i < dataGridViewEmployees.RowCount; i++)
				{
					if (dataGridViewEmployees[0, i].Selected && Convert.ToInt32(dataGridViewEmployees[6, i].Value) == 0)
					{
						panelPosition.Visible = true;
						comboBoxPosition.Items.Clear();
						AddPositions(comboBoxPositionCode);
					}
				}
			}
			else
			{
				MessageBox.Show("Данная функция недоступна.");
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			var possition = comboBoxPositionCode.SelectedItem.ToString();
			var indexPositions = 0;

			foreach (var i in listPosition)
			{
				if (i.Item2 == possition)
				{
					indexPositions = i.Item1;
				}
			}
			for (int i = 0; i < dataGridViewEmployees.RowCount; i++)
			{
				var id = 0;

				if (dataGridViewEmployees[0, i].Selected)
				{
					id = Convert.ToInt32(dataGridViewEmployees[0, i].Value);
					string query = $"UPDATE Employees SET PositionCode=@positionCode WHERE Id={id}";
					var connect = Connection.Connect();
					connect.Open();
					SqlCommand command = new SqlCommand(query, connect);
					SqlParameter parameter = new SqlParameter("@positionCode", indexPositions);
					command.Parameters.Add(parameter);
					command.ExecuteNonQuery();
					connect.Close();
				}
			}


			panelPosition.Visible = false;
			dataGridViewEmployees.Rows.Clear();
			listEmployees.Clear();
			ReadForDataBaseEmloyees();
			AddingDataToDataGridView(listEmployees, dataGridViewEmployees);
		}
	}
}
