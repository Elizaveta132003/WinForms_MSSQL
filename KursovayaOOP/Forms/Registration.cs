using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace KursovayaOOP.Forms
{
	public partial class Registration : Form
	{
		private CollectionUsers _collectionUsers = new CollectionUsers();
		public Registration()
		{
			InitializeComponent();
			_collectionUsers.ReadByDataBaseUsers();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var authorization = new Authorization();
			this.Hide();
			authorization.Show();

		}

		private void button1_MouseEnter(object sender, System.EventArgs e)
		{
			SignUpButton.FlatAppearance.BorderColor = Color.SaddleBrown;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (nameOrganizationTextBox.Rules().CheckingNumberOfCharacters(3)
				&& phoneNumberTextBox.Rules().CorrectnessOfEnteredPhoneNumber()
				&& passwordTextBox.Rules().CorrectnessPassword() && CheckingForPresenceOfSuchAccount("SELECT * FROM Users"))
			{
				var nameOrganization = nameOrganizationTextBox.Text;
				var phoneNumber = phoneNumberTextBox.Text;
				var password = passwordTextBox.Text;

				var connect = Connection.Connect();
				connect.Open();
				string query = $"INSERT INTO Users (NameOrganization, PhoneNumber, Password) VALUES(@nameOrganization,@phoneNumber,@password)";

				SqlCommand command = new SqlCommand(query, connect);
				command.Parameters.Add("@nameOrganization", SqlDbType.VarChar).Value = nameOrganization;
				command.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = phoneNumber;
				command.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
				int number = command.ExecuteNonQuery();
				connect.Close();
				MessageBox.Show("Вы зарегестрированы!");
				_collectionUsers.ReadByDataBaseUsers();
				var client = Information();

				this.Close();

				FunctionForUser functionForUser = new FunctionForUser(client);
				functionForUser.Client = client;
				functionForUser.Show();

			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так. Повторите ввод");
			}
		}

		public Client Information()
		{
			foreach (var user in _collectionUsers.Get)
			{
				if (user.PhoneNumber == phoneNumberTextBox.Text && user.Password == passwordTextBox.Text)
				{
					return user;
				}
			}

			return null;
		}


		private bool CheckingForPresenceOfSuchAccount(string sql)
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
						if (reader.GetString(1) == nameOrganizationTextBox.Text
							&& reader.GetString(2) == phoneNumberTextBox.Text)
						{
							return false;
						}
					}
				}
				reader.Close();
			}

			return true;
		}

		private void button1_MouseLeave(object sender, System.EventArgs e)
		{
			SignUpButton.FlatAppearance.BorderColor = Color.White;
		}

		private void Registration_Load(object sender, System.EventArgs e)
		{

		}
	}
}
