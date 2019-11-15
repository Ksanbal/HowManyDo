namespace HowManyDo
{
	partial class Main_Form_Index
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form_Index));
			this.Main_Lable_Title = new System.Windows.Forms.Label();
			this.Main_Pic_Logo = new System.Windows.Forms.PictureBox();
			this.Main_Label_Title = new System.Windows.Forms.Label();
			this.Main_Btn_Cancel = new System.Windows.Forms.Button();
			this.Main_TextB_LoginPasswd = new System.Windows.Forms.TextBox();
			this.Main_Label_LoginPasswd = new System.Windows.Forms.Label();
			this.Main_TextB_LoginId = new System.Windows.Forms.TextBox();
			this.Main_Btn_Login = new System.Windows.Forms.Button();
			this.Main_Label_LoginId = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Main_Pic_Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// Main_Lable_Title
			// 
			this.Main_Lable_Title.Font = new System.Drawing.Font("서울남산체 M", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Lable_Title.Location = new System.Drawing.Point(12, 50);
			this.Main_Lable_Title.Name = "Main_Lable_Title";
			this.Main_Lable_Title.Size = new System.Drawing.Size(319, 86);
			this.Main_Lable_Title.TabIndex = 2;
			this.Main_Lable_Title.Text = "How Many Do";
			this.Main_Lable_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_Pic_Logo
			// 
			this.Main_Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Main_Pic_Logo.Image")));
			this.Main_Pic_Logo.Location = new System.Drawing.Point(14, 12);
			this.Main_Pic_Logo.Name = "Main_Pic_Logo";
			this.Main_Pic_Logo.Size = new System.Drawing.Size(35, 35);
			this.Main_Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Main_Pic_Logo.TabIndex = 7;
			this.Main_Pic_Logo.TabStop = false;
			// 
			// Main_Label_Title
			// 
			this.Main_Label_Title.Font = new System.Drawing.Font("서울한강체 M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Label_Title.Location = new System.Drawing.Point(55, 12);
			this.Main_Label_Title.Name = "Main_Label_Title";
			this.Main_Label_Title.Size = new System.Drawing.Size(123, 35);
			this.Main_Label_Title.TabIndex = 6;
			this.Main_Label_Title.Text = "애플미술";
			this.Main_Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_Btn_Cancel
			// 
			this.Main_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Btn_Cancel.Location = new System.Drawing.Point(188, 232);
			this.Main_Btn_Cancel.Name = "Main_Btn_Cancel";
			this.Main_Btn_Cancel.Size = new System.Drawing.Size(99, 31);
			this.Main_Btn_Cancel.TabIndex = 13;
			this.Main_Btn_Cancel.Text = "취소";
			this.Main_Btn_Cancel.UseVisualStyleBackColor = true;
			this.Main_Btn_Cancel.Click += new System.EventHandler(this.Main_Btn_Cancel_Click);
			// 
			// Main_TextB_LoginPasswd
			// 
			this.Main_TextB_LoginPasswd.Location = new System.Drawing.Point(139, 186);
			this.Main_TextB_LoginPasswd.Name = "Main_TextB_LoginPasswd";
			this.Main_TextB_LoginPasswd.PasswordChar = '*';
			this.Main_TextB_LoginPasswd.Size = new System.Drawing.Size(147, 21);
			this.Main_TextB_LoginPasswd.TabIndex = 12;
			// 
			// Main_Label_LoginPasswd
			// 
			this.Main_Label_LoginPasswd.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Label_LoginPasswd.Location = new System.Drawing.Point(33, 186);
			this.Main_Label_LoginPasswd.Name = "Main_Label_LoginPasswd";
			this.Main_Label_LoginPasswd.Size = new System.Drawing.Size(100, 21);
			this.Main_Label_LoginPasswd.TabIndex = 11;
			this.Main_Label_LoginPasswd.Text = "비밀번호";
			this.Main_Label_LoginPasswd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_TextB_LoginId
			// 
			this.Main_TextB_LoginId.Location = new System.Drawing.Point(139, 136);
			this.Main_TextB_LoginId.Name = "Main_TextB_LoginId";
			this.Main_TextB_LoginId.Size = new System.Drawing.Size(147, 21);
			this.Main_TextB_LoginId.TabIndex = 10;
			// 
			// Main_Btn_Login
			// 
			this.Main_Btn_Login.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Btn_Login.Location = new System.Drawing.Point(53, 232);
			this.Main_Btn_Login.Name = "Main_Btn_Login";
			this.Main_Btn_Login.Size = new System.Drawing.Size(99, 31);
			this.Main_Btn_Login.TabIndex = 9;
			this.Main_Btn_Login.Text = "로그인";
			this.Main_Btn_Login.UseVisualStyleBackColor = true;
			this.Main_Btn_Login.Click += new System.EventHandler(this.Main_Btn_Login_Click);
			// 
			// Main_Label_LoginId
			// 
			this.Main_Label_LoginId.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Label_LoginId.Location = new System.Drawing.Point(33, 136);
			this.Main_Label_LoginId.Name = "Main_Label_LoginId";
			this.Main_Label_LoginId.Size = new System.Drawing.Size(100, 21);
			this.Main_Label_LoginId.TabIndex = 8;
			this.Main_Label_LoginId.Text = "아이디";
			this.Main_Label_LoginId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_Form_Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 293);
			this.Controls.Add(this.Main_Btn_Cancel);
			this.Controls.Add(this.Main_TextB_LoginPasswd);
			this.Controls.Add(this.Main_Label_LoginPasswd);
			this.Controls.Add(this.Main_TextB_LoginId);
			this.Controls.Add(this.Main_Btn_Login);
			this.Controls.Add(this.Main_Label_LoginId);
			this.Controls.Add(this.Main_Pic_Logo);
			this.Controls.Add(this.Main_Label_Title);
			this.Controls.Add(this.Main_Lable_Title);
			this.Name = "Main_Form_Index";
			this.Text = "HowManyDo 애플미술";
			((System.ComponentModel.ISupportInitialize)(this.Main_Pic_Logo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Main_Lable_Title;
		private System.Windows.Forms.PictureBox Main_Pic_Logo;
		private System.Windows.Forms.Label Main_Label_Title;
		private System.Windows.Forms.Button Main_Btn_Cancel;
		private System.Windows.Forms.TextBox Main_TextB_LoginPasswd;
		private System.Windows.Forms.Label Main_Label_LoginPasswd;
		private System.Windows.Forms.TextBox Main_TextB_LoginId;
		private System.Windows.Forms.Button Main_Btn_Login;
		private System.Windows.Forms.Label Main_Label_LoginId;
	}
}

