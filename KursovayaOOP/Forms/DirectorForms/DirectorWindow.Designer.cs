namespace KursovayaOOP.Forms.DirectorForms
{
	partial class DirectorWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorWindow));
			this.buttonReportAvailabilityProductsInStock = new System.Windows.Forms.Button();
			this.buttonSalesReport = new System.Windows.Forms.Button();
			this.buttonStatistics = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dataGridViewAvailabilityProductsInStock = new System.Windows.Forms.DataGridView();
			this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewSalesReport = new System.Windows.Forms.DataGridView();
			this.typeProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countProductsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelStatistics = new System.Windows.Forms.Panel();
			this.chartVIPClients = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.buttonVipClients = new System.Windows.Forms.Button();
			this.buttonBestSoldProduct = new System.Windows.Forms.Button();
			this.chartBestSellingProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityProductsInStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).BeginInit();
			this.panelStatistics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartVIPClients)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBestSellingProducts)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonReportAvailabilityProductsInStock
			// 
			this.buttonReportAvailabilityProductsInStock.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonReportAvailabilityProductsInStock.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonReportAvailabilityProductsInStock.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonReportAvailabilityProductsInStock.Location = new System.Drawing.Point(0, 429);
			this.buttonReportAvailabilityProductsInStock.Name = "buttonReportAvailabilityProductsInStock";
			this.buttonReportAvailabilityProductsInStock.Size = new System.Drawing.Size(321, 56);
			this.buttonReportAvailabilityProductsInStock.TabIndex = 0;
			this.buttonReportAvailabilityProductsInStock.Text = "Отчет о наличии продукции на складе";
			this.buttonReportAvailabilityProductsInStock.UseVisualStyleBackColor = false;
			this.buttonReportAvailabilityProductsInStock.Click += new System.EventHandler(this.buttonReportAvailabilityProductsInStock_Click);
			// 
			// buttonSalesReport
			// 
			this.buttonSalesReport.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonSalesReport.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonSalesReport.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonSalesReport.Location = new System.Drawing.Point(319, 429);
			this.buttonSalesReport.Name = "buttonSalesReport";
			this.buttonSalesReport.Size = new System.Drawing.Size(338, 56);
			this.buttonSalesReport.TabIndex = 1;
			this.buttonSalesReport.Text = "Отчет по продажам";
			this.buttonSalesReport.UseVisualStyleBackColor = false;
			this.buttonSalesReport.Click += new System.EventHandler(this.buttonSalesReport_Click);
			// 
			// buttonStatistics
			// 
			this.buttonStatistics.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonStatistics.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonStatistics.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonStatistics.Location = new System.Drawing.Point(654, 429);
			this.buttonStatistics.Name = "buttonStatistics";
			this.buttonStatistics.Size = new System.Drawing.Size(318, 56);
			this.buttonStatistics.TabIndex = 2;
			this.buttonStatistics.Text = "Статистика";
			this.buttonStatistics.UseVisualStyleBackColor = false;
			this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSalmon;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Location = new System.Drawing.Point(0, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(972, 22);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(0, 28);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(972, 394);
			this.panel2.TabIndex = 6;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.SeaShell;
			this.textBox1.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.textBox1.Location = new System.Drawing.Point(269, -4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(418, 26);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "О  А  О     Г  о  м  е  л  ь  х  л  е  б  п  р  о  д  у  к  т";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dataGridViewAvailabilityProductsInStock
			// 
			this.dataGridViewAvailabilityProductsInStock.BackgroundColor = System.Drawing.Color.Linen;
			this.dataGridViewAvailabilityProductsInStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAvailabilityProductsInStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProduct,
            this.count});
			this.dataGridViewAvailabilityProductsInStock.Location = new System.Drawing.Point(188, 48);
			this.dataGridViewAvailabilityProductsInStock.Name = "dataGridViewAvailabilityProductsInStock";
			this.dataGridViewAvailabilityProductsInStock.RowHeadersWidth = 51;
			this.dataGridViewAvailabilityProductsInStock.RowTemplate.Height = 24;
			this.dataGridViewAvailabilityProductsInStock.Size = new System.Drawing.Size(605, 345);
			this.dataGridViewAvailabilityProductsInStock.TabIndex = 4;
			this.dataGridViewAvailabilityProductsInStock.Visible = false;
			// 
			// nameProduct
			// 
			this.nameProduct.HeaderText = "Товар";
			this.nameProduct.MinimumWidth = 6;
			this.nameProduct.Name = "nameProduct";
			this.nameProduct.ReadOnly = true;
			this.nameProduct.Width = 300;
			// 
			// count
			// 
			this.count.HeaderText = "Количество";
			this.count.MinimumWidth = 6;
			this.count.Name = "count";
			this.count.ReadOnly = true;
			this.count.Width = 125;
			// 
			// dataGridViewSalesReport
			// 
			this.dataGridViewSalesReport.BackgroundColor = System.Drawing.Color.Linen;
			this.dataGridViewSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeProduct,
            this.countProductsSold});
			this.dataGridViewSalesReport.Location = new System.Drawing.Point(68, 48);
			this.dataGridViewSalesReport.Name = "dataGridViewSalesReport";
			this.dataGridViewSalesReport.RowHeadersWidth = 51;
			this.dataGridViewSalesReport.RowTemplate.Height = 24;
			this.dataGridViewSalesReport.Size = new System.Drawing.Size(858, 361);
			this.dataGridViewSalesReport.TabIndex = 5;
			this.dataGridViewSalesReport.Visible = false;
			// 
			// typeProduct
			// 
			this.typeProduct.HeaderText = "Тип товара";
			this.typeProduct.MinimumWidth = 6;
			this.typeProduct.Name = "typeProduct";
			this.typeProduct.ReadOnly = true;
			this.typeProduct.Width = 125;
			// 
			// countProductsSold
			// 
			this.countProductsSold.HeaderText = "Кол-во проданных";
			this.countProductsSold.MinimumWidth = 6;
			this.countProductsSold.Name = "countProductsSold";
			this.countProductsSold.ReadOnly = true;
			this.countProductsSold.Width = 125;
			// 
			// panelStatistics
			// 
			this.panelStatistics.Controls.Add(this.chartVIPClients);
			this.panelStatistics.Controls.Add(this.buttonVipClients);
			this.panelStatistics.Controls.Add(this.buttonBestSoldProduct);
			this.panelStatistics.Controls.Add(this.chartBestSellingProducts);
			this.panelStatistics.Location = new System.Drawing.Point(3, 32);
			this.panelStatistics.Name = "panelStatistics";
			this.panelStatistics.Size = new System.Drawing.Size(966, 388);
			this.panelStatistics.TabIndex = 6;
			this.panelStatistics.Visible = false;
			// 
			// chartVIPClients
			// 
			chartArea1.Name = "ChartArea1";
			this.chartVIPClients.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chartVIPClients.Legends.Add(legend1);
			this.chartVIPClients.Location = new System.Drawing.Point(76, 45);
			this.chartVIPClients.Name = "chartVIPClients";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "VIPClients";
			this.chartVIPClients.Series.Add(series1);
			this.chartVIPClients.Size = new System.Drawing.Size(515, 300);
			this.chartVIPClients.TabIndex = 3;
			this.chartVIPClients.Text = "chart1";
			// 
			// buttonVipClients
			// 
			this.buttonVipClients.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonVipClients.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonVipClients.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.buttonVipClients.Location = new System.Drawing.Point(651, 150);
			this.buttonVipClients.Name = "buttonVipClients";
			this.buttonVipClients.Size = new System.Drawing.Size(278, 35);
			this.buttonVipClients.TabIndex = 2;
			this.buttonVipClients.Text = "VIP клиенты";
			this.buttonVipClients.UseVisualStyleBackColor = false;
			this.buttonVipClients.Click += new System.EventHandler(this.buttonVipClients_Click);
			// 
			// buttonBestSoldProduct
			// 
			this.buttonBestSoldProduct.BackColor = System.Drawing.Color.PowderBlue;
			this.buttonBestSoldProduct.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonBestSoldProduct.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.buttonBestSoldProduct.Location = new System.Drawing.Point(651, 62);
			this.buttonBestSoldProduct.Name = "buttonBestSoldProduct";
			this.buttonBestSoldProduct.Size = new System.Drawing.Size(278, 35);
			this.buttonBestSoldProduct.TabIndex = 1;
			this.buttonBestSoldProduct.Text = "Наиболее продоваемый продукт";
			this.buttonBestSoldProduct.UseVisualStyleBackColor = false;
			this.buttonBestSoldProduct.Click += new System.EventHandler(this.buttonBestSoldProduct_Click);
			// 
			// chartBestSellingProducts
			// 
			chartArea2.Name = "ChartArea1";
			this.chartBestSellingProducts.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chartBestSellingProducts.Legends.Add(legend2);
			this.chartBestSellingProducts.Location = new System.Drawing.Point(76, 45);
			this.chartBestSellingProducts.Name = "chartBestSellingProducts";
			series2.ChartArea = "ChartArea1";
			series2.Legend = "Legend1";
			series2.Name = "BestSellingProduct";
			this.chartBestSellingProducts.Series.Add(series2);
			this.chartBestSellingProducts.Size = new System.Drawing.Size(515, 300);
			this.chartBestSellingProducts.TabIndex = 0;
			this.chartBestSellingProducts.Text = "chart1";
			this.chartBestSellingProducts.Visible = false;
			// 
			// DirectorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(973, 485);
			this.Controls.Add(this.panelStatistics);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonStatistics);
			this.Controls.Add(this.buttonSalesReport);
			this.Controls.Add(this.buttonReportAvailabilityProductsInStock);
			this.Controls.Add(this.dataGridViewSalesReport);
			this.Controls.Add(this.dataGridViewAvailabilityProductsInStock);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "DirectorWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailabilityProductsInStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalesReport)).EndInit();
			this.panelStatistics.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chartVIPClients)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartBestSellingProducts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonReportAvailabilityProductsInStock;
		private System.Windows.Forms.Button buttonSalesReport;
		private System.Windows.Forms.Button buttonStatistics;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridViewAvailabilityProductsInStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridView dataGridViewSalesReport;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn countProductsSold;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panelStatistics;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartBestSellingProducts;
		private System.Windows.Forms.Button buttonVipClients;
		private System.Windows.Forms.Button buttonBestSoldProduct;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartVIPClients;
	}
}