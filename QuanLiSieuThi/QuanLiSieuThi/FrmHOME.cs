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
    public partial class FrmHOME : Form
    {
        public FrmHOME()
        {
            InitializeComponent();
        }
        public void loadform(object Form) {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        public void Color(PictureBox picture,Button btn)
        {
            picNHANVIEN.BackColor = System.Drawing.Color.Transparent;
            picCHUCVU.BackColor = System.Drawing.Color.Transparent;
            picHD.BackColor = System.Drawing.Color.Transparent;
            picHH.BackColor = System.Drawing.Color.Transparent; ;
            picNCC.BackColor = System.Drawing.Color.Transparent;
            picTK.BackColor = System.Drawing.Color.Transparent;
            picDOANHTHU.BackColor = System.Drawing.Color.Transparent;

            picture.BackColor = System.Drawing.Color.Black;

            btnQLNV.BackColor = System.Drawing.Color.Transparent;
            btnHANGHOA.BackColor = System.Drawing.Color.Transparent;
            btnHOADON.BackColor = System.Drawing.Color.Transparent;
            btnQLCV.BackColor = System.Drawing.Color.Transparent;
            btnQLTK.BackColor = System.Drawing.Color.Transparent;
            btnQLNCC.BackColor = System.Drawing.Color.Transparent;
            btnDOANHTHU.BackColor = System.Drawing.Color.Transparent;


            btn.BackColor = System.Drawing.Color.FromArgb(252, 252, 212);

        }
        private void FrmHOME_Load(object sender, EventArgs e)
        {
            loadform(new FrmNHANVIEN());
            Color(picNHANVIEN, btnQLNV);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new FrmNHANVIEN());
            Color(picNHANVIEN, btnQLNV);
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnQLNV_MouseHover(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mainpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            loadform(new FrmCHUCVU());
            Color(picCHUCVU, btnQLCV);
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            loadform(new FrmNHACUNGCAP());
            Color(picNCC , btnQLNCC);
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            loadform(new FrmQLTAIKHOAN());
            Color(picTK, btnQLTK);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void btnHANGHOA_Click(object sender, EventArgs e)
        {
            loadform(new FrmHANGHOA());
            Color(picHH, btnHANGHOA);
        }

        private void btnHOADON_Click(object sender, EventArgs e)
        {

            loadform(new FrmHOADON());
            Color(picHD, btnHOADON);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void picNHANVIEN_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDOANHTHU_Click(object sender, EventArgs e)
        {
            loadform(new FrmPHIEUNHAP());
            Color(picDOANHTHU, btnDOANHTHU);
        }
    }
}
