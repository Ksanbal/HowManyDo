﻿using System;
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
	public partial class User_Form_Main : Form
	{
		public User_Form_Main()
		{
			InitializeComponent();
		}


		// 접속한 유저의 이름을 노출시키기 위한 프로퍼티입니다.
		public string SetUsername
		{
			set { User_Label_Welcome.Text = "환영합니다 " + value.ToString() + "님"; }
		}


		private void User_btn_Check_Click(object sender, EventArgs e)
		{
			User_Form_CheckNew CheckNew = new User_Form_CheckNew();
			CheckNew.ShowDialog();
		}

		private void User_Form_Main_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(MessageBox.Show("프로그램을 종료하시겠습니까?", "",MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Application.Exit();
			}
			else
			{
				e.Cancel = true;
			}
		}
	}
}
