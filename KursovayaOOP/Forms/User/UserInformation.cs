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

namespace KursovayaOOP.Forms
{
	public partial class UserInformation : Form
	{
		public Client client { get; set; }
		public List<string[]> list { get; set; }
		public UserInformation(Client client)
		{
			InitializeComponent();
			InformatinAboutUser(client);
		}

		private void InformatinAboutUser(Client client)
		{
			textBoxNameOfOrganization.Text = client.NameOrganization.ToString();
			textBoxPhoneNumber.Text = client.PhoneNumber.ToString();
			textBoxPassword.Text = client.Password.ToString();
		}

		private void UserInformation_Load(object sender, EventArgs e)
		{

		}

		private void buttonAboutMe_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void buttonMyOrders_Click(object sender, EventArgs e)
		{
			this.Close();
			UserAccaunt userAccaunt = new UserAccaunt(client);
			userAccaunt.list = list;
			userAccaunt.client = client;
			userAccaunt.Show();
		}

		private void buttonAccount_Click(object sender, EventArgs e)
		{
			buttonMyOrders_Click(sender, e);
		}

		private void buttonBasket_Click(object sender, EventArgs e)
		{
			this.Close();
			UsersCarzine usersCarzine = new UsersCarzine(client, list);
			usersCarzine.list = list;
			usersCarzine.client = client;
			usersCarzine.Show();
		}

		private void buttonProduct_Click(object sender, EventArgs e)
		{
			this.Close();
			FunctionForUser functionForUser = new FunctionForUser(client);
			functionForUser.List = list;
			functionForUser.Client = client;
			functionForUser.Show();
		}

		private void buttonChange_Click(object sender, EventArgs e)
		{
			textBoxNameOfOrganization.ReadOnly = false;
			textBoxPassword.ReadOnly = false;
			textBoxPhoneNumber.ReadOnly = false;
			buttonChange.Visible = false;
			buttonOKChange.Visible = true;
		}

		private void buttonOKChange_Click(object sender, EventArgs e)
		{
			UpdateUsersInformation();
			buttonOKChange.Visible = false;
			buttonChange.Visible = true;
			textBoxNameOfOrganization.ReadOnly = true;
			textBoxPassword.ReadOnly = true;
			textBoxPhoneNumber.ReadOnly = true;
		}
		private void UpdateUsersInformation()
		{
			string query = $"UPDATE Users SET NameOrganization = @nameOrganization, PhoneNumber = @phoneNumber, Password=@password WHERE Id={client.Id}";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter parameter = new SqlParameter("@nameOrganization", textBoxNameOfOrganization.Text);
			SqlParameter sqlParameter = new SqlParameter("@phoneNumber", textBoxPhoneNumber.Text);
			SqlParameter sqlParameterTwo = new SqlParameter("@password", textBoxPassword.Text);

			command.Parameters.Add(parameter);
			command.Parameters.Add(sqlParameter);
			command.Parameters.Add(sqlParameterTwo);
			command.ExecuteNonQuery();
			connect.Close();
		}
	}
}
