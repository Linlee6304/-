using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;

namespace 專題ERP初步.Service
{
	public class EmployeeProfileService
	{
		private readonly EmployeeProfileDao _dao = new EmployeeProfileDao();
		private readonly UserAccountDao _UserAccountDao = new UserAccountDao();
		//int Userid, string FullName, string Phone, string EmergencyContactName, string EmergencyContactPhone, string Address EmployeeProfileDao用
		//int Userid,string FullName, string Phone, string email,DateTime Createdtime UserAccountDao用
		//var attendance = _attendanceService.GetLeaveAttendance(leave.UserID, date);//根據日期查詢是否有打卡紀錄
					
		public void UpdateEmployeesEmployeeProfileAndAttendance(int Userid, string? FullName, string? Phone, string? email, DateTime Createdtime, string? EmergencyContactName, string? EmergencyContactPhone, string? Address)
		{
			bool Fitst = _dao.HasEmployeeProfile(Userid);
			if (FullName == null) { MessageBox.Show($"請輸入姓名"); return; }
			if (Phone == null) { MessageBox.Show($"請輸入電話"); return; }
			if (Fitst == false)
			{
				_dao.InsertEmployeeProfile(Userid, FullName, Phone, EmergencyContactName, EmergencyContactPhone, Address);
				_UserAccountDao.UpdateUserAccount(Userid, FullName, Phone, email, Createdtime);

			}
			else
			{
				_dao.UpdateEmployeeProfile(Userid, FullName, Phone, EmergencyContactName, EmergencyContactPhone, Address);
				_UserAccountDao.UpdateUserAccount(Userid, FullName, Phone, email, Createdtime);
			}
		}
		public void UpdateEmployeeProfileDepartmentIDAndPosition(int? UserID, int DepartmentID, string Position)
		{
			_dao.UpdateEmployeeProfileDepartmentIDAndPosition(UserID, DepartmentID, Position);
		}
	}
}
