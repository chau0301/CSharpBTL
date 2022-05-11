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
    public partial class FrmPHIEUNHAP : Form
    {
        public FrmPHIEUNHAP()
        {
            InitializeComponent();
        }
        Ketnoi_CSDL ketnoi = new Ketnoi_CSDL();
        
        public void LAYDATA_1()
        {   
            if (txtMAPN.Text != "")
            {
                DataTable dta = new DataTable();
                string sql = $"select * from CT_PHIEUNHAP where MAPN = '{txtMAPN.Text}'";
                dta = ketnoi.Lay_Dulieu(sql);
                dataGrid_CHITIET.DataSource = dta;
            }

        }
        public void LAYDATA_2()
        {
            DataTable dta = new DataTable();
            String sql = "select * from PHIEUNHAP"; 
            dta = ketnoi.Lay_Dulieu(sql);
            dataGrid_PHIEUNHAP.DataSource = dta;
        }
        public void LAYDATA_PHIEUNHAP()
        {
            LAYDATA_1();
            LAYDATA_2();
        }
        public void DATABINDING()
        {
            txtMAHH.DataBindings.Clear();
            txtMAHH.DataBindings.Add("Text", dataGrid_CHITIET.DataSource, "MAHH");

            txtTENHH.DataBindings.Clear();
            txtTENHH.DataBindings.Add("Text", dataGrid_CHITIET.DataSource, "TENHH");

            txtSLUONG.DataBindings.Clear();
            txtSLUONG.DataBindings.Add("Text", dataGrid_CHITIET.DataSource, "SLUONG");

            txtDGIA.DataBindings.Clear();
            txtDGIA.DataBindings.Add("Text", dataGrid_CHITIET.DataSource, "DGIA");
        }
        private void addValuesToCBO()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("select * from NHANVIEN");
            cboNHANVIEN.DataSource = dta;
            cboNHANVIEN.DisplayMember = "TENNV";
            cboNHANVIEN.ValueMember = "TENNV";

            dta = ketnoi.Lay_Dulieu("select * from NHACUNGCAP");
            cboTENNCC.DataSource = dta;
            cboTENNCC.DisplayMember = "TENNCC";
            cboTENNCC.ValueMember = "TENNCC";

            dta = ketnoi.Lay_Dulieu("SELECT * FROM NGANHHANG");
            cboTENNGANH.DataSource = dta;
            cboTENNGANH.DisplayMember = "TENNGANH";
            cboTENNGANH.ValueMember = "TENNGANH";
        }
      
        private void addValuesToCBONHOMHANG()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu($"select * from NHOMHANG inner join NGANHHANG on NHOMHANG.MANGANH = NGANHHANG.MANGANH where TENNGANH = N'{cboTENNGANH.Text}'");
            cboTENNHOM.DataSource = dta;
            cboTENNHOM.DisplayMember = "TENNHOM";
            cboTENNHOM.ValueMember = "TENNHOM";
        }

        private void creatMAHD()
        {
            string MAPN = "PN" + DateTime.Now.ToString("dd:mm:HH:mm").Replace(":", "");
            txtMAPN.Text = MAPN;
        }
        private void btnTHEM_Click(object sender, EventArgs e)
        {
        
            string sql = $"insert into CT_PHIEUNHAP values ('{txtMAPN.Text}', '{txtMAHH.Text}', N'{txtTENHH.Text}', {txtSLUONG.Value},{txtDGIA.Text})";
            ketnoi.Execute(sql);
            DataTable dta = new DataTable();
            sql = $"select MANHOM from NHOMHANG where TENNHOM = N'{cboTENNHOM.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANHOM = dta.Rows[0][0].ToString();

            sql = $"EXEC PHIEUNHAPTOHANGHOA '{txtMAHH.Text}','{MANHOM}',N'{txtTENHH.Text}',{txtSLUONG.Value},{txtDONGIA.Text}";
            ketnoi.Execute(sql);
            LAYDATA_PHIEUNHAP();
            TONG();


        }

        private void FrmPHIEUNHAP_Load(object sender, EventArgs e)
        {

        }

        private void cboTENNGANH_SelectedIndexChanged(object sender, EventArgs e)
        {
            addValuesToCBONHOMHANG();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = $"delete from CT_PHIEUNHAP where MAPN = '{txtMAPN.Text}' and MAHH = '{txtMAHH.Text}'";
                ketnoi.Execute(sql);
                sql = $"EXEC HOADONTOHANGHOADELETE '{txtMAHH.Text}'";
                ketnoi.Execute(sql);
            }
            catch
            {

            }
            LAYDATA_PHIEUNHAP();
            TONG();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creatMAHD();
            addValuesToCBO();
            LAYDATA_PHIEUNHAP();
        }

        private void btnXUATHD_Click(object sender, EventArgs e)
        {
            //lay manv + mancc
            DataTable dta = new DataTable();
            string sql = $"select MANCC from NHACUNGCAP where TENNCC = N'{cboTENNCC.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANCC = dta.Rows[0][0].ToString();
            sql = $"select MANV from NHANVIEN where TENNV = N'{cboNHANVIEN.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            string MANV = dta.Rows[0][0].ToString();



            sql = $"insert into PHIEUNHAP values ('{txtMAPN.Text}','{date.Value.ToString("yyyy - MM - dd")}','{MANCC}',{txtTONG.Text},'{MANV}')";
            ketnoi.Execute(sql);
            LAYDATA_PHIEUNHAP();


            sql = "select PHIEUNHAP.MAPN, NGAYNHAP, MANCC,TONGPHAITRA, MAHH,TENHH,SLUONG,DGIA, TENNV from PHIEUNHAP "
                    + "inner join CT_PHIEUNHAP on PHIEUNHAP.MAPN = CT_PHIEUNHAP.MAPN "
                    + "inner join NHANVIEN on PHIEUNHAP.MANV = NHANVIEN.MANV "
                    + $"where PHIEUNHAP.MAPN = '{txtMAPN.Text}'";
            dta = ketnoi.Lay_Dulieu(sql);
            PHIEUNHAP baocao = new PHIEUNHAP();
            baocao.SetDataSource(dta);
            

            //show crystal report
            FrmBAOCAO frm = new FrmBAOCAO();
            frm.crystalReportViewer1.ReportSource = baocao;
            frm.ShowDialog();


        }
        private void TONG()
        {
            if (txtMAPN.Text != "")
            {
                DataTable dta = new DataTable();
                String sql = $"select SUM(DGIA*SLUONG) as TONG from CT_PHIEUNHAP where MAPN ='{txtMAPN.Text}'";
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

        private void dataGrid_CHITIET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DATABINDING();
        }

        private void txtTENHH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
