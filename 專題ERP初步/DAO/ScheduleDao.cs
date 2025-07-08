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

			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT TaskDescription
							FROM Schedule
							WHERE DepartmentID = @departmentid
							AND WeekStartDate BETWEEN @starday AND @endday";
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@departmentid", departmentid);
					cmd.Parameters.AddWithValue("@starday", starday.Date);
					cmd.Parameters.AddWithValue("@endday", endday.Date);

					
					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					DataTable dt = new DataTable();
					adapter.Fill(dt);
					return dt;
				}

			}
		}
	}
}
