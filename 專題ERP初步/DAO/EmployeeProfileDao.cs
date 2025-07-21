using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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
		public void InsertEmployeeProfile(int Userid, string FullName, string? Phone, string? EmergencyContactName, string? EmergencyContactPhone, string? Address)//初次辦理個人資料
		{
			string Position="新進人員";//預設為新進人員
			int DepartmentID = 5;//預設部門為user
			var sql = @"INSERT INTO EmployeeProfile (UserID, FullName, Position, Phone, EmergencyContactName, EmergencyContactPhone, Address, DepartmentID)
						VALUES(@Userid, @FullName, @Position, @Phone, @EmergencyContactName, @EmergencyContactPhone, @Address, @DepartmentID)";


			var parameters = new[]
			{
					new SqlParameter("@Userid", Userid),
					new SqlParameter("@FullName", FullName),
					new SqlParameter("@Position", Position),
					new SqlParameter("@Phone", Phone),
					new SqlParameter("@EmergencyContactName", EmergencyContactName),
					new SqlParameter("@EmergencyContactPhone", EmergencyContactPhone),
					new SqlParameter("@Address", Address),
					new SqlParameter("@DepartmentID", DepartmentID)

			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}
		public void UpdateEmployeeProfile(int Userid, string FullName, string? Phone, string? EmergencyContactName, string? EmergencyContactPhone, string? Address)//更新個人資料2
		{
			var sql = @"UPDATE EmployeeProfile
						SET FullName = @FullName, 
							Phone = @Phone,
							EmergencyContactName = @EmergencyContactName,
							EmergencyContactPhone = @EmergencyContactPhone,
							Address = @Address
						
						WHERE Userid = @Userid";

			var parameters = new[]
			{
					new SqlParameter("@Userid", Userid),
					new SqlParameter("@FullName", FullName),
					new SqlParameter("@Phone", Phone),
					new SqlParameter("@EmergencyContactName", EmergencyContactName),
					new SqlParameter("@EmergencyContactPhone", EmergencyContactPhone),
					new SqlParameter("@Address", Address),
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}
		public bool HasEmployeeProfile(int userid)//單純查詢有沒有紀錄
		{
			var sql = @"select * from EmployeeProfile where userid =@userid";
			var param = new SqlParameter("@userid", userid);
			DataTable dt = DBHelper.ExecuteQuery(sql, param);
			return dt.Rows.Count > 0;
		}
		public void UpdateEmployeeProfileDepartmentIDAndPosition(int? UserID,int DepartmentID, string Position)
		{
			var sql = @"update EmployeeProfile
						SET Position = @Position,
						DepartmentID =@DepartmentID
						WHERE USERID = @USERID";
			var parameters = new[]
				{
					new SqlParameter("@Position", Position),
					new SqlParameter("@DepartmentID", DepartmentID),
					new SqlParameter("@USERID", UserID)
				};

			DBHelper.ExecuteNonQuery(sql, parameters);
		}
	}
}

