using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowManyDo.User
{
	public partial class User_Form_CheckNew : Form
	{
		public User_Form_CheckNew()
		{
			InitializeComponent();
		}

		private void UChecknew_Btn_ShowDetail_Click(object sender, EventArgs e)
		{
			Form_CheckLog form_checklog = new Form_CheckLog();

		}

		private void UCkecknew_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		// 메소드
		// 로그인한 계정의 학생 이름을 찾아 학생 이름이 포함된 파일을 찾는 메소드
		
		// 파일들의 사진을 찾아 이미지 리스트에 넣는 메소드

		//
	}
}
