namespace 專題ERP初步
{
	partial class Leave2
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
			splitContainer1 = new SplitContainer();
			dataGridView1 = new DataGridView();
			SelectBtu = new Button();
			label2 = new Label();
			CBReviewStatus = new ComboBox();
			radioLeavel3 = new RadioButton();
			label6 = new Label();
			comboBox1 = new ComboBox();
			btu執行 = new Button();
			dataGridView2 = new DataGridView();
			radioLeavel2 = new RadioButton();
			radioLeavel1 = new RadioButton();
			label5 = new Label();
			label4 = new Label();
			Enddate = new DateTimePicker();
			Startdate = new DateTimePicker();
			textBox1 = new TextBox();
			label3 = new Label();
			btu檢查 = new Button();
			label1 = new Label();
			CBFullName = new ComboBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回首頁ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1119, 27);
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
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 27);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			splitContainer1.Panel1.Controls.Add(dataGridView1);
			splitContainer1.Panel1.Controls.Add(SelectBtu);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(CBReviewStatus);
			splitContainer1.Panel1.DragDrop += splitContainer1_Panel2_DragDrop;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			splitContainer1.Panel2.Controls.Add(radioLeavel3);
			splitContainer1.Panel2.Controls.Add(label6);
			splitContainer1.Panel2.Controls.Add(comboBox1);
			splitContainer1.Panel2.Controls.Add(btu執行);
			splitContainer1.Panel2.Controls.Add(dataGridView2);
			splitContainer1.Panel2.Controls.Add(radioLeavel2);
			splitContainer1.Panel2.Controls.Add(radioLeavel1);
			splitContainer1.Panel2.Controls.Add(label5);
			splitContainer1.Panel2.Controls.Add(label4);
			splitContainer1.Panel2.Controls.Add(Enddate);
			splitContainer1.Panel2.Controls.Add(Startdate);
			splitContainer1.Panel2.Controls.Add(textBox1);
			splitContainer1.Panel2.Controls.Add(label3);
			splitContainer1.Panel2.Controls.Add(btu檢查);
			splitContainer1.Panel2.Controls.Add(label1);
			splitContainer1.Panel2.Controls.Add(CBFullName);
			splitContainer1.Panel2.DragDrop += splitContainer1_Panel2_DragDrop;
			splitContainer1.Size = new Size(1119, 589);
			splitContainer1.SplitterDistance = 290;
			splitContainer1.TabIndex = 11;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(304, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(809, 282);
			dataGridView1.TabIndex = 17;
			// 
			// SelectBtu
			// 
			SelectBtu.Location = new Point(103, 164);
			SelectBtu.Name = "SelectBtu";
			SelectBtu.Size = new Size(94, 29);
			SelectBtu.TabIndex = 15;
			SelectBtu.Text = "查詢/更新";
			SelectBtu.UseVisualStyleBackColor = true;
			SelectBtu.Click += SelectBtu_Click_1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(116, 82);
			label2.Name = "label2";
			label2.Size = new Size(69, 19);
			label2.TabIndex = 14;
			label2.Text = "審核狀況";
			// 
			// CBReviewStatus
			// 
			CBReviewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			CBReviewStatus.FormattingEnabled = true;
			CBReviewStatus.Location = new Point(75, 119);
			CBReviewStatus.Name = "CBReviewStatus";
			CBReviewStatus.Size = new Size(151, 27);
			CBReviewStatus.TabIndex = 12;
			CBReviewStatus.SelectedIndexChanged += CBReviewStatus_SelectedIndexChanged_1;
			// 
			// radioLeavel3
			// 
			radioLeavel3.AutoSize = true;
			radioLeavel3.Location = new Point(180, 139);
			radioLeavel3.Name = "radioLeavel3";
			radioLeavel3.Size = new Size(90, 23);
			radioLeavel3.TabIndex = 30;
			radioLeavel3.Text = "半天下午";
			radioLeavel3.UseVisualStyleBackColor = true;
			radioLeavel3.CheckedChanged += radioLeavel3_CheckedChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(61, 118);
			label6.Name = "label6";
			label6.Size = new Size(69, 19);
			label6.TabIndex = 28;
			label6.Text = "審核狀況";
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(20, 140);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 27);
			comboBox1.TabIndex = 27;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// btu執行
			// 
			btu執行.Location = new Point(116, 177);
			btu執行.Name = "btu執行";
			btu執行.Size = new Size(94, 29);
			btu執行.TabIndex = 26;
			btu執行.Text = "執行";
			btu執行.UseVisualStyleBackColor = true;
			btu執行.Click += btu執行_Click;
			// 
			// dataGridView2
			// 
			dataGridView2.AllowUserToAddRows = false;
			dataGridView2.AllowUserToDeleteRows = false;
			dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView2.Location = new Point(510, 3);
			dataGridView2.Name = "dataGridView2";
			dataGridView2.ReadOnly = true;
			dataGridView2.RowHeadersWidth = 51;
			dataGridView2.Size = new Size(603, 286);
			dataGridView2.TabIndex = 18;
			dataGridView2.CellContentClick += dataGridView2_CellContentClick;
			// 
			// radioLeavel2
			// 
			radioLeavel2.AutoSize = true;
			radioLeavel2.Location = new Point(180, 107);
			radioLeavel2.Name = "radioLeavel2";
			radioLeavel2.Size = new Size(90, 23);
			radioLeavel2.TabIndex = 25;
			radioLeavel2.Text = "半天上午";
			radioLeavel2.UseVisualStyleBackColor = true;
			radioLeavel2.CheckedChanged += radioLeavel2_CheckedChanged;
			// 
			// radioLeavel1
			// 
			radioLeavel1.AutoSize = true;
			radioLeavel1.Checked = true;
			radioLeavel1.Location = new Point(180, 75);
			radioLeavel1.Name = "radioLeavel1";
			radioLeavel1.Size = new Size(60, 23);
			radioLeavel1.TabIndex = 24;
			radioLeavel1.TabStop = true;
			radioLeavel1.Text = "全天";
			radioLeavel1.UseVisualStyleBackColor = true;
			radioLeavel1.CheckedChanged += radioLeavel1_CheckedChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(352, 142);
			label5.Name = "label5";
			label5.Size = new Size(54, 19);
			label5.TabIndex = 23;
			label5.Text = "結束日";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(352, 80);
			label4.Name = "label4";
			label4.Size = new Size(54, 19);
			label4.TabIndex = 22;
			label4.Text = "起始日";
			// 
			// Enddate
			// 
			Enddate.Location = new Point(295, 162);
			Enddate.Name = "Enddate";
			Enddate.Size = new Size(169, 27);
			Enddate.TabIndex = 21;
			Enddate.ValueChanged += Enddate_ValueChanged;
			// 
			// Startdate
			// 
			Startdate.Location = new Point(295, 102);
			Startdate.Name = "Startdate";
			Startdate.Size = new Size(169, 27);
			Startdate.TabIndex = 20;
			Startdate.ValueChanged += Startdate_ValueChanged;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(33, 85);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 19;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(61, 63);
			label3.Name = "label3";
			label3.Size = new Size(69, 19);
			label3.TabIndex = 18;
			label3.Text = "申請編號";
			// 
			// btu檢查
			// 
			btu檢查.Location = new Point(332, 208);
			btu檢查.Name = "btu檢查";
			btu檢查.Size = new Size(94, 29);
			btu檢查.TabIndex = 16;
			btu檢查.Text = "檢查";
			btu檢查.UseVisualStyleBackColor = true;
			btu檢查.Click += btu檢查_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(352, 17);
			label1.Name = "label1";
			label1.Size = new Size(54, 19);
			label1.TabIndex = 13;
			label1.Text = "申請人";
			// 
			// CBFullName
			// 
			CBFullName.DropDownStyle = ComboBoxStyle.DropDownList;
			CBFullName.FormattingEnabled = true;
			CBFullName.Location = new Point(304, 50);
			CBFullName.Name = "CBFullName";
			CBFullName.Size = new Size(151, 27);
			CBFullName.TabIndex = 11;
			CBFullName.SelectedIndexChanged += CBFullName_SelectedIndexChanged_1;
			// 
			// Leave2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackgroundImage = Properties.Resources.ChatGPT_Image_2025年7月21日_下午02_55_54;
			ClientSize = new Size(1119, 616);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			Name = "Leave2";
			Text = "請假核可";
			Load += Leave2_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private SplitContainer splitContainer1;
		private DataGridView dataGridView1;
		private Button SelectBtu;
		private Label label2;
		private ComboBox CBReviewStatus;
		private TextBox textBox1;
		private Label label3;
		private Button btu檢查;
		private Label label1;
		private ComboBox CBFullName;
		private Label label5;
		private Label label4;
		private DateTimePicker Enddate;
		private DateTimePicker Startdate;
		private RadioButton radioLeavel1;
		private RadioButton radioLeavel2;
		private Button btu執行;
		private DataGridView dataGridView2;
		private Label label6;
		private ComboBox comboBox1;
		private RadioButton radioLeavel3;
	}
}