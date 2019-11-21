namespace HowManyDo.User
{
	partial class User_Form_CheckNew
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
			this.components = new System.ComponentModel.Container();
			this.UChecknew_Btn_Cancel = new System.Windows.Forms.Button();
			this.ALog_ListV_List = new System.Windows.Forms.ListView();
			this.날짜 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.이름 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.본문 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.UChecknew_Btn_ShowDetail = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UChecknew_Btn_Cancel
			// 
			this.UChecknew_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UChecknew_Btn_Cancel.Location = new System.Drawing.Point(345, 385);
			this.UChecknew_Btn_Cancel.Name = "UChecknew_Btn_Cancel";
			this.UChecknew_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.UChecknew_Btn_Cancel.TabIndex = 4;
			this.UChecknew_Btn_Cancel.Text = "나가기";
			this.UChecknew_Btn_Cancel.UseVisualStyleBackColor = true;
			this.UChecknew_Btn_Cancel.Click += new System.EventHandler(this.UCkecknew_Btn_Cancel_Click);
			// 
			// ALog_ListV_List
			// 
			this.ALog_ListV_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.날짜,
            this.이름,
            this.본문});
			this.ALog_ListV_List.HideSelection = false;
			this.ALog_ListV_List.Location = new System.Drawing.Point(11, 13);
			this.ALog_ListV_List.Name = "ALog_ListV_List";
			this.ALog_ListV_List.Size = new System.Drawing.Size(328, 425);
			this.ALog_ListV_List.TabIndex = 3;
			this.ALog_ListV_List.UseCompatibleStateImageBehavior = false;
			// 
			// 날짜
			// 
			this.날짜.Text = "날짜";
			// 
			// 이름
			// 
			this.이름.Text = "이름";
			// 
			// 본문
			// 
			this.본문.Text = "본문";
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// UChecknew_Btn_ShowDetail
			// 
			this.UChecknew_Btn_ShowDetail.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.UChecknew_Btn_ShowDetail.Location = new System.Drawing.Point(346, 326);
			this.UChecknew_Btn_ShowDetail.Name = "UChecknew_Btn_ShowDetail";
			this.UChecknew_Btn_ShowDetail.Size = new System.Drawing.Size(138, 53);
			this.UChecknew_Btn_ShowDetail.TabIndex = 5;
			this.UChecknew_Btn_ShowDetail.Text = "파일 상세보기";
			this.UChecknew_Btn_ShowDetail.UseVisualStyleBackColor = true;
			this.UChecknew_Btn_ShowDetail.Click += new System.EventHandler(this.UChecknew_Btn_ShowDetail_Click);
			// 
			// User_Form_CheckNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.UChecknew_Btn_ShowDetail);
			this.Controls.Add(this.UChecknew_Btn_Cancel);
			this.Controls.Add(this.ALog_ListV_List);
			this.Name = "User_Form_CheckNew";
			this.Text = "진행상황 확인하기";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button UChecknew_Btn_Cancel;
		private System.Windows.Forms.ListView ALog_ListV_List;
		private System.Windows.Forms.ColumnHeader 날짜;
		private System.Windows.Forms.ColumnHeader 이름;
		private System.Windows.Forms.ColumnHeader 본문;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button UChecknew_Btn_ShowDetail;
	}
}