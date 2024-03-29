﻿using System;
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
	public partial class Admin_Form_Log : Form
	{
		public Admin_Form_Log()
		{
			InitializeComponent();
			SetListView();
		}

		private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
		{
			switch (ALog_MenuStrip.Items[0].Text)
			{
				case "Large Icon":
					ALog_ListV_List.View = View.LargeIcon;
					break;

				case "Details":
					ALog_ListV_List.View = View.Details;
					break;

				case "Small Icon":
					ALog_ListV_List.View = View.SmallIcon;
					break;

				case "List":
					ALog_ListV_List.View = View.List;
					break;

				case "Tile":
					ALog_ListV_List.View = View.Tile;
					break;
			}
		}

		private void ALog_Btn_ShowDetail_Click(object sender, EventArgs e)
		{
			try
			{
				Form_CheckLog formcheckLog = new Form_CheckLog();
				formcheckLog.Filename = ALog_ListV_List.SelectedItems[0].SubItems[1].Text
					+ "_" + ALog_ListV_List.SelectedItems[0].Text;

				formcheckLog.ShowDialog();
			}
			catch (ArgumentOutOfRangeException)
			{
				MessageBox.Show("원생이 선택되지 않았습니다.");
			}
		}

		private void ALog_Btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		// 메소드
		// list창을 채워주는 메소드
		private void SetListView()
		{
			// 글이 저장된 경로
			string writepath = "Write";
			
			//  경로에 저장된 파일을 리스트로 받아온다. 
			DirectoryInfo di = new DirectoryInfo(writepath);
			List<string> writes = new List<string>();
			foreach(var item in di.GetFiles())
			{
				writes.Add(item.Name);
			}

			// 이미지 리스트의 인덱스
			int i = 0;
			// 각 파일의 내용을 리스트뷰에 뿌려준다.
			foreach (string filename in writes)
			{
				//글 파일인 경우 리스트에 추가
				if (filename.Contains(".txt"))
				{
					StreamReader sr = new StreamReader(writepath + @"\" + filename, Encoding.Default);
					ListViewItem listviewitem = new ListViewItem();

					listviewitem.ImageIndex = i;
					listviewitem.Text = sr.ReadLine();
					listviewitem.SubItems.Add(sr.ReadLine());
					listviewitem.SubItems.Add(sr.ReadToEnd());

					ALog_ListV_List.Items.Add(listviewitem);
					sr.Close();
					i++; // 이미지 인덱스 ++
				}
				//사진 파일인 경우 이미지 리스트에 추가
				else if (filename.Contains(".jpg"))
				{
					ALog_imageList.Images.Add(Bitmap.FromFile(writepath + @"\" + filename));
				}
			}
		} // SetListView()

	}
}
