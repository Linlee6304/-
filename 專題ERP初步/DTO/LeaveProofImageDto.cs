using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 專題ERP初步.DTO
{
	public class LeaveProofImageDto
	{
		public int ImageID { get; set; }              // 圖片主鍵
		public int ApplicationID { get; set; }        // 對應請假申請 ID
		public string ImagePath { get; set; } = null!;      // 圖片儲存路徑（本機或雲端）
		public string? FileName { get; set; }         // 使用者上傳的原始檔名
		public DateTime UploadedTime { get; set; }    // 上傳時間
	}
}
