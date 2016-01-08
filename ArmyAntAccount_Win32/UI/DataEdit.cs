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
	public partial class DataEdit : Form
	{
		private AccountItem data = new AccountItem();
		public AccountItem Data
		{
			get
			{
				return data;
			}
		}
		public DataEdit()
		{
			InitializeComponent();
			for(int i = 0; i < Core.Data.Data.Length; i++)
			{
				if(!typeBox.Items.Contains(Core.Data.Data[i].type))
					typeBox.Items.Add(Core.Data.Data[i].type);
				if(!ioPersonBox.Items.Contains(Core.Data.Data[i].person))
					ioPersonBox.Items.Add(Core.Data.Data[i].person);
				if(!tagBox.Items.Contains(Core.Data.Data[i].tag))
					tagBox.Items.Add(Core.Data.Data[i].tag);
			}
			ioBox.SelectedIndex = 0;
		}

		private void DataEdit_Load(object sender, EventArgs e)
		{
		}

		public DialogResult ShowDialog(IWin32Window parent, AccountItem data, bool isChange = false)
		{
			if(data != null)
			{
				this.Text = "修改账目";
				this.data = data;
			}
			else
			{
				this.Text = "添加账目";
				this.data.datetime = DateTime.Now;
			}
			resetBtn_Click(null, null);

			bool enable = isChange || data == null;
			timePicker.Enabled = enable;
			typeBox.Enabled = enable;
			ioBox.Enabled = enable;
			ioNum.Enabled = enable;
			ioPersonBox.Enabled = enable;
			tagBox.Enabled = enable;
			commentText.ReadOnly = !enable;
			remarkText.ReadOnly = !enable;
			okBtn.Visible = enable;
			cancelBtn.Visible = enable;
			if(enable)
			{
				resetBtn.Text = "重置(&R)";
				resetBtn.Click -= exitBtn_Click;
				resetBtn.Click += resetBtn_Click;
			}
			else
			{
				this.Text = "账目明细";
				resetBtn.Text = "关闭(&R)";
				resetBtn.Click -= resetBtn_Click;
				resetBtn.Click += exitBtn_Click;
			}

			return ShowDialog(parent);
		}

		private void okBtn_Click(object sender, EventArgs e)
		{
			if(typeBox.Text == "")
			{
				MessageBox.Show(this, "类别不能为空", "输入错误");
				return;
			}
			if(ioNum.Value == 0)
			{
				MessageBox.Show(this, "金额变动不能为0", "输入错误");
				return;
			}
			if(ioPersonBox.Text == "")
			{
				MessageBox.Show(this, "必须填写变更人", "输入错误");
				return;
			}
			if(commentText.Text == "")
			{
				MessageBox.Show(this, "必须填写变更说明", "输入错误");
				return;
			}
			data.datetime = timePicker.Value;
			data.type = typeBox.Text;
			if(ioBox.SelectedIndex == 1)
				data.change = Convert.ToInt32(-ioNum.Value);
			else
				data.change = Convert.ToInt32(ioNum.Value);
			data.person = ioPersonBox.Text;
			data.tag = tagBox.Text;
			data.comment = commentText.Text;
			data.otherRemark = remarkText.Text;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void resetBtn_Click(object sender, EventArgs e)
		{
			timePicker.Value = data.datetime;
			typeBox.Text = data.type;
			if(data.change < 0)
				ioBox.SelectedIndex = 1;
			else
				ioBox.SelectedIndex = 0;
			ioNum.Value = Math.Abs(data.change);
			ioPersonBox.Text = data.person;
			tagBox.Text = data.tag;
			commentText.Text = data.comment;
			remarkText.Text = data.otherRemark;
		}

		private void cancelBtn_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(this, "确定要放弃编辑吗?", "取消", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				return;
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
