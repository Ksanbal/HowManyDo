namespace HowManyDo
{
	partial class Form_CheckLog
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
			if (disposing && (components != null))
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
			this.CheckLog_Btn_Cancel = new System.Windows.Forms.Button();
			this.CheckLog_Pic_SelectedPic = new System.Windows.Forms.PictureBox();
			this.CheckLog_TextB_Body = new System.Windows.Forms.TextBox();
			this.CheckLog_Label_Title = new System.Windows.Forms.Label();
			this.CheckLog_Label_Sname = new System.Windows.Forms.Label();
			this.CheckLog_Label_Date = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.CheckLog_Pic_SelectedPic)).BeginInit();
			this.SuspendLayout();
			// 
			// CheckLog_Btn_Cancel
			// 
			this.CheckLog_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CheckLog_Btn_Cancel.Location = new System.Drawing.Point(346, 385);
			this.CheckLog_Btn_Cancel.Name = "CheckLog_Btn_Cancel";
			this.CheckLog_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.CheckLog_Btn_Cancel.TabIndex = 12;
			this.CheckLog_Btn_Cancel.Text = "취소";
			this.CheckLog_Btn_Cancel.UseVisualStyleBackColor = true;
			this.CheckLog_Btn_Cancel.Click += new System.EventHandler(this.CheckLog_Btn_Cancel_Click);
			// 
			// CheckLog_Pic_SelectedPic
			// 
			this.CheckLog_Pic_SelectedPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CheckLog_Pic_SelectedPic.Location = new System.Drawing.Point(346, 151);
			this.CheckLog_Pic_SelectedPic.Name = "CheckLog_Pic_SelectedPic";
			this.CheckLog_Pic_SelectedPic.Size = new System.Drawing.Size(138, 90);
			this.CheckLog_Pic_SelectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.CheckLog_Pic_SelectedPic.TabIndex = 11;
			this.CheckLog_Pic_SelectedPic.TabStop = false;
			// 
			// CheckLog_TextB_Body
			// 
			this.CheckLog_TextB_Body.Location = new System.Drawing.Point(11, 13);
			this.CheckLog_TextB_Body.Multiline = true;
			this.CheckLog_TextB_Body.Name = "CheckLog_TextB_Body";
			this.CheckLog_TextB_Body.Size = new System.Drawing.Size(328, 425);
			this.CheckLog_TextB_Body.TabIndex = 9;
			// 
			// CheckLog_Label_Title
			// 
			this.CheckLog_Label_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CheckLog_Label_Title.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CheckLog_Label_Title.Location = new System.Drawing.Point(346, 13);
			this.CheckLog_Label_Title.Name = "CheckLog_Label_Title";
			this.CheckLog_Label_Title.Size = new System.Drawing.Size(138, 23);
			this.CheckLog_Label_Title.TabIndex = 10;
			this.CheckLog_Label_Title.Text = "원생 이름";
			this.CheckLog_Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CheckLog_Label_Sname
			// 
			this.CheckLog_Label_Sname.Font = new System.Drawing.Font("서울남산체 M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CheckLog_Label_Sname.Location = new System.Drawing.Point(346, 40);
			this.CheckLog_Label_Sname.Name = "CheckLog_Label_Sname";
			this.CheckLog_Label_Sname.Size = new System.Drawing.Size(138, 36);
			this.CheckLog_Label_Sname.TabIndex = 13;
			this.CheckLog_Label_Sname.Text = "홍길동";
			this.CheckLog_Label_Sname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CheckLog_Label_Date
			// 
			this.CheckLog_Label_Date.Font = new System.Drawing.Font("서울남산체 M", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.CheckLog_Label_Date.Location = new System.Drawing.Point(346, 83);
			this.CheckLog_Label_Date.Name = "CheckLog_Label_Date";
			this.CheckLog_Label_Date.Size = new System.Drawing.Size(138, 23);
			this.CheckLog_Label_Date.TabIndex = 15;
			this.CheckLog_Label_Date.Text = "2019. 11. 10";
			this.CheckLog_Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form_CheckLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.CheckLog_Label_Date);
			this.Controls.Add(this.CheckLog_Label_Sname);
			this.Controls.Add(this.CheckLog_Btn_Cancel);
			this.Controls.Add(this.CheckLog_Pic_SelectedPic);
			this.Controls.Add(this.CheckLog_TextB_Body);
			this.Controls.Add(this.CheckLog_Label_Title);
			this.Name = "Form_CheckLog";
			this.Text = "글 확인하기";
			((System.ComponentModel.ISupportInitialize)(this.CheckLog_Pic_SelectedPic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button CheckLog_Btn_Cancel;
		private System.Windows.Forms.PictureBox CheckLog_Pic_SelectedPic;
		private System.Windows.Forms.TextBox CheckLog_TextB_Body;
		private System.Windows.Forms.Label CheckLog_Label_Title;
		private System.Windows.Forms.Label CheckLog_Label_Sname;
		private System.Windows.Forms.Label CheckLog_Label_Date;
	}
}