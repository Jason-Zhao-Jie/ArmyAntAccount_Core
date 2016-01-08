using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArmyAntAccount
{
	public partial class UserManager : Form
	{
		public UserManager()
		{
			InitializeComponent();
		}

		private void UserManager_Load(object sender, EventArgs e)
		{
			MessageBox.Show(this,"账户管理功能暂未开发完成","开发未完成");
			Close();
		}
	}
}
