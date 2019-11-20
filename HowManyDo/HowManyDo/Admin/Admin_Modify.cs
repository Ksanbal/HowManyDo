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
	public partial class Admin_Form_Modify : Form
	{
		string selectedid;
		// 선택된 아이템의 아이디를 받아오는 프로퍼티
		public string Selectedid
		{
			set { selectedid = value; }
		}

		public Admin_Form_Modify()
		{
			InitializeComponent();
		}


		private void Admin_Form_Modify_Load(object sender, EventArgs e)
		{
			SetTextBoxs(selectedid);
		}



		private void AModify_Btn_Ok_Click(object sender, EventArgs e)
		{
			// TextBox중 하나라도 비어 있는 경우
			if (AModify_TextB_Sname.Text == "" || AModify_TextB_Birth.Text == "" || AModify_TextB_Pname.Text == "" ||
				AModify_TextB_Id.Text == "" || AModify_TextB_Passwd.Text == "")
			{
				if (MessageBox.Show("아직 채워지지 않은 칸이 있습니다. 정말 등록하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					// 등록 기능 구현
					ModifyAccount(AModify_TextB_Sname.Text, AModify_TextB_Birth.Text, AModify_TextB_Pname.Text,
						AModify_TextB_Id.Text, AModify_TextB_Passwd.Text, "user", selectedid);
				}
				else
				{ }
			}
			else
			{
				// 등록 기능 구현
				ModifyAccount(AModify_TextB_Sname.Text, AModify_TextB_Birth.Text, AModify_TextB_Pname.Text,
					AModify_TextB_Id.Text, AModify_TextB_Passwd.Text, "user", selectedid);
			}
		}

		private void AModify_Btn_Cancel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("정말 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
			else
			{ }
		}


		// 메소드
		// 선택된 아이템의 정보로 텍스트박스를 채워주는 메소드
		private void SetTextBoxs(string id)
		{
			string selectedaccount = string.Empty;
			List<string> accountinfo = new List<string>();

			// 디렉토리에서 선택된 계정과 같은 계정 정보 가져오기
			DirectoryInfo di = new DirectoryInfo("Accounts");
			/*
			foreach (var item in di.GetFiles())
			{
				if(item.Name == selectedid)
				{
					selectedaccount = @"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts\" + selectedid;
				}
			}
			*/

			selectedaccount = @"Accounts\" + id + ".txt";

			// 가져온 계정 정보를 텍스트 박스 텍스트에 입력
			StreamReader sr = new StreamReader(selectedaccount);

			for(int i = 0; i < 5; i++)
			{
				accountinfo.Add(sr.ReadLine());
			}

			AModify_TextB_Sname.Text = accountinfo[0];
			AModify_TextB_Birth.Text = accountinfo[1];
			AModify_TextB_Pname.Text = accountinfo[2];
			AModify_TextB_Id.Text = accountinfo[3];
			AModify_TextB_Passwd.Text = accountinfo[4];
		} // SetTextBoxs()


		//계정 정보를 갱신해주는 메소드
		private void ModifyAccount(string sname, string birth, string pname, string id, string passwd, string permission, string originid)
		{
			string[] account = { sname, birth, pname, id, passwd, permission };

			// 같은 아이디가 있는지 확인
			DirectoryInfo di = new DirectoryInfo("Accounts");
			foreach (var item in di.GetFiles())
			{
				if (item.Name == id + ".txt" && item.Name != originid+".txt")
				{
					MessageBox.Show("이미 존재하는 아이디입니다.");
					return;
				}
			}

			// 학생 정보가 담긴 파일을 덮어쓰기
			// StreamWriter sw = new StreamWriter(@"Accounts\" + originid + ".txt", true);
			StreamWriter sw = new StreamWriter(originid + ".txt");
			FileInfo fi = new FileInfo(originid + ".txt");

			foreach (string i in account)
			{
				sw.WriteLine(i);
			}
			sw.Close();

			


			MessageBox.Show("학생 등록이 완료되었습니다.");
			Close();

		} // ModifyAccount()
	}
}
