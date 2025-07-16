using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DTO;

namespace 專題ERP初步.DAO
{
	public class LeaveProofImageDao
	{
		public void InsertProofImage(LeaveProofImageDto dto)
		{

			string sql = @"INSERT INTO LeaveProofImage(ApplicationID, ImagePath, FileName, UploadedTime)
                           VALUES (@ApplicationID, @ImagePath, @FileName, @UploadedTime)";
			var parameters = new[] {
				new SqlParameter("@ApplicationID", dto.ApplicationID),
			new SqlParameter("@ImagePath", dto.ImagePath),
			new SqlParameter("@FileName", (object?)dto.FileName ?? DBNull.Value),
			new SqlParameter("@UploadedTime", (object?)dto.UploadedTime ?? DBNull.Value)
			};

		DBHelper.ExecuteNonQuery(sql, parameters);
		}
			
		
	}
}
