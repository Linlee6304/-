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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 專題ERP初步.DAO//請假申請邏輯
{
	public class LeaveApplicationDao
	{
		public int InsertAndReturnId(int userId, DateTime startDate, DateTime endDate, string? reason, int LeaveTypeID, bool isHalfDay,bool? IsAfternoon)//員工請假申請
		{
;
			string sql = @"Insert into LeaveApplication(UserID,LeaveTypeID,Reason,Status,CreatedTime,StartDate,EndDate,IsHalfDay,IsAfternoon)
							OUTPUT INSERTED.ApplicationID
							Values (@userid,@LeaveTypeID,@Reason,'申請中',@CreatedTime,@StartDate,@EndDate,@IsHalfDay,@IsAfternoon)";
			var Parameters = new[] 
			{
				new SqlParameter("@userid", userId),
				new SqlParameter("@LeaveTypeID", LeaveTypeID),
				new SqlParameter("@Reason", (object?)reason ?? DBNull.Value),
				new SqlParameter("@CreatedTime", DateTime.Now),
				new SqlParameter("@StartDate", startDate),
				new SqlParameter("@EndDate", endDate),
				new SqlParameter("@IsHalfDay", isHalfDay),
				new SqlParameter(@"IsAfternoon",IsAfternoon)
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
		public DataTable GetLeaveApply(int userid)//根據使用者名子取得請假一覽
		{
			var sql = @"select  L.ApplicationID,U.FullName,T.LeaveTypeName,L.Status,CONVERT(varchar(10), L.CreatedTime, 23) AS CreatedDate,L.StartDate,L.EndDate
						from LeaveApplication L join UserAccount U
						ON L.UserID=U.UserID
						JOIN LeaveType T
						ON T.LeaveTypeID = L.LeaveTypeID
						WHERE L.USERID=@userid";
			var param = new SqlParameter("@userid", userid);
			return DBHelper.ExecuteQuery(sql, param);
		}
		public DataTable GetStatusByLeaveApply(string Status)//根據申請狀況取得請假一覽
		{
			var sql = @"select  L.ApplicationID,U.FullName,T.LeaveTypeName,L.Status,CONVERT(varchar(10), L.CreatedTime, 23) AS CreatedDate,L.StartDate,L.EndDate
						from LeaveApplication L join UserAccount U
						ON L.UserID=U.UserID
						JOIN LeaveType T
						ON T.LeaveTypeID = L.LeaveTypeID
						WHERE L.Status=@Status";
			var param = new SqlParameter("@Status", Status);
			return DBHelper.ExecuteQuery(sql, param);
		}
		public LeaveApplicationDto GetLeaveApplicationById(int ApplicationID)//透過請假單號取得這單一列的資訊
		{
			var sql = @"select A.UserId,A.Reason,T.LeaveTypeName,A.StartDate,A.EndDate,A.IsHalfDay,A.IsAfternoon
						from LeaveApplication A
						JOIN LeaveType T
						ON T.LeaveTypeID=A.LeaveTypeID
						where ApplicationID = @ApplicationID";
			var param = new SqlParameter("@ApplicationID", ApplicationID);
			var dt = DBHelper.ExecuteQuery(sql, param);
			if (dt.Rows.Count == 0) return null;

			var row = dt.Rows[0];
			return new LeaveApplicationDto
			{
				UserID = Convert.ToInt32(row["UserID"]),
				Reason = row["Reason"] == DBNull.Value ? null : row["Reason"].ToString(),
				LeaveTypeName = row["LeaveTypeName"].ToString(),
				StartDate = Convert.ToDateTime(row["StartDate"]),
				EndDate = Convert.ToDateTime(row["EndDate"]),
				IsHalfDay = Convert.ToBoolean(row["IsHalfDay"]),
				IsAfternoon = row["IsAfternoon"] == DBNull.Value ? (bool?)null : Convert.ToBoolean(row["IsAfternoon"])
			};
		}
		public void UpdateInToApplicationStatus(int ApplicationID, string status)//透過請假單號對請假類型進行更新
		{
			var sql = @"update LeaveApplication
						set status=@status
						where ApplicationID= @ApplicationID";
			var parameters = new[]
			{
				new SqlParameter("@status",status),
				new SqlParameter("@ApplicationID",ApplicationID)
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}

	}
}
