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
			this.statuBar = new System.Windows.Forms.StatusStrip();
			this.file_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.edit_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.view_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setting_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.help_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statueTagLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.statueLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainMenu.SuspendLayout();
			this.statuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_toolStripMenuItem,
            this.edit_toolStripMenuItem,
            this.view_toolStripMenuItem,
            this.setting_toolStripMenuItem,
            this.help_toolStripMenuItem});
			this.mainMenu.Location = new System.Drawing.Point(0, 0);
			this.mainMenu.Name = "mainMenu";
			this.mainMenu.Size = new System.Drawing.Size(748, 25);
			this.mainMenu.TabIndex = 0;
			this.mainMenu.Text = "menuStrip1";
			// 
			// statuBar
			// 
			this.statuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statueTagLabel,
            this.statueLabel});
			this.statuBar.Location = new System.Drawing.Point(0, 447);
			this.statuBar.Name = "statuBar";
			this.statuBar.Size = new System.Drawing.Size(748, 22);
			this.statuBar.TabIndex = 1;
			this.statuBar.Text = "statusStrip1";
			// 
			// file_toolStripMenuItem
			// 
			this.file_toolStripMenuItem.Name = "file_toolStripMenuItem";
			this.file_toolStripMenuItem.Size = new System.Drawing.Size(58, 21);
			this.file_toolStripMenuItem.Text = "文件(&F)";
			// 
			// edit_toolStripMenuItem
			// 
			this.edit_toolStripMenuItem.Name = "edit_toolStripMenuItem";
			this.edit_toolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.edit_toolStripMenuItem.Text = "编辑(&E)";
			// 
			// view_toolStripMenuItem
			// 
			this.view_toolStripMenuItem.Name = "view_toolStripMenuItem";
			this.view_toolStripMenuItem.Size = new System.Drawing.Size(60, 21);
			this.view_toolStripMenuItem.Text = "视图(&V)";
			// 
			// setting_toolStripMenuItem
			// 
			this.setting_toolStripMenuItem.Name = "setting_toolStripMenuItem";
			this.setting_toolStripMenuItem.Size = new System.Drawing.Size(59, 21);
			this.setting_toolStripMenuItem.Text = "设置(&S)";
			// 
			// help_toolStripMenuItem
			// 
			this.help_toolStripMenuItem.Name = "help_toolStripMenuItem";
			this.help_toolStripMenuItem.Size = new System.Drawing.Size(61, 21);
			this.help_toolStripMenuItem.Text = "帮助(&H)";
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(748, 469);
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
		private System.Windows.Forms.ToolStripMenuItem file_toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem edit_toolStripMenuItem;
		private System.Windows.Forms.StatusStrip statuBar;
		private System.Windows.Forms.ToolStripMenuItem view_toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem setting_toolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem help_toolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel statueTagLabel;
		private System.Windows.Forms.ToolStripStatusLabel statueLabel;
	}
}