﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2115244_Lab1_complete
{
	public partial class frmBai4 : Form
	{
		public frmBai4()
		{
			InitializeComponent();
		}

		private void frmBai4_Load(object sender, EventArgs e)
		{
			int so;
			Random r = new Random();
			for (int i = 1; i <= 10; i++)
			{
				so = r.Next(100);           //Tạo hàm nhập ngẫu nhiên < 100
				listBox1.Items.Add(so);
			}
		}

		private void btnTimSo_Click(object sender, EventArgs e)
		{
			int soCanTim = int.Parse(txtNhapSo.Text);
			lblKetQua.Text = "Không Tìm Thấy";

			foreach (int so in listBox1.Items)
			{
				if (so == soCanTim)
				{
					lblKetQua.Text = "Tìm Thấy";
					break;
				}
			}
			txtNhapSo.Focus();
			txtNhapSo.Text = "";
		}
	}
}
