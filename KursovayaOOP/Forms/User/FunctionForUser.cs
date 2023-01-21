using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KursovayaOOP.Forms
{
	public partial class FunctionForUser : Form
	{
		public Client Client { get; set; }
		public List<string[]> List = new List<string[]>();
		public List<string[]> ListInBasket = new List<string[]>();
		public List<string> ListOfTypeGoods = new List<string>();

		public FunctionForUser(Client client)
		{
			Client = client;
			InitializeComponent();
			DataInArr();
			DataInDataGridView();
			AddingDataToDataGridView(List);
		}

		private void buttonBasket_Click(object sender, EventArgs e)
		{
			this.Close();
			UsersCarzine usersCarzine = new UsersCarzine(Client, ListInBasket);
			usersCarzine.list = ListInBasket;
			usersCarzine.client = Client;
			usersCarzine.Show();
		}

		private void buttonProduct_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void buttonAccount_Click(object sender, EventArgs e)
		{
			this.Close();
			UserAccaunt userAccaunt = new UserAccaunt(Client);
			userAccaunt.list = ListInBasket;
			userAccaunt.client = Client;
			userAccaunt.Show();
		}

		private void DataInDataGridView() => ReadByDataBase.Read("SELECT * FROM Products", ProcessInputInDataGridView);

		private void ProcessInputInDataGridView(SqlDataReader reader)
		{
			List.Add(new string[3]);
			List[List.Count - 1][0] = reader[1].ToString();
			List[List.Count - 1][1] = ListOfTypeGoods[(int)reader[2] - 1];
			List[List.Count - 1][2] = reader[3].ToString();

		}
		private void DataInArr() => ReadByDataBase.Read("SELECT * FROM TypeOfProducts", InputInArr);
		private void InputInArr(SqlDataReader reader)
		{
			var t = reader[1].ToString();
			ListOfTypeGoods.Add(reader[1].ToString());
		}

		private void AddingDataToDataGridView(List<string[]> list)
		{
			foreach (string[] item in list)
			{
				dataGridViewProduct.Rows.Add(item);
			}
		}

		private void FunctionForUser_Load(object sender, EventArgs e)
		{

		}

		private void buttonInputInBasket_Click(object sender, EventArgs e)
		{

			for (int i = 0; i < dataGridViewProduct.Rows.Count; i++)
			{
				if (dataGridViewProduct[3, i].Value != null)
				{
					ListInBasket.Add(new string[3]);
					ListInBasket[ListInBasket.Count - 1][0] = dataGridViewProduct[0, i].Value.ToString();
					ListInBasket[ListInBasket.Count - 1][1] = dataGridViewProduct[1, i].Value.ToString();
					ListInBasket[ListInBasket.Count - 1][2] = dataGridViewProduct[2, i].Value.ToString();
					dataGridViewProduct[3, i].Value = null;
				}
			}
		}
	}
}
