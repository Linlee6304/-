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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
			CBReviewStatus.Items.Add("准假");
			CBReviewStatus.Items.Add("核可失敗");
			comboBox1.Items.Add("申請中");
			comboBox1.Items.Add("准假");
			comboBox1.Items.Add("核可失敗");


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
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.RowHeadersVisible = false;
			dataGridView2.RowHeadersVisible = false;

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

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//審核狀況
		{

		}

		private bool isHalfDay = false;
		private int morning = 1;

		private void radioLeavel1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioLeavel1.Checked)
				isHalfDay = false;
			morning = 1;
		}

		private void radioLeavel2_CheckedChanged(object sender, EventArgs e)//半天上午
		{
			if (radioLeavel2.Checked)
				isHalfDay = true;
			morning = 2;
		}

		private void radioLeavel3_CheckedChanged(object sender, EventArgs e)//半天下午
		{
			if (radioLeavel3.Checked)
				isHalfDay = true;
			morning = 3;
		}


		private void Startdate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void Enddate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void btu執行_Click(object sender, EventArgs e)//點下去執行複雜邏輯處理出勤狀況到打卡單
		{
			try
			{
				int applicationId = Convert.ToInt32(textBox1.Text); // 申請單號輸入欄位
				string reviewStatus = comboBox1.Text;               // 審核狀態欄位：審核通過 or 審核失敗

				var leaveService = new LeaveApplicationService();
				leaveService.LeaveReviewMechanism(applicationId, reviewStatus);

				MessageBox.Show("審核處理完成");
			}
			catch (Exception ex)
			{
				MessageBox.Show("發生錯誤：" + ex.Message);
			}


		}

		private void btu檢查_Click(object sender, EventArgs e)//查詢申請人的FullName的起始日到結束日的打卡狀況
		{
			DateTime stardate = Startdate.Value.Date;//起始日
			DateTime endDate = Enddate.Value.Date;//結束日
			string fullName = CBFullName.Text;


			var attendanceService = new AttendanceService();
			DataTable result = attendanceService.GetAttendanceByFullNameAndDateRange(fullName, stardate, endDate);

			dataGridView2.DataSource = result;

		}

		private void CBFullName_SelectedIndexChanged_1(object sender, EventArgs e)//申請人的FullName
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)//申請編號
		{

		}

		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
