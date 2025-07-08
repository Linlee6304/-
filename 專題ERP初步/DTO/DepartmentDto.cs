using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class DepartmentDto//部門
	{
		public int DepartmentID { get; set; }//部門編號
		public string DepartmentName { get; set; }//部門名稱
		public int ManagerID { get; set; }//主管
	}
}
