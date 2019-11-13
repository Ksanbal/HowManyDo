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
		// Account폴더에서 입력한 ID와 같은 파일을 찾아서 파일명을 반환합니다. 
		private string SearchID(string InputId) 
		{
			DirectoryInfo DI = new DirectoryInfo("Accounts");

			foreach(var item in DI.GetDirectories()) //폴더 내 모든 파일 순환
			{
				if (item.Name == InputId) // 파일명이 입력한 아이디값과 같을 때
					return item.Name;
			}

			return null;
		}

		// 입력된 아이디와 비밀번호가 같은지 확인하는 메소드
		private string CheckPasswd(string InputId, string InputPasswd)
		{
			return null;
		}
	}
}
