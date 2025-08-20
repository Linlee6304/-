using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步
{
	public static class Session
	{
		public static int UserId { get; set; }
		public static string FullName { get; set; } = "";
		public static string Role { get; set; } = "";
	}
}
