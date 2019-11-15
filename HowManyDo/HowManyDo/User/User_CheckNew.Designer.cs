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
			this.ALog_Btn_Cancel = new System.Windows.Forms.Button();
			this.ALog_ListV_List = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// ALog_Btn_Cancel
			// 
			this.ALog_Btn_Cancel.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ALog_Btn_Cancel.Location = new System.Drawing.Point(345, 385);
			this.ALog_Btn_Cancel.Name = "ALog_Btn_Cancel";
			this.ALog_Btn_Cancel.Size = new System.Drawing.Size(138, 53);
			this.ALog_Btn_Cancel.TabIndex = 4;
			this.ALog_Btn_Cancel.Text = "나가기";
			this.ALog_Btn_Cancel.UseVisualStyleBackColor = true;
			this.ALog_Btn_Cancel.Click += new System.EventHandler(this.ALog_Btn_Cancel_Click);
			// 
			// ALog_ListV_List
			// 
			this.ALog_ListV_List.HideSelection = false;
			this.ALog_ListV_List.Location = new System.Drawing.Point(11, 13);
			this.ALog_ListV_List.Name = "ALog_ListV_List";
			this.ALog_ListV_List.Size = new System.Drawing.Size(328, 425);
			this.ALog_ListV_List.TabIndex = 3;
			this.ALog_ListV_List.UseCompatibleStateImageBehavior = false;
			// 
			// User_Form_CheckNew
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 450);
			this.Controls.Add(this.ALog_Btn_Cancel);
			this.Controls.Add(this.ALog_ListV_List);
			this.Name = "User_Form_CheckNew";
			this.Text = "진행상황 확인하기";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ALog_Btn_Cancel;
		private System.Windows.Forms.ListView ALog_ListV_List;
	}
}