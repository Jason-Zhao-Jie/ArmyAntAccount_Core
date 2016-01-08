namespace ArmyAntAccount
{
	partial class Setting
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
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.applyBtn = new System.Windows.Forms.Button();
			this.container = new System.Windows.Forms.SplitContainer();
			this.itemBox = new System.Windows.Forms.ListBox();
			this.tabs = new System.Windows.Forms.TabControl();
			this.sync_tabpage = new System.Windows.Forms.TabPage();
			this.bucketnameText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.updateBtn = new System.Windows.Forms.Button();
			this.commitBtn = new System.Windows.Forms.Button();
			this.secretkeyText = new System.Windows.Forms.TextBox();
			this.secretidText = new System.Windows.Forms.TextBox();
			this.appidText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.container)).BeginInit();
			this.container.Panel1.SuspendLayout();
			this.container.Panel2.SuspendLayout();
			this.container.SuspendLayout();
			this.tabs.SuspendLayout();
			this.sync_tabpage.SuspendLayout();
			this.SuspendLayout();
			// 
			// okBtn
			// 
			this.okBtn.Location = new System.Drawing.Point(72, 308);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(119, 23);
			this.okBtn.TabIndex = 2;
			this.okBtn.Text = "确定(&O)";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelBtn.Location = new System.Drawing.Point(221, 308);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(119, 23);
			this.cancelBtn.TabIndex = 3;
			this.cancelBtn.Text = "取消(&C)";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// applyBtn
			// 
			this.applyBtn.Location = new System.Drawing.Point(370, 308);
			this.applyBtn.Name = "applyBtn";
			this.applyBtn.Size = new System.Drawing.Size(119, 23);
			this.applyBtn.TabIndex = 4;
			this.applyBtn.Text = "应用(&A)";
			this.applyBtn.UseVisualStyleBackColor = true;
			// 
			// container
			// 
			this.container.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.container.Location = new System.Drawing.Point(12, 12);
			this.container.Name = "container";
			// 
			// container.Panel1
			// 
			this.container.Panel1.Controls.Add(this.itemBox);
			// 
			// container.Panel2
			// 
			this.container.Panel2.Controls.Add(this.tabs);
			this.container.Size = new System.Drawing.Size(536, 287);
			this.container.SplitterDistance = 151;
			this.container.TabIndex = 5;
			// 
			// itemBox
			// 
			this.itemBox.FormattingEnabled = true;
			this.itemBox.ItemHeight = 12;
			this.itemBox.Location = new System.Drawing.Point(3, 3);
			this.itemBox.Name = "itemBox";
			this.itemBox.Size = new System.Drawing.Size(141, 280);
			this.itemBox.TabIndex = 0;
			this.itemBox.SelectedIndexChanged += new System.EventHandler(this.itemBox_SelectedIndexChanged);
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.sync_tabpage);
			this.tabs.Location = new System.Drawing.Point(-5, -21);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(384, 304);
			this.tabs.TabIndex = 0;
			// 
			// sync_tabpage
			// 
			this.sync_tabpage.Controls.Add(this.bucketnameText);
			this.sync_tabpage.Controls.Add(this.label4);
			this.sync_tabpage.Controls.Add(this.updateBtn);
			this.sync_tabpage.Controls.Add(this.commitBtn);
			this.sync_tabpage.Controls.Add(this.secretkeyText);
			this.sync_tabpage.Controls.Add(this.secretidText);
			this.sync_tabpage.Controls.Add(this.appidText);
			this.sync_tabpage.Controls.Add(this.label3);
			this.sync_tabpage.Controls.Add(this.label2);
			this.sync_tabpage.Controls.Add(this.label1);
			this.sync_tabpage.Location = new System.Drawing.Point(4, 22);
			this.sync_tabpage.Name = "sync_tabpage";
			this.sync_tabpage.Padding = new System.Windows.Forms.Padding(3);
			this.sync_tabpage.Size = new System.Drawing.Size(376, 278);
			this.sync_tabpage.TabIndex = 1;
			this.sync_tabpage.Text = "同步";
			this.sync_tabpage.UseVisualStyleBackColor = true;
			// 
			// bucketnameText
			// 
			this.bucketnameText.Location = new System.Drawing.Point(83, 92);
			this.bucketnameText.Name = "bucketnameText";
			this.bucketnameText.ReadOnly = true;
			this.bucketnameText.Size = new System.Drawing.Size(287, 21);
			this.bucketnameText.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 95);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "bucket_name:";
			// 
			// updateBtn
			// 
			this.updateBtn.Location = new System.Drawing.Point(244, 131);
			this.updateBtn.Name = "updateBtn";
			this.updateBtn.Size = new System.Drawing.Size(107, 23);
			this.updateBtn.TabIndex = 7;
			this.updateBtn.Text = "立即从云更新";
			this.updateBtn.UseVisualStyleBackColor = true;
			this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
			// 
			// commitBtn
			// 
			this.commitBtn.Location = new System.Drawing.Point(32, 131);
			this.commitBtn.Name = "commitBtn";
			this.commitBtn.Size = new System.Drawing.Size(107, 23);
			this.commitBtn.TabIndex = 6;
			this.commitBtn.Text = "立即提交到云";
			this.commitBtn.UseVisualStyleBackColor = true;
			this.commitBtn.Click += new System.EventHandler(this.commitBtn_Click);
			// 
			// secretkeyText
			// 
			this.secretkeyText.Location = new System.Drawing.Point(83, 65);
			this.secretkeyText.Name = "secretkeyText";
			this.secretkeyText.ReadOnly = true;
			this.secretkeyText.Size = new System.Drawing.Size(287, 21);
			this.secretkeyText.TabIndex = 5;
			// 
			// secretidText
			// 
			this.secretidText.Location = new System.Drawing.Point(83, 38);
			this.secretidText.Name = "secretidText";
			this.secretidText.ReadOnly = true;
			this.secretidText.Size = new System.Drawing.Size(287, 21);
			this.secretidText.TabIndex = 4;
			// 
			// appidText
			// 
			this.appidText.Location = new System.Drawing.Point(83, 11);
			this.appidText.Name = "appidText";
			this.appidText.ReadOnly = true;
			this.appidText.Size = new System.Drawing.Size(287, 21);
			this.appidText.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "secret_key:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(19, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "secret_id:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "app_id:";
			// 
			// Setting
			// 
			this.AcceptButton = this.okBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelBtn;
			this.ClientSize = new System.Drawing.Size(560, 345);
			this.Controls.Add(this.container);
			this.Controls.Add(this.applyBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Setting";
			this.Text = "首选项";
			this.Load += new System.EventHandler(this.Setting_Load);
			this.container.Panel1.ResumeLayout(false);
			this.container.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.container)).EndInit();
			this.container.ResumeLayout(false);
			this.tabs.ResumeLayout(false);
			this.sync_tabpage.ResumeLayout(false);
			this.sync_tabpage.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button applyBtn;
		private System.Windows.Forms.SplitContainer container;
		private System.Windows.Forms.ListBox itemBox;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage sync_tabpage;
		private System.Windows.Forms.TextBox secretkeyText;
		private System.Windows.Forms.TextBox secretidText;
		private System.Windows.Forms.TextBox appidText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button updateBtn;
		private System.Windows.Forms.Button commitBtn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox bucketnameText;
	}
}