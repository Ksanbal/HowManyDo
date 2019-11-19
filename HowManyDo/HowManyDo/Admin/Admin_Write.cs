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
	public partial class Admin_Form_Write : Form
	{
		public Admin_Form_Write()
		{
			InitializeComponent();
		}

		// 이미지 경로를 저장해둘 변수
		private string imagepath;



		private void AWrite_Btn_SelectPic_Click(object sender, EventArgs e)
		{
			imagepath = LoadPic();
		}


		private void AWrtie_Btn_Send_Click(object sender, EventArgs e)
		{
			if(AWrite_TextB_Name.Text == "" || AWrite_TextB_Body.Text == "" || AWrite_Pic_SelectedPic.Image == null)
			{
				MessageBox.Show("아직 작성되지 않은 칸이 있습니다");
			}
			else
			{
				SaveWrite(AWrite_TextB_Name.Text, DateTime.Now.ToString("yyyyMMdd"), AWrite_TextB_Body.Text, imagepath);
				Close();
			}
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

		// 메소드
		private string LoadPic()
		{
			// 파일탐색기로 사진을 찾아서 사진 경로 반환
			string image = "";
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = @"D:\";

			if(ofd.ShowDialog() == DialogResult.OK)
			{
				image = ofd.FileName;
			}
			else
			{
				return null;
			}

			// 사진 폼에 사진 첨부
			AWrite_Pic_SelectedPic.Image = Bitmap.FromFile(image); 
			AWrite_Pic_SelectedPic.SizeMode = PictureBoxSizeMode.StretchImage;

			return image;
		} // LoadPic()

		private void SaveWrite(string name, string date,string body, string image)
		{
			// 텍스트 파일 작성
			StreamWriter sw = new StreamWriter(@"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Write\"+date+"_"+name+@".txt");
			sw.WriteLine(name, Encoding.Default);
			sw.WriteLine(date, Encoding.Default);
			sw.WriteLine(body, Encoding.Default);
			sw.Close();


			// 사진을 Write폴더로 복사
			FileInfo fi = new FileInfo(image);
			fi.CopyTo(@"D:\HG\Programing\HowManyDo\HowManyDo\HowManyDo\bin\Write\"+date+"_"+name+".jpg", true);
		}
	}
}
