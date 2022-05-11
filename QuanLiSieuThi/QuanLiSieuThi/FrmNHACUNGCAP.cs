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
    public partial class FrmNHACUNGCAP : Form
    {
        public FrmNHACUNGCAP()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();

        public void LAYDATA_NCC()
        {
            DataTable dta = new DataTable();
            String sql = "select * from NHACUNGCAP";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHACUNGCAP.DataSource = dta;
        }
        private void FrmNHACUNGCAP_Load(object sender, EventArgs e)
        {
            LAYDATA_NCC();
        }
        public void DATABINDING()
        {
            txtMANCC.DataBindings.Clear();
            txtMANCC.DataBindings.Add("Text", dataGrid_NHACUNGCAP.DataSource, "MANCC");

            txtDIACHI.DataBindings.Clear();
            txtDIACHI.DataBindings.Add("Text", dataGrid_NHACUNGCAP.DataSource, "DIACHI");

            txtTENNCC.DataBindings.Clear();
            txtTENNCC.DataBindings.Add("Text", dataGrid_NHACUNGCAP.DataSource, "TENNCC");

            txtEMAIL.DataBindings.Clear();
            txtEMAIL.DataBindings.Add("Text", dataGrid_NHACUNGCAP.DataSource, "EMAIL");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGrid_NHACUNGCAP.DataSource, "DIENTHOAI");
        }

        private void dataGrid_NHACUNGCAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void btnTIMKIEM_MANCC_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select * from NHACUNGCAP";
            sql += $" where MANCC = '{txtMANCC.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHACUNGCAP.DataSource = dta;
        }

        private void btnTIMKIEM_TENNCC_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select * from NHACUNGCAP";
            sql += $" where TENNCC = N'{txtTENNCC.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHACUNGCAP.DataSource = dta;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string sql = $"insert into NHACUNGCAP values('{txtMANCC.Text}',N'{txtTENNCC.Text}',N'{txtDIACHI.Text}', '{txtSDT.Text}', '{txtEMAIL.Text}')";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NCC();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql = $"update NHACUNGCAP set TENNCC = N'{txtTENNCC.Text}',DIACHI = N'{txtDIACHI.Text}', DIENTHOAI = '{txtSDT.Text}', EMAIL = '{txtEMAIL.Text}' where MANCC = '{txtMANCC.Text}'";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NCC();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = $"delete from NHACUNGCAP where MANCC = '{txtMANCC.Text}'";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NCC();
        }
    }
}
