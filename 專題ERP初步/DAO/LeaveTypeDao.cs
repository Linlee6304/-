using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;
using Microsoft.Data.SqlClient;

namespace 專題ERP初步.DAO
{
	public class LeaveTypeDao
	{
		public List<LeaveTypeDto> GetLeaveTypes()
		{
			var list = new List<LeaveTypeDto>();
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				string sql = @"select LeaveTypeName from LeaveType";
				var cmd = new SqlCommand(sql, conn);
				using(var reader = cmd.ExecuteReader())
				{
					while (reader.Read())
					{
						list.Add(new LeaveTypeDto
						{
							LeaveTypeName = reader["LeaveTypeName"].ToString()
						});
					}
				}
				return list;

			}
		}
	}
}
