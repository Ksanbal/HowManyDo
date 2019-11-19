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
	public partial class Admin_Form_ManageStu : Form
	{
		public Admin_Form_ManageStu()
		{
			InitializeComponent();
		}


		private void AManage_Btn_Regist_Click(object sender, EventArgs e)
		{
			Admin_Form_Regist regist = new Admin_Form_Regist();
			regist.ShowDialog();
		}



		private void AManage_Btn_Modify_Click(object sender, EventArgs e)
		{
			Admin_Form_Modify modify = new Admin_Form_Modify();
			modify.ShowDialog();
		}


		private void AManage_Btn_Delete_Click(object sender, EventArgs e)
		{

		}


		private void AManage_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
