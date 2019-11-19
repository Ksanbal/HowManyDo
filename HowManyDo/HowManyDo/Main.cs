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
using HowManyDo.Admin;
using HowManyDo.User;

namespace HowManyDo
{
	public partial class Main_Form_Index : Form
	{
		public Main_Form_Index()
		{
			InitializeComponent();
		}

		private void Main_Btn_Login_Click(object sender, EventArgs e)
		{
			LoginCheck(Main_TextB_LoginId.Text, Main_TextB_LoginPasswd.Text);
		}


		private void Main_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}


		// Account폴더에서 입력한 ID와 같은 파일을 찾아 비밀번호가 맞는지 확인하고, 계정정보를 반환하는 메소드
		private void LoginCheck(string InputId, string InputPasswd)
		{
			string AccountPath = @"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts"; //계정이 들어있는 폴더 경로
																								 // Account폴더에서 입력한 ID와 같은 파일을 검색
			DirectoryInfo DI = new DirectoryInfo(AccountPath);
			string RightId = "";

			foreach (var item in DI.GetFiles()) //폴더 내 모든 파일 순환
			{
				if (item.Name == InputId + ".txt") // 파일명이 입력한 아이디값과 같을 때
					RightId = item.Name; // 파일명 반환
			}

			if (RightId != InputId + ".txt") // 아이디가 일치하지 않는 경우
			{
				MessageBox.Show("일치하는 아이디가 없습니다.");
			}
			else //아이디가 일치하는 경우
			{
				// 파일내에 비밀번호와 사용자 이름, 권한을 배열로 반환
				StreamReader sr = new StreamReader(AccountPath + @"\" + RightId, Encoding.Default); //입력받은 계정 정보 파일의 경로
				string[] account = new string[6];
				int i = 0;

				while (i < 6)
				{
					account[i] = sr.ReadLine();
					i++;
				}

				//입력된 아이디와 비밀번호가 같은지 확인하는 메소드
				//account[0] : 학생이름, account[1] : 생년월일, account[2] : 학부모이름, account[3] : 아이디, account[4] : 비밀번호, account[5] : 권한
				if (account[4] != InputPasswd) // 비밀번호가 틀렸을 경우
				{
					MessageBox.Show("비밀번호가 틀렸습니다.");
				}
				else
				{
					MessageBox.Show("로그인 성공");
					if (account[5] == "admin")
					{
						Admin_Form_Main adminform = new Admin_Form_Main();
						adminform.SetUsername = account[2]; // 학부모이름을 프로퍼티로 입력
						adminform.Show();
						DisableForm();
					}
					else if (account[5] == "user")
					{
						User_Form_Main userform = new User_Form_Main();
						userform.SetUsername = account[2]; // 학부모이름을 프로퍼티로 입력
						userform.Show();
						DisableForm();
					}
				}
			}
		} //LoginCheck

		//부모폼을 숨기기 위해 부모폼을 비활성화하고 숨기는 메소드
		private void DisableForm()
		{
			this.Enabled = false;
			this.ShowInTaskbar = false;
			this.Opacity = 0;
		} //DisableForm
	}
}
