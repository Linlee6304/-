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
	//此為打卡相關邏輯
	//請假申請另外寫
	public class AttendanceService
	{
		private readonly AttendanceDao _dao = new AttendanceDao();
	
		//上班打卡紐
		public void ClockIn(int userId)
		{
			if (_dao.HasClockInToday(userId))
				throw new Exception("今天已經打過上班卡，不能重複打卡！");

			_dao.InsertClockIn(userId);
		}

		//下班打卡
		public void ClockOut(int userId)
		{
			if (!_dao.HasClockInToday(userId))
				throw new Exception("今天尚未打上班卡，不能打下班卡！");

			if (_dao.HasClockOutToday(userId))
				throw new Exception("今天已經打過下班卡！");

			var attendance = _dao.GetTodayAttendance(userId);
			if (attendance == null || !attendance.WorkProgressConfirmed)
				throw new Exception("請先送出今日工作進度再打下班卡！");

			if (!string.IsNullOrEmpty(attendance.Status))
			{
				// 如果已經被請假或其他狀態佔用，只更新 ClockOutTime 和備註
				string remarks = "自動補打下班卡（已有請假狀態）";
				_dao.UpdateClockOutBasic(userId, DateTime.Now, remarks);
			}
			else
			{
				// 系統自動計算遲到、早退或正常
				DateTime clockOutTime = DateTime.Now;
				TimeSpan duration = clockOutTime - attendance.ClockInTime.Value;

				string status;
				string remarks;

				if (attendance.ClockInTime.Value.Hour >= 10)
				{
					status = "遲到";
					remarks = $"本日只來 {(int)duration.TotalMinutes} 分鐘";
				}
				else if (duration.TotalMinutes < 540)
				{
					status = "早退";
					remarks = $"工時不足 {540 - (int)duration.TotalMinutes} 分鐘";
				}
				else
				{
					status = "正常";
					remarks = "出勤正常";
				}

				_dao.UpdateClockOutWithStatus(userId, clockOutTime, status, remarks);
			}
		}
		// 更新工作進度
		public void SubmitWorkProgress(int userId, string note)
		{
			if (string.IsNullOrWhiteSpace(note))
				throw new Exception("工作進度不得為空白！");

			_dao.UpdateWorkProgressNote(userId, note);
		}

		// 查詢今天出勤紀錄 (for UI 顯示用)
		public AttendanceDto GetTodayAttendance(int userId)
		{
			return _dao.GetTodayAttendance(userId);
		}

		// 是否已打上班卡
		public bool HasClockIn(int userId)
		{
			return _dao.HasClockInToday(userId);
		}

		// 是否已打下班卡
		public bool HasClockOut(int userId)
		{
			return _dao.HasClockOutToday(userId);
		}

		//查詢指定個人出勤紀錄
		public List<AttendanceDto> GetAttendanceByDateRange(int userId, DateTime startDate, DateTime endDate)
		{
			if (userId <= 0)
				throw new ArgumentException("請輸入有效的使用者 ID");

			if (startDate == DateTime.MinValue)
				throw new ArgumentException("請選擇有效的開始日期");

			if (endDate == DateTime.MinValue)
				throw new ArgumentException("請選擇有效的結束日期");

			if (startDate > endDate)
				throw new ArgumentException("開始日期不能大於結束日期");

			return _dao.GetAttendanceByDateRange(userId, startDate, endDate);
		}

		public AttendanceDto? GetLeaveAttendance(int userId, DateTime date)//查詢指定日
		{
			return _dao.GetLeaveAttendance(userId, date);
		}


		public DataTable GetAttendanceByFullNameAndDateRange(string fullName, DateTime startDate, DateTime endDate)
		{
			return _dao.GetAttendanceByFullNameAndDateRange(fullName, startDate, endDate);
		}
		public DataTable GetAttendanceByFullNameAndDateRangeAndStatus(string fullName, DateTime startDate, DateTime endDate, string Status)
		{
			return _dao.GetAttendanceByFullNameAndDateRangeAndStatus(fullName, startDate, endDate, Status);
		}
	}
}
