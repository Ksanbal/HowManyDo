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
			if (ARegist_TextB_Email.Text == "")
			{
				MessageBox.Show("아이디를 작성해주시기 바랍니다.");
			} // 아이디가 비어져있는 경우 
			else if (ARegist_TextB_Sname.Text == "" || ARegist_TextB_Birth.Text == "" || ARegist_TextB_Pname.Text == "")
			{
				if(MessageBox.Show("아직 채워지지 않은 칸이 있습니다. 정말 등록하시겠습니까?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					// 등록 기능 구현
					RegistNewAccount(ARegist_TextB_Sname.Text, ARegist_TextB_Birth.Text, ARegist_TextB_Pname.Text,
						ARegist_TextB_Email.Text, "user");
				}
			} // TextBox중 하나라도 비어 있는 경우
			else
			{
				// 등록 기능 구현
				RegistNewAccount(ARegist_TextB_Sname.Text, ARegist_TextB_Birth.Text, ARegist_TextB_Pname.Text, 
					ARegist_TextB_Email.Text, "user");
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

		private void RegistNewAccount(string sname, string birth, string pname, string email, string permission)
		{
			string[] account = { sname, birth, pname, email, permission};

			// 같은 아이디가 있는지 확인
			DirectoryInfo di = new DirectoryInfo("Accounts");
			foreach(var item in di.GetFiles())
			{
				if(item.Name == email + ".txt")
				{
					MessageBox.Show("이미 존재하는 아이디입니다.");
					return;
				}
			}

			// 학생 정보가 담긴 파일을 새로 작성
			StreamWriter sw = new StreamWriter(@"Accounts\" + email + ".txt");
			
			foreach(string i in account)
			{
				sw.WriteLine(i);
			}
			sw.Close();

			MessageBox.Show("학생 등록이 완료되었습니다.");
			Close();
		} // RegistNewAccount()
	}
}
