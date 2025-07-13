using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class LeaveApplicationService
	{
		private readonly LeaveApplicationDao _dao = new LeaveApplicationDao();
		public int InsertAndReturnApplicationId(int userId, DateTime startDate, DateTime endDate, string LeaveType, string? reason, bool isHalfDay)
		{
			int LeaveTypeID = 0;
			if (LeaveType == "病假") { LeaveTypeID = 1; }
			else if (LeaveType == "婚假") { LeaveTypeID = 2; }
			else if (LeaveType == "喪假") { LeaveTypeID = 3; }
			else if (LeaveType == "特休") { LeaveTypeID = 4; }
			else if (LeaveType == "公假") { LeaveTypeID = 5; }
			else if (LeaveType == "事假") { LeaveTypeID = 6; }
			else if (LeaveType == "產假") { LeaveTypeID = 7; }

			return _dao.InsertAndReturnId(userId, startDate, endDate, reason, LeaveTypeID, isHalfDay);
		}

		public List<LeaveApplicationDto> GetLeaveApplications(int userId)
		{
			return _dao.GetLeaveApplications(userId);
		}
	}
}
