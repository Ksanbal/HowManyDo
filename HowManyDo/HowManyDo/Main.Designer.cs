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
			this.Main_Btn_Admin = new System.Windows.Forms.Button();
			this.Main_Btn_User = new System.Windows.Forms.Button();
			this.Main_Lable_Title = new System.Windows.Forms.Label();
			this.Main_Pic_Logo = new System.Windows.Forms.PictureBox();
			this.Main_Label_Title = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Main_Pic_Logo)).BeginInit();
			this.SuspendLayout();
			// 
			// Main_Btn_Admin
			// 
			this.Main_Btn_Admin.Font = new System.Drawing.Font("서울남산체 M", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Btn_Admin.Location = new System.Drawing.Point(17, 208);
			this.Main_Btn_Admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Main_Btn_Admin.Name = "Main_Btn_Admin";
			this.Main_Btn_Admin.Size = new System.Drawing.Size(211, 93);
			this.Main_Btn_Admin.TabIndex = 0;
			this.Main_Btn_Admin.Text = "관리자 로그인";
			this.Main_Btn_Admin.UseVisualStyleBackColor = true;
			// 
			// Main_Btn_User
			// 
			this.Main_Btn_User.Font = new System.Drawing.Font("서울남산체 M", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Btn_User.Location = new System.Drawing.Point(261, 208);
			this.Main_Btn_User.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Main_Btn_User.Name = "Main_Btn_User";
			this.Main_Btn_User.Size = new System.Drawing.Size(211, 93);
			this.Main_Btn_User.TabIndex = 1;
			this.Main_Btn_User.Text = "학부모 로그인";
			this.Main_Btn_User.UseVisualStyleBackColor = true;
			// 
			// Main_Lable_Title
			// 
			this.Main_Lable_Title.Font = new System.Drawing.Font("서울남산체 M", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Lable_Title.Location = new System.Drawing.Point(17, 75);
			this.Main_Lable_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Main_Lable_Title.Name = "Main_Lable_Title";
			this.Main_Lable_Title.Size = new System.Drawing.Size(456, 129);
			this.Main_Lable_Title.TabIndex = 2;
			this.Main_Lable_Title.Text = "How Many Do";
			this.Main_Lable_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_Pic_Logo
			// 
			this.Main_Pic_Logo.Image = ((System.Drawing.Image)(resources.GetObject("Main_Pic_Logo.Image")));
			this.Main_Pic_Logo.Location = new System.Drawing.Point(20, 18);
			this.Main_Pic_Logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Main_Pic_Logo.Name = "Main_Pic_Logo";
			this.Main_Pic_Logo.Size = new System.Drawing.Size(50, 52);
			this.Main_Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Main_Pic_Logo.TabIndex = 7;
			this.Main_Pic_Logo.TabStop = false;
			// 
			// Main_Label_Title
			// 
			this.Main_Label_Title.Font = new System.Drawing.Font("서울한강체 M", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_Label_Title.Location = new System.Drawing.Point(79, 18);
			this.Main_Label_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Main_Label_Title.Name = "Main_Label_Title";
			this.Main_Label_Title.Size = new System.Drawing.Size(176, 52);
			this.Main_Label_Title.TabIndex = 6;
			this.Main_Label_Title.Text = "애플미술";
			this.Main_Label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Main_Form_Index
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 330);
			this.Controls.Add(this.Main_Pic_Logo);
			this.Controls.Add(this.Main_Label_Title);
			this.Controls.Add(this.Main_Lable_Title);
			this.Controls.Add(this.Main_Btn_User);
			this.Controls.Add(this.Main_Btn_Admin);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Main_Form_Index";
			this.Text = "HowManyDo 애플미술";
			((System.ComponentModel.ISupportInitialize)(this.Main_Pic_Logo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Main_Btn_Admin;
		private System.Windows.Forms.Button Main_Btn_User;
		private System.Windows.Forms.Label Main_Lable_Title;
		private System.Windows.Forms.PictureBox Main_Pic_Logo;
		private System.Windows.Forms.Label Main_Label_Title;
	}
}

