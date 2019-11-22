namespace HowManyDo.Admin
{
	partial class Admin_Form_Write
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form_Write));
			this.AWrite_TextB_Body = new System.Windows.Forms.TextBox();
			this.AWrite_Lable_Name = new System.Windows.Forms.Label();
			this.AWrite_Btn_SelectPic = new System.Windows.Forms.Button();
			this.AWrite_Pic_SelectedPic = new System.Windows.Forms.PictureBox();
			this.AWrtie_Btn_Send = new System.Windows.Forms.Button();
			this.AWrite_Btn_Cancel = new System.Windows.Forms.Button();
			this.AWrite_TextB_Name = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.AWrite_Label_SearchedName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.AWrite_Pic_SelectedPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// AWrite_TextB_Body
			// 
			this.AWrite_TextB_Body.Location = new System.Drawing.Point(13, 13);
			this.AWrite_TextB_Body.Multiline = true;
			this.AWrite_TextB_Body.Name = "AWrite_TextB_Body";
			this.AWrite_TextB_Body.Size = new System.Drawing.Size(328, 425);
			this.AWrite_TextB_Body.TabIndex = 0;
			// 
			// AWrite_Lable_Name
			// 
			this.AWrite_Lable_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AWrite_Lable_Name.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrite_Lable_Name.Location = new System.Drawing.Point(348, 13);
			this.AWrite_Lable_Name.Name = "AWrite_Lable_Name";
			this.AWrite_Lable_Name.Size = new System.Drawing.Size(138, 23);
			this.AWrite_Lable_Name.TabIndex = 2;
			this.AWrite_Lable_Name.Text = "원생 이름";
			this.AWrite_Lable_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AWrite_Btn_SelectPic
			// 
			this.AWrite_Btn_SelectPic.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrite_Btn_SelectPic.Location = new System.Drawing.Point(348, 188);
			this.AWrite_Btn_SelectPic.Name = "AWrite_Btn_SelectPic";
			this.AWrite_Btn_SelectPic.Size = new System.Drawing.Size(139, 23);
			this.AWrite_Btn_SelectPic.TabIndex = 3;
			this.AWrite_Btn_SelectPic.Text = "사진 첨부";
			this.AWrite_Btn_SelectPic.UseVisualStyleBackColor = true;
			this.AWrite_Btn_SelectPic.Click += new System.EventHandler(this.AWrite_Btn_SelectPic_Click);
			// 
			// AWrite_Pic_SelectedPic
			// 
			this.AWrite_Pic_SelectedPic.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.AWrite_Pic_SelectedPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.AWrite_Pic_SelectedPic.Location = new System.Drawing.Point(348, 217);
			this.AWrite_Pic_SelectedPic.Name = "AWrite_Pic_SelectedPic";
			this.AWrite_Pic_SelectedPic.Size = new System.Drawing.Size(138, 90);
			this.AWrite_Pic_SelectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.AWrite_Pic_SelectedPic.TabIndex = 4;
			this.AWrite_Pic_SelectedPic.TabStop = false;
			// 
			// AWrtie_Btn_Send
			// 
			this.AWrtie_Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AWrtie_Btn_Send.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrtie_Btn_Send.Location = new System.Drawing.Point(348, 326);
			this.AWrtie_Btn_Send.Name = "AWrtie_Btn_Send";
			this.AWrtie_Btn_Send.Size = new System.Drawing.Size(138, 53);
			this.AWrtie_Btn_Send.TabIndex = 5;
			this.AWrtie_Btn_Send.Text = "보내기";
			this.AWrtie_Btn_Send.UseVisualStyleBackColor = true;
			this.AWrtie_Btn_Send.Click += new System.EventHandler(this.AWrtie_Btn_Send_Click);
			// 
			// AWrite_Btn_Cancel
			// 
			this.AWrite_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrite_Btn_Cancel.Location = new System.Drawing.Point(348, 385);
			this.AWrite_Btn_Cancel.Name = "AWrite_Btn_Cancel";
			this.AWrite_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.AWrite_Btn_Cancel.TabIndex = 7;
			this.AWrite_Btn_Cancel.Text = "취소";
			this.AWrite_Btn_Cancel.UseVisualStyleBackColor = true;
			this.AWrite_Btn_Cancel.Click += new System.EventHandler(this.AWrite_Btn_Cancel_Click);
			// 
			// AWrite_TextB_Name
			// 
			this.AWrite_TextB_Name.Location = new System.Drawing.Point(348, 42);
			this.AWrite_TextB_Name.Margin = new System.Windows.Forms.Padding(2);
			this.AWrite_TextB_Name.Name = "AWrite_TextB_Name";
			this.AWrite_TextB_Name.Size = new System.Drawing.Size(114, 21);
			this.AWrite_TextB_Name.TabIndex = 8;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(467, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(19, 21);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// AWrite_Label_SearchedName
			// 
			this.AWrite_Label_SearchedName.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrite_Label_SearchedName.Location = new System.Drawing.Point(348, 66);
			this.AWrite_Label_SearchedName.Name = "AWrite_Label_SearchedName";
			this.AWrite_Label_SearchedName.Size = new System.Drawing.Size(138, 23);
			this.AWrite_Label_SearchedName.TabIndex = 10;
			this.AWrite_Label_SearchedName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Admin_Form_Write
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.AWrite_Label_SearchedName);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.AWrite_TextB_Name);
			this.Controls.Add(this.AWrite_Btn_Cancel);
			this.Controls.Add(this.AWrtie_Btn_Send);
			this.Controls.Add(this.AWrite_Pic_SelectedPic);
			this.Controls.Add(this.AWrite_Btn_SelectPic);
			this.Controls.Add(this.AWrite_TextB_Body);
			this.Controls.Add(this.AWrite_Lable_Name);
			this.Name = "Admin_Form_Write";
			this.Text = "글작성";
			((System.ComponentModel.ISupportInitialize)(this.AWrite_Pic_SelectedPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox AWrite_TextB_Body;
		private System.Windows.Forms.Label AWrite_Lable_Name;
		private System.Windows.Forms.Button AWrite_Btn_SelectPic;
		private System.Windows.Forms.PictureBox AWrite_Pic_SelectedPic;
		private System.Windows.Forms.Button AWrtie_Btn_Send;
		private System.Windows.Forms.Button AWrite_Btn_Cancel;
		private System.Windows.Forms.TextBox AWrite_TextB_Name;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label AWrite_Label_SearchedName;
	}
}