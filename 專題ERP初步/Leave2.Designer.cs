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
			CBFullName = new ComboBox();
			CBReviewStatus = new ComboBox();
			label1 = new Label();
			label2 = new Label();
			SelectBtu = new Button();
			button2 = new Button();
			dataGridView1 = new DataGridView();
			label3 = new Label();
			textBox1 = new TextBox();
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
			menuStrip1.Size = new Size(800, 27);
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
			// CBFullName
			// 
			CBFullName.DropDownStyle = ComboBoxStyle.DropDownList;
			CBFullName.FormattingEnabled = true;
			CBFullName.Location = new Point(68, 81);
			CBFullName.Name = "CBFullName";
			CBFullName.Size = new Size(151, 27);
			CBFullName.TabIndex = 2;
			CBFullName.SelectedIndexChanged += CBFullName_SelectedIndexChanged;
			// 
			// CBReviewStatus
			// 
			CBReviewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			CBReviewStatus.FormattingEnabled = true;
			CBReviewStatus.Location = new Point(68, 166);
			CBReviewStatus.Name = "CBReviewStatus";
			CBReviewStatus.Size = new Size(151, 27);
			CBReviewStatus.TabIndex = 3;
			CBReviewStatus.SelectedIndexChanged += CBReviewStatus_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(116, 48);
			label1.Name = "label1";
			label1.Size = new Size(54, 19);
			label1.TabIndex = 4;
			label1.Text = "申請人";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(109, 129);
			label2.Name = "label2";
			label2.Size = new Size(69, 19);
			label2.TabIndex = 5;
			label2.Text = "審核狀況";
			// 
			// SelectBtu
			// 
			SelectBtu.Location = new Point(96, 211);
			SelectBtu.Name = "SelectBtu";
			SelectBtu.Size = new Size(94, 29);
			SelectBtu.TabIndex = 6;
			SelectBtu.Text = "查詢/更新";
			SelectBtu.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(96, 391);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 7;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(258, 66);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(449, 188);
			dataGridView1.TabIndex = 8;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(109, 336);
			label3.Name = "label3";
			label3.Size = new Size(69, 19);
			label3.TabIndex = 9;
			label3.Text = "申請編號";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(81, 358);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 10;
			// 
			// Leave2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(dataGridView1);
			Controls.Add(button2);
			Controls.Add(SelectBtu);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(CBReviewStatus);
			Controls.Add(CBFullName);
			Controls.Add(menuStrip1);
			Name = "Leave2";
			Text = "請假核可";
			Load += Leave2_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private ComboBox CBFullName;
		private ComboBox CBReviewStatus;
		private Label label1;
		private Label label2;
		private Button SelectBtu;
		private Button button2;
		private DataGridView dataGridView1;
		private Label label3;
		private TextBox textBox1;
	}
}