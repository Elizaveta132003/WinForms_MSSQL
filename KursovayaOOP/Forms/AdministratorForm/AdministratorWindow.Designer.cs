namespace KursovayaOOP.Forms.AdministratorForm
{
	partial class AdministratorWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorWindow));
			this.buttonClients = new System.Windows.Forms.Button();
			this.buttonEmployees = new System.Windows.Forms.Button();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.idUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneNumberEmloyee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.middleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hideEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panelInputDataClient = new System.Windows.Forms.Panel();
			this.buttonAddClient = new System.Windows.Forms.Button();
			this.textBoxPassword = new System.Windows.Forms.TextBox();
			this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
			this.textBoxNameOrganization = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panelInputDataEmloyee = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBoxPosition = new System.Windows.Forms.ComboBox();
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
			this.textBoxPasswordEmloyee = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBoxNumberPhoneEmloyee = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panelPosition = new System.Windows.Forms.Panel();
			this.buttonOK = new System.Windows.Forms.Button();
			this.comboBoxPositionCode = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
			this.panelInputDataClient.SuspendLayout();
			this.panelInputDataEmloyee.SuspendLayout();
			this.panelPosition.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonClients
			// 
			this.buttonClients.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonClients.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonClients.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonClients.Location = new System.Drawing.Point(0, 451);
			this.buttonClients.Name = "buttonClients";
			this.buttonClients.Size = new System.Drawing.Size(490, 35);
			this.buttonClients.TabIndex = 0;
			this.buttonClients.Text = "Клиенты";
			this.buttonClients.UseVisualStyleBackColor = false;
			this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
			// 
			// buttonEmployees
			// 
			this.buttonEmployees.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonEmployees.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonEmployees.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonEmployees.Location = new System.Drawing.Point(487, 451);
			this.buttonEmployees.Name = "buttonEmployees";
			this.buttonEmployees.Size = new System.Drawing.Size(486, 35);
			this.buttonEmployees.TabIndex = 1;
			this.buttonEmployees.Text = "Сотрудники";
			this.buttonEmployees.UseVisualStyleBackColor = false;
			this.buttonEmployees.Click += new System.EventHandler(this.buttonEmployees_Click);
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.Bisque;
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUser,
            this.nameOrganization,
            this.phoneNumber});
			this.dataGridViewUsers.Location = new System.Drawing.Point(43, 43);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.RowHeadersWidth = 51;
			this.dataGridViewUsers.RowTemplate.Height = 24;
			this.dataGridViewUsers.Size = new System.Drawing.Size(877, 380);
			this.dataGridViewUsers.TabIndex = 2;
			// 
			// idUser
			// 
			this.idUser.HeaderText = "Id";
			this.idUser.MinimumWidth = 6;
			this.idUser.Name = "idUser";
			this.idUser.ReadOnly = true;
			this.idUser.Width = 125;
			// 
			// nameOrganization
			// 
			this.nameOrganization.HeaderText = "Название организации";
			this.nameOrganization.MinimumWidth = 6;
			this.nameOrganization.Name = "nameOrganization";
			this.nameOrganization.ReadOnly = true;
			this.nameOrganization.Width = 350;
			// 
			// phoneNumber
			// 
			this.phoneNumber.HeaderText = "Номер телефона";
			this.phoneNumber.MinimumWidth = 6;
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.ReadOnly = true;
			this.phoneNumber.Width = 350;
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
			this.menuStrip1.Size = new System.Drawing.Size(973, 29);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// добавитьToolStripMenuItem
			// 
			this.добавитьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.добавитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.добавитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
			this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(97, 25);
			this.добавитьToolStripMenuItem.Text = "Добавить";
			this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
			// 
			// удалитьToolStripMenuItem
			// 
			this.удалитьToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.удалитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.удалитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
			this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(83, 25);
			this.удалитьToolStripMenuItem.Text = "Удалить";
			this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
			// 
			// изменитьToolStripMenuItem
			// 
			this.изменитьToolStripMenuItem.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.изменитьToolStripMenuItem.ForeColor = System.Drawing.Color.SaddleBrown;
			this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
			this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
			this.изменитьToolStripMenuItem.Text = "Изменить";
			this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
			// 
			// dataGridViewEmployees
			// 
			this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.Bisque;
			this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.phoneNumberEmloyee,
            this.firstName,
            this.lastName,
            this.middleName,
            this.position,
            this.hideEmployee});
			this.dataGridViewEmployees.Location = new System.Drawing.Point(43, 65);
			this.dataGridViewEmployees.Name = "dataGridViewEmployees";
			this.dataGridViewEmployees.RowHeadersWidth = 51;
			this.dataGridViewEmployees.RowTemplate.Height = 24;
			this.dataGridViewEmployees.Size = new System.Drawing.Size(835, 380);
			this.dataGridViewEmployees.TabIndex = 4;
			this.dataGridViewEmployees.Visible = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 125;
			// 
			// phoneNumberEmloyee
			// 
			this.phoneNumberEmloyee.HeaderText = "Номер телефона";
			this.phoneNumberEmloyee.MinimumWidth = 6;
			this.phoneNumberEmloyee.Name = "phoneNumberEmloyee";
			this.phoneNumberEmloyee.ReadOnly = true;
			this.phoneNumberEmloyee.Width = 150;
			// 
			// firstName
			// 
			this.firstName.HeaderText = "Имя";
			this.firstName.MinimumWidth = 6;
			this.firstName.Name = "firstName";
			this.firstName.ReadOnly = true;
			this.firstName.Width = 125;
			// 
			// lastName
			// 
			this.lastName.HeaderText = "Фамилия";
			this.lastName.MinimumWidth = 6;
			this.lastName.Name = "lastName";
			this.lastName.ReadOnly = true;
			this.lastName.Width = 135;
			// 
			// middleName
			// 
			this.middleName.HeaderText = "Отчество";
			this.middleName.MinimumWidth = 6;
			this.middleName.Name = "middleName";
			this.middleName.ReadOnly = true;
			this.middleName.Width = 135;
			// 
			// position
			// 
			this.position.HeaderText = "Должность";
			this.position.MinimumWidth = 6;
			this.position.Name = "position";
			this.position.ReadOnly = true;
			this.position.Width = 125;
			// 
			// hideEmployee
			// 
			this.hideEmployee.HeaderText = "Hide";
			this.hideEmployee.MinimumWidth = 6;
			this.hideEmployee.Name = "hideEmployee";
			this.hideEmployee.ReadOnly = true;
			this.hideEmployee.Width = 125;
			// 
			// panelInputDataClient
			// 
			this.panelInputDataClient.BackColor = System.Drawing.Color.AntiqueWhite;
			this.panelInputDataClient.Controls.Add(this.buttonAddClient);
			this.panelInputDataClient.Controls.Add(this.textBoxPassword);
			this.panelInputDataClient.Controls.Add(this.textBoxPhoneNumber);
			this.panelInputDataClient.Controls.Add(this.textBoxNameOrganization);
			this.panelInputDataClient.Controls.Add(this.label3);
			this.panelInputDataClient.Controls.Add(this.label2);
			this.panelInputDataClient.Controls.Add(this.label1);
			this.panelInputDataClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panelInputDataClient.Location = new System.Drawing.Point(243, 74);
			this.panelInputDataClient.Name = "panelInputDataClient";
			this.panelInputDataClient.Size = new System.Drawing.Size(462, 309);
			this.panelInputDataClient.TabIndex = 5;
			this.panelInputDataClient.Visible = false;
			// 
			// buttonAddClient
			// 
			this.buttonAddClient.BackColor = System.Drawing.Color.PeachPuff;
			this.buttonAddClient.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddClient.ForeColor = System.Drawing.Color.SaddleBrown;
			this.buttonAddClient.Location = new System.Drawing.Point(86, 259);
			this.buttonAddClient.Name = "buttonAddClient";
			this.buttonAddClient.Size = new System.Drawing.Size(294, 33);
			this.buttonAddClient.TabIndex = 6;
			this.buttonAddClient.Text = "Добавить";
			this.buttonAddClient.UseVisualStyleBackColor = false;
			this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.Location = new System.Drawing.Point(235, 148);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(206, 22);
			this.textBoxPassword.TabIndex = 5;
			// 
			// textBoxPhoneNumber
			// 
			this.textBoxPhoneNumber.Location = new System.Drawing.Point(235, 93);
			this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
			this.textBoxPhoneNumber.Size = new System.Drawing.Size(206, 22);
			this.textBoxPhoneNumber.TabIndex = 4;
			// 
			// textBoxNameOrganization
			// 
			this.textBoxNameOrganization.Location = new System.Drawing.Point(235, 28);
			this.textBoxNameOrganization.Name = "textBoxNameOrganization";
			this.textBoxNameOrganization.Size = new System.Drawing.Size(206, 22);
			this.textBoxNameOrganization.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(134, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 21);
			this.label3.TabIndex = 2;
			this.label3.Text = "Пароль";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(62, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 21);
			this.label2.TabIndex = 1;
			this.label2.Text = "Номер телефона";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(19, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 21);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название организации";
			// 
			// panelInputDataEmloyee
			// 
			this.panelInputDataEmloyee.BackColor = System.Drawing.Color.AntiqueWhite;
			this.panelInputDataEmloyee.Controls.Add(this.button1);
			this.panelInputDataEmloyee.Controls.Add(this.comboBoxPosition);
			this.panelInputDataEmloyee.Controls.Add(this.textBoxMiddleName);
			this.panelInputDataEmloyee.Controls.Add(this.textBoxLastName);
			this.panelInputDataEmloyee.Controls.Add(this.textBoxNameEmployee);
			this.panelInputDataEmloyee.Controls.Add(this.textBoxPasswordEmloyee);
			this.panelInputDataEmloyee.Controls.Add(this.label9);
			this.panelInputDataEmloyee.Controls.Add(this.textBoxNumberPhoneEmloyee);
			this.panelInputDataEmloyee.Controls.Add(this.label8);
			this.panelInputDataEmloyee.Controls.Add(this.label7);
			this.panelInputDataEmloyee.Controls.Add(this.label6);
			this.panelInputDataEmloyee.Controls.Add(this.label5);
			this.panelInputDataEmloyee.Controls.Add(this.label4);
			this.panelInputDataEmloyee.Location = new System.Drawing.Point(329, 71);
			this.panelInputDataEmloyee.Name = "panelInputDataEmloyee";
			this.panelInputDataEmloyee.Size = new System.Drawing.Size(453, 295);
			this.panelInputDataEmloyee.TabIndex = 7;
			this.panelInputDataEmloyee.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.PeachPuff;
			this.button1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.button1.Location = new System.Drawing.Point(67, 259);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(307, 33);
			this.button1.TabIndex = 12;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBoxPosition
			// 
			this.comboBoxPosition.FormattingEnabled = true;
			this.comboBoxPosition.Location = new System.Drawing.Point(167, 220);
			this.comboBoxPosition.Name = "comboBoxPosition";
			this.comboBoxPosition.Size = new System.Drawing.Size(235, 24);
			this.comboBoxPosition.TabIndex = 11;
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.Location = new System.Drawing.Point(167, 182);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(235, 22);
			this.textBoxMiddleName.TabIndex = 10;
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.Location = new System.Drawing.Point(167, 138);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(235, 22);
			this.textBoxLastName.TabIndex = 9;
			// 
			// textBoxNameEmployee
			// 
			this.textBoxNameEmployee.Location = new System.Drawing.Point(167, 103);
			this.textBoxNameEmployee.Name = "textBoxNameEmployee";
			this.textBoxNameEmployee.Size = new System.Drawing.Size(235, 22);
			this.textBoxNameEmployee.TabIndex = 8;
			// 
			// textBoxPasswordEmloyee
			// 
			this.textBoxPasswordEmloyee.Location = new System.Drawing.Point(167, 67);
			this.textBoxPasswordEmloyee.Name = "textBoxPasswordEmloyee";
			this.textBoxPasswordEmloyee.Size = new System.Drawing.Size(235, 22);
			this.textBoxPasswordEmloyee.TabIndex = 7;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label9.Location = new System.Drawing.Point(64, 222);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 18);
			this.label9.TabIndex = 6;
			this.label9.Text = "Должность";
			// 
			// textBoxNumberPhoneEmloyee
			// 
			this.textBoxNumberPhoneEmloyee.Location = new System.Drawing.Point(167, 21);
			this.textBoxNumberPhoneEmloyee.Name = "textBoxNumberPhoneEmloyee";
			this.textBoxNumberPhoneEmloyee.Size = new System.Drawing.Size(235, 22);
			this.textBoxNumberPhoneEmloyee.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label8.Location = new System.Drawing.Point(76, 186);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(70, 18);
			this.label8.TabIndex = 4;
			this.label8.Text = "Отчество";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label7.Location = new System.Drawing.Point(78, 142);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 18);
			this.label7.TabIndex = 3;
			this.label7.Text = "Фамилия";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label6.Location = new System.Drawing.Point(110, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 18);
			this.label6.TabIndex = 2;
			this.label6.Text = "Имя";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label5.Location = new System.Drawing.Point(91, 65);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 18);
			this.label5.TabIndex = 1;
			this.label5.Text = "Пароль";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(27, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Номер телефона";
			// 
			// panelPosition
			// 
			this.panelPosition.BackColor = System.Drawing.Color.BurlyWood;
			this.panelPosition.Controls.Add(this.buttonOK);
			this.panelPosition.Controls.Add(this.comboBoxPositionCode);
			this.panelPosition.Controls.Add(this.label10);
			this.panelPosition.Location = new System.Drawing.Point(65, 155);
			this.panelPosition.Name = "panelPosition";
			this.panelPosition.Size = new System.Drawing.Size(322, 72);
			this.panelPosition.TabIndex = 6;
			this.panelPosition.Visible = false;
			// 
			// buttonOK
			// 
			this.buttonOK.BackColor = System.Drawing.Color.DarkSalmon;
			this.buttonOK.Location = new System.Drawing.Point(40, 44);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(251, 23);
			this.buttonOK.TabIndex = 2;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = false;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// comboBoxPositionCode
			// 
			this.comboBoxPositionCode.FormattingEnabled = true;
			this.comboBoxPositionCode.Location = new System.Drawing.Point(109, 8);
			this.comboBoxPositionCode.Name = "comboBoxPositionCode";
			this.comboBoxPositionCode.Size = new System.Drawing.Size(210, 24);
			this.comboBoxPositionCode.TabIndex = 1;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Candara", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label10.Location = new System.Drawing.Point(3, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(99, 22);
			this.label10.TabIndex = 0;
			this.label10.Text = "Должность";
			// 
			// AdministratorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(973, 485);
			this.Controls.Add(this.panelPosition);
			this.Controls.Add(this.buttonEmployees);
			this.Controls.Add(this.buttonClients);
			this.Controls.Add(this.panelInputDataEmloyee);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.panelInputDataClient);
			this.Controls.Add(this.dataGridViewUsers);
			this.Controls.Add(this.dataGridViewEmployees);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "AdministratorWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bakery";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
			this.panelInputDataClient.ResumeLayout(false);
			this.panelInputDataClient.PerformLayout();
			this.panelInputDataEmloyee.ResumeLayout(false);
			this.panelInputDataEmloyee.PerformLayout();
			this.panelPosition.ResumeLayout(false);
			this.panelPosition.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonClients;
		private System.Windows.Forms.Button buttonEmployees;
		private System.Windows.Forms.DataGridView dataGridViewUsers;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
		private System.Windows.Forms.DataGridView dataGridViewEmployees;
		private System.Windows.Forms.Panel panelInputDataClient;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonAddClient;
		private System.Windows.Forms.TextBox textBoxPassword;
		private System.Windows.Forms.TextBox textBoxPhoneNumber;
		private System.Windows.Forms.TextBox textBoxNameOrganization;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBoxNumberPhoneEmloyee;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBoxNameEmployee;
		private System.Windows.Forms.TextBox textBoxPasswordEmloyee;
		private System.Windows.Forms.TextBox textBoxMiddleName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBoxPosition;
		public System.Windows.Forms.Panel panelInputDataEmloyee;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameOrganization;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberEmloyee;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn middleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn position;
		private System.Windows.Forms.DataGridViewTextBoxColumn hideEmployee;
		private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
		private System.Windows.Forms.Panel panelPosition;
		private System.Windows.Forms.ComboBox comboBoxPositionCode;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button buttonOK;
	}
}