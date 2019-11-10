namespace HowManyDo
{
	partial class Form1
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
			this.Main_Btn_Admin = new System.Windows.Forms.Button();
			this.Main_Btn_User = new System.Windows.Forms.Button();
			this.Main_lable_ = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Main_Btn_Admin
			// 
			this.Main_Btn_Admin.Location = new System.Drawing.Point(12, 110);
			this.Main_Btn_Admin.Name = "Main_Btn_Admin";
			this.Main_Btn_Admin.Size = new System.Drawing.Size(148, 62);
			this.Main_Btn_Admin.TabIndex = 0;
			this.Main_Btn_Admin.Text = "button1";
			this.Main_Btn_Admin.UseVisualStyleBackColor = true;
			// 
			// Main_Btn_User
			// 
			this.Main_Btn_User.Location = new System.Drawing.Point(176, 110);
			this.Main_Btn_User.Name = "Main_Btn_User";
			this.Main_Btn_User.Size = new System.Drawing.Size(148, 62);
			this.Main_Btn_User.TabIndex = 1;
			this.Main_Btn_User.Text = "button2";
			this.Main_Btn_User.UseVisualStyleBackColor = true;
			// 
			// Main_lable_
			// 
			this.Main_lable_.Font = new System.Drawing.Font("서울한강체 M", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Main_lable_.Location = new System.Drawing.Point(13, 13);
			this.Main_lable_.Name = "Main_lable_";
			this.Main_lable_.Size = new System.Drawing.Size(311, 79);
			this.Main_lable_.TabIndex = 2;
			this.Main_lable_.Text = "How Many Do";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 184);
			this.Controls.Add(this.Main_lable_);
			this.Controls.Add(this.Main_Btn_User);
			this.Controls.Add(this.Main_Btn_Admin);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Main_Btn_Admin;
		private System.Windows.Forms.Button Main_Btn_User;
		private System.Windows.Forms.Label Main_lable_;
	}
}

