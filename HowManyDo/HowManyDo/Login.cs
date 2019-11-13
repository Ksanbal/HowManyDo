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

namespace HowManyDo
{
	public partial class Main_Form_Login : Form
	{
		public Main_Form_Login()
		{
			InitializeComponent();
		}
		
		private void Login_Btn_Login_Click(object sender, EventArgs e)
		{
			
		}

		private void Login_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		// 메소드 모음
		// Account폴더에서 입력한 ID와 같은 파일을 찾아 비밀번호가 맞는지 확인하고, 계정정보를 반환하는 메소드
		private string SearchID(string InputId, string InputPasswd) 
		{
			// Account폴더에서 입력한 ID와 같은 파일을 검색
			DirectoryInfo DI = new DirectoryInfo("Accounts");
			string RightId = "";

			foreach(var item in DI.GetDirectories()) //폴더 내 모든 파일 순환
			{
				if (item.Name == InputId) // 파일명이 입력한 아이디값과 같을 때
					RightId = item.Name; // 파일명 반환
			}

			// 파일내에 비밀번호와 사용자 이름, 권한을 배열로 반환
			StreamReader sr = new StreamReader(RightId);
			string[] account = new string[3];

			while(!sr.EndOfStream)
			{
				int i = 0;
				account[i] = sr.ReadLine();
				i++;
			}

			//입력된 아이디와 비밀번호가 같은지 확인하는 메소드
			//account[0] : 비밀번호, account[1] : 사용자명, account[2] : 권한
			if (account[0] != InputPasswd)
				MessageBox.Show("비밀번호가 맞지 않습니다.");
			else


			return null;
		}

		// 입력된 아이디와 비밀번호가 같은지 확인하는 메소드
		private string CheckPasswd(string InputId, string InputPasswd)
		{
			return null;
		}
	}
}
