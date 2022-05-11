
namespace QuanLiSieuThi
{
    partial class FrmHANGHOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHANGHOA));
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.txtTENHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_HANGHOA = new System.Windows.Forms.DataGridView();
            this.btnTIMKIEM_TENNV = new System.Windows.Forms.Button();
            this.btnTIMKIEM_MANV = new System.Windows.Forms.Button();
            this.txtSOLUONG = new System.Windows.Forms.NumericUpDown();
            this.cboTENNGANH = new System.Windows.Forms.ComboBox();
            this.cboTENNHOM = new System.Windows.Forms.ComboBox();
            this.txtMAHH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HANGHOA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXOA.Location = new System.Drawing.Point(963, 201);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(94, 35);
            this.btnXOA.TabIndex = 22;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSUA.Location = new System.Drawing.Point(963, 123);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(94, 35);
            this.btnSUA.TabIndex = 21;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTHEM.Location = new System.Drawing.Point(963, 46);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(94, 35);
            this.btnTHEM.TabIndex = 20;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // txtTENHH
            // 
            this.txtTENHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTENHH.Location = new System.Drawing.Point(90, 129);
            this.txtTENHH.Name = "txtTENHH";
            this.txtTENHH.Size = new System.Drawing.Size(327, 29);
            this.txtTENHH.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(71, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên hàng hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã hàng hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(71, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Số lượng:";
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDONGIA.Location = new System.Drawing.Point(561, 52);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.Size = new System.Drawing.Size(327, 29);
            this.txtDONGIA.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(542, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giá:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(542, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên ngành hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(542, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 24);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tên nhóm hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_HANGHOA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 400);
            this.panel1.TabIndex = 35;
            // 
            // dataGrid_HANGHOA
            // 
            this.dataGrid_HANGHOA.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_HANGHOA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_HANGHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_HANGHOA.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_HANGHOA.Name = "dataGrid_HANGHOA";
            this.dataGrid_HANGHOA.Size = new System.Drawing.Size(1300, 400);
            this.dataGrid_HANGHOA.TabIndex = 0;
            this.dataGrid_HANGHOA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_HANGHOA_CellContentClick);
            // 
            // btnTIMKIEM_TENNV
            // 
            this.btnTIMKIEM_TENNV.BackColor = System.Drawing.Color.Transparent;
            this.btnTIMKIEM_TENNV.Image = ((System.Drawing.Image)(resources.GetObject("btnTIMKIEM_TENNV.Image")));
            this.btnTIMKIEM_TENNV.Location = new System.Drawing.Point(438, 121);
            this.btnTIMKIEM_TENNV.Name = "btnTIMKIEM_TENNV";
            this.btnTIMKIEM_TENNV.Size = new System.Drawing.Size(37, 37);
            this.btnTIMKIEM_TENNV.TabIndex = 37;
            this.btnTIMKIEM_TENNV.UseVisualStyleBackColor = false;
            this.btnTIMKIEM_TENNV.Click += new System.EventHandler(this.btnTIMKIEM_TENNV_Click);
            // 
            // btnTIMKIEM_MANV
            // 
            this.btnTIMKIEM_MANV.BackColor = System.Drawing.Color.Transparent;
            this.btnTIMKIEM_MANV.Image = ((System.Drawing.Image)(resources.GetObject("btnTIMKIEM_MANV.Image")));
            this.btnTIMKIEM_MANV.Location = new System.Drawing.Point(438, 44);
            this.btnTIMKIEM_MANV.Name = "btnTIMKIEM_MANV";
            this.btnTIMKIEM_MANV.Size = new System.Drawing.Size(37, 37);
            this.btnTIMKIEM_MANV.TabIndex = 36;
            this.btnTIMKIEM_MANV.UseVisualStyleBackColor = false;
            this.btnTIMKIEM_MANV.Click += new System.EventHandler(this.btnTIMKIEM_MANV_Click);
            // 
            // txtSOLUONG
            // 
            this.txtSOLUONG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSOLUONG.Location = new System.Drawing.Point(90, 207);
            this.txtSOLUONG.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.txtSOLUONG.Name = "txtSOLUONG";
            this.txtSOLUONG.Size = new System.Drawing.Size(327, 29);
            this.txtSOLUONG.TabIndex = 27;
            // 
            // cboTENNGANH
            // 
            this.cboTENNGANH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTENNGANH.FormattingEnabled = true;
            this.cboTENNGANH.Location = new System.Drawing.Point(561, 129);
            this.cboTENNGANH.Name = "cboTENNGANH";
            this.cboTENNGANH.Size = new System.Drawing.Size(327, 32);
            this.cboTENNGANH.TabIndex = 29;
            this.cboTENNGANH.SelectedIndexChanged += new System.EventHandler(this.cboTENNGANH_SelectedIndexChanged);
            // 
            // cboTENNHOM
            // 
            this.cboTENNHOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboTENNHOM.FormattingEnabled = true;
            this.cboTENNHOM.Location = new System.Drawing.Point(561, 207);
            this.cboTENNHOM.Name = "cboTENNHOM";
            this.cboTENNHOM.Size = new System.Drawing.Size(327, 32);
            this.cboTENNHOM.TabIndex = 30;
            this.cboTENNHOM.SelectedIndexChanged += new System.EventHandler(this.cboTENNHOM_SelectedIndexChanged);
            // 
            // txtMAHH
            // 
            this.txtMAHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMAHH.Location = new System.Drawing.Point(90, 52);
            this.txtMAHH.Name = "txtMAHH";
            this.txtMAHH.Size = new System.Drawing.Size(327, 29);
            this.txtMAHH.TabIndex = 25;
            // 
            // FrmHANGHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.cboTENNHOM);
            this.Controls.Add(this.cboTENNGANH);
            this.Controls.Add(this.txtSOLUONG);
            this.Controls.Add(this.btnTIMKIEM_TENNV);
            this.Controls.Add(this.btnTIMKIEM_MANV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDONGIA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTENHH);
            this.Controls.Add(this.txtMAHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHANGHOA";
            this.Text = "FrmHANGHOA";
            this.Load += new System.EventHandler(this.FrmHANGHOA_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_HANGHOA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOLUONG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.TextBox txtTENHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_HANGHOA;
        private System.Windows.Forms.Button btnTIMKIEM_TENNV;
        private System.Windows.Forms.Button btnTIMKIEM_MANV;
        private System.Windows.Forms.NumericUpDown txtSOLUONG;
        private System.Windows.Forms.ComboBox cboTENNGANH;
        private System.Windows.Forms.ComboBox cboTENNHOM;
        private System.Windows.Forms.TextBox txtMAHH;
    }
}