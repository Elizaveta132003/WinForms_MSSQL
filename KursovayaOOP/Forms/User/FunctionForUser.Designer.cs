namespace KursovayaOOP.Forms
{
	partial class FunctionForUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FunctionForUser));
			this.panelFunctionForUser = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAccount = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonProduct = new System.Windows.Forms.Button();
			this.buttonBasket = new System.Windows.Forms.Button();
			this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
			this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TypeOfGoods = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InputInBasket = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.buttonInputInBasket = new System.Windows.Forms.Button();
			this.panelFunctionForUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
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
			this.panelFunctionForUser.TabIndex = 0;
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
			// dataGridViewProduct
			// 
			this.dataGridViewProduct.AllowUserToAddRows = false;
			this.dataGridViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProduct,
            this.TypeOfGoods,
            this.priceProduct,
            this.InputInBasket});
			this.dataGridViewProduct.Location = new System.Drawing.Point(27, 25);
			this.dataGridViewProduct.Name = "dataGridViewProduct";
			this.dataGridViewProduct.RowHeadersWidth = 51;
			this.dataGridViewProduct.RowTemplate.Height = 24;
			this.dataGridViewProduct.Size = new System.Drawing.Size(911, 348);
			this.dataGridViewProduct.TabIndex = 1;
			// 
			// nameProduct
			// 
			this.nameProduct.HeaderText = "Название";
			this.nameProduct.MinimumWidth = 6;
			this.nameProduct.Name = "nameProduct";
			this.nameProduct.Width = 200;
			// 
			// TypeOfGoods
			// 
			this.TypeOfGoods.HeaderText = "Тип товара";
			this.TypeOfGoods.MinimumWidth = 6;
			this.TypeOfGoods.Name = "TypeOfGoods";
			this.TypeOfGoods.ReadOnly = true;
			this.TypeOfGoods.Width = 125;
			// 
			// priceProduct
			// 
			this.priceProduct.HeaderText = "Цена";
			this.priceProduct.MinimumWidth = 6;
			this.priceProduct.Name = "priceProduct";
			this.priceProduct.Width = 200;
			// 
			// InputInBasket
			// 
			this.InputInBasket.HeaderText = "Добавить";
			this.InputInBasket.MinimumWidth = 6;
			this.InputInBasket.Name = "InputInBasket";
			this.InputInBasket.Width = 125;
			// 
			// buttonInputInBasket
			// 
			this.buttonInputInBasket.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonInputInBasket.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonInputInBasket.Location = new System.Drawing.Point(320, 395);
			this.buttonInputInBasket.Name = "buttonInputInBasket";
			this.buttonInputInBasket.Size = new System.Drawing.Size(288, 29);
			this.buttonInputInBasket.TabIndex = 2;
			this.buttonInputInBasket.Text = "Добавить в корзину";
			this.buttonInputInBasket.UseVisualStyleBackColor = false;
			this.buttonInputInBasket.Click += new System.EventHandler(this.buttonInputInBasket_Click);
			// 
			// FunctionForUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 547);
			this.Controls.Add(this.buttonInputInBasket);
			this.Controls.Add(this.dataGridViewProduct);
			this.Controls.Add(this.panelFunctionForUser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FunctionForUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.Load += new System.EventHandler(this.FunctionForUser_Load);
			this.panelFunctionForUser.ResumeLayout(false);
			this.panelFunctionForUser.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridViewProduct;
		private System.Windows.Forms.Button buttonInputInBasket;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfGoods;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
		private System.Windows.Forms.DataGridViewCheckBoxColumn InputInBasket;
	}
}