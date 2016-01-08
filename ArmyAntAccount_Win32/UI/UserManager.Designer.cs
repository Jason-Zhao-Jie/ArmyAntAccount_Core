namespace ArmyAntAccount
{
	partial class UserManager
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
			this.addBtn = new System.Windows.Forms.Button();
			this.delBtn = new System.Windows.Forms.Button();
			this.seeBtn = new System.Windows.Forms.Button();
			this.closeBtn = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.changeBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(453, 41);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(113, 23);
			this.addBtn.TabIndex = 1;
			this.addBtn.Text = "添加";
			this.addBtn.UseVisualStyleBackColor = true;
			// 
			// delBtn
			// 
			this.delBtn.Location = new System.Drawing.Point(453, 70);
			this.delBtn.Name = "delBtn";
			this.delBtn.Size = new System.Drawing.Size(113, 23);
			this.delBtn.TabIndex = 2;
			this.delBtn.Text = "删除";
			this.delBtn.UseVisualStyleBackColor = true;
			// 
			// seeBtn
			// 
			this.seeBtn.Location = new System.Drawing.Point(453, 12);
			this.seeBtn.Name = "seeBtn";
			this.seeBtn.Size = new System.Drawing.Size(113, 23);
			this.seeBtn.TabIndex = 3;
			this.seeBtn.Text = "查看";
			this.seeBtn.UseVisualStyleBackColor = true;
			// 
			// closeBtn
			// 
			this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.closeBtn.Location = new System.Drawing.Point(453, 150);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(113, 23);
			this.closeBtn.TabIndex = 5;
			this.closeBtn.Text = "关闭";
			this.closeBtn.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(435, 161);
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// changeBtn
			// 
			this.changeBtn.Location = new System.Drawing.Point(453, 99);
			this.changeBtn.Name = "changeBtn";
			this.changeBtn.Size = new System.Drawing.Size(113, 23);
			this.changeBtn.TabIndex = 7;
			this.changeBtn.Text = "修改";
			this.changeBtn.UseVisualStyleBackColor = true;
			// 
			// UserManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.closeBtn;
			this.ClientSize = new System.Drawing.Size(578, 193);
			this.Controls.Add(this.changeBtn);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.seeBtn);
			this.Controls.Add(this.delBtn);
			this.Controls.Add(this.addBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserManager";
			this.Text = "UserManager";
			this.Load += new System.EventHandler(this.UserManager_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addBtn;
		private System.Windows.Forms.Button delBtn;
		private System.Windows.Forms.Button seeBtn;
		private System.Windows.Forms.Button closeBtn;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button changeBtn;
	}
}