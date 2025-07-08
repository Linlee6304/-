using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 專題ERP初步
{
	public partial class InventoryManagement1 : Form
	{
		public InventoryManagement1()
		{
			InitializeComponent();
		}

		private void 返回首頁ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 mainForm = new Form2();
			mainForm.Show();
			this.Close();
		}
	}
}
