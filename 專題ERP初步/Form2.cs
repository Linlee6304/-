using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class Form2 : Form
	{
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;

		#region 需要研究
		private DateTime GetWeekStart(DateTime date)
		{
			int offset = date.DayOfWeek == DayOfWeek.Sunday ? -6 : -(int)date.DayOfWeek + 1;
			return date.AddDays(offset);
		}
		private void LoadSchedule()
		{
			try
			{
				DateTime weekStart = GetWeekStart(DateTime.Today); // 取得本週週一
				var service = new Service.ScheduleService();
				DataTable dt = service.GetWeeklyScheduleByUserId(_userId, weekStart);

				dataGridView1.DataSource = dt;
				dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

				if (dataGridView1.Columns.Contains("TaskDescription"))
					dataGridView1.Columns["TaskDescription"].HeaderText = "工作內容";
			}
			catch (Exception ex){}
		}
		#endregion

		public Form2()
		{
			InitializeComponent();
			_userId = Session.UserId;
			_fullName = Session.FullName;
			_role = Session.Role;
		}
		public Form2(int userId, string? fullName, string? role)
		{
			InitializeComponent();
			_fullName = fullName;
			_role = role;
			_userId = userId;
		}

		// Form2.cs
		private Dictionary<ToolStripMenuItem, List<string>> _menuRoleMap;



		private void 登出ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 mainForm = new Form1();
			mainForm.Show();
			this.Close();
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		#region 跳轉區
		private void 工作排程ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DataGrid mainForm = new DataGrid(this);
			mainForm.Show();
			this.Hide();
		}

		private void 個人出勤紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 請假記錄ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 請假申請ToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void 一般請款ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 請款紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 原物料庫存ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 成品庫存ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 個人資料資料ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 出勤紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 客戶資料ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 客戶訂單ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 員工資料ToolStripMenuItem1_Click(object sender, EventArgs e)
		{

		}

		private void 員工績效ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 員工進度ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void 帳號管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		#endregion

		private void Form2_Load(object sender, EventArgs e)
		{

			this.Text = $"歡迎 {_fullName} (ID: {_userId})";

			_menuRoleMap = new Dictionary<ToolStripMenuItem, List<string>>
			{
				{ 請假申請ToolStripMenuItem1, new List<string> { "Admin", "HR", "User" ,"RD"} },
				{ 請假記錄ToolStripMenuItem, new List<string> { "Admin", "HR", "User", "RD" } },
				{ 個人出勤紀錄ToolStripMenuItem, new List<string> { "Admin", "HR", "User", "RD" } },
				{ 一般請款ToolStripMenuItem, new List<string> { "Admin", "HR", "User", "RD" } },
				{ 請款紀錄ToolStripMenuItem, new List<string> { "Admin", "HR", "User", "RD" } },
				{ 個人資料資料ToolStripMenuItem, new List<string> { "Admin", "HR", "User", "RD" } },
				{ 帳號管理ToolStripMenuItem, new List<string> { "Admin", "HR" } },
				{ 出勤紀錄ToolStripMenuItem, new List<string> { "Admin", "HR" } },
				{ 客戶資料ToolStripMenuItem, new List<string> { "Admin" } },
				{ 客戶訂單ToolStripMenuItem, new List<string> { "Admin" } },
				{ 員工資料ToolStripMenuItem1, new List<string> { "Admin" } },
				{ 員工績效ToolStripMenuItem, new List<string> { "Admin" } },
				{ 員工進度ToolStripMenuItem, new List<string> { "Admin" } },
				{ 工作排程ToolStripMenuItem, new List<string> { "Admin", "RD", "HR" } },
				{ 原物料庫存ToolStripMenuItem, new List<string> { "Admin" } },
				{ 成品庫存ToolStripMenuItem, new List<string> { "Admin" } }
			};

			foreach (var pair in _menuRoleMap)
			{
				var menuItem = pair.Key;
				var allowedRoles = pair.Value;
				menuItem.Enabled = allowedRoles.Contains(_role);
			}

			#region 需要研究


			dataGridView1.RowHeadersVisible = false;

			dataGridView1.ColumnHeadersVisible = false;
			LoadSchedule();
			#endregion
		}//部門權限

		private void Form2_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			
		}

		private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//登入後該週工作顯示在這
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				string note = textBox2.Text.Trim();
				if (string.IsNullOrWhiteSpace(note))
				{
					MessageBox.Show("請輸入今日工作進度！");
					return;
				}

				var service = new Service.AttendanceService();
				service.SubmitWorkProgress(_userId, note);

				MessageBox.Show("工作進度已送出！");
			}
			catch (Exception ex)
			{
				MessageBox.Show("送出進度時發生錯誤：" + ex.Message);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var service = new Service.AttendanceService();
				service.ClockIn(_userId);
				MessageBox.Show("上班打卡成功！");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var service = new Service.AttendanceService();
				service.ClockOut(_userId);
				MessageBox.Show("下班打卡成功！");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

}
