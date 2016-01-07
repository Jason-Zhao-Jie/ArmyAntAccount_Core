using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ArmyAntAccount
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		~Login()
		{
		}

		private void Login_Load(object sender, EventArgs e)
		{
		}

		private void Exit_btn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void OK_btn_Click(object sender, EventArgs e)
		{
			Program.userdata = Program.userchecker.Check(uid_text.Text, pwd_text.Text);
			if(null == Program.userdata)
			{
				MessageBox.Show(this, "用户名或密码错误", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}
	}
}
