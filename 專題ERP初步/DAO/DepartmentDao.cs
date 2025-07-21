using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
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

			var sql = @"select DepartmentName from Department";
			DataTable dt = DBHelper.ExecuteQuery(sql);
			foreach (DataRow row in dt.Rows) 
			{ 
				list.Add(new DepartmentDto
				{
					DepartmentName = row["DepartmentName"]?.ToString()
				});
				
			}
			return list;
				
		}



		public List<DepartmentDto> GetUserIdForDepartments(int userid)//根據使用者id直接取得其單一部門名稱
		{
			var list = new List<DepartmentDto>();

			var sql = @"select DepartmentName 
						from Department  d
						join EmployeeProfile e on e.DepartmentID=d.DepartmentID
						where e.UserID=@userid;";
			var parameter = new SqlParameter("@UserID", userid);
			DataTable dt = DBHelper.ExecuteQuery(sql, parameter);

			foreach (DataRow row in dt.Rows)
			{ 
				
				list.Add(new DepartmentDto
				{ 
					DepartmentName = row["DepartmentName"]?.ToString()
				});
			}
			
			return list;
		}
		public int GetDepartmentnameToDepartmentnameid(string Departmentname) //依照輸入的departmentname取得id
		{
			var sql = @"select DepartmentID from Department where Departmentname = @Departmentname";
			var param = new SqlParameter("@Departmentname", Departmentname);
			object result = DBHelper.ExecuteScalar(sql, param);
			return Convert.ToInt32(result);
		}

	}
	
}
