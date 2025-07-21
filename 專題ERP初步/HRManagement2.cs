using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 專題ERP初步.Service;

namespace 專題ERP初步
{
	public partial class HRManagement2 : Form
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;
		public HRManagement2(Form2 callerForm)
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

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void HRManagement2_Load(object sender, EventArgs e)
		{
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;//自動填滿
			dataGridView1.RowHeadersVisible = false;//關閉最左列
			dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//內文文字置中
			dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//標題置中
			dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 8, FontStyle.Bold);//調整大小與字型
			dataGridView1.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;//禁止自動換行

			var Departmentservice = new DepartmentService();
			var Userservice = new UserAccountService();
			comboBox1.DataSource = Userservice.GetAllFullname();
			comboBox1.DisplayMember = "FullName"; // 顯示欄位
			comboBox1.ValueMember = "UserID";     // 實際值欄位（如有需要）
			comboBox3.DataSource = Departmentservice.GetAllDepartments();
			comboBox3.DisplayMember = "DepartmentName"; // 顯示欄位
			comboBox3.ValueMember = "DepartmentID";     // 實際值欄位
			comboBox2.Items.Add("Admin");
			comboBox2.Items.Add("HR");
			comboBox2.Items.Add("User");
			comboBox2.Items.Add("RD");
			//"Admin", "HR", "User" ,"RD"

			

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var service = new Service.UserAccountService();
			DataTable dt = service.GetUserAccountJoinDepartmentAndEmployee();
			dataGridView1.DataSource = dt;


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

			var Departmentservice = new DepartmentService();
			var Userservice = new UserAccountService();
			int Did = Departmentservice.GetDepartmentnameToDepartmentnameid(comboBox3.Text);
			int? Uid = Userservice.GetUseridByFullname(comboBox1.Text);

			var UserAccountservice = new UserAccountService();
			var EmployeeProfileservice = new Service.EmployeeProfileService();
			EmployeeProfileservice.UpdateEmployeeProfileDepartmentIDAndPosition(Uid, Did, textBox1.Text);
			UserAccountservice.UpdateUserAccountRole(Uid, comboBox2.Text);
			MessageBox.Show("更新成功！");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)//職位名稱
		{

		}
	}
}
