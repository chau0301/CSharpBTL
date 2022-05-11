using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiSieuThi
{
    public partial class FrmDANGNHAP : Form
    {
        public FrmDANGNHAP()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_2_Click(object sender, EventArgs e)
        {
            ketnoi.KetNoi_Dulieu();

            string TENDANGNHAP = txtTENDANGNHAP.Text;
            string MATKHAU = txtMATKHAU.Text;

            string sql_login = $"select TENDANGNHAP,MATKHAU from QUYEN_DANGNHAP where TENDANGNHAP = '{TENDANGNHAP}' and MATKHAU ='{MATKHAU}'";
            SqlCommand cmd = new SqlCommand(sql_login, ketnoi.cnn);

            SqlDataReader datRed = cmd.ExecuteReader();
            if (datRed.Read())
            {
                //MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                FrmHOME frm = new FrmHOME();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSHOWPASS_CheckedChanged(object sender, EventArgs e)
        {
            txtMATKHAU.PasswordChar = cbSHOWPASS.Checked ? '\0' : '*';
        }

        private void txtMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void btnTHOAT_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
