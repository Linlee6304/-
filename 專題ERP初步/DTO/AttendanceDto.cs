using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class AttendanceDto
	{
		public int AttendanceID { get; set; }
		public int UserID { get; set; }
		public DateTime AttendanceDate { get; set; }
		public DateTime? ClockInTime { get; set; }
		public DateTime? ClockOutTime { get; set; }
		public bool WorkProgressConfirmed { get; set; }
	}
}
