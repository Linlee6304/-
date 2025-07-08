using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;


namespace 專題ERP初步
{
	//帳號創建
	public partial class UserAccountManagement : Form
	{
		public UserAccountManagement()
		{
			InitializeComponent();
		}

		private void texUserName_TextChanged(object sender, EventArgs e){ }//輸入帳號
		private void texPassword_TextChanged(object sender, EventArgs e){}//輸入密碼
		private void texPassword2_TextChanged(object sender, EventArgs e){}//再次輸入密碼
		private void texFullName_TextChanged(object sender, EventArgs e){}//輸入使用者名稱
		private void texEmail_TextChanged(object sender, EventArgs e){}//輸入email
		private void texPhone_TextChanged(object sender, EventArgs e){}//輸入電話號碼
		private void button1_Click(object sender, EventArgs e)
		{
			string UserName = texUserName.Text.Trim();
			string Password = texPassword.Text.Trim();
			string Password2 = texPassword2.Text.Trim();
			string FullName = texFullName.Text.Trim();
			string Email = texEmail.Text.Trim();
			string Phone = texPhone.Text.Trim();


			if (string.IsNullOrWhiteSpace(UserName) ||
				string.IsNullOrWhiteSpace(Password) ||
				string.IsNullOrWhiteSpace(Password2) ||
				string.IsNullOrWhiteSpace(FullName))
			{
				MessageBox.Show("帳號 密碼 使用者名稱不能空白！");
				return;
			}
			if (Password != Password2) { 
				MessageBox.Show($"密碼輸入不一致");
				return;
			}
			if (Phone.Length != 10)
			{
				MessageBox.Show($"請輸入10位數手機號碼");
				return;
			}
			int turephone;
			if (int.TryParse(Phone, out turephone))
			{}
			else
			{
				MessageBox.Show("請輸入正確的數字！");
				return;
			}
			using (SqlConnection conn = new SqlConnection(DBHelper.ConnStr))
			{
				try
				{
					conn.Open();
					string sql = @"INSERT INTO UserAccount
                   (username, password, FullName, Phone, Email, Role, IsActive)
                   VALUES
                   (@username, @password, @FullName, @Phone, @Email, @Role, @IsActive)";

					var cmd = new Microsoft.Data.SqlClient.SqlCommand(sql, conn);

					cmd.Parameters.AddWithValue("@username", UserName);
					cmd.Parameters.AddWithValue("@password", Password);
					cmd.Parameters.AddWithValue("@FullName", FullName);
					cmd.Parameters.AddWithValue("@Phone", string.IsNullOrWhiteSpace(Phone) ? (object)DBNull.Value : Phone);
					cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(Email) ? (object)DBNull.Value : Email);
					cmd.Parameters.AddWithValue("@Role", "User");   // 設定最低層級角色
					cmd.Parameters.AddWithValue("@IsActive", 1);    // true = 1

					int rows = cmd.ExecuteNonQuery();

					if (rows > 0)
					{
						MessageBox.Show("帳號建立成功！");
					}
					else
					{
						MessageBox.Show("帳號建立失敗！");
					}
				}
				catch (Exception ex) { MessageBox.Show("資料庫連線或查詢錯誤: " + ex.Message); }
			}

			//全部完成確認
		}

		private void 返回登入ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 mainForm = new Form1();
			mainForm.Show();
			this.Close();
		}

		private void UserAccountManagement_Load(object sender, EventArgs e)
		{

		}
	}
}
