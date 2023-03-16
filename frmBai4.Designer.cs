
namespace _2115244_Lab1_complete
{
	partial class frmBai4
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNhapSo = new System.Windows.Forms.TextBox();
			this.btnTimSo = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKetQua = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(95, 59);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(254, 264);
			this.listBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(450, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nhập số cần tìm:";
			// 
			// txtNhapSo
			// 
			this.txtNhapSo.Location = new System.Drawing.Point(579, 59);
			this.txtNhapSo.Name = "txtNhapSo";
			this.txtNhapSo.Size = new System.Drawing.Size(100, 20);
			this.txtNhapSo.TabIndex = 0;
			// 
			// btnTimSo
			// 
			this.btnTimSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimSo.Location = new System.Drawing.Point(579, 111);
			this.btnTimSo.Name = "btnTimSo";
			this.btnTimSo.Size = new System.Drawing.Size(100, 26);
			this.btnTimSo.TabIndex = 1;
			this.btnTimSo.Text = "Tìm Số";
			this.btnTimSo.UseVisualStyleBackColor = true;
			this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(483, 207);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "KẾT QUẢ:";
			// 
			// lblKetQua
			// 
			this.lblKetQua.AutoSize = true;
			this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblKetQua.ForeColor = System.Drawing.Color.Red;
			this.lblKetQua.Location = new System.Drawing.Point(589, 207);
			this.lblKetQua.Name = "lblKetQua";
			this.lblKetQua.Size = new System.Drawing.Size(14, 20);
			this.lblKetQua.TabIndex = 4;
			this.lblKetQua.Text = ".";
			// 
			// frmBai4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblKetQua);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnTimSo);
			this.Controls.Add(this.txtNhapSo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Name = "frmBai4";
			this.Text = "frmBai4";
			this.Load += new System.EventHandler(this.frmBai4_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNhapSo;
		private System.Windows.Forms.Button btnTimSo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKetQua;
	}
}