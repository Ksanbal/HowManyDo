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
	public partial class Admin_Form_Regist : Form
	{
		public Admin_Form_Regist()
		{
			InitializeComponent();
		}


		private void ARegist_Btn_Ok_Click(object sender, EventArgs e)
		{
			MessageBox.Show("등록");
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
	}
}
