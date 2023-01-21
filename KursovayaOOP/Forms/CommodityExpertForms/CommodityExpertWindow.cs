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

namespace KursovayaOOP.Forms.CommodityExpertForms
{
	public partial class CommodityExpertWindow : Form
	{
		List<string[]> list = new List<string[]>();
		List<string[]> listProductsForInvoice = new List<string[]>();
		public CommodityExpert commodityExpert { get; set; }
		public CommodityExpertWindow()
		{
			InitializeComponent();

			ReadForDataBase();
			AddingDataToDataGridView(list);
			CheckDelivery();
		}

		private void ReadForDataBase() => ReadByDataBase.Read("SELECT * FROM Orders", InputInDateGridView);

		private void InputInDateGridView(SqlDataReader reader)
		{
			var date = reader.GetDateTime(3);
			list.Add(new string[5]);
			list[list.Count - 1][0] = reader[0].ToString();
			list[list.Count - 1][1] = reader[1].ToString();
			list[list.Count - 1][2] = date.ToString("dd.MM.yyyy");
			list[list.Count - 1][3] = reader[4].ToString();
			list[list.Count - 1][4] = reader[5].ToString();
		}

		private void AddingDataToDataGridView(List<string[]> list)
		{
			foreach (string[] item in list)
			{
				dataGridViewAllOrder.Rows.Add(item);
			}
		}
		private void CheckDelivery()
		{
			for (int i = 0; i < dataGridViewAllOrder.RowCount; i++)
			{
				var count = Convert.ToDateTime(dataGridViewAllOrder[2, i].Value);
				if (count.Date == DateTime.Now.Date)
				{
					dataGridViewAllOrder[5, i].ReadOnly = false;
				}
			}
		}

		private void заказыНаСегодняToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dataGridViewAllOrder != null)
			{
				for (int i = 0; i < dataGridViewAllOrder.RowCount; i++)
				{
					if (DateTime.Parse(dataGridViewAllOrder[2, i].Value.ToString()) != DateTime.Now.Date && dataGridViewAllOrder[2, i].Value.ToString() != null)
					{

						dataGridViewAllOrder.Rows.Remove(dataGridViewAllOrder.Rows[i]);
					}
				}
			}
		}

		private void dataGridViewAllOrder_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
			{
				var date = Convert.ToDateTime(dataGridViewAllOrder[2, e.RowIndex].Value);
				if (date.Date == DateTime.Now.Date)
				{
					dataGridViewAllOrder.Visible = false;
					buttonOK.Visible = true;
					textBoxTotalPrice.Text = dataGridViewAllOrder[4, e.RowIndex].Value.ToString();
					menuStripOrderNow.Visible = false;
					panelInvoice.Visible = true;
					AddInInvoice(e.RowIndex);
					ReadByInvoice(e.RowIndex);
					AddProductsForOrder(e.RowIndex);


				}
				else
				{
					MessageBox.Show("На данный момент эта функция недоступна.");
				}
			}

		}
		private void AddInInvoice(int indexRows)
		{
			var registrationDate = DateTime.Now;
			var nameOrganization = SearchClient(Convert.ToInt32(dataGridViewAllOrder[1, indexRows].Value)).Item1;
			var street = SearchClient(Convert.ToInt32(dataGridViewAllOrder[1, indexRows].Value)).Item2;
			var houseNumber = SearchClient(Convert.ToInt32(dataGridViewAllOrder[1, indexRows].Value)).Item3;
			var idOrder = Convert.ToInt32(dataGridViewAllOrder[0, indexRows].Value);
			var idClient = Convert.ToInt32(dataGridViewAllOrder[1, indexRows].Value);

			var connect = Connection.Connect();
			connect.Open();
			string query = $"INSERT INTO Invoice (RegistrationDate, NameOrganization, Street, HouseNumber, IdOrder, IdClient) VALUES(@registrationDate,@nameOrganization,@street, @houseNumber, @idOrder, @idClient)";

			SqlCommand command = new SqlCommand(query, connect);
			command.Parameters.Add("@registrationDate", SqlDbType.DateTime).Value = registrationDate;
			command.Parameters.Add("@nameOrganization", SqlDbType.VarChar).Value = nameOrganization;
			command.Parameters.Add("@street", SqlDbType.VarChar).Value = street;
			command.Parameters.Add("@houseNumber", SqlDbType.VarChar).Value = houseNumber;
			command.Parameters.Add("@idOrder", SqlDbType.Int).Value = idOrder;
			command.Parameters.Add("@idClient", SqlDbType.Int).Value = idClient;

			int number = command.ExecuteNonQuery();
			connect.Close();
		}

		private (string, string, string) SearchClient(int id)
		{
			using (var connection = Connection.Connect())
			{
				connection.Open();
				SqlCommand command = new SqlCommand($"SELECT Users.NameOrganization, Orders.Street, Orders.HouseNumber FROM Users INNER JOIN Orders ON Users.Id=Orders.IdClient WHERE Users.Id={id}", connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{

					while (reader.Read())
					{
						return (reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
					}
				}
			}

			return (null, null, null);
		}

		private void ReadByInvoice(int indexRow) => ReadByDataBase.Read($"SELECT Invoice.Id, Invoice.RegistrationDate, Invoice.NameOrganization, Invoice.Street, Invoice.HouseNumber FROM Invoice WHERE Invoice.IdClient={Convert.ToInt32(dataGridViewAllOrder[1, indexRow].Value)}", AddInInvoiceForm);
		private void AddInInvoiceForm(SqlDataReader reader)
		{
			textBoxNumberInvoice.Text = reader[0].ToString();
			textBoxRegistrationDate.Text = reader[1].ToString();
			textBoxNameOrganizationPayer.Text = reader[2].ToString();
			textBoxAddressPayer.Text = reader[3].ToString() + "," + reader[4].ToString();
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			UpdateStock();
			UpdateInvoice();
			foreach (var i in panelInvoice.Controls)
			{
				if (i is TextBox && i != textBoxDeliveryConditions)
				{
					((TextBox)i).Text = null;
				}
			}
			dataGridViewProductInOrder.Rows.Clear();

			panelInvoice.Visible = false;
			buttonOK.Visible = false;
			dataGridViewAllOrder.Visible = true;
			menuStripOrderNow.Visible = true;
		}
		private void UpdateStock()
		{
			string query = $"UPDATE Stock SET IdEmployee=@idEmployee, DateShipmentFromStock=@dateShipmentStock";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter parameter = new SqlParameter("@idEmployee", commodityExpert.Id);
			SqlParameter parameterTwo = new SqlParameter("@dateShipmentStock", DateTime.Now);
			command.Parameters.Add(parameter);
			command.Parameters.Add(parameterTwo);
			command.ExecuteNonQuery();
			connect.Close();
		}
		private void UpdateInvoice()
		{
			string query = $"UPDATE Invoice SET IdEmployee=@idEmployee";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter parameter = new SqlParameter("@idEmployee", commodityExpert.Id);
			command.Parameters.Add(parameter);
			command.ExecuteNonQuery();
			connect.Close();
		}
		private void AddProductsForOrder(int indexRow)
		{
			ConnectWithBaseDate(Convert.ToInt32(dataGridViewAllOrder[0, indexRow].Value));

			foreach (var i in listProductsForInvoice)
			{
				dataGridViewProductInOrder.Rows.Add(i);
			}
		}
		private void ConnectWithBaseDate(int idOrder)
			=> ReadByDataBase.Read($"SELECT Products.ProductName, OrderProducts.QuantityProducts, Products.Price*OrderProducts.QuantityProducts FROM OrderProducts INNER JOIN Products ON OrderProducts.IdProduct=Products.Id Where OrderProducts.IdOrder={idOrder}", AddInInvoiceProducts);
		private void AddInInvoiceProducts(SqlDataReader reader)
		{
			listProductsForInvoice.Add(new string[3]);
			listProductsForInvoice[listProductsForInvoice.Count - 1][0] = reader[0].ToString();
			listProductsForInvoice[listProductsForInvoice.Count - 1][1] = reader[1].ToString();
			listProductsForInvoice[listProductsForInvoice.Count - 1][2] = reader[2].ToString();
		}

		private void доставленоToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridViewAllOrder.RowCount; i++)
			{
				if (dataGridViewAllOrder[5, i].Selected)
				{
					//if(dataGridViewAllOrder[3,i].Value.ToString()==)
					ChangeStatus(Convert.ToInt32(dataGridViewAllOrder[0, i].Value));
					ChangeStock(Convert.ToInt32(dataGridViewAllOrder[0, i].Value));
					UpdateStockProducts();
				}
			}

			list.Clear();
			dataGridViewAllOrder.Rows.Clear();
			ReadForDataBase();
			AddingDataToDataGridView(list);
			CheckDelivery();
		}
		private void ChangeStatus(int id)
		{
			string query = $"UPDATE Orders SET Status = @status WHERE Id={id}";
			var connect = Connection.Connect();
			connect.Open();
			SqlCommand command = new SqlCommand(query, connect);
			SqlParameter parameter = new SqlParameter("@status", "Delivered");
			command.Parameters.Add(parameter);
			command.ExecuteNonQuery();
			connect.Close();
		}
		List<int> listProductsInOrders = new List<int>();
		private void ChangeStock(int id) => ReadByDataBase.Read($"SELECT OrderProducts.IdProduct FROM OrderProducts WHERE OrderProducts.IdOrder={id}", Change);
		private void Change(SqlDataReader reader)
		{
			listProductsInOrders.Add(reader.GetInt32(0));
		}
		private void UpdateStockProducts()
		{
			foreach (var i in listProductsInOrders)
			{
				var count = Count(i);
				string query = $"UPDATE Stock SET Count = @count WHERE IdProduct={i}";
				var connect = Connection.Connect();
				connect.Open();
				SqlCommand command = new SqlCommand(query, connect);
				SqlParameter parameter = new SqlParameter("@count", count - 1);
				command.Parameters.Add(parameter);
				command.ExecuteNonQuery();
				connect.Close();
			}
		}
		private int Count(int i)
		{
			string sql = $"SELECT Stock.Count FROM Stock WHERE Stock.IdProduct={i}";

			using (var connection = Connection.Connect())
			{
				connection.Open();
				SqlCommand command = new SqlCommand(sql, connection);

				using (SqlDataReader reader = command.ExecuteReader())
				{

					while (reader.Read())
					{

						return reader.GetInt32(0);

					}
				}
			}

			return 0;
		}
	}
}