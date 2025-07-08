namespace 專題ERP初步
{
	partial class Form2
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
			登出ToolStripMenuItem = new ToolStripMenuItem();
			工作排程ToolStripMenuItem = new ToolStripMenuItem();
			請假申請ToolStripMenuItem = new ToolStripMenuItem();
			請假申請ToolStripMenuItem1 = new ToolStripMenuItem();
			請假記錄ToolStripMenuItem = new ToolStripMenuItem();
			個人出勤紀錄ToolStripMenuItem = new ToolStripMenuItem();
			資金申請ToolStripMenuItem = new ToolStripMenuItem();
			一般請款ToolStripMenuItem = new ToolStripMenuItem();
			請款紀錄ToolStripMenuItem = new ToolStripMenuItem();
			庫存狀況ToolStripMenuItem = new ToolStripMenuItem();
			原物料庫存ToolStripMenuItem = new ToolStripMenuItem();
			成品庫存ToolStripMenuItem = new ToolStripMenuItem();
			人事ToolStripMenuItem = new ToolStripMenuItem();
			個人資料資料ToolStripMenuItem = new ToolStripMenuItem();
			出勤紀錄ToolStripMenuItem = new ToolStripMenuItem();
			管理ToolStripMenuItem = new ToolStripMenuItem();
			客戶ToolStripMenuItem = new ToolStripMenuItem();
			客戶資料ToolStripMenuItem = new ToolStripMenuItem();
			客戶訂單ToolStripMenuItem = new ToolStripMenuItem();
			員工ToolStripMenuItem = new ToolStripMenuItem();
			員工資料ToolStripMenuItem1 = new ToolStripMenuItem();
			員工績效ToolStripMenuItem = new ToolStripMenuItem();
			員工進度ToolStripMenuItem = new ToolStripMenuItem();
			帳號管理ToolStripMenuItem = new ToolStripMenuItem();
			button1 = new Button();
			button2 = new Button();
			textBox2 = new TextBox();
			thisweek = new Label();
			today = new Label();
			button3 = new Button();
			dataGridView1 = new DataGridView();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 登出ToolStripMenuItem, 工作排程ToolStripMenuItem, 請假申請ToolStripMenuItem, 資金申請ToolStripMenuItem, 庫存狀況ToolStripMenuItem, 人事ToolStripMenuItem, 管理ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(611, 27);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// 登出ToolStripMenuItem
			// 
			登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			登出ToolStripMenuItem.Size = new Size(53, 23);
			登出ToolStripMenuItem.Text = "登出";
			登出ToolStripMenuItem.Click += 登出ToolStripMenuItem_Click;
			// 
			// 工作排程ToolStripMenuItem
			// 
			工作排程ToolStripMenuItem.Name = "工作排程ToolStripMenuItem";
			工作排程ToolStripMenuItem.Size = new Size(83, 23);
			工作排程ToolStripMenuItem.Text = "工作排程";
			工作排程ToolStripMenuItem.Click += 工作排程ToolStripMenuItem_Click;
			// 
			// 請假申請ToolStripMenuItem
			// 
			請假申請ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 請假申請ToolStripMenuItem1, 請假記錄ToolStripMenuItem, 個人出勤紀錄ToolStripMenuItem });
			請假申請ToolStripMenuItem.Name = "請假申請ToolStripMenuItem";
			請假申請ToolStripMenuItem.Size = new Size(83, 23);
			請假申請ToolStripMenuItem.Text = "請假申請";
			// 
			// 請假申請ToolStripMenuItem1
			// 
			請假申請ToolStripMenuItem1.Name = "請假申請ToolStripMenuItem1";
			請假申請ToolStripMenuItem1.Size = new Size(182, 26);
			請假申請ToolStripMenuItem1.Text = "請假申請";
			請假申請ToolStripMenuItem1.Click += 請假申請ToolStripMenuItem1_Click;
			// 
			// 請假記錄ToolStripMenuItem
			// 
			請假記錄ToolStripMenuItem.Name = "請假記錄ToolStripMenuItem";
			請假記錄ToolStripMenuItem.Size = new Size(182, 26);
			請假記錄ToolStripMenuItem.Text = "請假記錄";
			請假記錄ToolStripMenuItem.Click += 請假記錄ToolStripMenuItem_Click;
			// 
			// 個人出勤紀錄ToolStripMenuItem
			// 
			個人出勤紀錄ToolStripMenuItem.Name = "個人出勤紀錄ToolStripMenuItem";
			個人出勤紀錄ToolStripMenuItem.Size = new Size(182, 26);
			個人出勤紀錄ToolStripMenuItem.Text = "個人出勤紀錄";
			個人出勤紀錄ToolStripMenuItem.Click += 個人出勤紀錄ToolStripMenuItem_Click;
			// 
			// 資金申請ToolStripMenuItem
			// 
			資金申請ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 一般請款ToolStripMenuItem, 請款紀錄ToolStripMenuItem });
			資金申請ToolStripMenuItem.Name = "資金申請ToolStripMenuItem";
			資金申請ToolStripMenuItem.Size = new Size(83, 23);
			資金申請ToolStripMenuItem.Text = "資金申請";
			// 
			// 一般請款ToolStripMenuItem
			// 
			一般請款ToolStripMenuItem.Name = "一般請款ToolStripMenuItem";
			一般請款ToolStripMenuItem.Size = new Size(152, 26);
			一般請款ToolStripMenuItem.Text = "一般請款";
			一般請款ToolStripMenuItem.Click += 一般請款ToolStripMenuItem_Click;
			// 
			// 請款紀錄ToolStripMenuItem
			// 
			請款紀錄ToolStripMenuItem.Name = "請款紀錄ToolStripMenuItem";
			請款紀錄ToolStripMenuItem.Size = new Size(152, 26);
			請款紀錄ToolStripMenuItem.Text = "請款紀錄";
			請款紀錄ToolStripMenuItem.Click += 請款紀錄ToolStripMenuItem_Click;
			// 
			// 庫存狀況ToolStripMenuItem
			// 
			庫存狀況ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 原物料庫存ToolStripMenuItem, 成品庫存ToolStripMenuItem });
			庫存狀況ToolStripMenuItem.Name = "庫存狀況ToolStripMenuItem";
			庫存狀況ToolStripMenuItem.Size = new Size(83, 23);
			庫存狀況ToolStripMenuItem.Text = "庫存狀況";
			// 
			// 原物料庫存ToolStripMenuItem
			// 
			原物料庫存ToolStripMenuItem.Name = "原物料庫存ToolStripMenuItem";
			原物料庫存ToolStripMenuItem.Size = new Size(167, 26);
			原物料庫存ToolStripMenuItem.Text = "原物料庫存";
			原物料庫存ToolStripMenuItem.Click += 原物料庫存ToolStripMenuItem_Click;
			// 
			// 成品庫存ToolStripMenuItem
			// 
			成品庫存ToolStripMenuItem.Name = "成品庫存ToolStripMenuItem";
			成品庫存ToolStripMenuItem.Size = new Size(167, 26);
			成品庫存ToolStripMenuItem.Text = "成品庫存";
			成品庫存ToolStripMenuItem.Click += 成品庫存ToolStripMenuItem_Click;
			// 
			// 人事ToolStripMenuItem
			// 
			人事ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 個人資料資料ToolStripMenuItem, 出勤紀錄ToolStripMenuItem });
			人事ToolStripMenuItem.Name = "人事ToolStripMenuItem";
			人事ToolStripMenuItem.Size = new Size(53, 23);
			人事ToolStripMenuItem.Text = "人事";
			// 
			// 個人資料資料ToolStripMenuItem
			// 
			個人資料資料ToolStripMenuItem.Name = "個人資料資料ToolStripMenuItem";
			個人資料資料ToolStripMenuItem.Size = new Size(152, 26);
			個人資料資料ToolStripMenuItem.Text = "個人資料";
			個人資料資料ToolStripMenuItem.Click += 個人資料資料ToolStripMenuItem_Click;
			// 
			// 出勤紀錄ToolStripMenuItem
			// 
			出勤紀錄ToolStripMenuItem.Name = "出勤紀錄ToolStripMenuItem";
			出勤紀錄ToolStripMenuItem.Size = new Size(152, 26);
			出勤紀錄ToolStripMenuItem.Text = "出勤紀錄";
			出勤紀錄ToolStripMenuItem.Click += 出勤紀錄ToolStripMenuItem_Click;
			// 
			// 管理ToolStripMenuItem
			// 
			管理ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 客戶ToolStripMenuItem, 員工ToolStripMenuItem, 帳號管理ToolStripMenuItem });
			管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
			管理ToolStripMenuItem.Size = new Size(53, 23);
			管理ToolStripMenuItem.Text = "管理";
			// 
			// 客戶ToolStripMenuItem
			// 
			客戶ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 客戶資料ToolStripMenuItem, 客戶訂單ToolStripMenuItem });
			客戶ToolStripMenuItem.Name = "客戶ToolStripMenuItem";
			客戶ToolStripMenuItem.Size = new Size(152, 26);
			客戶ToolStripMenuItem.Text = "客戶";
			// 
			// 客戶資料ToolStripMenuItem
			// 
			客戶資料ToolStripMenuItem.Name = "客戶資料ToolStripMenuItem";
			客戶資料ToolStripMenuItem.Size = new Size(152, 26);
			客戶資料ToolStripMenuItem.Text = "客戶資料";
			客戶資料ToolStripMenuItem.Click += 客戶資料ToolStripMenuItem_Click;
			// 
			// 客戶訂單ToolStripMenuItem
			// 
			客戶訂單ToolStripMenuItem.Name = "客戶訂單ToolStripMenuItem";
			客戶訂單ToolStripMenuItem.Size = new Size(152, 26);
			客戶訂單ToolStripMenuItem.Text = "客戶訂單";
			客戶訂單ToolStripMenuItem.Click += 客戶訂單ToolStripMenuItem_Click;
			// 
			// 員工ToolStripMenuItem
			// 
			員工ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 員工資料ToolStripMenuItem1, 員工績效ToolStripMenuItem, 員工進度ToolStripMenuItem });
			員工ToolStripMenuItem.Name = "員工ToolStripMenuItem";
			員工ToolStripMenuItem.Size = new Size(152, 26);
			員工ToolStripMenuItem.Text = "員工";
			// 
			// 員工資料ToolStripMenuItem1
			// 
			員工資料ToolStripMenuItem1.Name = "員工資料ToolStripMenuItem1";
			員工資料ToolStripMenuItem1.Size = new Size(152, 26);
			員工資料ToolStripMenuItem1.Text = "員工資料";
			員工資料ToolStripMenuItem1.Click += 員工資料ToolStripMenuItem1_Click;
			// 
			// 員工績效ToolStripMenuItem
			// 
			員工績效ToolStripMenuItem.Name = "員工績效ToolStripMenuItem";
			員工績效ToolStripMenuItem.Size = new Size(152, 26);
			員工績效ToolStripMenuItem.Text = "員工績效";
			員工績效ToolStripMenuItem.Click += 員工績效ToolStripMenuItem_Click;
			// 
			// 員工進度ToolStripMenuItem
			// 
			員工進度ToolStripMenuItem.Name = "員工進度ToolStripMenuItem";
			員工進度ToolStripMenuItem.Size = new Size(152, 26);
			員工進度ToolStripMenuItem.Text = "申請相關";
			員工進度ToolStripMenuItem.Click += 員工進度ToolStripMenuItem_Click;
			// 
			// 帳號管理ToolStripMenuItem
			// 
			帳號管理ToolStripMenuItem.Name = "帳號管理ToolStripMenuItem";
			帳號管理ToolStripMenuItem.Size = new Size(152, 26);
			帳號管理ToolStripMenuItem.Text = "帳號管理";
			帳號管理ToolStripMenuItem.Click += 帳號管理ToolStripMenuItem_Click;
			// 
			// button1
			// 
			button1.Location = new Point(41, 357);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "上班打卡";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(41, 409);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 3;
			button2.Text = "下班打卡";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(374, 103);
			textBox2.Multiline = true;
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(207, 205);
			textBox2.TabIndex = 7;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// thisweek
			// 
			thisweek.AutoSize = true;
			thisweek.Location = new Point(141, 81);
			thisweek.Name = "thisweek";
			thisweek.Size = new Size(69, 19);
			thisweek.TabIndex = 9;
			thisweek.Text = "本週排程";
			// 
			// today
			// 
			today.AutoSize = true;
			today.Location = new Point(453, 81);
			today.Name = "today";
			today.Size = new Size(69, 19);
			today.TabIndex = 10;
			today.Text = "本日進度";
			// 
			// button3
			// 
			button3.Location = new Point(428, 314);
			button3.Name = "button3";
			button3.Size = new Size(94, 29);
			button3.TabIndex = 12;
			button3.Text = "送出";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(23, 103);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(324, 205);
			dataGridView1.TabIndex = 13;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Form2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(611, 450);
			Controls.Add(dataGridView1);
			Controls.Add(button3);
			Controls.Add(today);
			Controls.Add(thisweek);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form2";
			Text = "首頁";
			FormClosing += Form2_FormClosing;
			FormClosed += Form2_FormClosed;
			Load += Form2_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 登出ToolStripMenuItem;
		private ToolStripMenuItem 人事ToolStripMenuItem;
		private ToolStripMenuItem 個人資料資料ToolStripMenuItem;
		private ToolStripMenuItem 出勤紀錄ToolStripMenuItem;
		private ToolStripMenuItem 請假申請ToolStripMenuItem;
		private ToolStripMenuItem 請假申請ToolStripMenuItem1;
		private ToolStripMenuItem 請假記錄ToolStripMenuItem;
		private ToolStripMenuItem 個人出勤紀錄ToolStripMenuItem;
		private ToolStripMenuItem 庫存狀況ToolStripMenuItem;
		private ToolStripMenuItem 原物料庫存ToolStripMenuItem;
		private ToolStripMenuItem 成品庫存ToolStripMenuItem;
		private ToolStripMenuItem 資金申請ToolStripMenuItem;
		private Button button1;
		private Button button2;
		private ToolStripMenuItem 管理ToolStripMenuItem;
		private ToolStripMenuItem 客戶ToolStripMenuItem;
		private ToolStripMenuItem 客戶資料ToolStripMenuItem;
		private ToolStripMenuItem 客戶訂單ToolStripMenuItem;
		private ToolStripMenuItem 員工ToolStripMenuItem;
		private ToolStripMenuItem 員工資料ToolStripMenuItem1;
		private ToolStripMenuItem 員工績效ToolStripMenuItem;
		private ToolStripMenuItem 一般請款ToolStripMenuItem;
		private ToolStripMenuItem 請款紀錄ToolStripMenuItem;
		private ToolStripMenuItem 工作排程ToolStripMenuItem;
		private TextBox textBox2;
		private Label thisweek;
		private TextBox textBox3;
		private Label label3;
		private Label today;
		private Label label5;
		private Button button3;
		private Button button4;
		private ToolStripMenuItem 員工進度ToolStripMenuItem;
		private ToolStripMenuItem 帳號管理ToolStripMenuItem;
		private DataGridView dataGridView1;
	}
}