namespace 專題ERP初步
{
	partial class UserAccountManagement
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
			返回登入ToolStripMenuItem = new ToolStripMenuItem();
			texUserName = new TextBox();
			UserName = new Label();
			Password = new Label();
			texPassword = new TextBox();
			Password2 = new Label();
			texPassword2 = new TextBox();
			FullName = new Label();
			texFullName = new TextBox();
			Email = new Label();
			texEmail = new TextBox();
			Phone = new Label();
			texPhone = new TextBox();
			button1 = new Button();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.BackColor = SystemColors.ActiveCaption;
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回登入ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(398, 27);
			menuStrip1.TabIndex = 2;
			menuStrip1.Text = "menuStrip1";
			// 
			// 返回登入ToolStripMenuItem
			// 
			返回登入ToolStripMenuItem.Name = "返回登入ToolStripMenuItem";
			返回登入ToolStripMenuItem.Size = new Size(83, 23);
			返回登入ToolStripMenuItem.Text = "返回登入";
			返回登入ToolStripMenuItem.Click += 返回登入ToolStripMenuItem_Click;
			// 
			// texUserName
			// 
			texUserName.Location = new Point(119, 30);
			texUserName.Name = "texUserName";
			texUserName.Size = new Size(262, 27);
			texUserName.TabIndex = 3;
			texUserName.TextChanged += texUserName_TextChanged;
			// 
			// UserName
			// 
			UserName.AutoSize = true;
			UserName.Location = new Point(52, 33);
			UserName.Name = "UserName";
			UserName.Size = new Size(39, 19);
			UserName.TabIndex = 4;
			UserName.Text = "帳號";
			// 
			// Password
			// 
			Password.AutoSize = true;
			Password.Location = new Point(52, 66);
			Password.Name = "Password";
			Password.Size = new Size(39, 19);
			Password.TabIndex = 6;
			Password.Text = "密碼";
			// 
			// texPassword
			// 
			texPassword.Location = new Point(119, 63);
			texPassword.Name = "texPassword";
			texPassword.Size = new Size(262, 27);
			texPassword.TabIndex = 5;
			texPassword.TextChanged += texPassword_TextChanged;
			// 
			// Password2
			// 
			Password2.AutoSize = true;
			Password2.Location = new Point(14, 99);
			Password2.Name = "Password2";
			Password2.Size = new Size(99, 19);
			Password2.TabIndex = 8;
			Password2.Text = "再次確認密碼";
			// 
			// texPassword2
			// 
			texPassword2.Location = new Point(119, 96);
			texPassword2.Name = "texPassword2";
			texPassword2.Size = new Size(262, 27);
			texPassword2.TabIndex = 7;
			texPassword2.TextChanged += texPassword2_TextChanged;
			// 
			// FullName
			// 
			FullName.AutoSize = true;
			FullName.Location = new Point(29, 132);
			FullName.Name = "FullName";
			FullName.Size = new Size(84, 19);
			FullName.TabIndex = 10;
			FullName.Text = "使用者名稱";
			// 
			// texFullName
			// 
			texFullName.Location = new Point(119, 129);
			texFullName.Name = "texFullName";
			texFullName.Size = new Size(262, 27);
			texFullName.TabIndex = 9;
			texFullName.TextChanged += texFullName_TextChanged;
			// 
			// Email
			// 
			Email.AutoSize = true;
			Email.Location = new Point(52, 165);
			Email.Name = "Email";
			Email.Size = new Size(39, 19);
			Email.TabIndex = 12;
			Email.Text = "信箱";
			// 
			// texEmail
			// 
			texEmail.Location = new Point(119, 162);
			texEmail.Name = "texEmail";
			texEmail.Size = new Size(262, 27);
			texEmail.TabIndex = 11;
			texEmail.TextChanged += texEmail_TextChanged;
			// 
			// Phone
			// 
			Phone.AutoSize = true;
			Phone.Location = new Point(44, 203);
			Phone.Name = "Phone";
			Phone.Size = new Size(69, 19);
			Phone.TabIndex = 14;
			Phone.Text = "手機電話";
			// 
			// texPhone
			// 
			texPhone.Location = new Point(119, 195);
			texPhone.Name = "texPhone";
			texPhone.Size = new Size(262, 27);
			texPhone.TabIndex = 13;
			texPhone.TextChanged += texPhone_TextChanged;
			// 
			// button1
			// 
			button1.Location = new Point(147, 248);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 15;
			button1.Text = "完成";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// UserAccountManagement
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.ERP_resized_50_percent;
			ClientSize = new Size(398, 297);
			Controls.Add(button1);
			Controls.Add(Phone);
			Controls.Add(texPhone);
			Controls.Add(Email);
			Controls.Add(texEmail);
			Controls.Add(FullName);
			Controls.Add(texFullName);
			Controls.Add(Password2);
			Controls.Add(texPassword2);
			Controls.Add(Password);
			Controls.Add(texPassword);
			Controls.Add(UserName);
			Controls.Add(texUserName);
			Controls.Add(menuStrip1);
			MaximizeBox = false;
			Name = "UserAccountManagement";
			Text = "UserAccountManagement";
			Load += UserAccountManagement_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回登入ToolStripMenuItem;
		private TextBox texUserName;
		private Label UserName;
		private Label Password;
		private TextBox texPassword;
		private Label Password2;
		private TextBox texPassword2;
		private Label FullName;
		private TextBox texFullName;
		private Label Email;
		private TextBox texEmail;
		private Label Phone;
		private TextBox texPhone;
		private Button button1;
	}
}