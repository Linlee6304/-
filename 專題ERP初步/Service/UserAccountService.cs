using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class UserAccountService
	{
		private readonly UserAccountDao _dao= new UserAccountDao();
		public List<UserAccountDto> GetAllFullname()
		{
			return _dao.GetFullName();
		}
		public int? GetUseridByFullname(string FullName)
		{
			return _dao.GetFullNameToUserid(FullName);
		}
	}
}
