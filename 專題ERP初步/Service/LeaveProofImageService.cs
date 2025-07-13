using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 專題ERP初步.DAO;
using 專題ERP初步.DTO;

namespace 專題ERP初步.Service
{
	public class LeaveProofImageService
	{
		private readonly LeaveProofImageDao _dao = new LeaveProofImageDao();

		public void SaveProofImage(int applicationId, string sourceFilePath)
		{
			// 存圖路徑（專案資料夾下 Images/LeaveProofs）
			string imageFolder = Path.Combine(Application.StartupPath, "Images", "LeaveProofs");
			Directory.CreateDirectory(imageFolder); // 若資料夾不存在則建立

			// 檔名處理（用原始檔名＋時間戳防止重複）
			string fileName = Path.GetFileName(sourceFilePath);
			string uniqueFileName = $"{DateTime.Now:yyyyMMddHHmmssfff}_{fileName}";
			string destPath = Path.Combine(imageFolder, uniqueFileName);

			File.Copy(sourceFilePath, destPath); // 實體存檔

			// 儲存到資料庫
			var dto = new LeaveProofImageDto
			{
				ApplicationID = applicationId,
				ImagePath = destPath,
				FileName = fileName,
				UploadedTime = DateTime.Now
			};

			_dao.InsertProofImage(dto);
		}
	}
}
