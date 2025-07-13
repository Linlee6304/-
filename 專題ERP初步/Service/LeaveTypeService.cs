using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class LeaveTypeService
	{
		private readonly LeaveTypeDao _dao;

		public LeaveTypeService()
		{
			_dao = new LeaveTypeDao(); // ← 少了這行會爆錯
		}

		public List<LeaveTypeDto> GetLeaveTypesName()
		{
			return _dao.GetLeaveTypes();
		}

		
	}
}
