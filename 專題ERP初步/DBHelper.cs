using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步
{
	internal class DBHelper
	{
		public static string ConnStr = @"Data Source=LAPTOP-GD2BR52T\SQLEXPRESS;Initial Catalog=ERPSystem;Integrated Security=True;TrustServerCertificate=True;";

		public static SqlConnection GetConnection()
		{
			return new SqlConnection(ConnStr);
		}

		//執行查詢
		public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
		{
			DataTable dt = new DataTable();
			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);

				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);
			}
			return dt;
		}

		// 執行非查詢指令 (Insert/Update/Delete)
		public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);

				return cmd.ExecuteNonQuery();
			}
		}

		// 執行 Scalar 查詢（只取一個值）
		public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				conn.Open();
				if (parameters != null)
					cmd.Parameters.AddRange(parameters);

				return cmd.ExecuteScalar();
			}
		}
	}
}