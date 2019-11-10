namespace HowManyDo.Admin
{
	partial class Admin_ManageStu
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.AWrtie_Btn_Send = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(13, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(328, 425);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// AWrtie_Btn_Send
			// 
			this.AWrtie_Btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AWrtie_Btn_Send.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.AWrtie_Btn_Send.Location = new System.Drawing.Point(348, 385);
			this.AWrtie_Btn_Send.Name = "AWrtie_Btn_Send";
			this.AWrtie_Btn_Send.Size = new System.Drawing.Size(138, 53);
			this.AWrtie_Btn_Send.TabIndex = 6;
			this.AWrtie_Btn_Send.Text = "나가기";
			this.AWrtie_Btn_Send.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button1.Location = new System.Drawing.Point(348, 315);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(138, 53);
			this.button1.TabIndex = 7;
			this.button1.Text = "원생 삭제";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button2.Location = new System.Drawing.Point(348, 245);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(138, 53);
			this.button2.TabIndex = 8;
			this.button2.Text = "원생 정보 수정";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("서울남산체 M", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.button3.Location = new System.Drawing.Point(348, 175);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(138, 53);
			this.button3.TabIndex = 9;
			this.button3.Text = "원생 등록";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// Admin_ManageStu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 450);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AWrtie_Btn_Send);
			this.Controls.Add(this.listView1);
			this.Name = "Admin_ManageStu";
			this.Text = "Student_Management";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button AWrtie_Btn_Send;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}