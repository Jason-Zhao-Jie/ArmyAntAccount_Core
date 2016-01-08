namespace ArmyAntAccount
{
	partial class Login
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.title = new System.Windows.Forms.Label();
			this.uid_label = new System.Windows.Forms.Label();
			this.uid_text = new System.Windows.Forms.TextBox();
			this.pwd_label = new System.Windows.Forms.Label();
			this.pwd_text = new System.Windows.Forms.TextBox();
			this.OK_btn = new System.Windows.Forms.Button();
			this.Exit_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// title
			// 
			this.title.AutoSize = true;
			this.title.Font = new System.Drawing.Font("宋体", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.title.ForeColor = System.Drawing.Color.Green;
			this.title.Location = new System.Drawing.Point(31, 9);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(135, 20);
			this.title.TabIndex = 0;
			this.title.Text = "账务管理系统";
			// 
			// uid_label
			// 
			this.uid_label.AutoSize = true;
			this.uid_label.Location = new System.Drawing.Point(15, 45);
			this.uid_label.Name = "uid_label";
			this.uid_label.Size = new System.Drawing.Size(29, 12);
			this.uid_label.TabIndex = 1;
			this.uid_label.Text = "账号";
			// 
			// uid_text
			// 
			this.uid_text.Location = new System.Drawing.Point(50, 42);
			this.uid_text.Name = "uid_text";
			this.uid_text.Size = new System.Drawing.Size(135, 21);
			this.uid_text.TabIndex = 2;
			this.uid_text.Text = "zhaojie";
			// 
			// pwd_label
			// 
			this.pwd_label.AutoSize = true;
			this.pwd_label.Location = new System.Drawing.Point(15, 79);
			this.pwd_label.Name = "pwd_label";
			this.pwd_label.Size = new System.Drawing.Size(29, 12);
			this.pwd_label.TabIndex = 3;
			this.pwd_label.Text = "密码";
			// 
			// pwd_text
			// 
			this.pwd_text.Location = new System.Drawing.Point(50, 76);
			this.pwd_text.MaxLength = 16;
			this.pwd_text.Name = "pwd_text";
			this.pwd_text.PasswordChar = '*';
			this.pwd_text.Size = new System.Drawing.Size(135, 21);
			this.pwd_text.TabIndex = 4;
			this.pwd_text.Text = "zjljcy";
			// 
			// OK_btn
			// 
			this.OK_btn.Location = new System.Drawing.Point(17, 112);
			this.OK_btn.Name = "OK_btn";
			this.OK_btn.Size = new System.Drawing.Size(68, 23);
			this.OK_btn.TabIndex = 5;
			this.OK_btn.Text = "登录(&L)";
			this.OK_btn.UseVisualStyleBackColor = true;
			this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
			// 
			// Exit_btn
			// 
			this.Exit_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Exit_btn.Location = new System.Drawing.Point(117, 112);
			this.Exit_btn.Name = "Exit_btn";
			this.Exit_btn.Size = new System.Drawing.Size(68, 23);
			this.Exit_btn.TabIndex = 6;
			this.Exit_btn.Text = "退出(&E)";
			this.Exit_btn.UseVisualStyleBackColor = true;
			this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.OK_btn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Exit_btn;
			this.ClientSize = new System.Drawing.Size(197, 147);
			this.Controls.Add(this.Exit_btn);
			this.Controls.Add(this.OK_btn);
			this.Controls.Add(this.pwd_text);
			this.Controls.Add(this.pwd_label);
			this.Controls.Add(this.uid_text);
			this.Controls.Add(this.uid_label);
			this.Controls.Add(this.title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label title;
		private System.Windows.Forms.Label uid_label;
		private System.Windows.Forms.TextBox uid_text;
		private System.Windows.Forms.Label pwd_label;
		private System.Windows.Forms.TextBox pwd_text;
		private System.Windows.Forms.Button OK_btn;
		private System.Windows.Forms.Button Exit_btn;
	}
}

