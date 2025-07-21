namespace 專題ERP初步
{
	partial class Leave1
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
			stardate = new DateTimePicker();
			enddate = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			LeaveMode = new ComboBox();
			label3 = new Label();
			radioLeave1 = new RadioButton();
			radioLeave2 = new RadioButton();
			btuInsert = new Button();
			btuSelect = new Button();
			dataGridView1 = new DataGridView();
			textBox1 = new TextBox();
			label4 = new Label();
			btutopictureBox1 = new Button();
			openFileDialog1 = new OpenFileDialog();
			pictureBox1 = new PictureBox();
			radioLeave3 = new RadioButton();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回首頁ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(836, 27);
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
			// stardate
			// 
			stardate.Location = new Point(307, 60);
			stardate.Name = "stardate";
			stardate.Size = new Size(203, 27);
			stardate.TabIndex = 2;
			stardate.ValueChanged += stardate_ValueChanged;
			// 
			// enddate
			// 
			enddate.Location = new Point(307, 128);
			enddate.Name = "enddate";
			enddate.Size = new Size(203, 27);
			enddate.TabIndex = 3;
			enddate.ValueChanged += enddate_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(365, 38);
			label1.Name = "label1";
			label1.Size = new Size(84, 19);
			label1.TabIndex = 4;
			label1.Text = "請假起始日";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(365, 106);
			label2.Name = "label2";
			label2.Size = new Size(84, 19);
			label2.TabIndex = 5;
			label2.Text = "請假結束日";
			// 
			// LeaveMode
			// 
			LeaveMode.DropDownStyle = ComboBoxStyle.DropDownList;
			LeaveMode.FormattingEnabled = true;
			LeaveMode.Location = new Point(560, 60);
			LeaveMode.Name = "LeaveMode";
			LeaveMode.Size = new Size(151, 27);
			LeaveMode.TabIndex = 6;
			LeaveMode.SelectedIndexChanged += LeaveMode_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(594, 38);
			label3.Name = "label3";
			label3.Size = new Size(69, 19);
			label3.TabIndex = 7;
			label3.Text = "請假類型";
			// 
			// radioLeave1
			// 
			radioLeave1.AutoSize = true;
			radioLeave1.Checked = true;
			radioLeave1.Location = new Point(717, 51);
			radioLeave1.Name = "radioLeave1";
			radioLeave1.Size = new Size(60, 23);
			radioLeave1.TabIndex = 8;
			radioLeave1.TabStop = true;
			radioLeave1.Text = "全天";
			radioLeave1.UseVisualStyleBackColor = true;
			radioLeave1.CheckedChanged += radioLeave1_CheckedChanged;
			// 
			// radioLeave2
			// 
			radioLeave2.AutoSize = true;
			radioLeave2.Location = new Point(717, 80);
			radioLeave2.Name = "radioLeave2";
			radioLeave2.Size = new Size(90, 23);
			radioLeave2.TabIndex = 9;
			radioLeave2.Text = "上午半天";
			radioLeave2.UseVisualStyleBackColor = true;
			radioLeave2.CheckedChanged += radioLeave2_CheckedChanged;
			// 
			// btuInsert
			// 
			btuInsert.Location = new Point(594, 129);
			btuInsert.Name = "btuInsert";
			btuInsert.Size = new Size(94, 29);
			btuInsert.TabIndex = 10;
			btuInsert.Text = "送出申請";
			btuInsert.UseVisualStyleBackColor = true;
			btuInsert.Click += btuInsert_Click;
			// 
			// btuSelect
			// 
			btuSelect.Location = new Point(491, 409);
			btuSelect.Name = "btuSelect";
			btuSelect.Size = new Size(137, 29);
			btuSelect.TabIndex = 11;
			btuSelect.Text = "查詢申請狀態";
			btuSelect.UseVisualStyleBackColor = true;
			btuSelect.Click += btuSelect_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(307, 190);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(481, 213);
			dataGridView1.TabIndex = 12;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(28, 50);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(233, 161);
			textBox1.TabIndex = 13;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(33, 28);
			label4.Name = "label4";
			label4.Size = new Size(228, 19);
			label4.TabIndex = 14;
			label4.Text = "特休以及請假超過3日外請寫原因";
			// 
			// btutopictureBox1
			// 
			btutopictureBox1.Location = new Point(73, 409);
			btutopictureBox1.Name = "btutopictureBox1";
			btutopictureBox1.Size = new Size(94, 29);
			btutopictureBox1.TabIndex = 15;
			btutopictureBox1.Text = "上傳圖片";
			btutopictureBox1.UseVisualStyleBackColor = true;
			btutopictureBox1.Click += btutopictureBox1_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(28, 259);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(195, 144);
			pictureBox1.TabIndex = 16;
			pictureBox1.TabStop = false;
			pictureBox1.Click += pictureBox1_Click;
			// 
			// radioLeave3
			// 
			radioLeave3.AutoSize = true;
			radioLeave3.Location = new Point(717, 109);
			radioLeave3.Name = "radioLeave3";
			radioLeave3.Size = new Size(90, 23);
			radioLeave3.TabIndex = 17;
			radioLeave3.Text = "下午半天";
			radioLeave3.UseVisualStyleBackColor = true;
			radioLeave3.CheckedChanged += radioLeave3_CheckedChanged;
			// 
			// Leave1
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(836, 450);
			Controls.Add(radioLeave3);
			Controls.Add(pictureBox1);
			Controls.Add(btutopictureBox1);
			Controls.Add(label4);
			Controls.Add(textBox1);
			Controls.Add(dataGridView1);
			Controls.Add(btuSelect);
			Controls.Add(btuInsert);
			Controls.Add(radioLeave2);
			Controls.Add(radioLeave1);
			Controls.Add(label3);
			Controls.Add(LeaveMode);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(enddate);
			Controls.Add(stardate);
			Controls.Add(menuStrip1);
			Name = "Leave1";
			Text = "請假申請";
			Load += Leave1_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private DateTimePicker stardate;
		private DateTimePicker enddate;
		private Label label1;
		private Label label2;
		private ComboBox LeaveMode;
		private Label label3;
		private RadioButton radioLeave1;
		private RadioButton radioLeave2;
		private Button btuInsert;
		private Button btuSelect;
		private DataGridView dataGridView1;
		private TextBox textBox1;
		private Label label4;
		private Button btutopictureBox1;
		private OpenFileDialog openFileDialog1;
		private PictureBox pictureBox1;
		private RadioButton radioLeave3;
	}
}