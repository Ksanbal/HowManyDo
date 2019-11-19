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
		public Admin_Form_Modify()
		{
			InitializeComponent();
			SetTextBoxs(selectedid);
		}

		private string selectedid;
		// 선택된 아이템의 아이디를 받아오는 프로퍼티
		public string Setid
		{
			set { selectedid = value.ToString(); }
		}

		private void AModify_Btn_Ok_Click(object sender, EventArgs e)
		{
			//정보 수정
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
		private void SetTextBoxs(string selectedid)
		{
			string selectedaccount = "";
			List<string> accountinfo = new List<string>();

			// 디렉토리에서 선택된 계정과 같은 계정 정보 가져오기
			DirectoryInfo di = new DirectoryInfo(@"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts");
			foreach(var item in di.GetFiles())
			{
				if(item.Name == selectedid)
				{
					selectedaccount = @"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts\" + item.Name;
				}
			}

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

	}
}
