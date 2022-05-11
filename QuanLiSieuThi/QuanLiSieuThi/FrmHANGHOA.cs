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
    public partial class FrmHANGHOA : Form
    {
        public FrmHANGHOA()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void FrmHANGHOA_Load(object sender, EventArgs e)
        {
            LAYDATA_HH();
            addToCBO();
        }
        public void LAYDATA_HH()
        {
            DataTable dta = new DataTable();
            String sql = "select MAHH, TENHH, SOLUONG, DONGIA, TENNHOM, TENNGANH from HANGHOA inner join NHOMHANG on HANGHOA.MANHOM = NHOMHANG.MANHOM inner join NGANHHANG on NHOMHANG.MANGANH = NGANHHANG.MANGANH";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_HANGHOA.DataSource = dta;
        }
        public void addToCBO()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("SELECT * FROM NGANHHANG");
            cboTENNGANH.DataSource = dta;
            cboTENNGANH.DisplayMember = "TENNGANH";
            cboTENNGANH.ValueMember = "TENNGANH";
        }
        public void addTocboTENNHOM()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu($"select * from NHOMHANG inner join NGANHHANG on NHOMHANG.MANGANH = NGANHHANG.MANGANH where TENNGANH = N'{cboTENNGANH.Text}'");
            cboTENNHOM.DataSource = dta;
            cboTENNHOM.DisplayMember = "TENNHOM";
            cboTENNHOM.ValueMember = "TENNHOM";
        }
        public void DATABINDING()
        {
            txtMAHH.DataBindings.Clear();
            txtMAHH.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "MAHH");
            
            txtTENHH.DataBindings.Clear();
            txtTENHH.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "TENHH");

            txtSOLUONG.DataBindings.Clear();
            txtSOLUONG.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "SOLUONG");

            txtDONGIA.DataBindings.Clear();
            txtDONGIA.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "DONGIA");

            cboTENNGANH.DataBindings.Clear();
            cboTENNGANH.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "TENNGANH");

            cboTENNHOM.DataBindings.Clear();
            cboTENNHOM.DataBindings.Add("Text", dataGrid_HANGHOA.DataSource, "TENNHOM");
        }

        private void btnTIMKIEM_MANV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select MAHH, TENHH, SOLUONG, DONGIA, TENNHOM, TENNGANH from HANGHOA inner join NHOMHANG on HANGHOA.MANHOM = NHOMHANG.MANHOM inner join NGANHHANG on NHOMHANG.MANGANH = NGANHHANG.MANGANH";
            sql += $" where MAHH = '{txtMAHH.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_HANGHOA.DataSource = dta;
        }

        private void btnTIMKIEM_TENNV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = "select MAHH, TENHH, SOLUONG, DONGIA, TENNHOM, TENNGANH from HANGHOA inner join NHOMHANG on HANGHOA.MANHOM = NHOMHANG.MANHOM inner join NGANHHANG on NHOMHANG.MANGANH = NGANHHANG.MANGANH";
            sql += $" where TENHH = N'{txtTENHH.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_HANGHOA.DataSource = dta;
        }

        private void dataGrid_HANGHOA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from NHOMHANG where TENNHOM = N'{cboTENNHOM.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANHOM = dta.Rows[0][0].ToString();

            sql = $"insert into HANGHOA values ('{txtMAHH.Text}','{MANHOM}' ,N'{txtTENHH.Text}',{txtSOLUONG.Value},{txtDONGIA.Text})";
            ketnoi.Execute(sql);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_HH();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from NHOMHANG where TENNHOM = N'{cboTENNHOM.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANHOM = dta.Rows[0][0].ToString();

            sql = $"update HANGHOA set MANHOM = '{MANHOM}' , TENHH = N'{txtTENHH.Text}',SOLUONG = {txtSOLUONG.Value}, DONGIA = '{txtDONGIA.Text}' where MAHH = '{txtMAHH.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_HH();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = $"delete from HANGHOA where MAHH = '{txtMAHH.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_HH();
        }

        private void cboTENNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboTENNGANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            addTocboTENNHOM();
        }
    }
}
