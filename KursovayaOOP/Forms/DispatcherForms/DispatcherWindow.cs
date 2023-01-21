using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;

namespace KursovayaOOP.Forms.DispatcherForms
{
	public partial class DispatcherWindow : Form
	{
		List<string[]> list = new List<string[]>();
		List<(string, int, int)> listOrdersAndProducts = new List<(string, int, int)>();
		public Dispatcher Dispatcher { get; set; }

		public DispatcherWindow()
		{
			InitializeComponent();
			ReadForDataBase();
			CollectionsProducts();
			AddingDataToDataGridView(list);
		}

		private void ReadForDataBase() => ReadByDataBase.Read("SELECT * FROM Orders", InputInDateGridView);

		private void InputInDateGridView(SqlDataReader reader)
		{
			list.Add(new string[6]);
			list[list.Count - 1][0] = reader[0].ToString();
			list[list.Count - 1][1] = reader[1].ToString();
			list[list.Count - 1][2] = reader[2].ToString();
			list[list.Count - 1][3] = reader[3].ToString();
			list[list.Count - 1][4] = reader[4].ToString();
			list[list.Count - 1][5] = reader[5].ToString();
		}
		private void AddingDataToDataGridView(List<string[]> list)
		{
			foreach (string[] item in list)
			{
				dataGridViewOrdersReceived.Rows.Add(item);
			}
		}

		private void AddColumn(int id)
		{
			var listProduct = new List<(string, int)>();

			foreach (var item in listOrdersAndProducts)
			{
				if (item.Item2 == id)
				{
					listProduct.Add((item.Item1, item.Item3));
				}
			}

			foreach (var i in listProduct)
			{
				richTextBoxProducts.Text += i.Item1 + " " + i.Item2 + "\n";
			}
		}
		private void CollectionsProducts() => ReadByDataBase.Read("SELECT Products.ProductName, OrderProducts.IdOrder, OrderProducts.QuantityProducts FROM Products INNER JOIN OrderProducts ON Products.Id=OrderProducts.IdProduct", InputInDataGridProducts);
		private void InputInDataGridProducts(SqlDataReader reader)
		{
			listOrdersAndProducts.Add((reader.GetString(0), reader.GetInt32(1), reader.GetInt32(2)));
		}

		private void buttonPlaceOrder_Click(object sender, System.EventArgs e)
		{
			for (int i = 0; i < dataGridViewOrdersReceived.Rows.Count; i++)
			{
				if (dataGridViewOrdersReceived[6, i].Value != null && dataGridViewOrdersReceived[4, i].Value.ToString() == "Unformulated")
				{
					Dispatcher.UpdateInDataGridView(int.Parse(dataGridViewOrdersReceived[0, i].Value.ToString()));
					dataGridViewOrdersReceived[6, i].Value = null;
				}
			}

			dataGridViewOrdersReceived.Rows.Clear();
			list.Clear();
			ReadForDataBase();
			AddingDataToDataGridView(list);
		}

		private void поДатеToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			var sortedList = from item in list
							 orderby Convert.ToDateTime(item[3]) ascending
							 select item;

			dataGridViewOrdersReceived.Rows.Clear();
			AddingDataToDataGridView(sortedList.ToList());
		}

		private void планПроизводстваToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			AddInStock();
			ChanceStatus();
			dataGridViewOrdersReceived.Rows.Clear();
			list.Clear();
			ReadForDataBase();
			AddingDataToDataGridView(list);
		}
		private int Read(string name)
		{
			using (var connection = Connection.Connect())
			{
				connection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM Products", connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{

					while (reader.Read())
					{
						if (reader[1].ToString() == name)
						{
							return int.Parse(reader[0].ToString());
						}
					}
				}
			}

			return 0;
		}
		private void AddInStock()
		{
			for (int i = 0; i < dataGridViewOrdersReceived.Rows.Count; i++)
			{
				if (dataGridViewOrdersReceived[4, i].Value.ToString() == "Formulated")
				{
					for (int j = 0; j < listOrdersAndProducts.Count; j++)
					{
						if (listOrdersAndProducts[j].Item2 == int.Parse(dataGridViewOrdersReceived[0, i].Value.ToString()))
						{
							var dateDeliveryToStock = DateTime.Now;
							var idProduct = Read(listOrdersAndProducts[j].Item1);
							var count = listOrdersAndProducts[j].Item3;

							var connect = Connection.Connect();
							connect.Open();
							string query = $"INSERT INTO Stock (DateDeliveryToStock, IdProduct, Count) VALUES(@dateDelivery,@idProduct,@count)";

							SqlCommand command = new SqlCommand(query, connect);
							command.Parameters.Add("@dateDelivery", SqlDbType.DateTime).Value = dateDeliveryToStock;
							command.Parameters.Add("@idProduct", SqlDbType.Int).Value = idProduct;
							command.Parameters.Add("@count", SqlDbType.Int).Value = count;
							int number = command.ExecuteNonQuery();
							connect.Close();
						}
					}
				}
			}
		}
		private void ChanceStatus()
		{
			string query = $"UPDATE Orders SET Status = @status WHERE Status='Formulated'";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter sqlParameter = new SqlParameter("@status", "InStock");
			command.Parameters.Add(sqlParameter);
			command.ExecuteNonQuery();
			connect.Close();
		}

		private void dataGridViewOrdersReceived_CellClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				textBoxIdOrder.Text = dataGridViewOrdersReceived[0, e.RowIndex].Value.ToString();
				AddColumn(int.Parse(dataGridViewOrdersReceived[0, e.RowIndex].Value.ToString()));
			}
		}
	}
}
