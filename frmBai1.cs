using System;
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
	public partial class frmBai1 : Form
	{
		public frmBai1()
		{
			InitializeComponent();
		}

		private void rbDo_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "55000";
		}

		private void rbVang_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "57000";
		}

		private void rbXanh_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "62000";
		}

		private void dbTrang_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "66000";
		}

		private void rbDen_CheckedChanged(object sender, EventArgs e)
		{
			txtDonGia.Text = "74000";
		}

		private void btnTinhTien_Click(object sender, EventArgs e)
		{
			int tinhTien = int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
			lblSoTien.Text = tinhTien.ToString();
		}
	}
}
