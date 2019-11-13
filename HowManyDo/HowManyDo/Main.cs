using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowManyDo
{
	public partial class Main_Form_Index : Form
	{
		public Main_Form_Index()
		{
			InitializeComponent();
		}

		private void Main_Btn_Login_Click(object sender, EventArgs e)
		{
			Main_Form_Login LoginForm = new Main_Form_Login();
			LoginForm.ShowDialog();
		}
	}
}
