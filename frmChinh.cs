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
	public partial class frmChinh : Form
	{
		public frmChinh()
		{
			InitializeComponent();
		}

		private void tsmiBai1_Click(object sender, EventArgs e)
		{
			var form = new frmBai1();
			form.ShowDialog();
		}

		private void tsmiBai3_Click(object sender, EventArgs e)
		{
			var form3 = new frmBai3();
			form3.ShowDialog();
		}

		private void tsmiBai2_Click(object sender, EventArgs e)
		{
			var form2 = new frmBai2();
			form2.ShowDialog();
		}

		private void tsmiBai4_Click(object sender, EventArgs e)
		{
			var form3 = new frmBai4();
			form3.ShowDialog();
		}
	}
}
