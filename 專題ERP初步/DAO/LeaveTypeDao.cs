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
	public class LeaveTypeDao
	{
		public List<LeaveTypeDto> GetLeaveTypes()
		{
			var list = new List<LeaveTypeDto>();
			string sql = "SELECT LeaveTypeName FROM LeaveType";

			DataTable dt = DBHelper.ExecuteQuery(sql); // 呼叫統一查詢工具

			foreach (DataRow row in dt.Rows) // 使用 DataTable 讀取資料
			{
				list.Add(new LeaveTypeDto
				{
					LeaveTypeName = row["LeaveTypeName"].ToString()
				});
			}
			return list;
		}
	}
}

