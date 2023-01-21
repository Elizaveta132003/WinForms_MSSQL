using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KursovayaOOP.Forms
{
	public partial class UserAccaunt : Form
	{
		public Client client { get; set; }
		public List<string[]> list { get; set; }
		List<string[]> listOrders = new List<string[]>();
		public UserAccaunt(Client client)
		{
			//client = client;
			InitializeComponent();
			ReadByDataBaseOrder(client.Id);
			AddInDataGridViewHistoryOrders(listOrders);
		}

		private void UserAccaunt_Load(object sender, EventArgs e)
		{

		}

		private void buttonAccount_Click(object sender, EventArgs e)
		{
			this.Show();
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

		private void buttonMyOrders_Click(object sender, EventArgs e)
		{
			this.Show();
		}
		private void AddInDataGridViewHistoryOrders(List<string[]> list)
		{
			foreach (var i in list)
			{
				dataGridViewOrderHistory.Rows.Add(i);
			}
		}
		private void ReadByDataBaseOrder(int id) => ReadByDataBase.Read($"SELECT * FROM Orders WHERE IdClient={id}", AddInDataGridView);
		private void AddInDataGridView(SqlDataReader reader)
		{

			listOrders.Add(new string[5]);
			listOrders[listOrders.Count - 1][0] = reader[0].ToString();
			listOrders[listOrders.Count - 1][1] = reader[2].ToString();
			listOrders[listOrders.Count - 1][2] = reader[3].ToString();
			listOrders[listOrders.Count - 1][3] = reader[4].ToString();
			listOrders[listOrders.Count - 1][4] = reader[5].ToString();


		}

		private void buttonAboutMe_Click(object sender, EventArgs e)
		{
			this.Close();
			UserInformation userInformation = new UserInformation(client);
			userInformation.list = list;
			userInformation.client = client;
			userInformation.Show();
		}
	}
}
