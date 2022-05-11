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
    public partial class FrmNHANVIEN : Form
    {
        public FrmNHANVIEN()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void FrmNHANVIEN_Load(object sender, EventArgs e)
        {
            LAYDATA_NHANVIEN();
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("SELECT * FROM CHUCVU");
            cboCHUCVU.DataSource = dta;
            cboCHUCVU.DisplayMember = "TENCV";
            cboCHUCVU.ValueMember = "TENCV";

            cboGIOITINH.Items.Add("NAM");
            cboGIOITINH.Items.Add("NỮ");

            dta = ketnoi.Lay_Dulieu("SELECT * FROM NHANVIEN");
            txtMANV.DataSource = dta;
            txtMANV.DisplayMember = "MANV";
            txtMANV.ValueMember = "MANV";
        }
        public void LAYDATA_NHANVIEN()
        {
            DataTable dta = new DataTable();
            String sql = "select MANV,TENNV, GIOITINH, DIACHI, SODIENTHOAI,TENCV from NHANVIEN inner join CHUCVU on NHANVIEN.MACV = CHUCVU.MACV";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHANVIEN.DataSource = dta;
        }
        public void DATABINDING()
        {
            txtMANV.DataBindings.Clear();
            txtMANV.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "MANV");

            txtTENNV.DataBindings.Clear();
            txtTENNV.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "TENNV");

            cboCHUCVU.DataBindings.Clear();
            cboCHUCVU.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "TENCV");

            txtDIACHI.DataBindings.Clear();
            txtDIACHI.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "DIACHI");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "SODIENTHOAI");

            cboGIOITINH.DataBindings.Clear();
            cboGIOITINH.DataBindings.Add("Text", dataGrid_NHANVIEN.DataSource, "GIOITINH");
        }

        private void dataGrid_NHANVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void btnTIMKIEM_MANV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select MANV,TENNV, GIOITINH, DIACHI, SODIENTHOAI,TENCV from NHANVIEN inner join CHUCVU on NHANVIEN.MACV = CHUCVU.MACV";
            sql += $" where MANV = '{txtMANV.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHANVIEN.DataSource = dta;
        }

        private void btnTIMKIEM_TENNV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select MANV,TENNV, GIOITINH, DIACHI, SODIENTHOAI,TENCV from NHANVIEN inner join CHUCVU on NHANVIEN.MACV = CHUCVU.MACV";
            sql += $" where TENNV = '{txtTENNV.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_NHANVIEN.DataSource = dta;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from CHUCVU where TENCV = N'{cboCHUCVU.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MACV = dta.Rows[0][0].ToString();

            sql = $"insert into NHANVIEN values ('{txtMANV.Text}','{MACV}' ,N'{txtTENNV.Text}',N'{cboGIOITINH.Text}','{txtSDT.Text}', N'{txtDIACHI.Text}')";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NHANVIEN();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from CHUCVU where TENCV = N'{cboCHUCVU.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MACV = dta.Rows[0][0].ToString();

            sql = $"update NHANVIEN set MACV = '{MACV}', TENNV = N'{txtTENNV.Text}', GIOITINH = N'{cboGIOITINH.Text}', SODIENTHOAI = '{txtSDT.Text}', DIACHI = N'{txtDIACHI.Text}' where MANV = '{txtMANV.Text}'";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NHANVIEN();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = $"delete from NHANVIEN where MANV = '{txtMANV.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_NHANVIEN();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGIOITINH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
