using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 專題ERP初步.DTO;
using 專題ERP初步.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 專題ERP初步
{

	public partial class DataGrid : Form
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;
		public DataGrid(Form2 callerForm)
		{
			InitializeComponent();
			_callerForm = callerForm;
			_userId = Session.UserId;
			_fullName = Session.FullName;
			_role = Session.Role;
		}

		private void LoadDepartmentName()//這是我創的
		{
			var service = new DepartmentService();
			if (_userId == 1)//如果使用者權限為admin的話可以看到所有行程
			{
				try
				{
					var Deptname = service.GetAllDepartments();
					部門.DataSource = Deptname;
					部門.DisplayMember = "DepartmentName";
					部門.DropDownWidth = 400;
				}
				catch (Exception ex)
				{
					MessageBox.Show("載入部門失敗：" + ex.Message);
				}
			}
			else
			{
				try
				{
					var Deptname = service.GetUserIdForDepartments(_userId);
					if (Deptname != null&& Deptname.Count > 0)
					{
						部門.DataSource = Deptname;
						部門.DisplayMember = "DepartmentName";
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("載入部門失敗：" + ex.Message);
				}
			}
		}



		public DataGrid()
		{
			InitializeComponent();
			_userId = Session.UserId;
			_fullName = Session.FullName;
			_role = Session.Role;
		}

		//帳號管理
		private void CreateAccount_Load(object sender, EventArgs e)//這才是真正讀取
		{
			LoadDepartmentName();
			textBox1.Multiline = true;
			textBox1.WordWrap = true;
			textBox1.ScrollBars = ScrollBars.Vertical;
		}

		private void 返回首頁ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_callerForm.Show();
			this.Close();
		}

		private void 部門_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)//我是想把這個紐當作更新 每次點選都會根據部門刷新到"至今派發工作總攬_CellContentClick"
		{
			try
			{
				string dept = 部門.Text;
				var service = new ScheduleService();
				var data = service.GetDeptAllWork(dept);
				至今派發工作總攬.DataSource = data;
				至今派發工作總攬.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				至今派發工作總攬.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
				至今派發工作總攬.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
				至今派發工作總攬.RowHeadersVisible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("發生異常：" + ex.Message);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btuTaskAssignment_Click(object sender, EventArgs e)//點選這個紐會把texbox1的內容新增到表格中
		{

			try
			{
				string note = textBox1.Text;
				string dept = 部門.Text;
				DateTime thisdate = 派發起始日.Value;
				if (string.IsNullOrWhiteSpace(dept))
				{
					MessageBox.Show("請派發工作！");
					return;
				}

				var service = new ScheduleService();
				service.InsertThisWeekWork(note, dept, thisdate, _userId);

				MessageBox.Show("工作進度已派發！");
			}
			catch (Exception ex)
			{
				MessageBox.Show("派發進度時發生錯誤：" + ex.Message);
			}

		}

		private void 派發起始日_ValueChanged(object sender, EventArgs e)
		{

		}

		private void 至今派發工作總攬_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
