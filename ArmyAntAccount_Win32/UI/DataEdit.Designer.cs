namespace ArmyAntAccount
{
	partial class DataEdit
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.typeBox = new System.Windows.Forms.ComboBox();
			this.ioBox = new System.Windows.Forms.ComboBox();
			this.ioNum = new System.Windows.Forms.NumericUpDown();
			this.ioPersonBox = new System.Windows.Forms.ComboBox();
			this.tagBox = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.commentText = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.remarkText = new System.Windows.Forms.TextBox();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelBtn = new System.Windows.Forms.Button();
			this.resetBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ioNum)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "时    间";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "类    别";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 12);
			this.label3.TabIndex = 2;
			this.label3.Text = "金额变动";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "变 更 人";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 123);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 4;
			this.label5.Text = "标    签";
			// 
			// timePicker
			// 
			this.timePicker.Location = new System.Drawing.Point(72, 13);
			this.timePicker.Name = "timePicker";
			this.timePicker.Size = new System.Drawing.Size(200, 21);
			this.timePicker.TabIndex = 5;
			// 
			// typeBox
			// 
			this.typeBox.FormattingEnabled = true;
			this.typeBox.Location = new System.Drawing.Point(72, 41);
			this.typeBox.Name = "typeBox";
			this.typeBox.Size = new System.Drawing.Size(200, 20);
			this.typeBox.TabIndex = 6;
			// 
			// ioBox
			// 
			this.ioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ioBox.FormattingEnabled = true;
			this.ioBox.Items.AddRange(new object[] {
            "收入",
            "支出"});
			this.ioBox.Location = new System.Drawing.Point(72, 67);
			this.ioBox.Name = "ioBox";
			this.ioBox.Size = new System.Drawing.Size(69, 20);
			this.ioBox.TabIndex = 7;
			// 
			// ioNum
			// 
			this.ioNum.Location = new System.Drawing.Point(147, 67);
			this.ioNum.Maximum = new decimal(new int[] {
            1078549667,
            0,
            0,
            0});
			this.ioNum.Name = "ioNum";
			this.ioNum.Size = new System.Drawing.Size(125, 21);
			this.ioNum.TabIndex = 8;
			// 
			// ioPersonBox
			// 
			this.ioPersonBox.FormattingEnabled = true;
			this.ioPersonBox.Location = new System.Drawing.Point(72, 94);
			this.ioPersonBox.Name = "ioPersonBox";
			this.ioPersonBox.Size = new System.Drawing.Size(200, 20);
			this.ioPersonBox.TabIndex = 9;
			// 
			// tagBox
			// 
			this.tagBox.FormattingEnabled = true;
			this.tagBox.Location = new System.Drawing.Point(72, 120);
			this.tagBox.Name = "tagBox";
			this.tagBox.Size = new System.Drawing.Size(200, 20);
			this.tagBox.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 12);
			this.label6.TabIndex = 11;
			this.label6.Text = "收支说明:";
			// 
			// commentText
			// 
			this.commentText.Location = new System.Drawing.Point(12, 176);
			this.commentText.Multiline = true;
			this.commentText.Name = "commentText";
			this.commentText.Size = new System.Drawing.Size(260, 69);
			this.commentText.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 263);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 12);
			this.label7.TabIndex = 13;
			this.label7.Text = "备注:";
			// 
			// remarkText
			// 
			this.remarkText.Location = new System.Drawing.Point(54, 259);
			this.remarkText.Name = "remarkText";
			this.remarkText.Size = new System.Drawing.Size(218, 21);
			this.remarkText.TabIndex = 14;
			// 
			// okBtn
			// 
			this.okBtn.Location = new System.Drawing.Point(14, 300);
			this.okBtn.Name = "okBtn";
			this.okBtn.Size = new System.Drawing.Size(75, 23);
			this.okBtn.TabIndex = 15;
			this.okBtn.Text = "确定";
			this.okBtn.UseVisualStyleBackColor = true;
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelBtn
			// 
			this.cancelBtn.Location = new System.Drawing.Point(196, 300);
			this.cancelBtn.Name = "cancelBtn";
			this.cancelBtn.Size = new System.Drawing.Size(75, 23);
			this.cancelBtn.TabIndex = 16;
			this.cancelBtn.Text = "取消";
			this.cancelBtn.UseVisualStyleBackColor = true;
			this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
			// 
			// resetBtn
			// 
			this.resetBtn.Location = new System.Drawing.Point(105, 300);
			this.resetBtn.Name = "resetBtn";
			this.resetBtn.Size = new System.Drawing.Size(75, 23);
			this.resetBtn.TabIndex = 17;
			this.resetBtn.Text = "重置";
			this.resetBtn.UseVisualStyleBackColor = true;
			this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
			// 
			// DataEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 335);
			this.Controls.Add(this.resetBtn);
			this.Controls.Add(this.cancelBtn);
			this.Controls.Add(this.okBtn);
			this.Controls.Add(this.remarkText);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.commentText);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tagBox);
			this.Controls.Add(this.ioPersonBox);
			this.Controls.Add(this.ioNum);
			this.Controls.Add(this.ioBox);
			this.Controls.Add(this.typeBox);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DataEdit";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DataEdit";
			this.Load += new System.EventHandler(this.DataEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.ioNum)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.ComboBox typeBox;
		private System.Windows.Forms.ComboBox ioBox;
		private System.Windows.Forms.NumericUpDown ioNum;
		private System.Windows.Forms.ComboBox ioPersonBox;
		private System.Windows.Forms.ComboBox tagBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox commentText;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox remarkText;
		private System.Windows.Forms.Button okBtn;
		private System.Windows.Forms.Button cancelBtn;
		private System.Windows.Forms.Button resetBtn;
	}
}