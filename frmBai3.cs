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
	public partial class frmBai3 : Form
	{
		List<string> list = new List<string>();
		public frmBai3()
		{
			InitializeComponent();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			var tu = txtTuMoi.Text;
			var nghia = txtNghia.Text;

			listBox1.Items.Add(tu);
			list.Add(nghia);		//danh sách nghĩa

			txtTuMoi.Focus();	//Tạo vofg lặp
			txtTuMoi.Text = "";	//xóa trống ô từ mới sau mỗi lần nhập lại
			txtNghia.Text = ""; //xóa trống

			listBox1.SelectedIndex = listBox1.Items.Count - 1;  //lấy phần tử cuối(vừa nhập)
			txtHienThiNghia.Text = nghia;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Lấy stt của từ trong list box
			var stt = listBox1.SelectedIndex;

			//Tra nghĩa của từ trong ds list dữ vào stt
			txtHienThiNghia.Text = list[stt];
		}

	}
}
