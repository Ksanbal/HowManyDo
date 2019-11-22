namespace HowManyDo.Admin
{
	partial class Admin_Form_Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form_Main));
			this.Admin_Btn_Write = new System.Windows.Forms.Button();
			this.Admin_Btn_Log = new System.Windows.Forms.Button();
			this.Admin_Btn_Manage = new System.Windows.Forms.Button();
			this.Admin_Label_Date = new System.Windows.Forms.Label();
			this.Admin_Label_Name = new System.Windows.Forms.Label();
			this.Admin_Pic_Logo = new System.Windows.Forms.PictureBox();
			this.Admin_Label_Welcome = new System.Windows.Forms.Label();
			this.Admin_Label_Title = new System.Windows.Forms.Label();
			this.Admin_MenuStrip = new System.Windows.Forms.MenuStrip();
			this.Admin_quitbtn = new System.Windows.Forms.ToolStripMenuItem();
			this.logout = new System.Windows.Forms.ToolStripMenuItem();
			this.exit = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.Admin_Pic_Logo)).BeginInit();
			this.Admin_MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Admin_Btn_Write
			// 
			this.Admin_Btn_Write.Font = new System.Drawing.Font("서울남산체 M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Btn_Write.Location = new System.Drawing.Point(290, 20);
			this.Admin_Btn_Write.Name = "Admin_Btn_Write";
			this.Admin_Btn_Write.Size = new System.Drawing.Size(215, 79);
			this.Admin_Btn_Write.TabIndex = 0;
			this.Admin_Btn_Write.Text = "글 작성하기";
			this.Admin_Btn_Write.UseVisualStyleBackColor = true;
			this.Admin_Btn_Write.Click += new System.EventHandler(this.Admin_Btn_Write_Click);
			// 
			// Admin_Btn_Log
			// 
			this.Admin_Btn_Log.Font = new System.Drawing.Font("서울남산체 M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Btn_Log.Location = new System.Drawing.Point(290, 114);
			this.Admin_Btn_Log.Name = "Admin_Btn_Log";
			this.Admin_Btn_Log.Size = new System.Drawing.Size(215, 79);
			this.Admin_Btn_Log.TabIndex = 1;
			this.Admin_Btn_Log.Text = "내역 확인하기";
			this.Admin_Btn_Log.UseVisualStyleBackColor = true;
			this.Admin_Btn_Log.Click += new System.EventHandler(this.Admin_Btn_Log_Click);
			// 
			// Admin_Btn_Manage
			// 
			this.Admin_Btn_Manage.Font = new System.Drawing.Font("서울남산체 M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Btn_Manage.Location = new System.Drawing.Point(290, 209);
			this.Admin_Btn_Manage.Name = "Admin_Btn_Manage";
			this.Admin_Btn_Manage.Size = new System.Drawing.Size(215, 79);
			this.Admin_Btn_Manage.TabIndex = 2;
			this.Admin_Btn_Manage.Text = "원생 관리";
			this.Admin_Btn_Manage.UseVisualStyleBackColor = true;
			this.Admin_Btn_Manage.Click += new System.EventHandler(this.Admin_Btn_Manage_Click);
			// 
			// Admin_Label_Date
			// 
			this.Admin_Label_Date.Font = new System.Drawing.Font("서울남산체 M", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Label_Date.Location = new System.Drawing.Point(30, 193);
			this.Admin_Label_Date.Name = "Admin_Label_Date";
			this.Admin_Label_Date.Size = new System.Drawing.Size(254, 33);
			this.Admin_Label_Date.TabIndex = 3;
			this.Admin_Label_Date.Text = "2019. 11. 10";
			this.Admin_Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Admin_Label_Name
			// 
			this.Admin_Label_Name.Font = new System.Drawing.Font("서울한강체 M", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Label_Name.Location = new System.Drawing.Point(19, 114);
			this.Admin_Label_Name.Name = "Admin_Label_Name";
			this.Admin_Label_Name.Size = new System.Drawing.Size(265, 79);
			this.Admin_Label_Name.TabIndex = 4;
			this.Admin_Label_Name.Text = "애플미술";
			this.Admin_Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Admin_Pic_Logo
			// 
			this.Admin_Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Admin_Pic_Logo.Image")));
			this.Admin_Pic_Logo.Location = new System.Drawing.Point(12, 34);
			this.Admin_Pic_Logo.Name = "Admin_Pic_Logo";
			this.Admin_Pic_Logo.Size = new System.Drawing.Size(80, 80);
			this.Admin_Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Admin_Pic_Logo.TabIndex = 5;
			this.Admin_Pic_Logo.TabStop = false;
			// 
			// Admin_Label_Welcome
			// 
			this.Admin_Label_Welcome.Font = new System.Drawing.Font("서울남산체 M", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Label_Welcome.Location = new System.Drawing.Point(32, 230);
			this.Admin_Label_Welcome.Name = "Admin_Label_Welcome";
			this.Admin_Label_Welcome.Size = new System.Drawing.Size(252, 27);
			this.Admin_Label_Welcome.TabIndex = 6;
			this.Admin_Label_Welcome.Text = "환영합니다 *Admin*님";
			this.Admin_Label_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Admin_Label_Title
			// 
			this.Admin_Label_Title.Font = new System.Drawing.Font("서울한강체 M", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Admin_Label_Title.Location = new System.Drawing.Point(9, 282);
			this.Admin_Label_Title.Name = "Admin_Label_Title";
			this.Admin_Label_Title.Size = new System.Drawing.Size(116, 22);
			this.Admin_Label_Title.TabIndex = 7;
			this.Admin_Label_Title.Text = "How Many Do";
			this.Admin_Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Admin_MenuStrip
			// 
			this.Admin_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Admin_quitbtn});
			this.Admin_MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.Admin_MenuStrip.Name = "Admin_MenuStrip";
			this.Admin_MenuStrip.Size = new System.Drawing.Size(517, 24);
			this.Admin_MenuStrip.TabIndex = 8;
			this.Admin_MenuStrip.Text = "메뉴창";
			// 
			// Admin_quitbtn
			// 
			this.Admin_quitbtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logout,
            this.exit});
			this.Admin_quitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Admin_quitbtn.Image")));
			this.Admin_quitbtn.Name = "Admin_quitbtn";
			this.Admin_quitbtn.Size = new System.Drawing.Size(28, 20);
			// 
			// logout
			// 
			this.logout.Name = "logout";
			this.logout.Size = new System.Drawing.Size(122, 22);
			this.logout.Text = "로그아웃";
			this.logout.Click += new System.EventHandler(this.logout_Click);
			// 
			// exit
			// 
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(122, 22);
			this.exit.Text = "종료";
			this.exit.Click += new System.EventHandler(this.exit_Click);
			// 
			// Admin_Form_Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 313);
			this.Controls.Add(this.Admin_Label_Title);
			this.Controls.Add(this.Admin_Label_Welcome);
			this.Controls.Add(this.Admin_Pic_Logo);
			this.Controls.Add(this.Admin_Label_Name);
			this.Controls.Add(this.Admin_Label_Date);
			this.Controls.Add(this.Admin_Btn_Manage);
			this.Controls.Add(this.Admin_Btn_Log);
			this.Controls.Add(this.Admin_Btn_Write);
			this.Controls.Add(this.Admin_MenuStrip);
			this.MainMenuStrip = this.Admin_MenuStrip;
			this.Name = "Admin_Form_Main";
			this.Text = "HowManyDo 관리자";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_Main_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.Admin_Pic_Logo)).EndInit();
			this.Admin_MenuStrip.ResumeLayout(false);
			this.Admin_MenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Admin_Btn_Write;
		private System.Windows.Forms.Button Admin_Btn_Log;
		private System.Windows.Forms.Button Admin_Btn_Manage;
		private System.Windows.Forms.Label Admin_Label_Date;
		private System.Windows.Forms.Label Admin_Label_Name;
		private System.Windows.Forms.PictureBox Admin_Pic_Logo;
		private System.Windows.Forms.Label Admin_Label_Welcome;
		private System.Windows.Forms.Label Admin_Label_Title;
		private System.Windows.Forms.MenuStrip Admin_MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem Admin_quitbtn;
		private System.Windows.Forms.ToolStripMenuItem logout;
		private System.Windows.Forms.ToolStripMenuItem exit;
	}
}