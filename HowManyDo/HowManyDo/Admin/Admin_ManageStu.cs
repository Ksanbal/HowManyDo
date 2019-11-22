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
			SetlistView(); // 리스트뷰 내용을 업데이트
		}


		private void AManage_Btn_Regist_Click(object sender, EventArgs e)
		{
			Admin_Form_Regist regist = new Admin_Form_Regist();
			regist.ShowDialog();
			SetlistView(); // 리스트뷰 내용을 업데이트
		}



		private void AManage_Btn_Modify_Click(object sender, EventArgs e)
		{
			try
			{
				Admin_Form_Modify modify = new Admin_Form_Modify();
				// 선택된 아이템의 3번째 서브 아이템의 텍스트(아이디)
				modify.Selectedid = AManage_ListV_List.SelectedItems[0].SubItems[3].Text;
				modify.ShowDialog();
				SetlistView(); // 리스트뷰 내용을 업데이트
			}
			catch(ArgumentOutOfRangeException)
			{
				MessageBox.Show("원생이 선택되지 않았습니다.");
			}
		}


		private void AManage_Btn_Delete_Click(object sender, EventArgs e)
		{
			// 선택된 아이템의 3번째 서브 아이템의 텍스트(아이디)

			try
			{
				DeleteList(AManage_ListV_List.SelectedItems[0].SubItems[0].Text,
					AManage_ListV_List.SelectedItems[0].SubItems[3].Text);
				SetlistView();
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("원생이 선택되지 않았습니다.");
			}
		}


		private void AManage_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}


		//메소드
		// 리스트의 정보를 초기화하고 리프레쉬 시키는 메소드
		private void SetlistView()
		{
			//리스트 정보를 클리어
			AManage_ListV_List.Items.Clear();

			//계정들이 저장된 경로
			string accountpath = "Accounts";

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
				sr.Close();
			}
		} //SetzlistView

		// 선택한 리스트의 파일을 삭제하는 메소드
		private void DeleteList(string sname, string id)
		{
			if(MessageBox.Show(sname + "의 정보를 정말 삭제하시겠습니까?","주의",MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				FileInfo fi = new FileInfo(@"Accounts\" + id + ".txt");
				fi.Delete();
				MessageBox.Show("정상적으로 삭제되었습니다.");
			}
		} // DeleteList()



	}
}
