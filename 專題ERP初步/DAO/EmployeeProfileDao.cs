using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class EmployeeProfileDao
	{
		public int? GetDepartmentIdByUserId(int userId)//透過userid查詢部門編號
		{
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"SELECT DepartmentID FROM EmployeeProfile WHERE UserID = @userId";

				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@userId", userId);

					var result = cmd.ExecuteScalar();
					return result == null ? (int?)null : Convert.ToInt32(result);
				}
			}
		}
	}
}
