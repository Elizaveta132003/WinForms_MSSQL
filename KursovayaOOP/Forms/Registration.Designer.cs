namespace KursovayaOOP.Forms
{
	partial class Registration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
			this.label1 = new System.Windows.Forms.Label();
			this.nameOrganizationTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.SignUpButton = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Candara", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(379, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Registration";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nameOrganizationTextBox
			// 
			this.nameOrganizationTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameOrganizationTextBox.Location = new System.Drawing.Point(318, 240);
			this.nameOrganizationTextBox.Name = "nameOrganizationTextBox";
			this.nameOrganizationTextBox.Size = new System.Drawing.Size(295, 32);
			this.nameOrganizationTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(314, 213);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name organization";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(314, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(134, 24);
			this.label3.TabIndex = 3;
			this.label3.Text = "Phone number";
			// 
			// phoneNumberTextBox
			// 
			this.phoneNumberTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.phoneNumberTextBox.Location = new System.Drawing.Point(318, 309);
			this.phoneNumberTextBox.Name = "phoneNumberTextBox";
			this.phoneNumberTextBox.Size = new System.Drawing.Size(295, 32);
			this.phoneNumberTextBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(314, 355);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 24);
			this.label4.TabIndex = 5;
			this.label4.Text = "Password";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.passwordTextBox.Location = new System.Drawing.Point(318, 382);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(295, 32);
			this.passwordTextBox.TabIndex = 6;
			this.passwordTextBox.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			// 
			// SignUpButton
			// 
			this.SignUpButton.BackColor = System.Drawing.Color.PeachPuff;
			this.SignUpButton.DialogResult = System.Windows.Forms.DialogResult.Retry;
			this.SignUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.SignUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignUpButton.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SignUpButton.ForeColor = System.Drawing.Color.SaddleBrown;
			this.SignUpButton.Location = new System.Drawing.Point(385, 439);
			this.SignUpButton.Name = "SignUpButton";
			this.SignUpButton.Size = new System.Drawing.Size(170, 38);
			this.SignUpButton.TabIndex = 7;
			this.SignUpButton.Text = "Sign up";
			this.SignUpButton.UseVisualStyleBackColor = false;
			this.SignUpButton.Click += new System.EventHandler(this.button1_Click);
			this.SignUpButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
			this.SignUpButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label5.Location = new System.Drawing.Point(417, 489);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 18);
			this.label5.TabIndex = 8;
			this.label5.Text = "Есть аккаунт?";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Candara", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.LinkColor = System.Drawing.Color.SaddleBrown;
			this.linkLabel1.Location = new System.Drawing.Point(387, 513);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(168, 21);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Войти в приложение";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(962, 543);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.SignUpButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.phoneNumberTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameOrganizationTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Registration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.Load += new System.EventHandler(this.Registration_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameOrganizationTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Button SignUpButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel linkLabel1;
	}
}