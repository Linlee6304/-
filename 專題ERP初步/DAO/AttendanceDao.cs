using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class AttendanceDao
	{
		public bool HasClockInToday(int userId)//確認是否打過卡
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT COUNT(*) FROM Attendance 
							WHERE UserID = @UserID AND AttendanceDate = CAST(GETDATE() AS DATE) 
							AND ClockInTime IS NOT NULL";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userId);
				return (int)cmd.ExecuteScalar() > 0;
			}
		}

		public bool HasClockOutToday(int userId)//確認下班是否已打卡並回傳
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT COUNT(*) FROM Attendance 
							WHERE UserID = @UserID AND 
							AttendanceDate = CAST(GETDATE() AS DATE) 
							AND ClockOutTime IS NOT NULL";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userId);

				return (int)cmd.ExecuteScalar() > 0;
			}
		}

		public void InsertClockIn(int userId)//插入上班打卡資料
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"insert into Attendance(UserID,AttendanceDate,ClockInTime, WorkProgressConfirmed)
							values (@userid,@AttendanceDate,@ClockInTime, 0) ";
				var cmd = new SqlCommand(sql, conn);

				cmd.Parameters.AddWithValue("@UserID", userId);
				cmd.Parameters.AddWithValue("@AttendanceDate", DateTime.Today); // 今天的日期
				cmd.Parameters.AddWithValue("@ClockInTime", DateTime.Now);      // 現在時間作為打卡時間

				cmd.ExecuteNonQuery();

			}
		}
		public void UpdateClockOutBasic(int userId, DateTime clockOutTime, string remarks)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				string sql = @"
			UPDATE Attendance
			SET ClockOutTime = @ClockOutTime,
				Remarks = @Remarks
			WHERE UserID = @UserID
			  AND AttendanceDate = CAST(GETDATE() AS DATE)
			  AND WorkProgressConfirmed = 1
			  AND ClockOutTime IS NULL";

				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ClockOutTime", clockOutTime);
				cmd.Parameters.AddWithValue("@Remarks", remarks);
				cmd.Parameters.AddWithValue("@UserID", userId);
				cmd.ExecuteNonQuery();
			}
		}
		public void UpdateClockOutWithStatus(int userId, DateTime clockOutTime, string status, string remarks)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				string sql = @"
			UPDATE Attendance
			SET ClockOutTime = @ClockOutTime,
				Status = @Status,
				Remarks = @Remarks
			WHERE UserID = @UserID
			  AND AttendanceDate = CAST(GETDATE() AS DATE)
			  AND WorkProgressConfirmed = 1
			  AND ClockOutTime IS NULL";

				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ClockOutTime", clockOutTime);
				cmd.Parameters.AddWithValue("@Status", status);
				cmd.Parameters.AddWithValue("@Remarks", remarks);
				cmd.Parameters.AddWithValue("@UserID", userId);
				cmd.ExecuteNonQuery();
			}
		}
		public void UpdateWorkProgressNote(int userId, string note)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();

				var sql = @"UPDATE Attendance
							SET WorkProgressNote = @Note, 
							WorkProgressConfirmed = 1
							WHERE UserID = @UserID
							AND AttendanceDate = CAST(GETDATE() AS DATE)";

				var cmd = new SqlCommand(sql, conn);

				// 加入參數
				cmd.Parameters.AddWithValue("@Note", note);
				cmd.Parameters.AddWithValue("@UserID", userId);

				cmd.ExecuteNonQuery();
			}
		}
		public AttendanceDto GetTodayAttendance(int userId)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT AttendanceID, UserID, AttendanceDate, ClockInTime, ClockOutTime, WorkProgressConfirmed
                            FROM Attendance
                            WHERE UserID = @UserID AND AttendanceDate = CAST(GETDATE() AS DATE)";
				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userId);

				using (var reader = cmd.ExecuteReader())
				{
					if (reader.Read())
					{
						return new AttendanceDto
						{
							AttendanceID = (int)reader["AttendanceID"],
							UserID = (int)reader["UserID"],
							AttendanceDate = (DateTime)reader["AttendanceDate"],
							ClockInTime = reader["ClockInTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ClockInTime"],
							ClockOutTime = reader["ClockOutTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ClockOutTime"],
							WorkProgressConfirmed = (bool)reader["WorkProgressConfirmed"]
						};
					}
				}
			}
			return null;
		}

		//查詢個人出勤紀錄
		public List<AttendanceDto> GetAttendanceByDateRange(int userId, DateTime startDate, DateTime endDate)
		{
			var list = new List<AttendanceDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT AttendanceID, UserID, AttendanceDate, ClockInTime, ClockOutTime, WorkProgressConfirmed
                    FROM Attendance
                    WHERE UserID = @UserID 
                    AND AttendanceDate BETWEEN @StartDate AND @EndDate
                    ORDER BY AttendanceDate";

				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userId);
				cmd.Parameters.AddWithValue("@StartDate", startDate);
				cmd.Parameters.AddWithValue("@EndDate", endDate);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new AttendanceDto
						{
							AttendanceID = (int)reader["AttendanceID"],
							UserID = (int)reader["UserID"],
							AttendanceDate = (DateTime)reader["AttendanceDate"],
							ClockInTime = reader["ClockInTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ClockInTime"],
							ClockOutTime = reader["ClockOutTime"] == DBNull.Value ? (DateTime?)null : (DateTime)reader["ClockOutTime"],
							WorkProgressConfirmed = (bool)reader["WorkProgressConfirmed"]
						});
					}
				}
			}
			return list;
		}

		public string GetTodayTaskDescription(int userId)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT TOP 1 TaskDescription 
                    FROM Schedule 
                    WHERE DepartmentID = (SELECT DepartmentID FROM EmployeeProfile WHERE UserID = @UserID)
                      AND WeekStartDate <= CAST(GETDATE() AS DATE)
                    ORDER BY WeekStartDate DESC";

				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userId);

				var result = cmd.ExecuteScalar();
				return result == null ? "今日無排程" : result.ToString();
			}
		}


		

	}
}
