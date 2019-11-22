namespace HowManyDo.Admin
{
	partial class Admin_Form_Log
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
			this.ALog_ListV_List = new System.Windows.Forms.ListView();
			this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.body = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ALog_imageList = new System.Windows.Forms.ImageList(this.components);
			this.ALog_Btn_Cancel = new System.Windows.Forms.Button();
			this.ALog_ComboBox = new System.Windows.Forms.ComboBox();
			this.ALog_Btn_ShowDetail = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ALog_ListV_List
			// 
			this.ALog_ListV_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.date,
            this.body});
			this.ALog_ListV_List.HideSelection = false;
			this.ALog_ListV_List.LargeImageList = this.ALog_imageList;
			this.ALog_ListV_List.Location = new System.Drawing.Point(13, 13);
			this.ALog_ListV_List.Name = "ALog_ListV_List";
			this.ALog_ListV_List.Size = new System.Drawing.Size(328, 425);
			this.ALog_ListV_List.SmallImageList = this.ALog_imageList;
			this.ALog_ListV_List.TabIndex = 0;
			this.ALog_ListV_List.UseCompatibleStateImageBehavior = false;
			this.ALog_ListV_List.View = System.Windows.Forms.View.Details;
			// 
			// name
			// 
			this.name.Text = "학생명";
			this.name.Width = 49;
			// 
			// date
			// 
			this.date.Text = "작성날짜";
			// 
			// body
			// 
			this.body.Text = "본문";
			this.body.Width = 222;
			// 
			// ALog_imageList
			// 
			this.ALog_imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ALog_imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.ALog_imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ALog_Btn_Cancel
			// 
			this.ALog_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ALog_Btn_Cancel.Location = new System.Drawing.Point(347, 385);
			this.ALog_Btn_Cancel.Name = "ALog_Btn_Cancel";
			this.ALog_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.ALog_Btn_Cancel.TabIndex = 2;
			this.ALog_Btn_Cancel.Text = "나가기";
			this.ALog_Btn_Cancel.UseVisualStyleBackColor = true;
			this.ALog_Btn_Cancel.Click += new System.EventHandler(this.ALog_Btn_Cancel_Click);
			// 
			// ALog_ComboBox
			// 
			this.ALog_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ALog_ComboBox.FormattingEnabled = true;
			this.ALog_ComboBox.Items.AddRange(new object[] {
            "Large icon",
            "Details",
            "Small icon",
            "List",
            "Tile"});
			this.ALog_ComboBox.Location = new System.Drawing.Point(348, 56);
			this.ALog_ComboBox.Name = "ALog_ComboBox";
			this.ALog_ComboBox.Size = new System.Drawing.Size(137, 20);
			this.ALog_ComboBox.TabIndex = 3;
			this.ALog_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// ALog_Btn_ShowDetail
			// 
			this.ALog_Btn_ShowDetail.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ALog_Btn_ShowDetail.Location = new System.Drawing.Point(347, 326);
			this.ALog_Btn_ShowDetail.Name = "ALog_Btn_ShowDetail";
			this.ALog_Btn_ShowDetail.Size = new System.Drawing.Size(138, 53);
			this.ALog_Btn_ShowDetail.TabIndex = 4;
			this.ALog_Btn_ShowDetail.Text = "자세히보기";
			this.ALog_Btn_ShowDetail.UseVisualStyleBackColor = true;
			this.ALog_Btn_ShowDetail.Click += new System.EventHandler(this.ALog_Btn_ShowDetail_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(348, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 27);
			this.label1.TabIndex = 5;
			this.label1.Text = "보기 설정";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Admin_Form_Log
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ALog_Btn_ShowDetail);
			this.Controls.Add(this.ALog_ComboBox);
			this.Controls.Add(this.ALog_Btn_Cancel);
			this.Controls.Add(this.ALog_ListV_List);
			this.Name = "Admin_Form_Log";
			this.Text = "내역 확인하기";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView ALog_ListV_List;
		private System.Windows.Forms.Button ALog_Btn_Cancel;
		private System.Windows.Forms.ColumnHeader name;
		private System.Windows.Forms.ColumnHeader date;
		private System.Windows.Forms.ColumnHeader body;
		private System.Windows.Forms.ImageList ALog_imageList;
		private System.Windows.Forms.ComboBox ALog_ComboBox;
		private System.Windows.Forms.Button ALog_Btn_ShowDetail;
		private System.Windows.Forms.Label label1;
	}
}