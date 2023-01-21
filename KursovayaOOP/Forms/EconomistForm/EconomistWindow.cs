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

namespace KursovayaOOP.Forms.EconomistForm
{
	public partial class EconomistWindow : Form
	{
		List<string[]> listProduct = new List<string[]>();
		List<(int, string)> listTypeProducts = new List<(int, string)>();
		public Economist economist { get; set; }
		public EconomistWindow()
		{
			InitializeComponent();
			ReadForDataBaseProducts();
			AddingDataToDataGridView(listProduct);

		}

		private void ReadForDataBaseProducts() => ReadByDataBase.Read("SELECT Products.Id, Products.ProductName, TypeOfProducts.Type, Products.Price, Products.Hide FROM Products INNER JOIN TypeOfProducts ON ProductTypeCode=TypeOfProducts.Id", InputInDateGridViewProducts);

		private void InputInDateGridViewProducts(SqlDataReader reader)
		{
			listProduct.Add(new string[5]);
			listProduct[listProduct.Count - 1][0] = reader[0].ToString();
			listProduct[listProduct.Count - 1][1] = reader[1].ToString();
			listProduct[listProduct.Count - 1][2] = reader[2].ToString();
			listProduct[listProduct.Count - 1][3] = reader[3].ToString();
			listProduct[listProduct.Count - 1][4] = reader[4].ToString();
		}

		private void AddingDataToDataGridView(List<string[]> list)
		{
			foreach (string[] item in listProduct)
			{
				dataGridViewProducts.Rows.Add(item);
			}
		}

		private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CollectionTypeProducts();

			foreach (var i in listTypeProducts)
			{
				comboBoxTypeProduct.Items.Add(i.Item2);
			}

			panelAddproduct.Visible = true;
		}

		private void CollectionTypeProducts() => ReadByDataBase.Read("SELECT * FROM TypeOfProducts", ReadProductsType);
		private void ReadProductsType(SqlDataReader reader)
		{
			listTypeProducts.Add((reader.GetInt32(0), reader.GetString(1)));
		}

		private void buttonAddProductInDataBase_Click(object sender, EventArgs e)
		{
			if (textBoxNameProduct.Rules().CheckingNumberOfCharacters(3)
				&& textBoxPriceProduct.Rules().CorrectnessOfDecimal()
				&& comboBoxTypeProduct.SelectedItem != null)
			{
				AddProduct();
				textBoxNameProduct.Clear();
				textBoxPriceProduct.Clear();
				comboBoxTypeProduct.SelectedItem = null;
				panelAddproduct.Visible = false;
				dataGridViewProducts.Rows.Clear();
				listProduct.Clear();
				ReadForDataBaseProducts();
				AddingDataToDataGridView(listProduct);
			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так. Проверить ввод.");
			}
		}

		private void AddProduct()
		{
			var nameProduct = textBoxNameProduct.Text;
			var priceProduct = decimal.Parse(textBoxPriceProduct.Text);
			var typeProduct = comboBoxTypeProduct.SelectedItem.ToString();

			var idType = 0;

			foreach (var item in listTypeProducts)
			{
				if (item.Item2 == typeProduct)
				{
					idType = item.Item1;
				}
			}

			var connect = Connection.Connect();
			connect.Open();
			string query = $"INSERT INTO Products (ProductName, ProductTypeCode, Price, Hide) VALUES(@productName,@productTypeCode,@price, @hide)";

			SqlCommand command = new SqlCommand(query, connect);
			command.Parameters.Add("@productName", SqlDbType.VarChar).Value = nameProduct;
			command.Parameters.Add("@productTypeCode", SqlDbType.Int).Value = idType;
			command.Parameters.Add("@price", SqlDbType.Decimal).Value = priceProduct;
			command.Parameters.Add("@hide", SqlDbType.Int).Value = 0;
			int number = command.ExecuteNonQuery();
			connect.Close();


		}

		private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridViewProducts.RowCount; i++)
			{
				if (dataGridViewProducts[0, i].Selected && int.Parse(dataGridViewProducts[4, i].Value.ToString()) == 0)
				{
					string query = $"UPDATE Products SET Hide=@hide WHERE Id={int.Parse(dataGridViewProducts[0, i].Value.ToString())}";
					var connect = Connection.Connect();
					connect.Open();
					SqlCommand command = new SqlCommand(query, connect);
					SqlParameter parameter = new SqlParameter("@hide", 1);

					command.Parameters.Add(parameter);


					command.ExecuteNonQuery();
					connect.Close();
				}
			}

			dataGridViewProducts.Rows.Clear();
			listProduct.Clear();
			ReadForDataBaseProducts();
			AddingDataToDataGridView(listProduct);
		}

		private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridViewProducts.RowCount; i++)
			{
				if (dataGridViewProducts[3, i].Selected)
				{
					string query = $"UPDATE Products SET Price=@price WHERE Id={int.Parse(dataGridViewProducts[0, i].Value.ToString())}";
					var connect = Connection.Connect();
					connect.Open();
					SqlCommand command = new SqlCommand(query, connect);
					SqlParameter parameter = new SqlParameter("@price", decimal.Parse(dataGridViewProducts[3, i].Value.ToString()));

					command.Parameters.Add(parameter);
					command.ExecuteNonQuery();
					connect.Close();
				}
			}
		}
	}
}
