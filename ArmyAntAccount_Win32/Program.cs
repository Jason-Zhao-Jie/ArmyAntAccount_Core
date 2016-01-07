using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyAntAccount
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static int Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			try
			{
				ConfigSync.cloud = cloud;
				ConfigSync.file = stream;
				ConfigSync.Instance.SyncFromCloud();
				userchecker = new UserChecker(stream, cloud);
				data = new AccountData(stream, cloud);
			}
			catch(Exception)
			{
				MessageBox.Show("连接云服务器失败,无法读取数据,请检查你的网络连接!");
				return -1;
			}
			var ret = new Login();
			MainForm main = new MainForm();
			
			Application.Run(ret);
			while(ret.DialogResult == DialogResult.OK)
			{
				Application.Run(main = new MainForm());
				if(main.DialogResult == DialogResult.OK)
					Application.Run(ret = new Login());
				else
					ret.DialogResult = DialogResult.Cancel;
			}
			userchecker.Save();
			data.Save();
			if(!ConfigSync.Instance.SyncToCloud())
				MessageBox.Show("将数据上传到云时出错!");
			return 0;
		}
		internal static QCloudOS_Win32 cloud = new QCloudOS_Win32();
		internal static Stream_Win32 stream = new Stream_Win32();
		internal static UserChecker userchecker = null;
		internal static AccountData data = null;
		internal static UserData userdata = null;
	}
}
