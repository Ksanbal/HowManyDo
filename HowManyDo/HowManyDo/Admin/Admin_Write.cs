using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowManyDo.Admin
{
	public partial class Admin_Form_Write : Form
	{
		public Admin_Form_Write()
		{
			InitializeComponent();
		}



		private void AWrite_Btn_SelectPic_Click(object sender, EventArgs e)
		{
			MessageBox.Show("사진첨부");
		}



		private void AWrtie_Btn_Send_Click(object sender, EventArgs e)
		{
			MessageBox.Show("보내기");
		}



		private void AWrite_Btn_Temp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("임시저장");
		}



		private void AWrite_Btn_Cancel_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("정말 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
			else
			{ }
		}
	}
}
