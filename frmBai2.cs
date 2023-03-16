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
	public partial class frmBai2 : Form
	{
		public frmBai2()
		{
			InitializeComponent();
		}

		private void btnChonHang_Click(object sender, EventArgs e)
		{
			var item = listBox1.SelectedItem;
			listBox2.Items.Add(item);
		}

		private void btnBoHang_Click(object sender, EventArgs e)
		{
			listBox2.Items.Remove(listBox2.SelectedItem);
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int soTien = 0;

			foreach (string hang in listBox2.Items)
			{
				switch (hang)
				{
					case "Chuột":
						soTien += 100000;
						break;
					case "Bàn Phím":
						soTien += 150000;
						break;
					case "Máy In":
						soTien += 2000000;
						break;
					case "USB KingMax":
						soTien += 200000;
						break;
					default:
						break;
				}
				lblSoTien.Text = soTien + " Đồng";
			}
		}
	}
}
