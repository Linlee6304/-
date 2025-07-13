using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class LeaveTypeDto
	{
		public int LeaveTypeID { get; set; }      // 請假類型編號（主鍵）
		public string LeaveTypeName { get; set; }      // 類型名稱（如事假、病假）
	}
}
