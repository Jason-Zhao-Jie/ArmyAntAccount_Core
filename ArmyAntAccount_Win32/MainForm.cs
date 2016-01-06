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
	public partial class MainForm : Form
	{
		UserData user = null;
		AccountData data = null;
		public MainForm(UserData user)
		{
			this.user = user;
			try
			{
				data = new AccountData(new Stream_Win32(), new QCloudOS_Win32());
			}
			catch(Exception)
			{
				MessageBox.Show("连接云服务器失败,无法读取数据,请检查你的网络连接!");
				DialogResult = DialogResult.Cancel;
				Close();
			}
			InitializeComponent();
		}

		~MainForm()
		{
			data.Save();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
