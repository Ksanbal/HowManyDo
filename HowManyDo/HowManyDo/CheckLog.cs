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
	public partial class Form_CheckLog : Form
	{
		public Form_CheckLog()
		{
			InitializeComponent();
		}

		private void CheckLog_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
