namespace 專題ERP初步
{
	partial class DataGrid
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
			派發起始日 = new DateTimePicker();
			label1 = new Label();
			textBox1 = new TextBox();
			btuTaskAssignment = new Button();
			至今派發工作總攬 = new DataGridView();
			部門 = new ComboBox();
			label3 = new Label();
			button1 = new Button();
			menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)至今派發工作總攬).BeginInit();
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
			// 派發起始日
			// 
			派發起始日.Location = new Point(51, 125);
			派發起始日.Name = "派發起始日";
			派發起始日.Size = new Size(183, 27);
			派發起始日.TabIndex = 2;
			派發起始日.ValueChanged += 派發起始日_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(102, 103);
			label1.Name = "label1";
			label1.Size = new Size(84, 19);
			label1.TabIndex = 4;
			label1.Text = "派發工作日";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(12, 158);
			textBox1.Multiline = true;
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(298, 233);
			textBox1.TabIndex = 6;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// btuTaskAssignment
			// 
			btuTaskAssignment.Location = new Point(102, 409);
			btuTaskAssignment.Name = "btuTaskAssignment";
			btuTaskAssignment.Size = new Size(94, 29);
			btuTaskAssignment.TabIndex = 7;
			btuTaskAssignment.Text = "送出";
			btuTaskAssignment.UseVisualStyleBackColor = true;
			btuTaskAssignment.Click += btuTaskAssignment_Click;
			// 
			// 至今派發工作總攬
			// 
			至今派發工作總攬.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			至今派發工作總攬.Location = new Point(316, 35);
			至今派發工作總攬.Name = "至今派發工作總攬";
			至今派發工作總攬.RowHeadersWidth = 51;
			至今派發工作總攬.Size = new Size(472, 356);
			至今派發工作總攬.TabIndex = 8;
			至今派發工作總攬.CellContentClick += 至今派發工作總攬_CellContentClick;
			// 
			// 部門
			// 
			部門.DropDownStyle = ComboBoxStyle.DropDownList;
			部門.FormattingEnabled = true;
			部門.Location = new Point(65, 59);
			部門.Name = "部門";
			部門.Size = new Size(151, 27);
			部門.TabIndex = 9;
			部門.SelectedIndexChanged += 部門_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(117, 37);
			label3.Name = "label3";
			label3.Size = new Size(39, 19);
			label3.TabIndex = 10;
			label3.Text = "部門";
			// 
			// button1
			// 
			button1.Location = new Point(516, 409);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 11;
			button1.Text = "更新";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// DataGrid
			// 
			AutoScaleDimensions = new SizeF(9F, 19F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label3);
			Controls.Add(部門);
			Controls.Add(至今派發工作總攬);
			Controls.Add(btuTaskAssignment);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(派發起始日);
			Controls.Add(menuStrip1);
			Name = "DataGrid";
			Text = "工作排程";
			Load += CreateAccount_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)至今派發工作總攬).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem 返回首頁ToolStripMenuItem;
		private DateTimePicker 派發起始日;
		private Label label1;
		private TextBox textBox1;
		private Button btuTaskAssignment;
		private DataGridView 至今派發工作總攬;
		private ComboBox 部門;
		private Label label3;
		private Button button1;
	}
}