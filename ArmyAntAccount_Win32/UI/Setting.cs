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
	public partial class Setting : Form
	{
		public Setting()
		{
			InitializeComponent();
		}

		private void Setting_Load(object sender, EventArgs e)
		{
			for(int i=0;i<tabs.TabCount;i++)
			{
				itemBox.Items.Add(tabs.TabPages[i].Text);
			}
			appidText.Text = Core.Cloud.APP_ID.ToString();
			secretidText.Text = Core.Cloud.Secret_ID;
			secretkeyText.Text = Core.Cloud.Secret_Key;
			bucketnameText.Text = Core.Cloud.Bucket_Name;
		}

		private void itemBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			tabs.SelectedIndex = itemBox.SelectedIndex;
		}

		private void commitBtn_Click(object sender, EventArgs e)
		{
			if(!Core.Save(Core.IOType.Data))
				MessageBox.Show(this, "数据保存失败!", "提交");
			else if(!Core.Upload(Core.IOType.Data))
				MessageBox.Show(this, "数据同步失败!", "提交");
			MessageBox.Show(this, "数据同步成功!", "提交");
		}

		private void updateBtn_Click(object sender, EventArgs e)
		{
			if(!Core.Download(Core.IOType.Data))
				MessageBox.Show(this, "数据下载失败!", "更新");
			MessageBox.Show(this, "数据下载成功!", "更新");
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
