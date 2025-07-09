using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class DepartmentDao
	{
		public List<DepartmentDto> GetAllDepartments()//根據使用者權限為admin直接取得所有部門名稱
		{
			var list = new List<DepartmentDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"select DepartmentName from Department";
				var cmd = new SqlCommand(sql, conn);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new DepartmentDto
						{
							DepartmentName = reader["DepartmentName"].ToString()
						});
					}
				}
			}
			return list;
		}
		
		public DepartmentDto GetUserIdForDepartments(int userid)//根據使用者id直接取得所有部門名稱
		{
			var list = new List<DepartmentDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"select DepartmentName 
							from Department  d
							join EmployeeProfile e on e.DepartmentID=d.DepartmentID
							where e.UserID=@userid;";
				SqlCommand cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@userId", userid);

				using (var reader = cmd.ExecuteReader())
				{					
					if (reader.Read())
					{
						return new DepartmentDto
						{
							DepartmentName = reader["DepartmentName"].ToString()
						};
					} 					
				}
			return null;
			}
		}
	}
	
}
