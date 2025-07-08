using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class ScheduleDto
	{
		public int ScheduleID { get; set; }//編寫流水號
		public int CreatedBy { get; set; }//工作派發者
		public int DepartmentID { get; set; }//部門編號
		public DateTime? CreatedDate { get; set; }//編寫日期
		public string TaskDescription { get; set; }//工作內容
		public DateTime?  WeekStartDate { get; set; }//工作起始日

	}
}
