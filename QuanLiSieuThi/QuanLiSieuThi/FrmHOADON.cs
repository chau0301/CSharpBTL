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
    public partial class FrmHOADON : Form
    {
        public FrmHOADON()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void LAYDATA_HD1()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from HOADONBANHANG");
            dataGrid_HOADON.DataSource = dta;
        }
        public void LAYDATA_HD()
        {
            DataTable dta = new DataTable();
            String sql = "select MAHD,CT_HOADON.MAHH,TENHH,SLUONG,DGIA,TILE_VAT,THANHTIEN from CT_HOADON inner join HANGHOA on HANGHOA.MAHH = CT_HOADON.MAHH";
            if (txtMAHD.Text != "" )
            {
                sql = $"select MAHD,CT_HOADON.MAHH,TENHH,SLUONG,DGIA,TILE_VAT,THANHTIEN from CT_HOADON inner join HANGHOA on HANGHOA.MAHH = CT_HOADON.MAHH where MAHD = '{txtMAHD.Text}'";
            }
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_HD.DataSource = dta;
            LAYDATA_HD1();
        }
        public void DATABINDING()
        {
            cboMAHH.DataBindings.Clear();
            cboMAHH.DataBindings.Add("Text", dataGrid_HD.DataSource, "MAHH");

            cboTENHH.DataBindings.Clear();
            cboTENHH.DataBindings.Add("Text", dataGrid_HD.DataSource, "TENHH");

            txtSLUONG.DataBindings.Clear();
            txtSLUONG.DataBindings.Add("Text", dataGrid_HD.DataSource, "SLUONG");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }
        private void creatMAHD()
        {
            string MAHD = "HD" + DateTime.Now.ToString("dd:mm:yy::HH:mm").Replace(":", "");
            txtMAHD.Text = MAHD;
        }
        private void addValuesToCBO()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from HANGHOA");
            cboMAHH.DataSource = dta;
            cboMAHH.DisplayMember = "MAHH";
            cboMAHH.ValueMember = "MAHH";
            cboTENHH.DataSource = dta;
            cboTENHH.DisplayMember = "TENHH";
            cboTENHH.ValueMember = "TENHH";

            dta = ketnoi.Lay_Dulieu("select * from NHANVIEN");
            cboNV.DataSource = dta;
            cboNV.DisplayMember = "TENNV";
            cboNV.ValueMember = "TENNV";
        }

        private void FrmHOADON_Load(object sender, EventArgs e)
        {
            txtTONG.Text = "0";
            LAYDATA_HD1();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            addValuesToCBO();
            creatMAHD();
            LAYDATA_HD();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            
            string sql = $"insert into CT_HOADON values ('{txtMAHD.Text}','{cboMAHH.Text}' , {txtSLUONG.Value}, '{txtDONGIA.Text}', {txtGIAMGIA.Value}, {txtTHANHTIEN.Text})";
            ketnoi.Execute(sql);

            sql = $"EXEC HOADONADD {txtSLUONG.Value},'{txtMAHD.Text}'";
            ketnoi.Execute(sql);
            LAYDATA_HD();
            Tong();

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete from CT_HOADON where MAHD = '{txtMAHD.Text}' and MAHH = '{cboMAHH.Text}'";
                ketnoi.Execute(sql);

                sql = $"EXEC HOADONMINUS {txtSLUONG.Value},'{txtMAHD.Text}'";
                ketnoi.Execute(sql);

                LAYDATA_HD();
                Tong();
            }
            catch
            {

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tong()
        {
            if (txtMAHD.Text != "")
            {
                DataTable dta = new DataTable();
                String sql = $"select sum(THANHTIEN) as TONG from CT_HOADON where MAHD = '{txtMAHD.Text}'";
                dta = ketnoi.Lay_Dulieu(sql);
                if (dta.Rows[0][0].ToString() != null)
                {
                    txtTONG.Text = dta.Rows[0][0].ToString();
                }
                else
                {
                    txtTONG.Text = "0";
                }
            }            
        }
        private void THANHTIEN()
        {
            txtTHANHTIEN.Text = (float.Parse(txtDONGIA.Text) * (float)txtSLUONG.Value * (1 - ((float)txtGIAMGIA.Value) / 100)).ToString();
        }
        private void cboTENHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            String sql = $"select DONGIA from HANGHOA where MAHH = '{cboMAHH.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            txtDONGIA.Text = dta.Rows[0][0].ToString();
            THANHTIEN();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            THANHTIEN();
        }

        private void txtGIAMGIA_ValueChanged(object sender, EventArgs e)
        {
            THANHTIEN();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnXUATHD_Click(object sender, EventArgs e)
        {
            string sql = $"select MAHD,CT_HOADON.MAHH,TENHH,SLUONG,DGIA,TILE_VAT,THANHTIEN from CT_HOADON inner join HANGHOA on HANGHOA.MAHH = CT_HOADON.MAHH where MAHD = '{txtMAHD.Text}'";
            DataTable data = new DataTable();
            data = ketnoi.Lay_Dulieu(sql);
            HOADON baocao = new HOADON();

            baocao.SetDataSource(data);
            
            FrmBAOCAO frm = new FrmBAOCAO();
            frm.crystalReportViewer1.ReportSource = baocao;
            frm.ShowDialog();

            DataTable dta = new DataTable();
            sql = $"select MANV from NHANVIEN where TENNV = N'{cboNV.Text}';";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANV = dta.Rows[0][0].ToString();

            sql = $"insert into HOADONBANHANG values ('{txtMAHD.Text}','{date.Value.ToString("yyyy - MM - dd")}','{txtTONG.Text}','{MANV}')";
            ketnoi.Execute(sql);
            LAYDATA_HD1();


        }

        private void txtMAHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
