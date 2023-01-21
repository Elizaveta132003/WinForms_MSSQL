namespace KursovayaOOP.Forms.EconomistForm
{
	partial class EconomistWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EconomistWindow));
			this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
			this.idProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hideProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelAddproduct = new System.Windows.Forms.Panel();
			this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
			this.buttonAddProductInDataBase = new System.Windows.Forms.Button();
			this.textBoxPriceProduct = new System.Windows.Forms.TextBox();
			this.textBoxNameProduct = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.panelAddproduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewProducts
			// 
			this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.PeachPuff;
			this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduct,
            this.nameProduct,
            this.typeOfProduct,
            this.priceProduct,
            this.hideProduct});
			this.dataGridViewProducts.Location = new System.Drawing.Point(159, 45);
			this.dataGridViewProducts.Name = "dataGridViewProducts";
			this.dataGridViewProducts.RowHeadersWidth = 51;
			this.dataGridViewProducts.RowTemplate.Height = 24;
			this.dataGridViewProducts.Size = new System.Drawing.Size(634, 393);
			this.dataGridViewProducts.TabIndex = 0;
			// 
			// idProduct
			// 
			this.idProduct.HeaderText = "Id";
			this.idProduct.MinimumWidth = 6;
			this.idProduct.Name = "idProduct";
			this.idProduct.ReadOnly = true;
			this.idProduct.Width = 125;
			// 
			// nameProduct
			// 
			this.nameProduct.HeaderText = "Название";
			this.nameProduct.MinimumWidth = 6;
			this.nameProduct.Name = "nameProduct";
			this.nameProduct.ReadOnly = true;
			this.nameProduct.Width = 180;
			// 
			// typeOfProduct
			// 
			this.typeOfProduct.HeaderText = "Тип товара";
			this.typeOfProduct.MinimumWidth = 6;
			this.typeOfProduct.Name = "typeOfProduct";
			this.typeOfProduct.ReadOnly = true;
			this.typeOfProduct.Width = 150;
			// 
			// priceProduct
			// 
			this.priceProduct.HeaderText = "Цена";
			this.priceProduct.MinimumWidth = 6;
			this.priceProduct.Name = "priceProduct";
			this.priceProduct.Width = 125;
			// 
			// hideProduct
			// 
			this.hideProduct.HeaderText = "Hide";
			this.hideProduct.MinimumWidth = 6;
			this.hideProduct.Name = "hideProduct";
			this.hideProduct.ReadOnly = true;
			this.hideProduct.Width = 125;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(425, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Товары";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(973, 26);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.добавитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.добавитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.удалитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(74, 22);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// изменитьToolStripMenuItem
			// 
			this.изменитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
			this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
			this.изменитьToolStripMenuItem.Text = "Изменить";
			this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
			// 
			// panelAddproduct
			// 
			this.panelAddproduct.BackColor = System.Drawing.Color.Bisque;
			this.panelAddproduct.Controls.Add(this.comboBoxTypeProduct);
			this.panelAddproduct.Controls.Add(this.buttonAddProductInDataBase);
			this.panelAddproduct.Controls.Add(this.textBoxPriceProduct);
			this.panelAddproduct.Controls.Add(this.textBoxNameProduct);
			this.panelAddproduct.Controls.Add(this.label4);
			this.panelAddproduct.Controls.Add(this.label3);
			this.panelAddproduct.Controls.Add(this.label2);
			this.panelAddproduct.Location = new System.Drawing.Point(274, 107);
			this.panelAddproduct.Name = "panelAddproduct";
			this.panelAddproduct.Size = new System.Drawing.Size(366, 230);
			this.panelAddproduct.TabIndex = 3;
			this.panelAddproduct.Visible = false;
			// 
			// comboBoxTypeProduct
			// 
			this.comboBoxTypeProduct.FormattingEnabled = true;
			this.comboBoxTypeProduct.Location = new System.Drawing.Point(138, 74);
			this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
			this.comboBoxTypeProduct.Size = new System.Drawing.Size(213, 24);
			this.comboBoxTypeProduct.TabIndex = 7;
			// 
			// buttonAddProductInDataBase
			// 
			this.buttonAddProductInDataBase.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonAddProductInDataBase.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddProductInDataBase.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonAddProductInDataBase.Location = new System.Drawing.Point(55, 178);
			this.buttonAddProductInDataBase.Name = "buttonAddProductInDataBase";
			this.buttonAddProductInDataBase.Size = new System.Drawing.Size(252, 31);
			this.buttonAddProductInDataBase.TabIndex = 6;
			this.buttonAddProductInDataBase.Text = "Добавить";
			this.buttonAddProductInDataBase.UseVisualStyleBackColor = false;
			this.buttonAddProductInDataBase.Click += new System.EventHandler(this.buttonAddProductInDataBase_Click);
			// 
			// textBoxPriceProduct
			// 
			this.textBoxPriceProduct.Location = new System.Drawing.Point(138, 120);
			this.textBoxPriceProduct.Name = "textBoxPriceProduct";
			this.textBoxPriceProduct.Size = new System.Drawing.Size(213, 22);
			this.textBoxPriceProduct.TabIndex = 5;
			// 
			// textBoxNameProduct
			// 
			this.textBoxNameProduct.Location = new System.Drawing.Point(138, 30);
			this.textBoxNameProduct.Name = "textBoxNameProduct";
			this.textBoxNameProduct.Size = new System.Drawing.Size(213, 22);
			this.textBoxNameProduct.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(68, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 21);
			this.label4.TabIndex = 2;
			this.label4.Text = "Цена";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(22, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Тип товара";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(34, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Название";
			// 
			// EconomistWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(973, 485);
			this.Controls.Add(this.panelAddproduct);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewProducts);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "EconomistWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelAddproduct.ResumeLayout(false);
			this.panelAddproduct.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewProducts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
		private System.Windows.Forms.Panel panelAddproduct;
		private System.Windows.Forms.TextBox textBoxPriceProduct;
		private System.Windows.Forms.TextBox textBoxNameProduct;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonAddProductInDataBase;
		private System.Windows.Forms.ComboBox comboBoxTypeProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn idProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeOfProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceProduct;
		private System.Windows.Forms.DataGridViewTextBoxColumn hideProduct;
	}
}