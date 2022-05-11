using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSieuThi
{
    public partial class FrmQLTAIKHOAN : Form
    {
        public FrmQLTAIKHOAN()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void FrmQLTAIKHOAN_Load(object sender, EventArgs e)
        {
            LAYDATA_QLTK();
        }
        public void LAYDATA_QLTK()
        {
            DataTable dta = new DataTable();
            String sql = "select TENDANGNHAP,MATKHAU from QUYEN_DANGNHAP";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_QLTK.DataSource = dta;
        }
        public void DATABINDING()
        {
            txtTENTAIKHOAN.DataBindings.Clear();
            txtTENTAIKHOAN.DataBindings.Add("Text", dataGrid_QLTK.DataSource, "TENDANGNHAP");

            txtMATKHAU.DataBindings.Clear();
            txtMATKHAU.DataBindings.Add("Text", dataGrid_QLTK.DataSource, "MATKHAU");
        }

        private void dataGrid_QLTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string sql = $"insert into QUYEN_DANGNHAP Values ('{txtTENTAIKHOAN.Text}','AD','{txtMATKHAU.Text}')";
            ketnoi.Execute(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_QLTK();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql = $"update QUYEN_DANGNHAP set MATKHAU = '{txtMATKHAU.Text}' where TENDANGNHAP = '{txtTENTAIKHOAN.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_QLTK();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = $"delete from QUYEN_DANGNHAP where TENDANGNHAP = '{txtTENTAIKHOAN.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_QLTK();
        }
    }
}
