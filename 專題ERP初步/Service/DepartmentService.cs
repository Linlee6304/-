using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{

	public class DepartmentService
	{
		private readonly DepartmentDao _dao=new DepartmentDao();

		public DepartmentDto GetUserIdForDepartments(int userid)
		{
			return _dao.GetUserIdForDepartments(userid);
		}
		public List<DepartmentDto> GetAllDepartments()
		{
			return _dao.GetAllDepartments();
		}
	}
}
