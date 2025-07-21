using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace 專題ERP初步.DAO
{
	public class AttendanceDao
	{
		public bool HasClockInToday(int userId)//確認是否打過卡
		{

				var sql = @"SELECT COUNT(*) FROM Attendance 
							WHERE UserID = @UserID AND AttendanceDate = CAST(GETDATE() AS DATE) 
							AND ClockInTime IS NOT NULL";
				var param = new SqlParameter("@UserID", userId);
				object result =DBHelper.ExecuteScalar(sql, param);
				return Convert.ToInt32(result) > 0;
		}

		public bool HasClockOutToday(int userId)//確認下班是否已打卡並回傳
		{

			var sql = @"SELECT COUNT(*) FROM Attendance 
						WHERE UserID = @UserID AND 
						AttendanceDate = CAST(GETDATE() AS DATE) 
						AND ClockOutTime IS NOT NULL";
			var param =new SqlParameter("@UserID", userId);
			object result =DBHelper.ExecuteScalar(sql, param);

			return Convert.ToInt32(result) > 0;
			
		}

		public void InsertClockIn(int userId)//插入上班打卡資料
		{

			var sql = @"insert into Attendance(UserID,AttendanceDate,ClockInTime, WorkProgressConfirmed)
							values (@userid,@AttendanceDate,@ClockInTime, 0) ";
			var parameters = new[]
			{
				new SqlParameter("@UserID", userId),
				new SqlParameter("@AttendanceDate", DateTime.Today),
				new SqlParameter("@ClockInTime", DateTime.Now),
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}
		public void UpdateClockOutBasic(int userId, DateTime clockOutTime, string remarks)
		{

			string sql = @"UPDATE Attendance
			SET ClockOutTime = @ClockOutTime,
			Remarks = @Remarks
			WHERE UserID = @UserID
			 AND AttendanceDate = CAST(GETDATE() AS DATE)
			 AND WorkProgressConfirmed = 1
			 AND ClockOutTime IS NULL";
			var parameters = new[]
			{
				new SqlParameter("@ClockOutTime", clockOutTime),
				new SqlParameter("@Remarks", remarks),
				new SqlParameter("@UserID", userId)
			};
			DBHelper.ExecuteQuery(sql, parameters);

			
		}
		public void UpdateClockOutWithStatus(int userId, DateTime clockOutTime, string status, string remarks)
		{
				string sql = @"
				UPDATE Attendance
				SET ClockOutTime = @ClockOutTime,
				Status = @Status,
				Remarks = @Remarks
				WHERE UserID = @UserID
				AND AttendanceDate = CAST(GETDATE() AS DATE)
				AND WorkProgressConfirmed = 1
				AND ClockOutTime IS NULL";

			var parameters = new[]
			{
					new SqlParameter("@ClockOutTime", clockOutTime),
					new SqlParameter("@Status", status),
					new SqlParameter("@Remarks", remarks),
					new SqlParameter("@UserID", userId)
			};
				DBHelper.ExecuteQuery(sql, parameters);
			
		}
		public void UpdateWorkProgressNote(int userId, string note)
		{

			var sql = @"UPDATE Attendance
						SET WorkProgressNote = @Note, 
						WorkProgressConfirmed = 1
						WHERE UserID = @UserID
						AND AttendanceDate = CAST(GETDATE() AS DATE)";

			var parameters = new[]
			{
					new SqlParameter("@Note", note),
					new SqlParameter("@UserID", userId)
			};
			DBHelper.ExecuteQuery(sql,parameters);

		}
		public AttendanceDto? GetTodayAttendance(int userId)
		{

			var sql = @"SELECT AttendanceID, UserID, AttendanceDate, ClockInTime, ClockOutTime, WorkProgressConfirmed
                            FROM Attendance
                            WHERE UserID = @UserID AND AttendanceDate = CAST(GETDATE() AS DATE)";
			var param = new SqlParameter("@UserID", userId);

			DataTable dt =DBHelper.ExecuteQuery(sql, param);
			if (dt.Rows.Count == 0)
				return null;

			DataRow row = dt.Rows[0];
			return new AttendanceDto
			{
				AttendanceID = Convert.ToInt32(row["AttendanceID"]),
				UserID = Convert.ToInt32(row["UserID"]),
				AttendanceDate = Convert.ToDateTime(row["AttendanceDate"]),
				ClockInTime = row["ClockInTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockInTime"]),
				ClockOutTime = row["ClockOutTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockOutTime"]),
				WorkProgressConfirmed = Convert.ToBoolean(row["WorkProgressConfirmed"])
			};

		}

		//查詢個人出勤紀錄
		public List<AttendanceDto> GetAttendanceByDateRange(int userId, DateTime startDate, DateTime endDate)
		{
			var list = new List<AttendanceDto>();

			var sql = @"SELECT AttendanceID, UserID, AttendanceDate, ClockInTime, ClockOutTime, WorkProgressConfirmed
                    FROM Attendance
                    WHERE UserID = @UserID 
                    AND AttendanceDate BETWEEN @StartDate AND @EndDate
                    ORDER BY AttendanceDate";

			var parameters = new[]
			{
				new SqlParameter("@UserID", userId),
				new SqlParameter("@StartDate", startDate),
				new SqlParameter("@EndDate", endDate),
			};


			DataTable dt = DBHelper.ExecuteQuery(sql, parameters);

			foreach (DataRow row in dt.Rows)
			{
				list.Add(new AttendanceDto
				{
					AttendanceID = Convert.ToInt32(row["AttendanceID"]),
					UserID = Convert.ToInt32(row["UserID"]),
					AttendanceDate = Convert.ToDateTime(row["AttendanceDate"]),
					ClockInTime = row["ClockInTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockInTime"]),
					ClockOutTime = row["ClockOutTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockOutTime"]),
					WorkProgressConfirmed = Convert.ToBoolean(row["WorkProgressConfirmed"])
				});
			}
			return list;
		}

		public string? GetTodayTaskDescription(int userId)
		{
			string sql = @"SELECT TOP 1 TaskDescription 
				   FROM Schedule 
				   WHERE DepartmentID = (
					   SELECT DepartmentID FROM EmployeeProfile WHERE UserID = @UserID
				   )
				   AND WeekStartDate <= CAST(GETDATE() AS DATE)
				   ORDER BY WeekStartDate DESC";

			var parameter = new SqlParameter("@UserID", userId);

			object result = DBHelper.ExecuteScalar(sql, parameter);

			return result == null || result == DBNull.Value
				? "今日無排程"
				: result.ToString();
		}

		public void InsertLeaveAttendance(int userId, DateTime leaveDate, DateTime ClockInTime, string leaveType, bool? isHalfDay)//請假輸入用
		{
			var sql = @"INSERT INTO Attendance (UserID, AttendanceDate, ClockInTime, Status, sHalfDay)
						VALUES (@UserID, @LeaveDate, @ClockInTime, @LeaveType, @IsHalfDay)";
			var parameters = new[]
			{
				new SqlParameter("@UserID",userId),
				new SqlParameter("@LeaveDate",leaveDate),
				new SqlParameter("@ClockInTime",ClockInTime),
				new SqlParameter("@LeaveType",leaveType),
				new SqlParameter("@IsHalfDay",isHalfDay)
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}

		public AttendanceDto? GetLeaveAttendance(int userId,DateTime date)//只得指定日出勤資訊
		{

			var sql = @"SELECT AttendanceID, UserID, AttendanceDate, ClockInTime, ClockOutTime, WorkProgressConfirmed
                            FROM Attendance
                            WHERE UserID = @UserID AND AttendanceDate = @date";
			var parameters = new[]
			{
				 new SqlParameter("@UserID", userId),
				 new SqlParameter("@date", date)
			};

			DataTable dt = DBHelper.ExecuteQuery(sql, parameters);
			if (dt.Rows.Count == 0)
				return null;

			DataRow row = dt.Rows[0];
			return new AttendanceDto
			{
				AttendanceID = Convert.ToInt32(row["AttendanceID"]),
				UserID = Convert.ToInt32(row["UserID"]),
				AttendanceDate = Convert.ToDateTime(row["AttendanceDate"]),
				ClockInTime = row["ClockInTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockInTime"]),
				ClockOutTime = row["ClockOutTime"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ClockOutTime"]),
				WorkProgressConfirmed = row["WorkProgressConfirmed"] == DBNull.Value
					? false
					: Convert.ToBoolean(row["WorkProgressConfirmed"]),
			};

		}
		public void UpdateLeaveAttendance(int attendanceId, DateTime? clockInTime, string LeaveTypeName, bool? isHalfDay)
		{
			var sql = @"UPDATE Attendance 
						SET Status = @LeaveTypeName,
							ClockInTime = @ClockInTime,  
							sHalfDay = @IsHalfDay
						WHERE AttendanceID = @AttendanceID";

			var parameters = new List<SqlParameter>
				{
					new SqlParameter("@LeaveTypeName", LeaveTypeName),
					new SqlParameter("@AttendanceID", attendanceId),
					new SqlParameter("@ClockInTime", clockInTime),
					new SqlParameter("@IsHalfDay", isHalfDay.Value)
				};



			DBHelper.ExecuteNonQuery(sql, parameters.ToArray());
		}

		public DataTable GetAttendanceByFullNameAndDateRange(string fullName, DateTime startDate, DateTime endDate)//根據起始日終結日查詢此人出勤狀況
		{
			string sql = @"
        SELECT A.AttendanceDate, A.ClockInTime, A.ClockOutTime, A.Status, A.sHalfDay
        FROM Attendance A
        JOIN UserAccount U ON A.UserID = U.UserID
        WHERE U.FullName = @FullName
          AND A.AttendanceDate BETWEEN @StartDate AND @EndDate
        ORDER BY A.AttendanceDate";

			var parameters = new[]
			{
		new SqlParameter("@FullName", fullName),
		new SqlParameter("@StartDate", startDate),
		new SqlParameter("@EndDate", endDate)
	};

			return DBHelper.ExecuteQuery(sql, parameters);
		}

		public DataTable GetAttendanceByFullNameAndDateRangeAndStatus(string fullName, DateTime startDate, DateTime endDate,string Status)//根據起始日終結日查詢此人出勤狀況
		{
			string sql = @"
        SELECT A.AttendanceDate, A.ClockInTime, A.ClockOutTime, A.Status, A.sHalfDay
        FROM Attendance A
        JOIN UserAccount U ON A.UserID = U.UserID
        WHERE U.FullName = @FullName
		AND A.Status = @Status
         AND A.AttendanceDate BETWEEN @StartDate AND @EndDate
        ORDER BY A.AttendanceDate";

			var parameters = new[]
			{
		new SqlParameter("@FullName", fullName),
		new SqlParameter("@StartDate", startDate),
		new SqlParameter("@EndDate", endDate),
		new SqlParameter("@Status", Status)
			};

			return DBHelper.ExecuteQuery(sql, parameters);
		}



	}
}
