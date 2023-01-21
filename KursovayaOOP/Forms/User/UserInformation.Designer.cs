namespace KursovayaOOP.Forms
{
	partial class UserInformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformation));
			this.panelFunctionForUser = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonAccount = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonProduct = new System.Windows.Forms.Button();
			this.buttonBasket = new System.Windows.Forms.Button();
			this.buttonMyOrders = new System.Windows.Forms.Button();
			this.buttonAboutMe = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNameOfOrganization = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.buttonChange = new System.Windows.Forms.Button();
			this.buttonOKChange = new System.Windows.Forms.Button();
			this.panelFunctionForUser.SuspendLayout();
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
			this.panelFunctionForUser.TabIndex = 2;
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
			// buttonMyOrders
			// 
			this.buttonMyOrders.BackColor = System.Drawing.Color.Bisque;
			this.buttonMyOrders.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonMyOrders.Location = new System.Drawing.Point(488, 0);
			this.buttonMyOrders.Name = "buttonMyOrders";
			this.buttonMyOrders.Size = new System.Drawing.Size(478, 41);
			this.buttonMyOrders.TabIndex = 3;
			this.buttonMyOrders.Text = "МОИ ЗАКАЗЫ";
			this.buttonMyOrders.UseVisualStyleBackColor = false;
			this.buttonMyOrders.Click += new System.EventHandler(this.buttonMyOrders_Click);
			// 
			// buttonAboutMe
			// 
			this.buttonAboutMe.BackColor = System.Drawing.Color.Bisque;
			this.buttonAboutMe.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAboutMe.Location = new System.Drawing.Point(0, 0);
			this.buttonAboutMe.Name = "buttonAboutMe";
			this.buttonAboutMe.Size = new System.Drawing.Size(490, 41);
			this.buttonAboutMe.TabIndex = 4;
			this.buttonAboutMe.Text = "ОБО МНЕ";
			this.buttonAboutMe.UseVisualStyleBackColor = false;
			this.buttonAboutMe.Click += new System.EventHandler(this.buttonAboutMe_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(160, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 21);
			this.label4.TabIndex = 5;
			this.label4.Text = "Название организации";
			// 
			// textBoxNameOfOrganization
			// 
			this.textBoxNameOfOrganization.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNameOfOrganization.Location = new System.Drawing.Point(372, 120);
			this.textBoxNameOfOrganization.Name = "textBoxNameOfOrganization";
			this.textBoxNameOfOrganization.ReadOnly = true;
			this.textBoxNameOfOrganization.Size = new System.Drawing.Size(450, 26);
			this.textBoxNameOfOrganization.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(203, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 21);
			this.label5.TabIndex = 7;
			this.label5.Text = "Номер телефона";
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(372, 164);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.ReadOnly = true;
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(450, 26);
			this.textBoxPhoneNumber.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(275, 204);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 21);
			this.label6.TabIndex = 9;
			this.label6.Text = "Пароль";
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassword.Location = new System.Drawing.Point(372, 204);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.ReadOnly = true;
			this.textBoxPassword.Size = new System.Drawing.Size(450, 26);
			this.textBoxPassword.TabIndex = 10;
			// 
			// buttonChange
			// 
			this.buttonChange.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonChange.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonChange.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonChange.Location = new System.Drawing.Point(289, 305);
			this.buttonChange.Name = "buttonChange";
			this.buttonChange.Size = new System.Drawing.Size(377, 30);
			this.buttonChange.TabIndex = 11;
			this.buttonChange.Text = "Изменить";
			this.buttonChange.UseVisualStyleBackColor = false;
			this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
			// 
			// buttonOKChange
			// 
			this.buttonOKChange.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonOKChange.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonOKChange.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonOKChange.Location = new System.Drawing.Point(289, 270);
			this.buttonOKChange.Name = "buttonOKChange";
			this.buttonOKChange.Size = new System.Drawing.Size(377, 29);
			this.buttonOKChange.TabIndex = 12;
			this.buttonOKChange.Text = "OK";
			this.buttonOKChange.UseVisualStyleBackColor = false;
			this.buttonOKChange.Visible = false;
			this.buttonOKChange.Click += new System.EventHandler(this.buttonOKChange_Click);
			// 
			// UserInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(966, 547);
			this.Controls.Add(this.buttonOKChange);
			this.Controls.Add(this.buttonChange);
			this.Controls.Add(this.textBoxPassword);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxPhoneNumber);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBoxNameOfOrganization);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.buttonAboutMe);
			this.Controls.Add(this.buttonMyOrders);
			this.Controls.Add(this.panelFunctionForUser);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UserInformation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.Load += new System.EventHandler(this.UserInformation_Load);
			this.panelFunctionForUser.ResumeLayout(false);
			this.panelFunctionForUser.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelFunctionForUser;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonAccount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonProduct;
		private System.Windows.Forms.Button buttonBasket;
		private System.Windows.Forms.Button buttonMyOrders;
		private System.Windows.Forms.Button buttonAboutMe;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBoxNameOfOrganization;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.Button buttonChange;
		private System.Windows.Forms.Button buttonOKChange;
	}
}