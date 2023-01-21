using KursovayaOOP.Modals;
using KursovayaOOP.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovayaOOP.Forms.DirectorForms
{
	public partial class DirectorWindow : Form
	{
		List<string[]> listProductInStock = new List<string[]>();
		List<string[]> listSoldProduct = new List<string[]>();
		public Director director { get; set; }
		public DirectorWindow()
		{
			InitializeComponent();
		}

		private void buttonReportAvailabilityProductsInStock_Click(object sender, EventArgs e)
		{
			Reports reports = new Reports();
			panelStatistics.Visible = false;
			dataGridViewAvailabilityProductsInStock.Rows.Clear();
			dataGridViewAvailabilityProductsInStock.Visible = true;
			dataGridViewSalesReport.Visible = false;
			reports.CreateReportAboutProductsInStock(dataGridViewAvailabilityProductsInStock);
		}

		private void buttonSalesReport_Click(object sender, EventArgs e)
		{
			Reports reports = new Reports();
			panelStatistics.Visible = false;
			dataGridViewSalesReport.Rows.Clear();
			dataGridViewAvailabilityProductsInStock.Visible = false;
			dataGridViewSalesReport.Visible = true;
			reports.CreateReportAboutSoldProducts(dataGridViewSalesReport);
		}

		private void AddChart()
		{
			Reports reports = new Reports();
			chartBestSellingProducts.Series[0].Points.Clear();
			reports.Statistics(chartBestSellingProducts, "BestSellingProduct");
		}

		private void buttonStatistics_Click(object sender, EventArgs e)
		{
			panelStatistics.Visible = true;

		}

		private void buttonBestSoldProduct_Click(object sender, EventArgs e)
		{
			AddChart();
			chartVIPClients.Visible = false;
			chartBestSellingProducts.Visible = true;
		}

		private void buttonVipClients_Click(object sender, EventArgs e)
		{
			AddVipClientsAtChart();
			chartBestSellingProducts.Visible = false;
			chartVIPClients.Visible = true;
		}
		private void AddVipClientsAtChart()
		{
			Reports reports = new Reports();
			chartVIPClients.Series[0].Points.Clear();
			reports.StatisticsAboutVipClient(chartVIPClients, "VIPClients");
		}
	}
}
