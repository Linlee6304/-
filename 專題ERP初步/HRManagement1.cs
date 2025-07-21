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

namespace 專題ERP初步
{
	public partial class HRManagement1 : Form
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;
		public HRManagement1(Form2 callerForm)
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

		private void HRManagement1_Load(object sender, EventArgs e)
		{

		}

		private void txtFullname_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)//電話
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)//信箱
		{

		}

		private void txtEmergencyContactName_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)//緊急連絡人電話
		{

		}

		private void txtAddress_TextChanged(object sender, EventArgs e)
		{

		}

		
		//int Userid, string? FullName, string? Phone, string? email, DateTime Createdtime, string? EmergencyContactName, string? EmergencyContactPhone, string? Address
		private void button1_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFullname.Text))
			{
				MessageBox.Show("姓名不可空白");
				return;
			}
			if (string.IsNullOrWhiteSpace(textBox2.Text))
			{
				MessageBox.Show("電話不可空白");
				return;
			}
			DateTime create = CreateddateTime.Value.Date;
			var service = new EmployeeProfileService();
			service.UpdateEmployeesEmployeeProfileAndAttendance(_userId, txtFullname.Text, textBox2.Text, textBox3.Text, create, txtEmergencyContactName.Text, textBox5.Text, txtAddress.Text);
			MessageBox.Show("員工資料更新成功！");
		}

		private void CreateddateTime_ValueChanged(object sender, EventArgs e)//入職日
		{

		}
	}
}
