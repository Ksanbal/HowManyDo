using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace HowManyDo.Admin
{
	public partial class Admin_Form_Regist : Form
	{
		public Admin_Form_Regist()
		{
			InitializeComponent();
		}


		private void ARegist_Btn_Ok_Click(object sender, EventArgs e)
		{
			// TextBox중 하나라도 비어 있는 경우
			if(ARegist_TextB_Sname.Text == "" || ARegist_TextB_Birth.Text == "" || ARegist_TextB_Pname.Text == "" || 
				ARegist_TextB_Id.Text == "" || ARegist_TextB_Passwd.Text == "")
			{
				if(MessageBox.Show("아직 채워지지 않은 칸이 있습니다. 정말 등록하시겠습니까?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					// 등록 기능 구현
					RegistNewAccount(ARegist_TextB_Sname.Text, ARegist_TextB_Birth.Text, ARegist_TextB_Pname.Text,
						ARegist_TextB_Id.Text, ARegist_TextB_Passwd.Text, "user");
					MessageBox.Show("학생 등록이 완료되었습니다.");
					Close();
				}
				else
				{ }
			}
			else
			{
				// 등록 기능 구현
				RegistNewAccount(ARegist_TextB_Sname.Text, ARegist_TextB_Birth.Text, ARegist_TextB_Pname.Text, 
					ARegist_TextB_Id.Text, ARegist_TextB_Passwd.Text, "user");
				MessageBox.Show("학생 등록이 완료되었습니다.");
				Close();
			}
		}


		private void ARegist_Btn_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("정말 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
			else
			{ }
		}

		private void RegistNewAccount(string sname, string birth, string pname, string id, string passwd, string permission)
		{
			string[] account = { sname, birth, pname, id, passwd, permission};
			StreamWriter sw = new StreamWriter(@"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts\" + id + ".txt");
			
			foreach(string i in account)
			{
				sw.WriteLine(i);
			}
			sw.Close();
		}
	}
}
