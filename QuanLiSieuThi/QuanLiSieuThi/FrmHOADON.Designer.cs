
namespace QuanLiSieuThi
{
    partial class FrmHOADON
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGrid_HD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTHANHTIEN = new System.Windows.Forms.TextBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSLUONG = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGIAMGIA = new System.Windows.Forms.NumericUpDown();
            this.btnHDMOI = new System.Windows.Forms.Button();
            this.btnXUATHD = new System.Windows.Forms.Button();
            this.cboTENHH = new System.Windows.Forms.ComboBox();
            this.btnXOA = new System.Windows.Forms.Button();
            this.cboMAHH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtTONG = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_HOADON = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLUONG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIAMGIA)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMAHD
            // 
            this.txtMAHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMAHD.Location = new System.Drawing.Point(50, 145);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.ReadOnly = true;
            this.txtMAHD.Size = new System.Drawing.Size(236, 29);
            this.txtMAHD.TabIndex = 30;
            this.txtMAHD.TextChanged += new System.EventHandler(this.txtMAHD_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(31, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã hóa đơn:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(31, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày:";
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(50, 72);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(236, 29);
            this.date.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(432, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Tên hàng hóa:";
            // 
            // dataGrid_HD
            // 
            this.dataGrid_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_HD.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_HD.Location = new System.Drawing.Point(373, -1);
            this.dataGrid_HD.Name = "dataGrid_HD";
            this.dataGrid_HD.Size = new System.Drawing.Size(827, 175);
            this.dataGrid_HD.TabIndex = 32;
            this.dataGrid_HD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(28, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã hàng hóa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(885, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 24);
            this.label6.TabIndex = 37;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(885, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 39;
            this.label5.Text = "Thành tiền:";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // txtTHANHTIEN
            // 
            this.txtTHANHTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTHANHTIEN.Location = new System.Drawing.Point(904, 380);
            this.txtTHANHTIEN.Name = "txtTHANHTIEN";
            this.txtTHANHTIEN.ReadOnly = true;
            this.txtTHANHTIEN.Size = new System.Drawing.Size(236, 29);
            this.txtTHANHTIEN.TabIndex = 37;
            this.txtTHANHTIEN.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTHEM.Location = new System.Drawing.Point(508, 310);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(58, 45);
            this.btnTHEM.TabIndex = 42;
            this.btnTHEM.Text = "+";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDONGIA.Location = new System.Drawing.Point(904, 305);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.ReadOnly = true;
            this.txtDONGIA.Size = new System.Drawing.Size(236, 29);
            this.txtDONGIA.TabIndex = 35;
            this.txtDONGIA.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(885, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Đơn giá:";
            // 
            // txtSLUONG
            // 
            this.txtSLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSLUONG.Location = new System.Drawing.Point(904, 240);
            this.txtSLUONG.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtSLUONG.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSLUONG.Name = "txtSLUONG";
            this.txtSLUONG.Size = new System.Drawing.Size(236, 29);
            this.txtSLUONG.TabIndex = 33;
            this.txtSLUONG.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSLUONG.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(28, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Giảm giá%:";
            // 
            // txtGIAMGIA
            // 
            this.txtGIAMGIA.DecimalPlaces = 2;
            this.txtGIAMGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGIAMGIA.Location = new System.Drawing.Point(47, 311);
            this.txtGIAMGIA.Name = "txtGIAMGIA";
            this.txtGIAMGIA.Size = new System.Drawing.Size(236, 29);
            this.txtGIAMGIA.TabIndex = 34;
            this.txtGIAMGIA.ValueChanged += new System.EventHandler(this.txtGIAMGIA_ValueChanged);
            // 
            // btnHDMOI
            // 
            this.btnHDMOI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnHDMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHDMOI.Location = new System.Drawing.Point(47, 454);
            this.btnHDMOI.Name = "btnHDMOI";
            this.btnHDMOI.Size = new System.Drawing.Size(153, 44);
            this.btnHDMOI.TabIndex = 52;
            this.btnHDMOI.Text = "Hóa đơn mới";
            this.btnHDMOI.UseVisualStyleBackColor = false;
            this.btnHDMOI.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXUATHD
            // 
            this.btnXUATHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnXUATHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXUATHD.Location = new System.Drawing.Point(248, 454);
            this.btnXUATHD.Name = "btnXUATHD";
            this.btnXUATHD.Size = new System.Drawing.Size(153, 44);
            this.btnXUATHD.TabIndex = 53;
            this.btnXUATHD.Text = "Xuất hóa đơn";
            this.btnXUATHD.UseVisualStyleBackColor = false;
            this.btnXUATHD.Click += new System.EventHandler(this.btnXUATHD_Click);
            // 
            // cboTENHH
            // 
            this.cboTENHH.DropDownHeight = 200;
            this.cboTENHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTENHH.FormattingEnabled = true;
            this.cboTENHH.IntegralHeight = false;
            this.cboTENHH.Location = new System.Drawing.Point(436, 237);
            this.cboTENHH.Name = "cboTENHH";
            this.cboTENHH.Size = new System.Drawing.Size(326, 32);
            this.cboTENHH.TabIndex = 32;
            this.cboTENHH.SelectedIndexChanged += new System.EventHandler(this.cboTENHH_SelectedIndexChanged);
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXOA.Location = new System.Drawing.Point(611, 309);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(58, 45);
            this.btnXOA.TabIndex = 55;
            this.btnXOA.Text = "-";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // cboMAHH
            // 
            this.cboMAHH.DropDownHeight = 200;
            this.cboMAHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboMAHH.FormattingEnabled = true;
            this.cboMAHH.IntegralHeight = false;
            this.cboMAHH.Location = new System.Drawing.Point(47, 237);
            this.cboMAHH.Name = "cboMAHH";
            this.cboMAHH.Size = new System.Drawing.Size(236, 32);
            this.cboMAHH.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(31, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 57;
            this.label9.Text = "Nhân viên:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownHeight = 200;
            this.cboNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboNV.FormattingEnabled = true;
            this.cboNV.IntegralHeight = false;
            this.cboNV.Location = new System.Drawing.Point(47, 385);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(236, 32);
            this.cboNV.TabIndex = 36;
            // 
            // txtTONG
            // 
            this.txtTONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTONG.Location = new System.Drawing.Point(904, 454);
            this.txtTONG.Name = "txtTONG";
            this.txtTONG.ReadOnly = true;
            this.txtTONG.Size = new System.Drawing.Size(236, 29);
            this.txtTONG.TabIndex = 60;
            this.txtTONG.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(885, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 24);
            this.label10.TabIndex = 59;
            this.label10.Text = "Tổng hóa đơn:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_HOADON);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 200);
            this.panel1.TabIndex = 61;
            // 
            // dataGrid_HOADON
            // 
            this.dataGrid_HOADON.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_HOADON.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_HOADON.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_HOADON.Name = "dataGrid_HOADON";
            this.dataGrid_HOADON.Size = new System.Drawing.Size(1200, 200);
            this.dataGrid_HOADON.TabIndex = 0;
            // 
            // FrmHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTONG);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboMAHH);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.cboTENHH);
            this.Controls.Add(this.btnXUATHD);
            this.Controls.Add(this.btnHDMOI);
            this.Controls.Add(this.txtGIAMGIA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSLUONG);
            this.Controls.Add(this.txtDONGIA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtTHANHTIEN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGrid_HD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMAHD);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHOADON";
            this.Text = "FrmHOADON";
            this.Load += new System.EventHandler(this.FrmHOADON_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLUONG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGIAMGIA)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HOADON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGrid_HD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTHANHTIEN;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtSLUONG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtGIAMGIA;
        private System.Windows.Forms.Button btnHDMOI;
        private System.Windows.Forms.Button btnXUATHD;
        private System.Windows.Forms.ComboBox cboTENHH;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.ComboBox cboMAHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.TextBox txtTONG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_HOADON;
    }
}