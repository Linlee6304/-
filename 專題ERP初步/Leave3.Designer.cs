namespace 專題ERP初步
{
	partial class Leave3
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
			dataGridView1 = new DataGridView();
			dateTimeStardate = new DateTimePicker();
			dateTimeEnddate = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			comboBoxLeaveType = new ComboBox();
			comboBoxAttendance = new ComboBox();
			label3 = new Label();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回首頁ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(838, 27);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			menuStrip1.ItemClicked += menuStrip1_ItemClicked;
			// 
			// 返回首頁ToolStripMenuItem
			// 
			返回首頁ToolStripMenuItem.Name = "返回首頁ToolStripMenuItem";
			返回首頁ToolStripMenuItem.Size = new Size(83, 23);
			返回首頁ToolStripMenuItem.Text = "返回首頁";
			返回首頁ToolStripMenuItem.Click += 返回首頁ToolStripMenuItem_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(199, 45);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(627, 338);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// dateTimeStardate
			// 
			dateTimeStardate.Location = new Point(28, 226);
			dateTimeStardate.Name = "dateTimeStardate";
			dateTimeStardate.Size = new Size(151, 27);
			dateTimeStardate.TabIndex = 3;
			dateTimeStardate.ValueChanged += dateTimeStardate_ValueChanged;
			// 
			// dateTimeEnddate
			// 
			dateTimeEnddate.Location = new Point(28, 324);
			dateTimeEnddate.Name = "dateTimeEnddate";
			dateTimeEnddate.Size = new Size(151, 27);
			dateTimeEnddate.TabIndex = 4;
			dateTimeEnddate.ValueChanged += dateTimeEnddate_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(61, 202);
			label1.Name = "label1";
			label1.Size = new Size(84, 19);
			label1.TabIndex = 5;
			label1.Text = "查詢起始日";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(61, 300);
			label2.Name = "label2";
			label2.Size = new Size(84, 19);
			label2.TabIndex = 6;
			label2.Text = "查詢結束日";
			// 
			// button1
			// 
			button1.Location = new Point(464, 404);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 7;
			button1.Text = "查詢";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// comboBoxLeaveType
			// 
			comboBoxLeaveType.FormattingEnabled = true;
			comboBoxLeaveType.Location = new Point(28, 159);
			comboBoxLeaveType.Name = "comboBoxLeaveType";
			comboBoxLeaveType.Size = new Size(151, 27);
			comboBoxLeaveType.TabIndex = 8;
			comboBoxLeaveType.SelectedIndexChanged += comboBoxLeaveType_SelectedIndexChanged;
			// 
			// comboBoxAttendance
			// 
			comboBoxAttendance.FormattingEnabled = true;
			comboBoxAttendance.Location = new Point(28, 95);
			comboBoxAttendance.Name = "comboBoxAttendance";
			comboBoxAttendance.Size = new Size(151, 27);
			comboBoxAttendance.TabIndex = 9;
			comboBoxAttendance.SelectedIndexChanged += comboBoxAttendance_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(61, 135);
			label3.Name = "label3";
			label3.Size = new Size(99, 19);
			label3.TabIndex = 10;
			label3.Text = "查詢出勤狀況";
			// 
			// Leave3
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			ClientSize = new Size(838, 445);
			Controls.Add(label3);
			Controls.Add(comboBoxAttendance);
			Controls.Add(comboBoxLeaveType);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dateTimeEnddate);
			Controls.Add(dateTimeStardate);
			Controls.Add(dataGridView1);
			Controls.Add(menuStrip1);
			Name = "Leave3";
			Text = "個人出勤紀錄";
			Load += Leave3_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private DataGridView dataGridView1;
		private DateTimePicker dateTimeStardate;
		private DateTimePicker dateTimeEnddate;
		private Label label1;
		private Label label2;
		private Button button1;
		private ComboBox comboBoxLeaveType;
		private ComboBox comboBoxAttendance;
		private Label label3;
	}
}