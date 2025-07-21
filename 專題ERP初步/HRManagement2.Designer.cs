namespace 專題ERP初步
{
	partial class HRManagement2
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
			label4 = new Label();
			textBox1 = new TextBox();
			label3 = new Label();
			comboBox3 = new ComboBox();
			label2 = new Label();
			label1 = new Label();
			comboBox2 = new ComboBox();
			comboBox1 = new ComboBox();
			button2 = new Button();
			button1 = new Button();
			dataGridView1 = new DataGridView();
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
			menuStrip1.Size = new Size(1096, 27);
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
			splitContainer1.Panel1.Controls.Add(label4);
			splitContainer1.Panel1.Controls.Add(textBox1);
			splitContainer1.Panel1.Controls.Add(label3);
			splitContainer1.Panel1.Controls.Add(comboBox3);
			splitContainer1.Panel1.Controls.Add(label2);
			splitContainer1.Panel1.Controls.Add(label1);
			splitContainer1.Panel1.Controls.Add(comboBox2);
			splitContainer1.Panel1.Controls.Add(comboBox1);
			splitContainer1.Panel1.Controls.Add(button2);
			splitContainer1.Panel1.Controls.Add(button1);
			splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(dataGridView1);
			splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
			splitContainer1.Size = new Size(1096, 453);
			splitContainer1.SplitterDistance = 194;
			splitContainer1.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(271, 88);
			label4.Name = "label4";
			label4.Size = new Size(69, 19);
			label4.TabIndex = 9;
			label4.Text = "職位名稱";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(241, 110);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 8;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(266, 21);
			label3.Name = "label3";
			label3.Size = new Size(69, 19);
			label3.TabIndex = 7;
			label3.Text = "部門名稱";
			// 
			// comboBox3
			// 
			comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox3.FormattingEnabled = true;
			comboBox3.Location = new Point(231, 43);
			comboBox3.Name = "comboBox3";
			comboBox3.Size = new Size(151, 27);
			comboBox3.TabIndex = 6;
			comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(103, 88);
			label2.Name = "label2";
			label2.Size = new Size(39, 19);
			label2.TabIndex = 5;
			label2.Text = "權限";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(85, 21);
			label1.Name = "label1";
			label1.Size = new Size(84, 19);
			label1.TabIndex = 4;
			label1.Text = "使用者名稱";
			// 
			// comboBox2
			// 
			comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox2.FormattingEnabled = true;
			comboBox2.Location = new Point(50, 110);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new Size(151, 27);
			comboBox2.TabIndex = 3;
			comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
			// 
			// comboBox1
			// 
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(50, 43);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(151, 27);
			comboBox1.TabIndex = 2;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// button2
			// 
			button2.Location = new Point(137, 143);
			button2.Name = "button2";
			button2.Size = new Size(151, 29);
			button2.TabIndex = 1;
			button2.Text = "資料與權限變更";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.Location = new Point(600, 43);
			button1.Name = "button1";
			button1.Size = new Size(187, 112);
			button1.TabIndex = 0;
			button1.Text = "瀏覽資訊更新";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.BackgroundColor = Color.Linen;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Dock = DockStyle.Fill;
			dataGridView1.Location = new Point(0, 0);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1096, 255);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// HRManagement2
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.MenuHighlight;
			ClientSize = new Size(1096, 480);
			Controls.Add(splitContainer1);
			Controls.Add(menuStrip1);
			Name = "HRManagement2";
			Text = "帳號權限管理資料";
			Load += HRManagement2_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
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
		private Button button2;
		private Button button1;
		private DataGridView dataGridView1;
		private ComboBox comboBox2;
		private ComboBox comboBox1;
		private Label label3;
		private ComboBox comboBox3;
		private Label label2;
		private Label label1;
		private Label label4;
		private TextBox textBox1;
	}
}