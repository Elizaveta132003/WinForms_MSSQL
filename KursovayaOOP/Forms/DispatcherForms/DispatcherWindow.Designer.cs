namespace KursovayaOOP.Forms.DispatcherForms
{
	partial class DispatcherWindow
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispatcherWindow));
			this.dataGridViewOrdersReceived = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonPlaceOrder = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.отсортироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.планПроизводстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelCollectionProducts = new System.Windows.Forms.Panel();
			this.richTextBoxProducts = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxIdOrder = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PlaceOrder = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersReceived)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panelCollectionProducts.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewOrdersReceived
			// 
			this.dataGridViewOrdersReceived.AllowUserToAddRows = false;
			this.dataGridViewOrdersReceived.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridViewOrdersReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrdersReceived.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.IdClient,
            this.DateOrder,
            this.DateDelivery,
            this.status,
            this.Price,
            this.PlaceOrder});
			this.dataGridViewOrdersReceived.Location = new System.Drawing.Point(12, 32);
			this.dataGridViewOrdersReceived.Name = "dataGridViewOrdersReceived";
			this.dataGridViewOrdersReceived.RowHeadersWidth = 51;
			this.dataGridViewOrdersReceived.RowTemplate.Height = 24;
			this.dataGridViewOrdersReceived.Size = new System.Drawing.Size(644, 393);
			this.dataGridViewOrdersReceived.TabIndex = 0;
			this.dataGridViewOrdersReceived.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrdersReceived_CellClick_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(410, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Заказы";
			// 
			// buttonPlaceOrder
			// 
			this.buttonPlaceOrder.BackColor = System.Drawing.Color.LightSalmon;
			this.buttonPlaceOrder.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPlaceOrder.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonPlaceOrder.Location = new System.Drawing.Point(121, 440);
			this.buttonPlaceOrder.Name = "buttonPlaceOrder";
			this.buttonPlaceOrder.Size = new System.Drawing.Size(362, 33);
			this.buttonPlaceOrder.TabIndex = 2;
			this.buttonPlaceOrder.Text = "Оформить";
			this.buttonPlaceOrder.UseVisualStyleBackColor = false;
			this.buttonPlaceOrder.Click += new System.EventHandler(this.buttonPlaceOrder_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отсортироватьToolStripMenuItem,
            this.планПроизводстваToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(973, 28);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// отсортироватьToolStripMenuItem
			// 
			this.отсортироватьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.отсортироватьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеToolStripMenuItem});
			this.отсортироватьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.отсортироватьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.отсортироватьToolStripMenuItem.Name = "отсортироватьToolStripMenuItem";
			this.отсортироватьToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
			this.отсортироватьToolStripMenuItem.Text = "Отсортировать";
			// 
			// поДатеToolStripMenuItem
			// 
			this.поДатеToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.поДатеToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
			this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.поДатеToolStripMenuItem.Text = " По дате поставки";
			this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.поДатеToolStripMenuItem_Click);
			// 
			// планПроизводстваToolStripMenuItem
			// 
			this.планПроизводстваToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.планПроизводстваToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.планПроизводстваToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.планПроизводстваToolStripMenuItem.Name = "планПроизводстваToolStripMenuItem";
			this.планПроизводстваToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
			this.планПроизводстваToolStripMenuItem.Text = "План производства";
			this.планПроизводстваToolStripMenuItem.Click += new System.EventHandler(this.планПроизводстваToolStripMenuItem_Click);
			// 
			// panelCollectionProducts
			// 
			this.panelCollectionProducts.BackColor = System.Drawing.Color.Transparent;
			this.panelCollectionProducts.Controls.Add(this.richTextBoxProducts);
			this.panelCollectionProducts.Controls.Add(this.label3);
			this.panelCollectionProducts.Controls.Add(this.textBoxIdOrder);
			this.panelCollectionProducts.Controls.Add(this.label2);
			this.panelCollectionProducts.Location = new System.Drawing.Point(681, 32);
			this.panelCollectionProducts.Name = "panelCollectionProducts";
			this.panelCollectionProducts.Size = new System.Drawing.Size(280, 393);
			this.panelCollectionProducts.TabIndex = 5;
			// 
			// richTextBoxProducts
			// 
			this.richTextBoxProducts.BackColor = System.Drawing.Color.MistyRose;
			this.richTextBoxProducts.Location = new System.Drawing.Point(3, 116);
			this.richTextBoxProducts.Name = "richTextBoxProducts";
			this.richTextBoxProducts.ReadOnly = true;
			this.richTextBoxProducts.Size = new System.Drawing.Size(274, 274);
			this.richTextBoxProducts.TabIndex = 3;
			this.richTextBoxProducts.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(95, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Товары";
			// 
			// textBoxIdOrder
			// 
			this.textBoxIdOrder.Location = new System.Drawing.Point(71, 17);
			this.textBoxIdOrder.Name = "textBoxIdOrder";
			this.textBoxIdOrder.ReadOnly = true;
			this.textBoxIdOrder.Size = new System.Drawing.Size(189, 22);
			this.textBoxIdOrder.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(18, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Id";
			// 
			// idOrder
			// 
			this.idOrder.HeaderText = "Id";
			this.idOrder.MinimumWidth = 6;
			this.idOrder.Name = "idOrder";
			this.idOrder.ReadOnly = true;
			this.idOrder.Width = 125;
			// 
			// IdClient
			// 
			this.IdClient.HeaderText = "Клиент";
			this.IdClient.MinimumWidth = 6;
			this.IdClient.Name = "IdClient";
			this.IdClient.ReadOnly = true;
			this.IdClient.Width = 125;
			// 
			// DateOrder
			// 
			this.DateOrder.HeaderText = "Дата заказа";
			this.DateOrder.MinimumWidth = 6;
			this.DateOrder.Name = "DateOrder";
			this.DateOrder.ReadOnly = true;
			this.DateOrder.Width = 125;
			// 
			// DateDelivery
			// 
			dataGridViewCellStyle1.Format = "G";
			dataGridViewCellStyle1.NullValue = null;
			this.DateDelivery.DefaultCellStyle = dataGridViewCellStyle1;
			this.DateDelivery.HeaderText = "Дата поставки";
			this.DateDelivery.MinimumWidth = 6;
			this.DateDelivery.Name = "DateDelivery";
			this.DateDelivery.ReadOnly = true;
			this.DateDelivery.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.DateDelivery.Width = 125;
			// 
			// status
			// 
			this.status.HeaderText = "Статус";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.ReadOnly = true;
			this.status.Width = 125;
			// 
			// Price
			// 
			this.Price.HeaderText = "Цена";
			this.Price.MinimumWidth = 6;
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 125;
			// 
			// PlaceOrder
			// 
			this.PlaceOrder.HeaderText = "Оформить";
			this.PlaceOrder.MinimumWidth = 6;
			this.PlaceOrder.Name = "PlaceOrder";
			this.PlaceOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.PlaceOrder.Width = 125;
			// 
			// DispatcherWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(973, 485);
			this.Controls.Add(this.panelCollectionProducts);
			this.Controls.Add(this.buttonPlaceOrder);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewOrdersReceived);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "DispatcherWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrdersReceived)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelCollectionProducts.ResumeLayout(false);
			this.panelCollectionProducts.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewOrdersReceived;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonPlaceOrder;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem отсортироватьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem планПроизводстваToolStripMenuItem;
		private System.Windows.Forms.Panel panelCollectionProducts;
		private System.Windows.Forms.RichTextBox richTextBoxProducts;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxIdOrder;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewCheckBoxColumn PlaceOrder;
	}
}