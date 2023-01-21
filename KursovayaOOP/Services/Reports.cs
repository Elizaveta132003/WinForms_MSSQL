using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursovayaOOP.Services
{
	public class Reports
	{
		List<string[]> listProductInStock = new List<string[]>();
		List<string[]> listSoldProduct = new List<string[]>();

		private void ReadForDataBaseProductsInStock() => ReadByDataBase.Read("SELECT Products.ProductName, Stock.Count FROM Stock INNER JOIN Products ON Stock.IdProduct=Products.Id", InputInDateGridViewProducts);

		private void InputInDateGridViewProducts(SqlDataReader reader)
		{
			listProductInStock.Add(new string[2]);
			listProductInStock[listProductInStock.Count - 1][0] = reader[0].ToString();
			listProductInStock[listProductInStock.Count - 1][1] = reader[1].ToString();
		}

		public void CreateReportAboutProductsInStock(DataGridView dateGridView)
		{
			ReadForDataBaseProductsInStock();

			foreach (var product in listProductInStock)
			{
				dateGridView.Rows.Add(product);
			}
		}

		private void ReadForDataBaseSoldProducts() => ReadByDataBase.Read("SELECT TypeOfProducts.Type, Sum(OrderProducts.QuantityProducts) AS SumOfQuantityProducts FROM TypeOfProducts INNER JOIN (Products INNER JOIN OrderProducts ON Products.Id = OrderProducts.IdProduct) ON TypeOfProducts.Id = Products.ProductTypeCode GROUP BY TypeOfProducts.Type", InputInDateGridViewSoldProducts);

		private void InputInDateGridViewSoldProducts(SqlDataReader reader)
		{
			listSoldProduct.Add(new string[2]);
			listSoldProduct[listSoldProduct.Count - 1][0] = reader[0].ToString();
			listSoldProduct[listSoldProduct.Count - 1][1] = reader[1].ToString();
		}

		public void CreateReportAboutSoldProducts(DataGridView dateGridView)
		{
			ReadForDataBaseSoldProducts();

			foreach (var product in listSoldProduct)
			{
				dateGridView.Rows.Add(product);
			}
		}

		public void Statistics(Chart chart, string series)
		{
			ReadForDataBaseSoldProducts();

			foreach (var i in listSoldProduct)
			{
				chart.Series[series].Points.AddXY(i[0].ToString(), i[1].ToString());
			}
		}
		public void StatisticsAboutVipClient(Chart chart, string series)
		{
			ReadForDataBaseVIP();

			foreach (var i in listSoldProduct)
			{
				chart.Series[series].Points.AddXY(i[0].ToString(), i[1].ToString());
			}
		}
		private void ReadForDataBaseVIP() => ReadByDataBase.Read("SELECT Orders.IdClient, Count(Orders.IdClient) AS CountOfIdClient FROM Orders GROUP BY Orders.IdClient;", InputInDateGridViewSoldProducts);
	}
}
