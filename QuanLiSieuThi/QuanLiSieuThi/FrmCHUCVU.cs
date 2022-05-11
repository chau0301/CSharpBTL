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
    public partial class FrmCHUCVU : Form
    {
        public FrmCHUCVU()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void FrmCHUCVU_Load(object sender, EventArgs e)
        {
            LAYDATA_CHUCVU();
        }
        public void LAYDATA_CHUCVU()
        {
            DataTable dta = new DataTable();
            String sql = "select * from CHUCVU";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_CHUCVU.DataSource = dta;
        }
        public void DATABINDING()
        {
            txtMACV.DataBindings.Clear();
            txtMACV.DataBindings.Add("Text", dataGrid_CHUCVU.DataSource, "MACV");

            txtTENCV.DataBindings.Clear();
            txtTENCV.DataBindings.Add("Text", dataGrid_CHUCVU.DataSource, "TENCV");
        }

        private void dataGrid_CHUCVU_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void btnTIMKIEM_MACV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from CHUCVU where MACV = '{txtMACV.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_CHUCVU.DataSource = dta;
        }

        private void btnTIMKIEM_TENCV_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select * from CHUCVU where TENCV = N'{txtTENCV.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_CHUCVU.DataSource = dta;
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            string sql = $"insert into CHUCVU values ('{txtMACV.Text}', N'{txtTENCV.Text}')";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_CHUCVU();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            string sql = $"update CHUCVU set TENCV = N'{txtTENCV.Text}' where MACV = '{txtMACV.Text}'";
            ketnoi.Execute(sql.ToUpper());
            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_CHUCVU();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            string sql = $"delete from CHUCVU where MACV = '{txtMACV.Text}'";
            ketnoi.Execute(sql);
            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LAYDATA_CHUCVU();
        }
    }
}
