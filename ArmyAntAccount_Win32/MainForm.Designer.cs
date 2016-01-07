namespace ArmyAntAccount
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu = new System.Windows.Forms.MenuStrip();
			this.file_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.logout_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exit_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.edit_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.add_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.view_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.total_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setting_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.usermanager_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allset_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.help_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.about_menuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statuBar = new System.Windows.Forms.StatusStrip();
			this.statueTagLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statueLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.listview = new System.Windows.Forms.ListView();
			this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.change = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.person = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.otherRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.mainMenu.SuspendLayout();
			this.statuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menuItem,
            this.edit_menuItem,
            this.view_menuItem,
            this.setting_menuItem,
            this.help_menuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(305, 25);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// file_menuItem
			// 
			this.file_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logout_menuItem,
            this.exit_menuItem});
			this.file_menuItem.Name = "file_menuItem";
			this.file_menuItem.Size = new System.Drawing.Size(58, 21);
			this.file_menuItem.Text = "文件(&F)";
			// 
			// logout_menuItem
			// 
			this.logout_menuItem.Name = "logout_menuItem";
			this.logout_menuItem.Size = new System.Drawing.Size(152, 22);
			this.logout_menuItem.Text = "注销";
			this.logout_menuItem.Click += new System.EventHandler(this.logout_menuItem_Click);
			// 
			// exit_menuItem
			// 
			this.exit_menuItem.Name = "exit_menuItem";
			this.exit_menuItem.Size = new System.Drawing.Size(152, 22);
			this.exit_menuItem.Text = "退出";
			this.exit_menuItem.Click += new System.EventHandler(this.exit_menuItem_Click);
			// 
			// edit_menuItem
			// 
			this.edit_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_menuItem});
			this.edit_menuItem.Name = "edit_menuItem";
			this.edit_menuItem.Size = new System.Drawing.Size(59, 21);
			this.edit_menuItem.Text = "编辑(&E)";
			// 
			// add_menuItem
			// 
			this.add_menuItem.Name = "add_menuItem";
			this.add_menuItem.Size = new System.Drawing.Size(152, 22);
			this.add_menuItem.Text = "添加账目";
			this.add_menuItem.Click += new System.EventHandler(this.add_menuItem_Click);
			// 
			// view_menuItem
			// 
			this.view_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.total_menuItem});
			this.view_menuItem.Name = "view_menuItem";
			this.view_menuItem.Size = new System.Drawing.Size(60, 21);
			this.view_menuItem.Text = "视图(&V)";
			// 
			// total_menuItem
			// 
			this.total_menuItem.Name = "total_menuItem";
			this.total_menuItem.Size = new System.Drawing.Size(100, 22);
			this.total_menuItem.Text = "统计";
			// 
			// setting_menuItem
			// 
			this.setting_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usermanager_menuItem,
            this.allset_menuItem});
			this.setting_menuItem.Name = "setting_menuItem";
			this.setting_menuItem.Size = new System.Drawing.Size(59, 21);
			this.setting_menuItem.Text = "设置(&S)";
			// 
			// usermanager_menuItem
			// 
			this.usermanager_menuItem.Name = "usermanager_menuItem";
			this.usermanager_menuItem.Size = new System.Drawing.Size(124, 22);
			this.usermanager_menuItem.Text = "账户管理";
			// 
			// allset_menuItem
			// 
			this.allset_menuItem.Name = "allset_menuItem";
			this.allset_menuItem.Size = new System.Drawing.Size(124, 22);
			this.allset_menuItem.Text = "首选项";
			// 
			// help_menuItem
			// 
			this.help_menuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.about_menuItem});
			this.help_menuItem.Name = "help_menuItem";
			this.help_menuItem.Size = new System.Drawing.Size(61, 21);
			this.help_menuItem.Text = "帮助(&H)";
			// 
			// about_menuItem
			// 
			this.about_menuItem.Name = "about_menuItem";
			this.about_menuItem.Size = new System.Drawing.Size(100, 22);
			this.about_menuItem.Text = "关于";
			// 
			// statuBar
			// 
			this.statuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.statuBar.Dock = System.Windows.Forms.DockStyle.None;
			this.statuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statueTagLabel,
            this.statueLabel});
			this.statuBar.Location = new System.Drawing.Point(0, 447);
			this.statuBar.Name = "statuBar";
			this.statuBar.Size = new System.Drawing.Size(717, 22);
			this.statuBar.TabIndex = 1;
			this.statuBar.Text = "statusStrip1";
			// 
			// statueTagLabel
			// 
			this.statueTagLabel.AutoSize = false;
			this.statueTagLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			this.statueTagLabel.Name = "statueTagLabel";
			this.statueTagLabel.Size = new System.Drawing.Size(100, 17);
			this.statueTagLabel.Text = "就绪";
			// 
			// statueLabel
			// 
			this.statueLabel.AutoSize = false;
			this.statueLabel.Name = "statueLabel";
			this.statueLabel.Size = new System.Drawing.Size(600, 17);
			// 
			// listview
			// 
			this.listview.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.listview.Alignment = System.Windows.Forms.ListViewAlignment.Default;
			this.listview.AllowColumnReorder = true;
			this.listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listview.AutoArrange = false;
			this.listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.time,
            this.type,
            this.change,
            this.person,
            this.tag,
            this.comment,
            this.otherRemark});
			this.listview.FullRowSelect = true;
			this.listview.GridLines = true;
			this.listview.HideSelection = false;
			this.listview.LabelWrap = false;
			this.listview.Location = new System.Drawing.Point(12, 78);
			this.listview.MultiSelect = false;
			this.listview.Name = "listview";
			this.listview.Size = new System.Drawing.Size(724, 306);
			this.listview.TabIndex = 2;
			this.listview.UseCompatibleStateImageBehavior = false;
			this.listview.View = System.Windows.Forms.View.Details;
			this.listview.ItemActivate += new System.EventHandler(this.listview_ItemActivate);
			// 
			// date
			// 
			this.date.Text = "日期";
			this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.date.Width = 70;
			// 
			// time
			// 
			this.time.Text = "时间";
			this.time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.time.Width = 64;
			// 
			// type
			// 
			this.type.Text = "类别";
			this.type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.type.Width = 61;
			// 
			// change
			// 
			this.change.Text = "收支变更";
			this.change.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.change.Width = 76;
			// 
			// person
			// 
			this.person.Text = "变更者";
			this.person.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.person.Width = 80;
			// 
			// tag
			// 
			this.tag.Text = "标注";
			this.tag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.tag.Width = 70;
			// 
			// comment
			// 
			this.comment.Text = "变更事项";
			this.comment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.comment.Width = 200;
			// 
			// otherRemark
			// 
			this.otherRemark.Text = "备注";
			this.otherRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 469);
			this.Controls.Add(this.listview);
			this.Controls.Add(this.statuBar);
			this.Controls.Add(this.mainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MainMenuStrip = this.mainMenu;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "账务管理系统";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.mainMenu.ResumeLayout(false);
			this.mainMenu.PerformLayout();
			this.statuBar.ResumeLayout(false);
			this.statuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripMenuItem file_menuItem;
		private System.Windows.Forms.ToolStripMenuItem edit_menuItem;
		private System.Windows.Forms.StatusStrip statuBar;
		private System.Windows.Forms.ToolStripMenuItem view_menuItem;
		private System.Windows.Forms.ToolStripMenuItem setting_menuItem;
		private System.Windows.Forms.ToolStripMenuItem help_menuItem;
		private System.Windows.Forms.ToolStripStatusLabel statueTagLabel;
		private System.Windows.Forms.ToolStripStatusLabel statueLabel;
		private System.Windows.Forms.ToolStripMenuItem logout_menuItem;
		private System.Windows.Forms.ToolStripMenuItem exit_menuItem;
		private System.Windows.Forms.ToolStripMenuItem add_menuItem;
		private System.Windows.Forms.ToolStripMenuItem total_menuItem;
		private System.Windows.Forms.ToolStripMenuItem usermanager_menuItem;
		private System.Windows.Forms.ToolStripMenuItem allset_menuItem;
		private System.Windows.Forms.ToolStripMenuItem about_menuItem;
		private System.Windows.Forms.ListView listview;
		private System.Windows.Forms.ColumnHeader time;
		private System.Windows.Forms.ColumnHeader type;
		private System.Windows.Forms.ColumnHeader change;
		private System.Windows.Forms.ColumnHeader person;
		private System.Windows.Forms.ColumnHeader tag;
		private System.Windows.Forms.ColumnHeader comment;
		private System.Windows.Forms.ColumnHeader otherRemark;
		private System.Windows.Forms.ColumnHeader date;
	}
}