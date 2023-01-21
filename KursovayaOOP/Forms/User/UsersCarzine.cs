using KursovayaOOP.Forms.DispatcherForms;
using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace KursovayaOOP.Forms
{
	public partial class UsersCarzine : Form
	{
		public Client client { get; set; }

		public List<string[]> list { get; set; }
		public int Ip { get; set; }
		public List<int> IdProduct = new List<int>();


		public UsersCarzine(Client client, List<string[]> listt = null)
		{
			InitializeComponent();
			AddToDataGredView(listt);

		}

		private void UsersCarzine_Load(object sender, EventArgs e)
		{

		}

		private void buttonProduct_Click(object sender, EventArgs e)
		{
			this.Close();
			FunctionForUser functionForUser = new FunctionForUser(client);
			functionForUser.List = list;
			functionForUser.Client = client;
			functionForUser.Show();
		}

		private void buttonBasket_Click(object sender, EventArgs e)
		{
			this.Show();
		}

		private void buttonAccount_Click(object sender, EventArgs e)
		{
			this.Close();
			UserAccaunt userAccaunt = new UserAccaunt(client);
			userAccaunt.list = list;
			userAccaunt.client = client;
			userAccaunt.Show();
		}

		private void AddToDataGredView(List<string[]> list)
		{

			foreach (var item in list)
			{
				dataGridViewBasket.Rows.Add(item);
				dataGridViewBasket.Columns["count"].DefaultCellStyle.NullValue = "1";
			}
		}


		private void buttonSaveShange_Click(object sender, EventArgs e)
		{
			double number = 0;

			for (int i = 0; i < dataGridViewBasket.Rows.Count; i++)
			{
				if (dataGridViewBasket[3, i].Value == null)
				{
					dataGridViewBasket[3, i].Value = 1;
				}
				number += (double.Parse(dataGridViewBasket[3, i].Value.ToString()) * (double.Parse(dataGridViewBasket[2, i].Value.ToString())));
			}

			textBoxFinishPrice.Text = number.ToString();
		}

		private void buttonPlaceAnOrder_Click(object sender, EventArgs e)
		{
			if (textBoxStreet.Rules().CorrectnessOfReceivedString()
				&& textBoxNumberHouse.Rules().CorrectnessOfRecivedInt()
				&& dateTimePickerDelivery.Value > DateTime.Now
				&& dataGridViewBasket.Rows.Count > 0)
			{
				if (radioButtonCashPayment.Checked)
				{
					panelIsAccutarePlaceOrder.Visible = true;
				}
				else if (radioButtonCardPayment.Checked)
				{
					panelCardData.Visible = true;
				}
				else
				{
					MessageBox.Show("Выберете способ оплаты.");
				}
			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так. Или не добавили ничего в корзину.");
			}

		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			var connect = Connection.Connect();
			connect.Open();
			string query = $"INSERT INTO Orders (IdClient,OrderDate,DateOfSgipment,Status, Price, Street, HouseNumber) VALUES(@idClient, @orderDate, @dateOfSgipment,@status,@price, @street, @houseNumber)";
			SqlCommand command = new SqlCommand(query, connect);
			command.Parameters.Add("@idClient", SqlDbType.Int).Value = client.Id;
			command.Parameters.Add("@orderDate", SqlDbType.DateTime).Value = DateTime.Now;
			command.Parameters.Add("@dateOfSgipment", SqlDbType.DateTime).Value = dateTimePickerDelivery.Value;
			command.Parameters.Add("@status", SqlDbType.VarChar).Value = "Unformulated";
			command.Parameters.Add("@price", SqlDbType.Decimal).Value = decimal.Parse(textBoxFinishPrice.Text);
			command.Parameters.Add("@street", SqlDbType.VarChar).Value = textBoxStreet.Text;
			command.Parameters.Add("@houseNumber", SqlDbType.VarChar).Value = textBoxNumberHouse.Text;
			int number = command.ExecuteNonQuery();
			ReadLateOrder();
			ReadProduct();


			for (int i = 0; i < dataGridViewBasket.Rows.Count; i++)
			{
				string sql = $"INSERT INTO OrderProducts (IdOrder,IdProduct,QuantityProducts) VALUES(@idOrder,@idProduct,@qiantityProducts)";
				SqlCommand sqlCommand = new SqlCommand(sql, connect);
				sqlCommand.Parameters.Add("@idOrder", SqlDbType.Int).Value = Ip;
				sqlCommand.Parameters.Add("@idProduct", SqlDbType.Int).Value = IdProduct[i];
				sqlCommand.Parameters.Add("@qiantityProducts", SqlDbType.Int).Value = int.Parse(dataGridViewBasket[3, i].Value.ToString());
				int count = sqlCommand.ExecuteNonQuery();
			}

			connect.Close();
			MessageBox.Show("Заказ оформлен! Спасибо, что выбрали нас!");
			ClearPlace();
		}

		private void ReadLateOrder() => ReadByDataBase.Read("SELECT * FROM Orders", GetIpOrder);

		private void GetIpOrder(SqlDataReader reader)
		{
			Ip = int.Parse(reader[0].ToString());
		}

		private void ReadProduct() => ReadByDataBase.Read("SELECT * FROM Products", GetIdProduct);

		private void GetIdProduct(SqlDataReader reader)
		{
			for (int i = 0; i < dataGridViewBasket.Rows.Count; i++)
			{
				if (reader[1].ToString() == dataGridViewBasket[0, i].Value.ToString())
				{
					IdProduct.Add(int.Parse(reader[0].ToString()));
				}
			}

		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			ClearPlace();
		}

		private void ClearPlace()
		{
			panelIsAccutarePlaceOrder.Visible = false;
			textBoxStreet.Clear();
			textBoxNumberHouse.Clear();
			radioButtonCardPayment.Checked = false;
			radioButtonCashPayment.Checked = false;
		}

		private void buttonConsentCardEntry_Click(object sender, EventArgs e)
		{
			if (textBoxCardNumber.Rules().CorrectnessOfRecivedInt() && textBoxCardNumber.Text.Length == 16
				&& textBoxMM.Rules().CorrectnessOfRecivedInt() && textBoxMM.Text.Length == 2
				&& textBoxГГ.Rules().CorrectnessOfRecivedInt() && textBoxГГ.Text.Length == 2)
			{
				Checking();
			}
			else
			{
				MessageBox.Show("Вы ввели что-то не так.");
			}
		}

		private void buttonCancelInDataCard_Click(object sender, EventArgs e)
		{
			panelCardData.Visible = false;
			ClearPlace();
		}

		private void Checking()
		{
			if (Int64.Parse(textBoxCardNumber.Text).CheckingExistenceCard())
			{
				CheckingMoney();
			}
			else
			{
				MessageBox.Show("Данная карта не найдена. Повторите ввод.");
			}
		}

		private void CheckingMoney()
		{
			if (Int64.Parse(textBoxCardNumber.Text).CheckingAvailabilityMoneyOnTheCard())
			{
				panelCardData.Visible = false;
				panelIsAccutarePlaceOrder.Visible = true;
			}
			else
			{
				MessageBox.Show("Недостаточно средств на карте.");
			}
		}

		private List<OrderItem> ListProductOrder()
		{
			List<OrderItem> listOrderItem = new List<OrderItem>();

			for (int i = 0; i < dataGridViewBasket.Rows.Count; i++)
			{
				string name = dataGridViewBasket[0, i].ToString();
				string typeOfGood = dataGridViewBasket[1, i].ToString();
				decimal price = decimal.Parse(dataGridViewBasket[2, i].ToString());
				int count = int.Parse(dataGridViewBasket[3, i].ToString());

				listOrderItem.Add(new OrderItem(new Product(name, typeOfGood, price), count));
			}

			return listOrderItem;
		}


	}
}
