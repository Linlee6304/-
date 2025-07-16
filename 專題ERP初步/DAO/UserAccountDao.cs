using Microsoft.Data.SqlClient;
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
		public List<UserAccountDto> GetFullName()
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
	}
}
