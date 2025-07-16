using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{

	public class ScheduleDao
	{
		public DataTable GetThisWeekWork(int departmentid, DateTime starday)//利用部門id與當日查詢那週工作
		{
			DateTime endday = starday.AddDays(6); // 該週結束日（含）


				var sql = @"SELECT TaskDescription
							FROM Schedule
							WHERE DepartmentID = @departmentid
							AND WeekStartDate BETWEEN @starday AND @endday";
			var parameters = new[]
			{
					new SqlParameter("@departmentid", departmentid),
					new SqlParameter("@starday", starday.Date),
					new SqlParameter("@endday", endday.Date) 
			};

					return DBHelper.ExecuteQuery(sql, parameters);
		}



		public void InsertWork(string note, string dept, DateTime thisdate, int userid)//輸入工作到該日期
		{

			var sql = @"insert into Schedule(WeekStartDate,DepartmentID,TaskDescription,CreatedBy,CreatedDate)
						select @weekstardate,DepartmentID,@note,@userid,GETDATE()
						FROM Department
						where DepartmentName = @DepartmentName";
			var parameters = new[] 
			{
				new SqlParameter("@DepartmentName", dept),
				new SqlParameter("@userid", userid),
				new SqlParameter("@weekstardate", thisdate),
				new SqlParameter("@note", note)
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}


		public DataTable GetDeptWork(string DepartmentName)//根據部門名查詢至今已派發的工作
		{

				var sql = @"select s.WeekStartDate as '派發日',s.TaskDescription as '派發內容',s.CreatedDate as '派發撰寫時間'
				from Schedule s
				join Department d on d.DepartmentID =s.DepartmentID
				join UserAccount u on s.CreatedBy =u.UserID
				where DepartmentName =@DepartmentName
				ORDER BY s.WeekStartDate DESC, s.CreatedDate DESC";
			var param = new SqlParameter("@DepartmentName", DepartmentName);
			return DBHelper.ExecuteQuery(sql, param);
		}
	}
}



