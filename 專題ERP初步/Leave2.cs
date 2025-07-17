using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using 專題ERP初步.Service;

namespace 專題ERP初步
{
	public partial class Leave2 : Form
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;
		public Leave2(Form2 callerForm)
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

		private void Leave2_Load(object sender, EventArgs e)
		{
			#region 審核選項加入在CBReviewStatus
			CBReviewStatus.Items.Add("申請中");
			CBReviewStatus.Items.Add("審核通過");
			CBReviewStatus.Items.Add("審核失敗");
			#endregion

			#region 查詢審核狀況

			var UAService = new UserAccountService();

			try
			{
				var Fullname = UAService.GetAllFullname();
				CBFullName.DataSource = Fullname;
				CBFullName.DisplayMember = "FullName";
				CBFullName.DropDownWidth = 400;
			}
			catch (Exception ex)
			{
				MessageBox.Show("載入失敗：" + ex.Message);
			}
			#endregion

		}

		private void CBReviewStatus_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void CBFullName_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void SelectBtu_Click(object sender, EventArgs e)
		{


		}

		private void splitContainer1_Panel2_DragDrop(object sender, DragEventArgs e)
		{

		}

		private void SelectBtu_Click_1(object sender, EventArgs e)
		{
			//string Fullname= CBFullName.Text;
			string ReviewStatus = CBReviewStatus.Text;
			//var UserAccountservice = new UserAccountService();
			//int? workerid = UserAccountservice.GetUseridByFullname(Fullname);

			var LeaveApplicationservice = new LeaveApplicationService();
			dataGridView1.DataSource = LeaveApplicationservice.GetLeaveByStatus(ReviewStatus);

		}

		private void CBReviewStatus_SelectedIndexChanged_1(object sender, EventArgs e)
		{

		}
	}
}
