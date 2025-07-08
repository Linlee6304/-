using System;
using System.Collections.Generic;
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

			_dao.UpdateClockOut(userId);

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




	}
}
