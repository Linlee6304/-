using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 專題ERP初步.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
			//int LeaveTypeID = 0;
			//if (LeaveType == "病假") { LeaveTypeID = 1; }
			//else if (LeaveType == "婚假") { LeaveTypeID = 2; }
			//else if (LeaveType == "喪假") { LeaveTypeID = 3; }
			//else if (LeaveType == "特休") { LeaveTypeID = 4; }
			//else if (LeaveType == "公假") { LeaveTypeID = 5; }
			//else if (LeaveType == "事假") { LeaveTypeID = 6; }
			//else if (LeaveType == "產假") { LeaveTypeID = 7; }
			comboBoxLeaveType.Items.Add("正常");
			comboBoxLeaveType.Items.Add("遲到");
			comboBoxLeaveType.Items.Add("早退");
			comboBoxLeaveType.Items.Add("病假");
			comboBoxLeaveType.Items.Add("婚假");
			comboBoxLeaveType.Items.Add("特休");
			comboBoxLeaveType.Items.Add("公假");
			comboBoxLeaveType.Items.Add("事假");
			comboBoxLeaveType.Items.Add("產假");

			comboBoxAttendance.Items.Add("查詢全部");
			comboBoxAttendance.Items.Add("查詢單一狀況");
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.RowHeadersVisible = false;

		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime stardate = dateTimeStardate.Value.Date;//起始日
			DateTime endDate = dateTimeEnddate.Value.Date;//結束日
			if (comboBoxAttendance.Text == "查詢全部")
			{
				var attendanceService = new AttendanceService();
				DataTable result = attendanceService.GetAttendanceByFullNameAndDateRange(_fullName, stardate, endDate);
				dataGridView1.DataSource = result;
			}
			else 
			{
				var attendanceService = new AttendanceService();
				DataTable result = attendanceService.GetAttendanceByFullNameAndDateRangeAndStatus(_fullName, stardate, endDate, comboBoxLeaveType.Text);
				dataGridView1.DataSource = result;
			}

		}

		private void comboBoxLeaveType_SelectedIndexChanged(object sender, EventArgs e)//出勤狀況
		{

		}

		private void comboBoxAttendance_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dateTimeStardate_ValueChanged(object sender, EventArgs e)
		{

		}

		private void dateTimeEnddate_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
