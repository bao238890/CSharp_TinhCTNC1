using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhCTNC1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntinhtong_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 + so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhhieu_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 - so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhtich_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 * so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            if (so2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo lỗi", MessageBoxButtons.OKCancel);
            }
            else
            {
                ketqua = so1 / so2;
                txtKQ.Text = ketqua.ToString();
                lblKQ.Text = ketqua.ToString();
            }
        }
    }
}
