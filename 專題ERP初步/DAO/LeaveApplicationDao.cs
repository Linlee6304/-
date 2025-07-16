using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO//請假申請邏輯
{
	public class LeaveApplicationDao
	{
		public int InsertAndReturnId(int userId, DateTime startDate, DateTime endDate, string? reason, int LeaveTypeID, bool isHalfDay)//員工請假申請
		{
;
				string sql = @"Insert into LeaveApplication(UserID,LeaveTypeID,Reason,Status,CreatedTime,StartDate,EndDate,IsHalfDay)
								OUTPUT INSERTED.ApplicationID
								Values (@userid,@LeaveTypeID,@Reason,'申請中',@CreatedTime,@StartDate,@EndDate,@IsHalfDay)";
			var Parameters = new[] 
			{
				new SqlParameter("@userid", userId),
				new SqlParameter("@LeaveTypeID", LeaveTypeID),
				new SqlParameter("@Reason", (object?)reason ?? DBNull.Value),
				new SqlParameter("@CreatedTime", DateTime.Now),
				new SqlParameter("@StartDate", startDate),
				new SqlParameter("@EndDate", endDate),
				new SqlParameter("@IsHalfDay", isHalfDay)
			};

			object result = DBHelper.ExecuteScalar(sql, Parameters);
			return Convert.ToInt32(result);
		}
		
		public List<LeaveApplicationDto> GetLeaveApplications(int userid)//進度查詢
		{
			var list = new List<LeaveApplicationDto>();

				var sql = @"select CreatedTime , Reason ,Status ,StartDate ,EndDate ,IsHalfDay 
							from LeaveApplication
							where UserID = @UserID";

			var param = new SqlParameter("@UserID", userid);
			DataTable dt = DBHelper.ExecuteQuery(sql,param);

			foreach (DataRow row in dt.Rows)
			{
				list.Add(new LeaveApplicationDto
				{
					CreatedTime = Convert.ToDateTime(row["CreatedTime"]),
					Reason = row["Reason"]?.ToString(),
					Status = row["Status"]?.ToString(),
					StartDate = Convert.ToDateTime(row["StartDate"]),
					EndDate = Convert.ToDateTime(row["EndDate"]),
					IsHalfDay = Convert.ToBoolean(row["IsHalfDay"])
				});
			}
			return list;
		}
	}
}
