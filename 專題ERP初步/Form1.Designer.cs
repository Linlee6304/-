namespace 專題ERP初步
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			login = new Button();
			UserName = new TextBox();
			password = new TextBox();
			label1 = new Label();
			label2 = new Label();
			UserAccountManagement = new Button();
			SuspendLayout();
			// 
			// login
			// 
			login.Location = new Point(127, 235);
			login.Name = "login";
			login.Size = new Size(165, 29);
			login.TabIndex = 0;
			login.Text = "登入";
			login.UseVisualStyleBackColor = true;
			login.Click += login_Click;
			// 
			// UserName
			// 
			UserName.Location = new Point(127, 112);
			UserName.Name = "UserName";
			UserName.Size = new Size(165, 27);
			UserName.TabIndex = 1;
			UserName.TextChanged += UserName_TextChanged;
			// 
			// password
			// 
			password.Location = new Point(127, 175);
			password.Name = "password";
			password.Size = new Size(165, 27);
			password.TabIndex = 2;
			password.TextChanged += password_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(82, 120);
			label1.Name = "label1";
			label1.Size = new Size(39, 19);
			label1.TabIndex = 3;
			label1.Text = "帳號";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(82, 178);
			label2.Name = "label2";
			label2.Size = new Size(39, 19);
			label2.TabIndex = 4;
			label2.Text = "密碼";
			// 
			// UserAccountManagement
			// 
			UserAccountManagement.Location = new Point(127, 270);
			UserAccountManagement.Name = "UserAccountManagement";
			UserAccountManagement.Size = new Size(165, 29);
			UserAccountManagement.TabIndex = 5;
			UserAccountManagement.Text = "創建帳號";
			UserAccountManagement.UseVisualStyleBackColor = true;
			UserAccountManagement.Click += UserAccountManagement_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			ClientSize = new Size(440, 409);
			Controls.Add(UserAccountManagement);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(password);
			Controls.Add(UserName);
			Controls.Add(login);
			MaximizeBox = false;
			Name = "Form1";
			Text = "登入畫面";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button login;
		private TextBox UserName;
		private TextBox password;
		private Label label1;
		private Label label2;
		private Button UserAccountManagement;
	}
}
