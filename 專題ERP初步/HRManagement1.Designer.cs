namespace 專題ERP初步
{
	partial class HRManagement1
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
			menuStrip1 = new MenuStrip();
			返回首頁ToolStripMenuItem = new ToolStripMenuItem();
			txtFullname = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			txtEmergencyContactName = new TextBox();
			textBox5 = new TextBox();
			txtAddress = new TextBox();
			姓名 = new Label();
			txtPhone = new Label();
			txtEmail = new Label();
			label4 = new Label();
			txtEmergencyContactPhone = new Label();
			label6 = new Label();
			button1 = new Button();
			CreateddateTime = new DateTimePicker();
			created = new Label();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回首頁ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(546, 27);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// 返回首頁ToolStripMenuItem
			// 
			返回首頁ToolStripMenuItem.Name = "返回首頁ToolStripMenuItem";
			返回首頁ToolStripMenuItem.Size = new Size(83, 23);
			返回首頁ToolStripMenuItem.Text = "返回首頁";
			返回首頁ToolStripMenuItem.Click += 返回首頁ToolStripMenuItem_Click;
			// 
			// txtFullname
			// 
			txtFullname.Location = new Point(78, 71);
			txtFullname.Name = "txtFullname";
			txtFullname.Size = new Size(125, 27);
			txtFullname.TabIndex = 2;
			txtFullname.TextChanged += txtFullname_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(78, 139);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 3;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(78, 207);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 4;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// txtEmergencyContactName
			// 
			txtEmergencyContactName.Location = new Point(346, 71);
			txtEmergencyContactName.Name = "txtEmergencyContactName";
			txtEmergencyContactName.Size = new Size(125, 27);
			txtEmergencyContactName.TabIndex = 5;
			txtEmergencyContactName.TextChanged += txtEmergencyContactName_TextChanged;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(346, 139);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(125, 27);
			textBox5.TabIndex = 6;
			textBox5.TextChanged += textBox5_TextChanged;
			// 
			// txtAddress
			// 
			txtAddress.Location = new Point(346, 207);
			txtAddress.Name = "txtAddress";
			txtAddress.Size = new Size(125, 27);
			txtAddress.TabIndex = 7;
			txtAddress.TextChanged += txtAddress_TextChanged;
			// 
			// 姓名
			// 
			姓名.AutoSize = true;
			姓名.Location = new Point(36, 76);
			姓名.Name = "姓名";
			姓名.Size = new Size(39, 19);
			姓名.TabIndex = 8;
			姓名.Text = "姓名";
			// 
			// txtPhone
			// 
			txtPhone.AutoSize = true;
			txtPhone.Location = new Point(33, 147);
			txtPhone.Name = "txtPhone";
			txtPhone.Size = new Size(39, 19);
			txtPhone.TabIndex = 9;
			txtPhone.Text = "電話";
			// 
			// txtEmail
			// 
			txtEmail.AutoSize = true;
			txtEmail.Location = new Point(33, 210);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(39, 19);
			txtEmail.TabIndex = 10;
			txtEmail.Text = "信箱";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(241, 76);
			label4.Name = "label4";
			label4.Size = new Size(84, 19);
			label4.TabIndex = 11;
			label4.Text = "緊急聯絡人";
			// 
			// txtEmergencyContactPhone
			// 
			txtEmergencyContactPhone.AutoSize = true;
			txtEmergencyContactPhone.Location = new Point(226, 147);
			txtEmergencyContactPhone.Name = "txtEmergencyContactPhone";
			txtEmergencyContactPhone.Size = new Size(114, 19);
			txtEmergencyContactPhone.TabIndex = 12;
			txtEmergencyContactPhone.Text = "緊急連絡人電話";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(264, 215);
			label6.Name = "label6";
			label6.Size = new Size(39, 19);
			label6.TabIndex = 13;
			label6.Text = "住址";
			// 
			// button1
			// 
			button1.Location = new Point(361, 287);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 14;
			button1.Text = "送出";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// CreateddateTime
			// 
			CreateddateTime.Location = new Point(63, 286);
			CreateddateTime.Name = "CreateddateTime";
			CreateddateTime.Size = new Size(168, 27);
			CreateddateTime.TabIndex = 15;
			CreateddateTime.ValueChanged += CreateddateTime_ValueChanged;
			// 
			// created
			// 
			created.AutoSize = true;
			created.Location = new Point(133, 264);
			created.Name = "created";
			created.Size = new Size(69, 19);
			created.TabIndex = 16;
			created.Text = "入職日期";
			// 
			// HRManagement1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			ClientSize = new Size(546, 363);
			Controls.Add(created);
			Controls.Add(CreateddateTime);
			Controls.Add(button1);
			Controls.Add(label6);
			Controls.Add(txtEmergencyContactPhone);
			Controls.Add(label4);
			Controls.Add(txtEmail);
			Controls.Add(txtPhone);
			Controls.Add(姓名);
			Controls.Add(txtAddress);
			Controls.Add(textBox5);
			Controls.Add(txtEmergencyContactName);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(txtFullname);
			Controls.Add(menuStrip1);
			Name = "HRManagement1";
			Text = "個人資料";
			Load += HRManagement1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private TextBox txtFullname;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox txtEmergencyContactName;
		private TextBox textBox5;
		private TextBox txtAddress;
		private Label 姓名;
		private Label txtPhone;
		private Label txtEmail;
		private Label label4;
		private Label txtEmergencyContactPhone;
		private Label label6;
		private Button button1;
		private DateTimePicker CreateddateTime;
		private Label created;
	}
}