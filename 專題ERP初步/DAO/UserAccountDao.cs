using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class UserAccountDao
	{
		public List<UserAccountDto> GetFullName()//讀取所有員工姓名
		{

			var list = new List<UserAccountDto>();

				var sql = @"select FullName from UserAccount";
			DataTable dt = DBHelper.ExecuteQuery(sql);

			foreach (DataRow row in dt.Rows)
			{
				list.Add(new UserAccountDto
				{
					FullName = row["FullName"].ToString()
				});
			}
			return list;
		}
		public int? GetFullNameToUserid(string FullName) //依照輸入的FullName取得id
		{
			var sql = @"select userid from UserAccount where FullName = @FullName";
			var param =new SqlParameter("FullName", FullName);
			object result = DBHelper.ExecuteScalar(sql, param);
			return Convert.ToInt32(result);

		}
	}
}
