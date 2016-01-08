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
				Core.Init(new Stream_Win32(), new QCloudOS_Win32());
			}
			catch(Exception e)
			{
				MessageBox.Show("读取本地数据失败!\n错误信息:" + e.Message);
				return -1;
			}
			if(!Core.Download(Core.IOType.Users))
			{
				MessageBox.Show("从云读取账户信息失败!");
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
			return 0;
		}
		internal static UserData userdata = null;
	}
}