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
	public partial class Leave3 : Form//Leave3是個人出勤紀錄未包含請假狀況
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;
		public Leave3(Form2 callerForm)
		{
			InitializeComponent();
			_callerForm = callerForm;
			_userId = Session.UserId;
			_fullName = Session.FullName;
			_role = Session.Role;
		}

		private void 返回首頁ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_callerForm.Show();
			this.Close();
		}

		private void Leave3_Load(object sender, EventArgs e)
		{

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}
	}
}
