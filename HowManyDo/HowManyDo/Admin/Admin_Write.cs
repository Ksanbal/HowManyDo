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
using System.Net.Mail;

namespace HowManyDo.Admin
{
	public partial class Admin_Form_Write : Form
	{
		public Admin_Form_Write()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			SearchStu(AWrite_TextB_Name.Text);
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
				MessageBox.Show("파일을 작성하였습니다.");
;
				SendMail(Getemail(AWrite_Label_SearchedName.Text), DateTime.Now.ToString("yyyyMMdd") + "_" + AWrite_Label_SearchedName.Text,
					AWrite_TextB_Body.Text, imagepath);
				Close();
			}
		}



		private void AWrite_Btn_Cancel_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("정말 취소하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				Close();
			}
		}


		// 메소드
		// 사진을 불러오는 메소드
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

		// 텍스트 파일을 작성하는 메소드
		private void SaveWrite(string name, string date,string body, string image)
		{
			// 텍스트 파일 작성
			StreamWriter sw = new StreamWriter(@"Write\"+date+"_"+name+@".txt");
			sw.WriteLine(name, Encoding.Default);
			sw.WriteLine(date, Encoding.Default);
			sw.WriteLine(body, Encoding.Default);
			sw.Close();


			// 사진을 Write폴더로 복사
			FileInfo fi = new FileInfo(image);
			fi.CopyTo(@"Write\"+date+"_"+name+".jpg", true);
		} // SaveWrite()


		// 입력한 이름이 등록된 계정 중 있는지 확인하는 메소드
		private void SearchStu(string text)
		{
			bool exist = false;
			DirectoryInfo di = new DirectoryInfo("Accounts");
			foreach(var item in di.GetFiles())
			{
				StreamReader sr = new StreamReader(@"Accounts\" + item.Name, Encoding.Default);

				if(text == sr.ReadLine())
				{
					exist = true;
					break;
				}
				sr.Close();
			}

			if (exist == true)
			{
				MessageBox.Show("이름을 성공적으로 확인했습니다.");
				AWrite_Label_SearchedName.Text = text;
			}
			else
			{
				MessageBox.Show("찾으시는 이름이 없습니다.");
			}


		} // SearchStu()


		// 작성한 글을 메일로 보내는 메소드
		private void SendMail(string tmail, string tsub, string tbody, string filename)
		{
			string SMTPaddress = "smtp.naver.com"; //smtp 주소
			string SMTPid = "hyungyun96"; // 이메일 주소
			string SMTPpasswd = "Ktksqkf1021!"; // 이메일 비밀번호
			string senderID = "hyungyun96@naver.com"; // 상대방에게 보여질 이메일주소
			string senderNAME = "HowManyDo_AppleMusic";

			string Tmail = tmail; // 받는 사람 이메일
			string Tsub = tsub; // 메일 제목
			string Tbody = tbody; // 메일 내용

			try
			{
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress(senderID, senderNAME, Encoding.UTF8);
				mail.To.Add(Tmail); // 받는 사람 이메일
				mail.Subject = Tsub; // 메일 제목
				mail.Body = Tbody; // 메일 내용
				mail.BodyEncoding = Encoding.UTF8;
				mail.SubjectEncoding = Encoding.UTF8;

				//첨부파일
				//Attachment attachment = new Attachment(filename);
				mail.Attachments.Add(new Attachment(filename));


				SmtpClient smtpclient = new SmtpClient();
				smtpclient.Host = SMTPaddress;
				smtpclient.Port = 587;
				smtpclient.EnableSsl = true;
				smtpclient.Timeout = 10000;
				smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtpclient.UseDefaultCredentials = false;
				smtpclient.Credentials = new System.Net.NetworkCredential(SMTPid, SMTPpasswd);
				smtpclient.Send(mail);
				MessageBox.Show("메일발송 완료");

				smtpclient.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		} // SendMail


		// 계정의 이메일을 반환하는 메소드
		private string Getemail(string name)
		{

			DirectoryInfo di = new DirectoryInfo("Accounts");
			foreach (var item in di.GetFiles())
			{
				StreamReader sr = new StreamReader(@"Accounts\" + item.Name, Encoding.Default);
				
				if(name == sr.ReadLine())
				{
					for (int i = 0; i < 3; i++)
					{
						if (i == 2)
						{
							return sr.ReadLine();
						}
						sr.ReadLine();
					}
				}
				sr.Close();
			}
			return "error";
		} // Getemail()

	}
}
