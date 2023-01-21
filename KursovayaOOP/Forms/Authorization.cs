using KursovayaOOP.Forms;
using KursovayaOOP.Forms.AdministratorForm;
using KursovayaOOP.Forms.CommodityExpertForms;
using KursovayaOOP.Forms.DirectorForms;
using KursovayaOOP.Forms.DispatcherForms;
using KursovayaOOP.Forms.EconomistForm;
using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursovayaOOP
{
	public partial class Authorization : Form
	{
		private CollectionUsers _collectionUsers = new CollectionUsers();
		private CollectionEmployees _collectionEmployees = new CollectionEmployees();
		public Authorization()
		{
			_collectionUsers.ReadByDataBaseUsers();
			_collectionEmployees.ReadByDataBaseUsers();
			InitializeComponent();

		}

		private void PasswordTextBox_TextChanged(object sender, EventArgs e)
		{
			PasswordTextBox.PasswordChar = '*';
		}

		private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var registrationForms = new Registration();
			this.Hide();
			registrationForms.Show();

		}

		private void SignInButton_MouseEnter(object sender, EventArgs e)
		{
			SignInButton.FlatAppearance.BorderColor = Color.SaddleBrown;
		}

		private void SignInButton_MouseLeave(object sender, EventArgs e)
		{
			SignInButton.FlatAppearance.BorderColor = Color.White;
		}

		private bool FindAnAccountUser(string sql)
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
						if (reader.GetString(2) == LoginTextBox.Text && reader.GetString(3) == PasswordTextBox.Text)
						{
							return true;
						}
					}
				}
				reader.Close();
			}

			return false;
		}

		private bool FindAnAccountEmployee(string sql)
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
						if (reader[1].ToString() == LoginTextBox.Text && reader[2].ToString() == PasswordTextBox.Text && reader.GetInt32(7) == 0)
						{
							return true;
						}
					}
				}
				reader.Close();
			}

			return false;
		}


		private Client SearchClient()
		{
			foreach (var i in _collectionUsers.Get)
			{
				if (i.PhoneNumber == LoginTextBox.Text && i.Password == PasswordTextBox.Text)
				{
					return i;
				}
			}

			return null;
		}


		private Employee SearchEmployee()
		{
			foreach (var i in _collectionEmployees.Get)
			{
				if (i.PhoneNumber == LoginTextBox.Text && i.Password == PasswordTextBox.Text)
				{
					return i;
				}
			}

			return null;
		}

		private void Information()
		{
			var emplyee = SearchEmployee();
			if (emplyee.PositionCode == 6)
			{
				DispatcherWindow dispatcherWindow = new DispatcherWindow();
				dispatcherWindow.Dispatcher = (Dispatcher)SearchEmployee();
				dispatcherWindow.Show();
			}
			else if (emplyee.PositionCode == 3)
			{
				EconomistWindow economistWindow = new EconomistWindow();
				economistWindow.economist = (Economist)SearchEmployee();
				economistWindow.Show();
			}
			else if (emplyee.PositionCode == 4)
			{
				CommodityExpertWindow commodityExpertWindow = new CommodityExpertWindow();
				commodityExpertWindow.commodityExpert = (CommodityExpert)SearchEmployee();
				commodityExpertWindow.Show();
			}
			else if (emplyee.PositionCode == 7)
			{
				AdministratorWindow administratorWindow = new AdministratorWindow();
				administratorWindow.administrator = (Administrator)SearchEmployee();
				administratorWindow.Show();
			}
			else if (emplyee.PositionCode == 8)
			{
				DirectorWindow directorWindow = new DirectorWindow();
				directorWindow.director = (Director)SearchEmployee();
				directorWindow.Show();
			}

		}
		private void SignInButton_Click(object sender, EventArgs e)
		{
			if (FindAnAccountUser("SELECT * FROM Users"))
			{
				this.Hide();
				FunctionForUser functionForUser = new FunctionForUser(SearchClient());
				functionForUser.Client = SearchClient();
				functionForUser.Show();
			}
			else if (FindAnAccountEmployee("SELECT * FROM Employees"))
			{
				this.Hide();
				Information();
			}
			else
			{
				MessageBox.Show("Такого пользователя нет");
			}
		}


		private void Authorization_Load(object sender, EventArgs e)
		{

		}
	}
}
