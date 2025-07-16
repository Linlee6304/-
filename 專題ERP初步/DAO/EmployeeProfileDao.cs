using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class EmployeeProfileDao
	{
		public int? GetDepartmentIdByUserId(int userId)//透過userid查詢部門編號
		{

			var sql = @"SELECT DepartmentID FROM EmployeeProfile WHERE UserID = @userId";
			var Parameters = new[]
			{
				new SqlParameter("@userId", userId)
			};
			object result = DBHelper.ExecuteScalar(sql, Parameters);

			// 處理資料不存在的情況
			if (result == null || result == DBNull.Value)
				return null;

			return Convert.ToInt32(result);
		}
			
	}
}

