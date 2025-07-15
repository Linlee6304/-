using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class UserAccountDto//創建帳號密碼
	{
		public int UserID { get; set; }//流水號
		public string UserName { get; set; }//帳號
		public string Password { get; set; }//密碼
		public string Email { get; set; }//信箱
		public string FullName { get; set; }//使用者名稱
		public string Phone { get; set; }//電話
		public string Role { get; set; }//帳號權限
		public bool IsActive { get; set; }//帳號是否啟用

		public DateTime? CreateDate { get; set; }//帳號使用這者上班日期
	}
}
