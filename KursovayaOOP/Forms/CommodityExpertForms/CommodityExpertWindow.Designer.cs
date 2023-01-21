namespace KursovayaOOP.Forms.CommodityExpertForms
{
	partial class CommodityExpertWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommodityExpertWindow));
			this.dataGridViewAllOrder = new System.Windows.Forms.DataGridView();
			this.idOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDelivered = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.menuStripOrderNow = new System.Windows.Forms.MenuStrip();
			this.заказыНаСегодняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.доставленоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelInvoice = new System.Windows.Forms.Panel();
			this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBoxDeliveryConditions = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.dataGridViewProductInOrder = new System.Windows.Forms.DataGridView();
			this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.unitMeasurement = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxAddressPayer = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxNameOrganizationPayer = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxRegistrationDate = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxNumberInvoice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOK = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrder)).BeginInit();
			this.menuStripOrderNow.SuspendLayout();
			this.panelInvoice.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInOrder)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAllOrder
			// 
			this.dataGridViewAllOrder.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridViewAllOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAllOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrder,
            this.idClient,
            this.dateDelivery,
            this.status,
            this.price,
            this.orderDelivered});
			this.dataGridViewAllOrder.Location = new System.Drawing.Point(12, 64);
			this.dataGridViewAllOrder.Name = "dataGridViewAllOrder";
			this.dataGridViewAllOrder.RowHeadersWidth = 51;
			this.dataGridViewAllOrder.RowTemplate.Height = 24;
			this.dataGridViewAllOrder.Size = new System.Drawing.Size(938, 408);
			this.dataGridViewAllOrder.TabIndex = 0;
			this.dataGridViewAllOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllOrder_CellClick);
			// 
			// idOrder
			// 
			this.idOrder.HeaderText = "Id заказа";
			this.idOrder.MinimumWidth = 6;
			this.idOrder.Name = "idOrder";
			this.idOrder.Width = 125;
			// 
			// idClient
			// 
			this.idClient.HeaderText = "Id клиента";
			this.idClient.MinimumWidth = 6;
			this.idClient.Name = "idClient";
			this.idClient.Width = 125;
			// 
			// dateDelivery
			// 
			this.dateDelivery.HeaderText = "Дата поставки";
			this.dateDelivery.MinimumWidth = 6;
			this.dateDelivery.Name = "dateDelivery";
			this.dateDelivery.Width = 125;
			// 
			// status
			// 
			this.status.HeaderText = "Статус";
			this.status.MinimumWidth = 6;
			this.status.Name = "status";
			this.status.Width = 125;
			// 
			// price
			// 
			this.price.HeaderText = "Цена";
			this.price.MinimumWidth = 6;
			this.price.Name = "price";
			this.price.Width = 125;
			// 
			// orderDelivered
			// 
			this.orderDelivered.HeaderText = "Доставлено";
			this.orderDelivered.MinimumWidth = 6;
			this.orderDelivered.Name = "orderDelivered";
			this.orderDelivered.ReadOnly = true;
			this.orderDelivered.Width = 125;
			// 
			// menuStripOrderNow
			// 
			this.menuStripOrderNow.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStripOrderNow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыНаСегодняToolStripMenuItem,
            this.доставленоToolStripMenuItem});
			this.menuStripOrderNow.Location = new System.Drawing.Point(0, 0);
			this.menuStripOrderNow.Name = "menuStripOrderNow";
			this.menuStripOrderNow.Size = new System.Drawing.Size(966, 29);
			this.menuStripOrderNow.TabIndex = 1;
			this.menuStripOrderNow.Text = "menuStrip1";
			// 
			// заказыНаСегодняToolStripMenuItem
			// 
			this.заказыНаСегодняToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.заказыНаСегодняToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.заказыНаСегодняToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.заказыНаСегодняToolStripMenuItem.Name = "заказыНаСегодняToolStripMenuItem";
			this.заказыНаСегодняToolStripMenuItem.Size = new System.Drawing.Size(163, 25);
			this.заказыНаСегодняToolStripMenuItem.Text = "Заказы на сегодня";
			this.заказыНаСегодняToolStripMenuItem.Click += new System.EventHandler(this.заказыНаСегодняToolStripMenuItem_Click);
			// 
			// доставленоToolStripMenuItem
			// 
			this.доставленоToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.доставленоToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.доставленоToolStripMenuItem.Name = "доставленоToolStripMenuItem";
			this.доставленоToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
			this.доставленоToolStripMenuItem.Text = "Доставлено";
			this.доставленоToolStripMenuItem.Click += new System.EventHandler(this.доставленоToolStripMenuItem_Click);
			// 
			// panelInvoice
			// 
			this.panelInvoice.BackColor = System.Drawing.Color.White;
			this.panelInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelInvoice.Controls.Add(this.textBoxTotalPrice);
			this.panelInvoice.Controls.Add(this.label16);
			this.panelInvoice.Controls.Add(this.label15);
			this.panelInvoice.Controls.Add(this.label14);
			this.panelInvoice.Controls.Add(this.textBox6);
			this.panelInvoice.Controls.Add(this.label13);
			this.panelInvoice.Controls.Add(this.label12);
			this.panelInvoice.Controls.Add(this.label11);
			this.panelInvoice.Controls.Add(this.textBoxDeliveryConditions);
			this.panelInvoice.Controls.Add(this.label10);
			this.panelInvoice.Controls.Add(this.dataGridViewProductInOrder);
			this.panelInvoice.Controls.Add(this.textBoxAddressPayer);
			this.panelInvoice.Controls.Add(this.label9);
			this.panelInvoice.Controls.Add(this.textBoxNameOrganizationPayer);
			this.panelInvoice.Controls.Add(this.label8);
			this.panelInvoice.Controls.Add(this.label7);
			this.panelInvoice.Controls.Add(this.label6);
			this.panelInvoice.Controls.Add(this.textBoxRegistrationDate);
			this.panelInvoice.Controls.Add(this.label5);
			this.panelInvoice.Controls.Add(this.textBoxNumberInvoice);
			this.panelInvoice.Controls.Add(this.label4);
			this.panelInvoice.Controls.Add(this.label3);
			this.panelInvoice.Controls.Add(this.label2);
			this.panelInvoice.Controls.Add(this.label1);
			this.panelInvoice.Location = new System.Drawing.Point(317, 26);
			this.panelInvoice.Name = "panelInvoice";
			this.panelInvoice.Size = new System.Drawing.Size(637, 509);
			this.panelInvoice.TabIndex = 2;
			this.panelInvoice.Visible = false;
			// 
			// textBoxTotalPrice
			// 
			this.textBoxTotalPrice.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxTotalPrice.Location = new System.Drawing.Point(471, 385);
			this.textBoxTotalPrice.Name = "textBoxTotalPrice";
			this.textBoxTotalPrice.ReadOnly = true;
			this.textBoxTotalPrice.Size = new System.Drawing.Size(104, 15);
			this.textBoxTotalPrice.TabIndex = 23;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(421, 385);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(49, 16);
			this.label16.TabIndex = 22;
			this.label16.Text = "Итого:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(15, 452);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(66, 16);
			this.label15.TabIndex = 21;
			this.label15.Text = "Подпись:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(298, 452);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(66, 16);
			this.label14.TabIndex = 20;
			this.label14.Text = "Подпись:";
			// 
			// textBox6
			// 
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox6.Location = new System.Drawing.Point(298, 431);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(289, 15);
			this.textBox6.TabIndex = 19;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label13.Location = new System.Drawing.Point(295, 412);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(115, 16);
			this.label13.TabIndex = 18;
			this.label13.Text = "ПОКУПАТЕЛЬ:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 428);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(180, 16);
			this.label12.TabIndex = 17;
			this.label12.Text = "ОАО \"Гомельхлебпродукт\"";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(15, 412);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(105, 16);
			this.label11.TabIndex = 16;
			this.label11.Text = "ПОСТАВЩИК:";
			// 
			// textBoxDeliveryConditions
			// 
			this.textBoxDeliveryConditions.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxDeliveryConditions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDeliveryConditions.Location = new System.Drawing.Point(148, 387);
			this.textBoxDeliveryConditions.Name = "textBoxDeliveryConditions";
			this.textBoxDeliveryConditions.ReadOnly = true;
			this.textBoxDeliveryConditions.Size = new System.Drawing.Size(144, 15);
			this.textBoxDeliveryConditions.TabIndex = 15;
			this.textBoxDeliveryConditions.Text = "Курьером";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 387);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 16);
			this.label10.TabIndex = 14;
			this.label10.Text = "Условие доставки:";
			// 
			// dataGridViewProductInOrder
			// 
			this.dataGridViewProductInOrder.AllowUserToAddRows = false;
			this.dataGridViewProductInOrder.BackgroundColor = System.Drawing.Color.PaleGreen;
			this.dataGridViewProductInOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductInOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProduct,
            this.count,
            this.Column1,
            this.unitMeasurement});
			this.dataGridViewProductInOrder.Location = new System.Drawing.Point(50, 197);
			this.dataGridViewProductInOrder.Name = "dataGridViewProductInOrder";
			this.dataGridViewProductInOrder.RowHeadersWidth = 51;
			this.dataGridViewProductInOrder.RowTemplate.Height = 24;
			this.dataGridViewProductInOrder.Size = new System.Drawing.Size(525, 187);
			this.dataGridViewProductInOrder.TabIndex = 13;
			// 
			// nameProduct
			// 
			this.nameProduct.Frozen = true;
			this.nameProduct.HeaderText = "Наименование";
			this.nameProduct.MinimumWidth = 6;
			this.nameProduct.Name = "nameProduct";
			this.nameProduct.Width = 125;
			// 
			// count
			// 
			this.count.HeaderText = "Кол-во";
			this.count.MinimumWidth = 6;
			this.count.Name = "count";
			this.count.Width = 125;
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Цена, руб.";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// unitMeasurement
			// 
			this.unitMeasurement.HeaderText = "Ед. изм.";
			this.unitMeasurement.MinimumWidth = 6;
			this.unitMeasurement.Name = "unitMeasurement";
			this.unitMeasurement.Width = 125;
			// 
			// textBoxAddressPayer
			// 
			this.textBoxAddressPayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxAddressPayer.Location = new System.Drawing.Point(186, 179);
			this.textBoxAddressPayer.Name = "textBoxAddressPayer";
			this.textBoxAddressPayer.Size = new System.Drawing.Size(429, 15);
			this.textBoxAddressPayer.TabIndex = 12;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(130, 178);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 16);
			this.label9.TabIndex = 11;
			this.label9.Text = "Адрес:";
			// 
			// textBoxNameOrganizationPayer
			// 
			this.textBoxNameOrganizationPayer.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxNameOrganizationPayer.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNameOrganizationPayer.Location = new System.Drawing.Point(186, 149);
			this.textBoxNameOrganizationPayer.Name = "textBoxNameOrganizationPayer";
			this.textBoxNameOrganizationPayer.Size = new System.Drawing.Size(429, 15);
			this.textBoxNameOrganizationPayer.TabIndex = 10;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(15, 149);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 16);
			this.label8.TabIndex = 9;
			this.label8.Text = "Название организации:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(15, 121);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(191, 16);
			this.label7.TabIndex = 8;
			this.label7.Text = "Плательщик и его адрес:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(378, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "От";
			// 
			// textBoxRegistrationDate
			// 
			this.textBoxRegistrationDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxRegistrationDate.Location = new System.Drawing.Point(421, 80);
			this.textBoxRegistrationDate.Name = "textBoxRegistrationDate";
			this.textBoxRegistrationDate.Size = new System.Drawing.Size(184, 15);
			this.textBoxRegistrationDate.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(390, 50);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "№";
			// 
			// textBoxNumberInvoice
			// 
			this.textBoxNumberInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxNumberInvoice.Location = new System.Drawing.Point(421, 50);
			this.textBoxNumberInvoice.Name = "textBoxNumberInvoice";
			this.textBoxNumberInvoice.Size = new System.Drawing.Size(184, 15);
			this.textBoxNumberInvoice.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(417, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(166, 21);
			this.label4.TabIndex = 3;
			this.label4.Text = "С Ч Е Т - Ф А К Т У Р А";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 50);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "246045, Гомель, ул.Олимпийская, 5 ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(62, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "ОАО \"Гомельхлебпродукт\"";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Поставщик и его адрес:";
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonOK.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOK.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonOK.Location = new System.Drawing.Point(32, 414);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(263, 48);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "Готово";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Visible = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// CommodityExpertWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 547);
			this.Controls.Add(this.panelInvoice);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.menuStripOrderNow);
			this.Controls.Add(this.dataGridViewAllOrder);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStripOrderNow;
			this.Name = "CommodityExpertWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrder)).EndInit();
			this.menuStripOrderNow.ResumeLayout(false);
			this.menuStripOrderNow.PerformLayout();
			this.panelInvoice.ResumeLayout(false);
			this.panelInvoice.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductInOrder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAllOrder;
		private System.Windows.Forms.MenuStrip menuStripOrderNow;
		private System.Windows.Forms.ToolStripMenuItem заказыНаСегодняToolStripMenuItem;
		private System.Windows.Forms.Panel panelInvoice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxRegistrationDate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxNumberInvoice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxDeliveryConditions;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dataGridViewProductInOrder;
		private System.Windows.Forms.TextBox textBoxAddressPayer;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNameOrganizationPayer;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBoxTotalPrice;
		private System.Windows.Forms.ToolStripMenuItem доставленоToolStripMenuItem;
		private System.Windows.Forms.DataGridViewTextBoxColumn idOrder;
		private System.Windows.Forms.DataGridViewTextBoxColumn idClient;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDelivery;
		private System.Windows.Forms.DataGridViewTextBoxColumn status;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewCheckBoxColumn orderDelivered;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn unitMeasurement;
	}
}