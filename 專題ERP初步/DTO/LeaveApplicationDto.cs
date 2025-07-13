using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class LeaveApplicationDto
	{
		public int ApplicationID { get; set; }//請假流水號
		public int UserID { get; set; }//請假人
		public int LeaveTypeID { get; set; }//請假類型id
		public DateTime StartDate { get; set; }//請假起始日
		public DateTime EndDate { get; set; } //請假結束日
		public string? Reason { get; set; }//請假原因
		public string Status { get; set; }//核可進度
		public DateTime CreatedTime { get; set; }//表單建立時間
		public bool IsHalfDay { get; set; } //半天假標記
	}
}
