using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO//請假申請邏輯
{
	public class LeaveApplicationDao
	{
		public int InsertAndReturnId(int userId, DateTime startDate, DateTime endDate, string? reason, int LeaveTypeID, bool isHalfDay)
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				string sql = @"Insert into LeaveApplication(UserID,LeaveTypeID,Reason,Status,CreatedTime,StartDate,EndDate,IsHalfDay)
								OUTPUT INSERTED.ApplicationID
								Values (@userid,@LeaveTypeID,@Reason,'申請中',@CreatedTime,@StartDate,@EndDate,@IsHalfDay)";
				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@userid", userId);
				cmd.Parameters.AddWithValue("@LeaveTypeID", LeaveTypeID);
				cmd.Parameters.AddWithValue("@Reason", (object?)reason ?? DBNull.Value);
				cmd.Parameters.AddWithValue("@CreatedTime", DateTime.Now);
				cmd.Parameters.AddWithValue("@StartDate", startDate);
				cmd.Parameters.AddWithValue("@EndDate", endDate);
				cmd.Parameters.AddWithValue("@IsHalfDay", isHalfDay);

				return (int)cmd.ExecuteScalar();

			}
		}
		public List<LeaveApplicationDto> GetLeaveApplications(int userid)//進度查詢
		{
			var list = new List<LeaveApplicationDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"select CreatedTime , Reason ,Status ,StartDate ,EndDate ,IsHalfDay 
							from LeaveApplication
							where UserID = @UserID";
				var cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@UserID", userid);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new LeaveApplicationDto
						{
							CreatedTime = reader.GetDateTime(reader.GetOrdinal("CreatedTime")),
							Reason = reader["Reason"]?.ToString(),
							Status = reader["Status"]?.ToString(),
							StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
							EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate")),
							IsHalfDay = reader.GetBoolean(reader.GetOrdinal("IsHalfDay"))

						});
					}
				}
			}
			return list;
		}
	}
}
