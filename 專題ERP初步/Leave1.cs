using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 專題ERP初步.Service;

namespace 專題ERP初步
{
	public partial class Leave1 : Form
	{
		private readonly Form2? _callerForm;
		private readonly int _userId;
		private readonly string _fullName;
		private readonly string _role;

		private byte[] uploadedImageData = null; // 儲存圖片的位元組資料
		public Leave1(Form2 callerForm)
		{
			InitializeComponent();
			_callerForm = callerForm;
			_userId = Session.UserId;
			_fullName = Session.FullName;
			_role = Session.Role;
		}

		private void 返回首頁ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_callerForm.Show();
			this.Close();
		}

		private void LeaveMode_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Leave1_Load(object sender, EventArgs e)
		{
			var LeaveService = new LeaveTypeService();

			try
			{
				var LeaveName = LeaveService.GetLeaveTypesName();
				LeaveMode.DataSource = LeaveName;
				LeaveMode.DisplayMember = "LeaveTypeName";
				LeaveMode.DropDownWidth = 400;
			}
			catch (Exception ex)
			{
				MessageBox.Show("載入失敗：" + ex.Message);
			}



		}

		private void stardate_ValueChanged(object sender, EventArgs e)//起始日
		{

		}

		private void enddate_ValueChanged(object sender, EventArgs e)//終結日
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)//預覽圖片顯示於此
		{
			
		}

		private void btutopictureBox1_Click(object sender, EventArgs e)//上傳圖片紐
		{
			using (OpenFileDialog ofd = new OpenFileDialog())
			{
				ofd.Filter = "圖片檔案 (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

				if (ofd.ShowDialog() == DialogResult.OK)
				{
					FileInfo fileInfo = new FileInfo(ofd.FileName);

					if (fileInfo.Length > 2 * 1024 * 1024) // 2MB 限制
					{
						MessageBox.Show("圖片大小不得超過 2MB！");
						return;
					}

					// 預覽圖片顯示
					pictureBox1.Image = Image.FromFile(ofd.FileName);
					pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

					// 將圖片讀成 byte[]
					uploadedImageData = File.ReadAllBytes(ofd.FileName);
				}
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btuInsert_Click(object sender, EventArgs e)//按下後會把資料送到請假申請表單
		{
			try
			{
				// 1. 取得登入者ID（從 Session）
				int userId = Session.UserId;

				// 2. 請假類型（DropDownList）
				string leaveTypeName = LeaveMode.Text;  // LeaveMode 是 ComboBox

				// 3. 起訖日期
				DateTime startDate = stardate.Value.Date;
				DateTime endDate = enddate.Value.Date;

				// 4. 請假原因（可為 null）
				string? reason = string.IsNullOrWhiteSpace(textBox1.Text) ? null : textBox1.Text;

				// 5. 是否為半天（單選按鈕判斷）
				bool isHalfDay = radioLeave2.Checked;

				// 6. 呼叫 Service 寫入
				var leaveService = new LeaveApplicationService();
				int applicationId = leaveService.InsertAndReturnApplicationId(userId, startDate, endDate, leaveTypeName, reason, isHalfDay);

				if (uploadedImageData != null)
				{
					var imageService = new LeaveProofImageService();
					string tempFilePath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".jpg");
					File.WriteAllBytes(tempFilePath, uploadedImageData);

					imageService.SaveProofImage(applicationId, tempFilePath);
					File.Delete(tempFilePath); // 刪除暫存圖
				}

				MessageBox.Show("請假申請已成功送出！");
			}
			catch (Exception ex)
			{
				MessageBox.Show("申請失敗：" + ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//送出申請查詢紐按下去後會顯示在這
		{

		}

		private void btuSelect_Click(object sender, EventArgs e)//送出申請查詢紐
		{
			var service = new LeaveApplicationService();
			var list = service.GetLeaveApplications(Session.UserId);

			// 選擇用原始資料
			dataGridView1.DataSource = list;

			dataGridView1.Columns["ApplicationID"].Visible = false;
			dataGridView1.Columns["UserID"].Visible = false;
			dataGridView1.Columns["LeaveTypeID"].Visible = false;
			// 顯示中文表頭
			dataGridView1.Columns["CreatedTime"].HeaderText = "建立時間";
			dataGridView1.Columns["Reason"].HeaderText = "請假原因";
			dataGridView1.Columns["Status"].HeaderText = "核可進度";
			dataGridView1.Columns["StartDate"].HeaderText = "請假起始日";
			dataGridView1.Columns["EndDate"].HeaderText = "請假結束日";
			dataGridView1.Columns["IsHalfDay"].HeaderText = "是否為半天";
		}

		private bool isHalfDay = false; // 預設為全天
		private void radioLeave2_CheckedChanged(object sender, EventArgs e)//半天紐
		{
			if (radioLeave2.Checked)
				isHalfDay = true;
		}

		private void radioLeave1_CheckedChanged(object sender, EventArgs e)//全天紐
		{
			if (radioLeave1.Checked)
				isHalfDay = false;
		}
	}
}
