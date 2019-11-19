namespace HowManyDo.Admin
{
	partial class Admin_Form_ManageStu
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
			this.AManage_ListV_List = new System.Windows.Forms.ListView();
			this.AManage_Btn_Cancel = new System.Windows.Forms.Button();
			this.AManage_Btn_Delete = new System.Windows.Forms.Button();
			this.AManage_Btn_Modify = new System.Windows.Forms.Button();
			this.AManage_Btn_Regist = new System.Windows.Forms.Button();
			this.sname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// AManage_ListV_List
			// 
			this.AManage_ListV_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.sname,
            this.birth,
            this.pname,
            this.id});
			this.AManage_ListV_List.HideSelection = false;
			this.AManage_ListV_List.Location = new System.Drawing.Point(13, 13);
			this.AManage_ListV_List.Name = "AManage_ListV_List";
			this.AManage_ListV_List.Size = new System.Drawing.Size(328, 425);
			this.AManage_ListV_List.TabIndex = 0;
			this.AManage_ListV_List.UseCompatibleStateImageBehavior = false;
			this.AManage_ListV_List.View = System.Windows.Forms.View.Details;
			// 
			// AManage_Btn_Cancel
			// 
			this.AManage_Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AManage_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AManage_Btn_Cancel.Location = new System.Drawing.Point(348, 385);
			this.AManage_Btn_Cancel.Name = "AManage_Btn_Cancel";
			this.AManage_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.AManage_Btn_Cancel.TabIndex = 6;
			this.AManage_Btn_Cancel.Text = "나가기";
			this.AManage_Btn_Cancel.UseVisualStyleBackColor = true;
			this.AManage_Btn_Cancel.Click += new System.EventHandler(this.AManage_Btn_Cancel_Click);
			// 
			// AManage_Btn_Delete
			// 
			this.AManage_Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AManage_Btn_Delete.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AManage_Btn_Delete.Location = new System.Drawing.Point(348, 315);
			this.AManage_Btn_Delete.Name = "AManage_Btn_Delete";
			this.AManage_Btn_Delete.Size = new System.Drawing.Size(138, 53);
			this.AManage_Btn_Delete.TabIndex = 7;
			this.AManage_Btn_Delete.Text = "원생 삭제";
			this.AManage_Btn_Delete.UseVisualStyleBackColor = true;
			this.AManage_Btn_Delete.Click += new System.EventHandler(this.AManage_Btn_Delete_Click);
			// 
			// AManage_Btn_Modify
			// 
			this.AManage_Btn_Modify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AManage_Btn_Modify.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AManage_Btn_Modify.Location = new System.Drawing.Point(348, 245);
			this.AManage_Btn_Modify.Name = "AManage_Btn_Modify";
			this.AManage_Btn_Modify.Size = new System.Drawing.Size(138, 53);
			this.AManage_Btn_Modify.TabIndex = 8;
			this.AManage_Btn_Modify.Text = "원생 정보 수정";
			this.AManage_Btn_Modify.UseVisualStyleBackColor = true;
			this.AManage_Btn_Modify.Click += new System.EventHandler(this.AManage_Btn_Modify_Click);
			// 
			// AManage_Btn_Regist
			// 
			this.AManage_Btn_Regist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AManage_Btn_Regist.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AManage_Btn_Regist.Location = new System.Drawing.Point(348, 175);
			this.AManage_Btn_Regist.Name = "AManage_Btn_Regist";
			this.AManage_Btn_Regist.Size = new System.Drawing.Size(138, 53);
			this.AManage_Btn_Regist.TabIndex = 9;
			this.AManage_Btn_Regist.Text = "원생 등록";
			this.AManage_Btn_Regist.UseVisualStyleBackColor = true;
			this.AManage_Btn_Regist.Click += new System.EventHandler(this.AManage_Btn_Regist_Click);
			// 
			// sname
			// 
			this.sname.Text = "학생이름";
			// 
			// birth
			// 
			this.birth.Text = "생년월일";
			// 
			// pname
			// 
			this.pname.Text = "학부모성함";
			// 
			// id
			// 
			this.id.Text = "아이디";
			// 
			// Admin_Form_ManageStu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 450);
			this.Controls.Add(this.AManage_Btn_Regist);
			this.Controls.Add(this.AManage_Btn_Modify);
			this.Controls.Add(this.AManage_Btn_Delete);
			this.Controls.Add(this.AManage_Btn_Cancel);
			this.Controls.Add(this.AManage_ListV_List);
			this.Name = "Admin_Form_ManageStu";
			this.Text = "원생 관리";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView AManage_ListV_List;
		private System.Windows.Forms.Button AManage_Btn_Cancel;
		private System.Windows.Forms.Button AManage_Btn_Delete;
		private System.Windows.Forms.Button AManage_Btn_Modify;
		private System.Windows.Forms.Button AManage_Btn_Regist;
		private System.Windows.Forms.ColumnHeader sname;
		private System.Windows.Forms.ColumnHeader birth;
		private System.Windows.Forms.ColumnHeader pname;
		private System.Windows.Forms.ColumnHeader id;
	}
}