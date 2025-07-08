using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class ScheduleService
	{
		private readonly ScheduleDao _scheduleDao = new ScheduleDao();
		private readonly EmployeeProfileDao _employeeprofileDao = new EmployeeProfileDao();
		public DataTable GetWeeklyScheduleByUserId(int userId, DateTime starday)
		{
			int? departmentId = _employeeprofileDao.GetDepartmentIdByUserId(userId);
			if (departmentId == null)
				throw new Exception("查無此使用者的部門資料");

			// 2. 查該部門當週排程
			return _scheduleDao.GetThisWeekWork(departmentId.Value, starday);
		}
	}
}
