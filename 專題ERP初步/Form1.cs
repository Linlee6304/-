using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace 專題ERP初步
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void UserName_TextChanged(object sender, EventArgs e)
		{
			//這格是輸入帳號
		}

		private void password_TextChanged(object sender, EventArgs e)
		{
			//這格是輸入的密碼
		}

		private void login_Click(object sender, EventArgs e)
		{
			using (SqlConnection conn = new SqlConnection(DBHelper.ConnStr))
			{
				try
				{
					conn.Open();
					string sql = "select UserID,FullName,password,Role from UserAccount where IsActive = 1 and UserName = @UserName AND Password = @Password;";
					SqlCommand cmd = new SqlCommand(sql, conn);
					cmd.Parameters.AddWithValue("@UserName", UserName.Text);
					cmd.Parameters.AddWithValue("@Password", password.Text);
					SqlDataReader reader = cmd.ExecuteReader();

					
					if (reader.Read())
					{
						int userId = Convert.ToInt32(reader["UserId"]);
						string fullName = reader["FullName"].ToString();
						string role = reader["Role"].ToString();

						Form2 mainForm = new Form2(userId, fullName, role);
						mainForm.Show();
						this.Hide();
						MessageBox.Show($"登入成功");
					}
					else { MessageBox.Show($"登入失敗"); }
					reader.Close();

				}
				catch (Exception ex) { MessageBox.Show("資料庫連線或查詢錯誤: " + ex.Message); }
			}
			//這格是確認帳號密碼與資料庫相符
		}

		private void UserAccountManagement_Click(object sender, EventArgs e)
		{

			UserAccountManagement mainForm = new UserAccountManagement();
			mainForm.Show();
			this.Hide();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}

}
