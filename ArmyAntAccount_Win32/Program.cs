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
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var ret = new Login();
			Application.Run(ret);
			if(ret.DialogResult == DialogResult.OK)
				Application.Run(new MainForm(ret.user));
		}
	}
}
