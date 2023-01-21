namespace KursovayaOOP
{
	partial class Authorization
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
			this.label1 = new System.Windows.Forms.Label();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SignInButton = new System.Windows.Forms.Button();
			this.SignUpLink = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Candara", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(379, 160);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Authorization";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoginTextBox.Location = new System.Drawing.Point(318, 240);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(295, 32);
			this.LoginTextBox.TabIndex = 1;
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PasswordTextBox.Location = new System.Drawing.Point(318, 309);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(295, 32);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(314, 213);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Phone number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(314, 282);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password";
			// 
			// SignInButton
			// 
			this.SignInButton.BackColor = System.Drawing.Color.PeachPuff;
			this.SignInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SignInButton.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SignInButton.ForeColor = System.Drawing.Color.SaddleBrown;
			this.SignInButton.Location = new System.Drawing.Point(385, 371);
			this.SignInButton.Name = "SignInButton";
			this.SignInButton.Size = new System.Drawing.Size(170, 38);
			this.SignInButton.TabIndex = 5;
			this.SignInButton.Text = "Sign In";
			this.SignInButton.UseVisualStyleBackColor = false;
			this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
			this.SignInButton.MouseEnter += new System.EventHandler(this.SignInButton_MouseEnter);
			this.SignInButton.MouseLeave += new System.EventHandler(this.SignInButton_MouseLeave);
			// 
			// SignUpLink
			// 
			this.SignUpLink.AutoSize = true;
			this.SignUpLink.BackColor = System.Drawing.Color.Transparent;
			this.SignUpLink.DisabledLinkColor = System.Drawing.Color.Transparent;
			this.SignUpLink.Font = new System.Drawing.Font("Candara", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SignUpLink.LinkColor = System.Drawing.Color.SaddleBrown;
			this.SignUpLink.Location = new System.Drawing.Point(431, 439);
			this.SignUpLink.Name = "SignUpLink";
			this.SignUpLink.Size = new System.Drawing.Size(65, 21);
			this.SignUpLink.TabIndex = 6;
			this.SignUpLink.TabStop = true;
			this.SignUpLink.Text = "Sign Up";
			this.SignUpLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLink_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Candara Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(419, 421);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 18);
			this.label4.TabIndex = 7;
			this.label4.Text = "Нет аккаунта?";
			// 
			// Authorization
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(969, 481);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.SignUpLink);
			this.Controls.Add(this.SignInButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Authorization";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			this.Load += new System.EventHandler(this.Authorization_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LoginTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button SignInButton;
		private System.Windows.Forms.LinkLabel SignUpLink;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.Label label4;
	}
}

