namespace HowManyDo
{
	partial class Main_Form_Login
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
			this.Login_Label_Id = new System.Windows.Forms.Label();
			this.Login_Btn_Login = new System.Windows.Forms.Button();
			this.Login_TextB_Id = new System.Windows.Forms.TextBox();
			this.Login_TextB_Passwd = new System.Windows.Forms.TextBox();
			this.Login_Lable_Passwd = new System.Windows.Forms.Label();
			this.Login_Btn_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Login_Label_Id
			// 
			this.Login_Label_Id.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Login_Label_Id.Location = new System.Drawing.Point(10, 21);
			this.Login_Label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Login_Label_Id.Name = "Login_Label_Id";
			this.Login_Label_Id.Size = new System.Drawing.Size(143, 32);
			this.Login_Label_Id.TabIndex = 0;
			this.Login_Label_Id.Text = "아이디";
			this.Login_Label_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login_Btn_Login
			// 
			this.Login_Btn_Login.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Login_Btn_Login.Location = new System.Drawing.Point(81, 165);
			this.Login_Btn_Login.Margin = new System.Windows.Forms.Padding(4);
			this.Login_Btn_Login.Name = "Login_Btn_Login";
			this.Login_Btn_Login.Size = new System.Drawing.Size(141, 46);
			this.Login_Btn_Login.TabIndex = 1;
			this.Login_Btn_Login.Text = "로그인";
			this.Login_Btn_Login.UseVisualStyleBackColor = true;
			this.Login_Btn_Login.Click += new System.EventHandler(this.Login_Btn_Login_Click);
			// 
			// Login_TextB_Id
			// 
			this.Login_TextB_Id.Location = new System.Drawing.Point(161, 21);
			this.Login_TextB_Id.Margin = new System.Windows.Forms.Padding(4);
			this.Login_TextB_Id.Name = "Login_TextB_Id";
			this.Login_TextB_Id.Size = new System.Drawing.Size(208, 28);
			this.Login_TextB_Id.TabIndex = 3;
			// 
			// Login_TextB_Passwd
			// 
			this.Login_TextB_Passwd.Location = new System.Drawing.Point(161, 96);
			this.Login_TextB_Passwd.Margin = new System.Windows.Forms.Padding(4);
			this.Login_TextB_Passwd.Name = "Login_TextB_Passwd";
			this.Login_TextB_Passwd.Size = new System.Drawing.Size(208, 28);
			this.Login_TextB_Passwd.TabIndex = 5;
			// 
			// Login_Lable_Passwd
			// 
			this.Login_Lable_Passwd.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Login_Lable_Passwd.Location = new System.Drawing.Point(10, 96);
			this.Login_Lable_Passwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Login_Lable_Passwd.Name = "Login_Lable_Passwd";
			this.Login_Lable_Passwd.Size = new System.Drawing.Size(143, 32);
			this.Login_Lable_Passwd.TabIndex = 4;
			this.Login_Lable_Passwd.Text = "비밀번호";
			this.Login_Lable_Passwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Login_Btn_Cancel
			// 
			this.Login_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Login_Btn_Cancel.Location = new System.Drawing.Point(231, 165);
			this.Login_Btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
			this.Login_Btn_Cancel.Name = "Login_Btn_Cancel";
			this.Login_Btn_Cancel.Size = new System.Drawing.Size(141, 46);
			this.Login_Btn_Cancel.TabIndex = 6;
			this.Login_Btn_Cancel.Text = "취소";
			this.Login_Btn_Cancel.UseVisualStyleBackColor = true;
			this.Login_Btn_Cancel.Click += new System.EventHandler(this.Login_Btn_Cancel_Click);
			// 
			// Main_Form_Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(401, 230);
			this.Controls.Add(this.Login_Btn_Cancel);
			this.Controls.Add(this.Login_TextB_Passwd);
			this.Controls.Add(this.Login_Lable_Passwd);
			this.Controls.Add(this.Login_TextB_Id);
			this.Controls.Add(this.Login_Btn_Login);
			this.Controls.Add(this.Login_Label_Id);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Main_Form_Login";
			this.Text = "로그인";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Login_Label_Id;
		private System.Windows.Forms.Button Login_Btn_Login;
		private System.Windows.Forms.TextBox Login_TextB_Id;
		private System.Windows.Forms.TextBox Login_TextB_Passwd;
		private System.Windows.Forms.Label Login_Lable_Passwd;
		private System.Windows.Forms.Button Login_Btn_Cancel;
	}
}