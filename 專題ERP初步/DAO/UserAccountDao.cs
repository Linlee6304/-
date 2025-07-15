using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class UserAccountDao
	{
		public List<UserAccountDto> GetFullName()
		{

			var list = new List<UserAccountDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				var sql = @"select FullName from UserAccount";
				var cmd = new SqlCommand(sql, conn);

				using (var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new UserAccountDto
						{
							FullName = reader["FullName"].ToString()
						});
					}
				}
			}
			return list;
		}
	}
}
