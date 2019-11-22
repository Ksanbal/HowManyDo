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

namespace HowManyDo
{
	public partial class Form_CheckLog : Form
	{
		public Form_CheckLog()
		{
			InitializeComponent();
		}

		private void Form_CheckLog_Load(object sender, EventArgs e)
		{
			Init(filename);
		}

		private string filename = String.Empty;

		public string Filename
		{
			set { filename = value; }
		}

		private void CheckLog_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		//메소드
		// 선택한 리스트의 내용을 띄워주는 메소드
		private void Init(string filename)
		{
			// 텍스트 처리
			StreamReader sr = new StreamReader(@"Write\" + filename + ".txt");
			CheckLog_Label_Sname.Text = sr.ReadLine();

			// 날짜를 yyyy. MM. dd 형식에 맞게 처리
			string datestring = sr.ReadLine();
			datestring = datestring.Insert(4, ". ");
			datestring = datestring.Insert(8, ". ");

			CheckLog_Label_Date.Text = datestring;
			CheckLog_Label_Body.Text = sr.ReadToEnd();

			// 그림 처리
			CheckLog_Pic_SelectedPic.Image = Bitmap.FromFile(@"Write\" + filename + ".jpg");
		}
	}
}
