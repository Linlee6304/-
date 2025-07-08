using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	internal class EmployeeProfileDto
	{
		public int EmployeeID { get; set; }
		public int UserID { get; set; }
		public int DepartmentID { get; set; }
		public string FullName { get; set; }
		public string Position { get; set; }
		public string Phone { get; set; }
		public string EmergencyContactName { get; set; }
		public string EmergencyContactPhone { get; set; }
		public string Address { get; set; }
	}
}
