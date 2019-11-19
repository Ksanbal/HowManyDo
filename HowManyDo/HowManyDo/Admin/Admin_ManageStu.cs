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
	public partial class Admin_Form_ManageStu : Form
	{
		public Admin_Form_ManageStu()
		{
			InitializeComponent();
			SetzlistView(); // 리스트뷰 내용을 업데이트
		}


		private void AManage_Btn_Regist_Click(object sender, EventArgs e)
		{
			Admin_Form_Regist regist = new Admin_Form_Regist();
			regist.ShowDialog();
			SetzlistView(); // 리스트뷰 내용을 업데이트
		}



		private void AManage_Btn_Modify_Click(object sender, EventArgs e)
		{
			Admin_Form_Modify modify = new Admin_Form_Modify();
			// modify.Setid = 선택된 아이템의 3번째 서브 아이템의 텍스트(아이디)
			modify.ShowDialog();
			SetzlistView(); // 리스트뷰 내용을 업데이트
		}


		private void AManage_Btn_Delete_Click(object sender, EventArgs e)
		{

		}


		private void AManage_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}


		//메소드
		private void SetzlistView()
		{
			//리스트 정보를 클리어
			AManage_ListV_List.Items.Clear();

			//계정들이 저장된 경로
			string accountpath = @"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Accounts";

			//경로에 존재하는 파일들을 리스트로 받아온다
			DirectoryInfo di = new DirectoryInfo(accountpath);
			List<string> accounts = new List<string>();
			foreach(var item in di.GetFiles())
			{
				accounts.Add(item.Name);
			}

			// 각 파일의 내용을 리스트뷰에 뿌려준다
			foreach(string filename in accounts)
			{
				StreamReader sr = new StreamReader(accountpath+@"\"+filename, Encoding.Default);
				ListViewItem listviewitem = new ListViewItem();
				
				listviewitem.Text = sr.ReadLine();
				listviewitem.SubItems.Add(sr.ReadLine());
				listviewitem.SubItems.Add(sr.ReadLine());
				listviewitem.SubItems.Add(sr.ReadLine());

				AManage_ListV_List.Items.Add(listviewitem);
			}

		}
	}
}
