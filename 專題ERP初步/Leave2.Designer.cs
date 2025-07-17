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
			textBox1 = new TextBox();
			label3 = new Label();
			button2 = new Button();
			label1 = new Label();
			CBFullName = new ComboBox();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 返回首頁ToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1312, 27);
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
			splitContainer1.Panel1.Controls.Add(dataGridView1);
			splitContainer1.Panel1.Controls.Add(SelectBtu);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(CBReviewStatus);
			splitContainer1.Panel1.DragDrop += splitContainer1_Panel2_DragDrop;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(textBox1);
			splitContainer1.Panel2.Controls.Add(label3);
			splitContainer1.Panel2.Controls.Add(button2);
			splitContainer1.Panel2.Controls.Add(label1);
			splitContainer1.Panel2.Controls.Add(CBFullName);
			splitContainer1.Panel2.DragDrop += splitContainer1_Panel2_DragDrop;
			splitContainer1.Size = new Size(1312, 578);
			splitContainer1.SplitterDistance = 285;
			splitContainer1.TabIndex = 11;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(169, 0);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1143, 282);
			dataGridView1.TabIndex = 17;
			// 
			// SelectBtu
			// 
			SelectBtu.Location = new Point(40, 165);
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
			label2.Location = new Point(53, 83);
			label2.Name = "label2";
			label2.Size = new Size(69, 19);
			label2.TabIndex = 14;
			label2.Text = "審核狀況";
			// 
			// CBReviewStatus
			// 
			CBReviewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
			CBReviewStatus.FormattingEnabled = true;
			CBReviewStatus.Location = new Point(12, 120);
			CBReviewStatus.Name = "CBReviewStatus";
			CBReviewStatus.Size = new Size(151, 27);
			CBReviewStatus.TabIndex = 12;
			CBReviewStatus.SelectedIndexChanged += CBReviewStatus_SelectedIndexChanged_1;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(38, 141);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 19;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(66, 119);
			label3.Name = "label3";
			label3.Size = new Size(69, 19);
			label3.TabIndex = 18;
			label3.Text = "申請編號";
			// 
			// button2
			// 
			button2.Location = new Point(53, 193);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 16;
			button2.Text = "button2";
			button2.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(77, 46);
			label1.Name = "label1";
			label1.Size = new Size(54, 19);
			label1.TabIndex = 13;
			label1.Text = "申請人";
			// 
			// CBFullName
			// 
			CBFullName.DropDownStyle = ComboBoxStyle.DropDownList;
			CBFullName.FormattingEnabled = true;
			CBFullName.Location = new Point(29, 79);
			CBFullName.Name = "CBFullName";
			CBFullName.Size = new Size(151, 27);
			CBFullName.TabIndex = 11;
			// 
			// Leave2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1312, 605);
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
		private Button button2;
		private Label label1;
		private ComboBox CBFullName;
	}
}