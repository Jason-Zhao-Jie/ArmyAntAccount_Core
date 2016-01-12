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
		public MainForm()
		{
			InitializeComponent();
		}

		~MainForm()
		{
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			if(Program.userdata.access < Access.Manager)
				usermanager_menuItem.Enabled = false;
			FlushCash();
			UpdateListView();
			listview_SelectedIndexChanged(sender, e);
		}

		private void UpdateListView()
		{
			listview.Items.Clear();
			listview.BeginUpdate();
			for(int i = 0; i < Core.Data.Data.Length; i++)
			{
				AddData(Core.Data.Data[i]);
			}
			listview.EndUpdate();
			if(listview.Items.Count > 0)
				listview.Items[0].EnsureVisible();
			FlushCash();
		}

		private void AddData(AccountItem item)
		{
			listview.Items.Insert(0, new ListViewItem(new[] { item.datetime.ToShortDateString(), item.datetime.ToShortTimeString(), item.type, item.change.ToString(), item.person, item.tag, item.comment, item.otherRemark }));
		}

		private void logout_menuItem_Click(object sender, EventArgs e)
		{
			if(save_menuItem.Enabled)
				switch(MessageBox.Show(this, "是否保存更改?", "注销", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Cancel:
						return;
					case DialogResult.Yes:
						Core.Save();
						break;
				}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void exit_menuItem_Click(object sender, EventArgs e)
		{
			if(save_menuItem.Enabled)
				switch(MessageBox.Show(this, "是否保存更改?", "退出", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Cancel:
						return;
					case DialogResult.Yes:
						Core.Save();
						break;
				}
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void add_menuItem_Click(object sender, EventArgs e)
		{
			DataEdit editor = new DataEdit();
			if(editor.ShowDialog(this, null, true) == DialogResult.OK)
			{
				Core.Data.InsertRecord(editor.Data);
				AddData(editor.Data);
				save_menuItem.Enabled = true;
				//listview.Sort();
			}
		}

		private void listview_ItemActivate(object sender, EventArgs e)
		{
			new DataEdit().ShowDialog(this, Core.Data.Data[listview.SelectedItems[0].Index]);
		}

		private void save_menuItem_Click(object sender, EventArgs e)
		{
			if(Core.Save())
				save_menuItem.Enabled = false;
			MessageBox.Show(this, !save_menuItem.Enabled ? "保存成功!" : "保存失败!", "保存");
		}

		private void listview_KeyDown(object sender, KeyEventArgs e)
		{
			switch(e.KeyCode)
			{
				case Keys.Delete:
					delBtn_Click(sender, e);
					break;
				case Keys.Space:
				case Keys.Enter:
					listview_ItemActivate(sender, e);
					break;
				case Keys.Insert:
					add_menuItem_Click(sender, e);
					break;
			}
		}

		private void usermanager_menuItem_Click(object sender, EventArgs e)
		{
			new UserManager().ShowDialog(this);
		}

		private void allset_menuItem_Click(object sender, EventArgs e)
		{
			new Setting().ShowDialog(this);
			UpdateListView();
		}

		private void about_menuItem_Click(object sender, EventArgs e)
		{
			new AboutBox().ShowDialog(this);
		}

		private void sync_menuItem_Click(object sender, EventArgs e)
		{
			if(save_menuItem.Enabled)
				switch(MessageBox.Show(this, "是否先保存更改,然后同步?", "同步", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					case DialogResult.No:
						return;
					case DialogResult.Yes:
						Core.Save();
						break;
				}
			MessageBox.Show(this, Core.Sync(Core.IOType.Data) ? "同步成功!" : "同步失败!", "保存");
		}

		private void changeBtn_Click(object sender, EventArgs e)
		{
			DataEdit editor = new DataEdit();
			if(editor.ShowDialog(this, Core.Data.Data[listview.SelectedItems[0].Index], true) == DialogResult.OK)
			{
				save_menuItem.Enabled = true;
				UpdateListView();
				//listview.Sort();
			}
		}

		private void delBtn_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(this, "确定删除此项数据?", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Core.Data.RemoveRecord(listview.SelectedIndices[0]);
				listview.Items.Remove(listview.Items[listview.SelectedIndices[0]]);
				save_menuItem.Enabled = true;
				FlushCash();
			}
		}

		private void listview_SelectedIndexChanged(object sender, EventArgs e)
		{
			var enable = listview.SelectedIndices.Count > 0;
			changeBtn.Enabled = enable;
			delBtn.Enabled = enable;
		}

		private void LookBtn_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this, "当前资产: " + Core.Data.Total + "\n总收入: " + Core.Data.TotalGain + "\n总支出: " + Core.Data.TotalPain + "\n日均净收入: " + Core.Data.TotalOneDay, "资产总览");
		}

		private void FlushCash()
		{
			nowCash.Text = Core.Data.Total.ToString();
		}
	}
}