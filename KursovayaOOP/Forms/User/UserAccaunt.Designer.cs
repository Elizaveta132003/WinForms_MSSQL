namespace KursovayaOOP.Forms
{
	partial class UserAccaunt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAccaunt));
			this.panelFunctionForUser = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAccount = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonProduct = new System.Windows.Forms.Button();
			this.buttonBasket = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonAboutMe = new System.Windows.Forms.Button();
			this.buttonMyOrders = new System.Windows.Forms.Button();
			this.dataGridViewOrderHistory = new System.Windows.Forms.DataGridView();
			this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelFunctionForUser.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// panelFunctionForUser
			// 
			this.panelFunctionForUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelFunctionForUser.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelFunctionForUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panelFunctionForUser.Controls.Add(this.label3);
			this.panelFunctionForUser.Controls.Add(this.buttonAccount);
			this.panelFunctionForUser.Controls.Add(this.label2);
			this.panelFunctionForUser.Controls.Add(this.label1);
			this.panelFunctionForUser.Controls.Add(this.buttonProduct);
			this.panelFunctionForUser.Controls.Add(this.buttonBasket);
			this.panelFunctionForUser.Location = new System.Drawing.Point(1, 458);
			this.panelFunctionForUser.Name = "panelFunctionForUser";
			this.panelFunctionForUser.Size = new System.Drawing.Size(966, 90);
			this.panelFunctionForUser.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SandyBrown;
			this.label3.Location = new System.Drawing.Point(535, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Аккаунт";
			// 
			// buttonAccount
			// 
			this.buttonAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttonAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAccount.BackgroundImage")));
			this.buttonAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonAccount.Location = new System.Drawing.Point(532, 0);
			this.buttonAccount.Name = "buttonAccount";
			this.buttonAccount.Size = new System.Drawing.Size(75, 63);
			this.buttonAccount.TabIndex = 4;
			this.buttonAccount.UseVisualStyleBackColor = true;
			this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SandyBrown;
			this.label2.Location = new System.Drawing.Point(416, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Корзина";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SandyBrown;
			this.label1.Location = new System.Drawing.Point(284, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "Продукты";
			// 
			// buttonProduct
			// 
			this.buttonProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttonProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonProduct.BackgroundImage")));
			this.buttonProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonProduct.Location = new System.Drawing.Point(288, 0);
			this.buttonProduct.Name = "buttonProduct";
			this.buttonProduct.Size = new System.Drawing.Size(75, 63);
			this.buttonProduct.TabIndex = 1;
			this.buttonProduct.UseVisualStyleBackColor = true;
			this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
			// 
			// buttonBasket
			// 
			this.buttonBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttonBasket.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBasket.BackgroundImage")));
			this.buttonBasket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonBasket.Location = new System.Drawing.Point(406, 0);
			this.buttonBasket.Name = "buttonBasket";
			this.buttonBasket.Size = new System.Drawing.Size(84, 63);
			this.buttonBasket.TabIndex = 0;
			this.buttonBasket.UseVisualStyleBackColor = true;
			this.buttonBasket.Click += new System.EventHandler(this.buttonBasket_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Bisque;
			this.panel1.Controls.Add(this.buttonAboutMe);
			this.panel1.Controls.Add(this.buttonMyOrders);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(966, 41);
			this.panel1.TabIndex = 2;
			// 
			// buttonAboutMe
			// 
			this.buttonAboutMe.BackColor = System.Drawing.Color.Bisque;
			this.buttonAboutMe.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAboutMe.Location = new System.Drawing.Point(0, 0);
			this.buttonAboutMe.Name = "buttonAboutMe";
			this.buttonAboutMe.Size = new System.Drawing.Size(490, 41);
			this.buttonAboutMe.TabIndex = 1;
			this.buttonAboutMe.Text = "ОБО МНЕ";
			this.buttonAboutMe.UseVisualStyleBackColor = false;
			this.buttonAboutMe.Click += new System.EventHandler(this.buttonAboutMe_Click);
			// 
			// buttonMyOrders
			// 
			this.buttonMyOrders.BackColor = System.Drawing.Color.Bisque;
			this.buttonMyOrders.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMyOrders.Location = new System.Drawing.Point(488, 0);
			this.buttonMyOrders.Name = "buttonMyOrders";
			this.buttonMyOrders.Size = new System.Drawing.Size(478, 41);
			this.buttonMyOrders.TabIndex = 0;
			this.buttonMyOrders.Text = "МОИ ЗАКАЗЫ";
			this.buttonMyOrders.UseVisualStyleBackColor = false;
			this.buttonMyOrders.Click += new System.EventHandler(this.buttonMyOrders_Click);
			// 
			// dataGridViewOrderHistory
			// 
			this.dataGridViewOrderHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewOrderHistory.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridViewOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrderHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.orderDate,
            this.orderDelivery,
            this.status,
            this.price});
			this.dataGridViewOrderHistory.Location = new System.Drawing.Point(38, 63);
			this.dataGridViewOrderHistory.Name = "dataGridViewOrderHistory";
			this.dataGridViewOrderHistory.RowHeadersWidth = 51;
			this.dataGridViewOrderHistory.RowTemplate.Height = 24;
			this.dataGridViewOrderHistory.Size = new System.Drawing.Size(905, 366);
			this.dataGridViewOrderHistory.TabIndex = 3;
			// 
			// idOrder
			// 
			this.idOrder.HeaderText = "Id";
			this.idOrder.MinimumWidth = 6;
			this.idOrder.Name = "idOrder";
			this.idOrder.ReadOnly = true;
			this.idOrder.Width = 125;
			// 
			// orderDate
			// 
			this.orderDate.HeaderText = "Дата заказа";
			this.orderDate.MinimumWidth = 6;
			this.orderDate.Name = "orderDate";
			this.orderDate.ReadOnly = true;
			this.orderDate.Width = 125;
			// 
			// orderDelivery
			// 
			this.orderDelivery.HeaderText = "Дата доставки";
			this.orderDelivery.MinimumWidth = 6;
			this.orderDelivery.Name = "orderDelivery";
			this.orderDelivery.ReadOnly = true;
			this.orderDelivery.Width = 125;
			// 
			// status
			// 
			this.status.HeaderText = "Статус";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.ReadOnly = true;
			this.status.Width = 125;
			// 
			// price
			// 
			this.price.HeaderText = "Цена";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.ReadOnly = true;
			this.price.Width = 125;
			// 
			// UserAccaunt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 547);
			this.Controls.Add(this.dataGridViewOrderHistory);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelFunctionForUser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserAccaunt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.Load += new System.EventHandler(this.UserAccaunt_Load);
			this.panelFunctionForUser.ResumeLayout(false);
			this.panelFunctionForUser.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderHistory)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelFunctionForUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonProduct;
		private System.Windows.Forms.Button buttonBasket;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonAboutMe;
		private System.Windows.Forms.Button buttonMyOrders;
		private System.Windows.Forms.DataGridView dataGridViewOrderHistory;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
	}
}