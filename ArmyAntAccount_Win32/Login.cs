using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ArmyAntAccount
{
	public partial class Login : Form
	{
		private UserChecker userdata = null;
		public UserData user = null;
		public Login()
		{
			try
			{
				userdata = new UserChecker(new Stream_Win32(), new QCloudOS_Win32());
			}
			catch(Exception)
			{
				MessageBox.Show("连接云服务器失败,无法读取数据,请检查你的网络连接!");
				DialogResult = DialogResult.Cancel;
				Close();
			}
			InitializeComponent();
		}
		~Login()
		{
			userdata.Save();
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
			user = userdata.Check(uid_text.Text, pwd_text.Text);
			if(null == user)
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
