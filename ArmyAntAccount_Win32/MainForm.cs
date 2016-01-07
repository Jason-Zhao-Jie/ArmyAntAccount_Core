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
			listview.BeginUpdate();
			for(int i = 0; i < Program.data.Data.Length; i++)
			{
				AddData(Program.data.Data[i]);
			}
			listview.EndUpdate();
			if(listview.Items.Count > 0)
				listview.Items[0].EnsureVisible();
		}

		private void AddData(AccountItem item)
		{
			listview.Items.Insert(0, new ListViewItem(new[] { item.datetime.ToShortDateString(), item.datetime.ToShortTimeString(), item.type, item.change.ToString(), item.person, item.tag, item.comment, item.otherRemark }));
		}

		private void logout_menuItem_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void exit_menuItem_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void add_menuItem_Click(object sender, EventArgs e)
		{
			DataEdit editor = new DataEdit();
			if(editor.ShowDialog(this, null, true) == DialogResult.OK)
			{
				Program.data.InsertRecord(editor.Data);
				AddData(editor.Data);
				//listview.Sort();
			}
		}

		private void listview_ItemActivate(object sender, EventArgs e)
		{
			new DataEdit().ShowDialog(this, Program.data.Data[listview.SelectedItems[0].Index]);
		}
	}
}
