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
			using (var conn = new SqlConnection(DBHelper.ConnStr))
			{
				conn.Open();
				string sql = @"INSERT INTO LeaveProofImage(ApplicationID, ImagePath, FileName, UploadedTime)
                           VALUES (@ApplicationID, @ImagePath, @FileName, @UploadedTime)";
				using (var cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@ApplicationID", dto.ApplicationID);
					cmd.Parameters.AddWithValue("@ImagePath", dto.ImagePath);
					cmd.Parameters.AddWithValue("@FileName", (object?)dto.FileName ?? DBNull.Value);
					cmd.Parameters.AddWithValue("@UploadedTime", (object?)dto.UploadedTime ?? DBNull.Value);

					cmd.ExecuteNonQuery();
				}
			}
		}
	}
}
