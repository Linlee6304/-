using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class LeaveApplicationService
	{
		private readonly LeaveApplicationDao _dao = new LeaveApplicationDao();
		private readonly AttendanceDao _attendanceDao = new AttendanceDao();
		private readonly AttendanceService _attendanceService = new AttendanceService();
		public int InsertAndReturnApplicationId(int userId, DateTime startDate, DateTime endDate, string LeaveType, string? reason, bool isHalfDay,bool? IsAfternoon)
		{
			int LeaveTypeID = 0;
			if (LeaveType == "病假") { LeaveTypeID = 1; }
			else if (LeaveType == "婚假") { LeaveTypeID = 2; }
			else if (LeaveType == "喪假") { LeaveTypeID = 3; }
			else if (LeaveType == "特休") { LeaveTypeID = 4; }
			else if (LeaveType == "公假") { LeaveTypeID = 5; }
			else if (LeaveType == "事假") { LeaveTypeID = 6; }
			else if (LeaveType == "產假") { LeaveTypeID = 7; }

			return _dao.InsertAndReturnId(userId, startDate, endDate, reason, LeaveTypeID, isHalfDay, IsAfternoon);
		}

		public List<LeaveApplicationDto> GetLeaveApplications(int userId)
		{
			return _dao.GetLeaveApplications(userId);
		}
		// 根據 UserID 查詢請假紀錄
		public DataTable GetLeaveByUserId(int userId)
		{
			return _dao.GetLeaveApply(userId);
		}

		// 根據請假狀態查詢請假紀錄
		public DataTable GetLeaveByStatus(string status)
		{
			return _dao.GetStatusByLeaveApply(status);
		}


		//複雜邏輯
		//comboBox1.Items.Add("申請中");
		//comboBox1.Items.Add("准假");
		//comboBox1.Items.Add("核可失敗");

		//UserID = Convert.ToInt32(row["UserID"]),
		//Reason = row["Reason"].ToString(),
		//LeaveTypeName = row["LeaveTypeName"].ToString(),
		//StartDate = Convert.ToDateTime(row["StartDate"]),
		//EndDate = Convert.ToDateTime(row["EndDate"]),
		//IsHalfDay = Convert.ToBoolean(row["IsHalfDay"])
		//IsAfternoon = row["IsAfternoon"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(row["IsAfternoon"])
		public void LeaveReviewMechanism(int ApplicationID,string Audit)//複雜邏輯
		{
			var leave = _dao.GetLeaveApplicationById(ApplicationID);//根據單號查詢需求資訊
			if (Audit == "准假")
			{
				for(DateTime date = leave.StartDate;date<=leave.EndDate; date = date.AddDays(1))
				{
					DateTime clockInTime = leave.IsAfternoon == true
						? date.Date.AddHours(13)  // 下午 1 點
						: date.Date.AddHours(8);  // 上午 8 點

					var attendance = _attendanceService.GetLeaveAttendance(leave.UserID, date);//根據日期查詢是否有打卡紀錄
					if (attendance==null)//沒打卡紀錄正常將請假單寫入
					{
						_attendanceDao.InsertLeaveAttendance(
						leave.UserID,
						date.Date,
						clockInTime,
						leave.LeaveTypeName,
						leave.IsHalfDay);
					}
					else //打過卡
					{
						if (attendance.sHalfDay != null) //如果請過假期的話用來補假或是更改假期類型
						{
							_attendanceDao.UpdateLeaveAttendance(
						attendance.AttendanceID,
						clockInTime,
						leave.LeaveTypeName,
						leave.IsHalfDay);
						}
						else if (attendance.ClockOutTime != null)//如果請過假且打過下班卡
						{
							TimeSpan workDuration = attendance.ClockOutTime.Value - attendance.ClockInTime.Value;

							if (workDuration.TotalHours < 9)
							{
								// 打卡但未滿工時 直接更新請假類型 + sHalfDay
								_attendanceDao.UpdateLeaveAttendance(
									attendance.AttendanceID,
									clockInTime, // 或 null
									leave.LeaveTypeName,
									leave.IsHalfDay
								);
							}
							// 打卡並滿工時  不處理（跳過）
						}

					}

				}
				_dao.UpdateInToApplicationStatus(ApplicationID, Audit);
			}
			else if (Audit == "核可失敗")
			{
				_dao.UpdateInToApplicationStatus(ApplicationID, Audit);
			}

		}
	}
			
	


		
	
}
