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
			var param =new SqlParameter("@FullName", FullName);
			object result = DBHelper.ExecuteScalar(sql, param);
			return Convert.ToInt32(result);
		}
		public void UpdateUserAccount(int Userid,string FullName, string Phone, string email,DateTime Createdtime)//更新個人資料
		{
			var sql = @"UPDATE UserAccount
						SET FullName = @FullName, 
							Phone = @Phone,
							email = @email,
							CreatedDate = @CreatedDate
						
						WHERE UserID = @UserID";

			var parameters = new[]
			{
					new SqlParameter("@FullName", FullName),
					new SqlParameter("@Phone", Phone),
					new SqlParameter("@email", email),
					new SqlParameter("@CreatedDate", Createdtime),
					new SqlParameter("@UserID", Userid)
			};
			DBHelper.ExecuteNonQuery(sql, parameters);
		}
		public DataTable GetUserAccountJoinDepartmentAndEmployee()//取得所有員工個人資訊
		{
			var sql = @"select a.FullName as '姓名', a.Role as '權限', a.Email as '信箱',a.Phone as '電話',a.CreatedDate as '入職日期',d.DepartmentName as '部門',e.Position as '職位名稱',e.EmergencyContactName as '緊急聯絡人',e.EmergencyContactPhone as '緊急聯絡電話',e.Address as '住址'
						from UserAccount A
						LEFT JOIN EmployeeProfile e
						on a.UserID =e.UserID
						LEFT JOIN Department d
						on d.DepartmentID=e.DepartmentID";
			return DBHelper.ExecuteQuery(sql);
		}
		public void UpdateUserAccountRole(int? UserID, string Role)
		{
			var sql = @"UPDATE UserAccount
						SET Role = @Role
						WHERE USERID = @USERID";
			var parameters = new[]
				{

					new SqlParameter("@Role", Role),
					new SqlParameter("@USERID", UserID)
				};

			DBHelper.ExecuteNonQuery(sql, parameters);
		}
	}
}
