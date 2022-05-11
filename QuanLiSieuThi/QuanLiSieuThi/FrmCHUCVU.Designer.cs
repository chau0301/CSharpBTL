
namespace QuanLiSieuThi
{
    partial class FrmCHUCVU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCHUCVU));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_CHUCVU = new System.Windows.Forms.DataGridView();
            this.btnTIMKIEM_TENCV = new System.Windows.Forms.Button();
            this.btnTIMKIEM_MACV = new System.Windows.Forms.Button();
            this.txtTENCV = new System.Windows.Forms.TextBox();
            this.txtMACV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CHUCVU)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_CHUCVU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 400);
            this.panel1.TabIndex = 0;
            // 
            // dataGrid_CHUCVU
            // 
            this.dataGrid_CHUCVU.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_CHUCVU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_CHUCVU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_CHUCVU.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_CHUCVU.Name = "dataGrid_CHUCVU";
            this.dataGrid_CHUCVU.Size = new System.Drawing.Size(1300, 400);
            this.dataGrid_CHUCVU.TabIndex = 0;
            this.dataGrid_CHUCVU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CHUCVU_CellContentClick);
            // 
            // btnTIMKIEM_TENCV
            // 
            this.btnTIMKIEM_TENCV.BackColor = System.Drawing.Color.Transparent;
            this.btnTIMKIEM_TENCV.Image = ((System.Drawing.Image)(resources.GetObject("btnTIMKIEM_TENCV.Image")));
            this.btnTIMKIEM_TENCV.Location = new System.Drawing.Point(1016, 96);
            this.btnTIMKIEM_TENCV.Name = "btnTIMKIEM_TENCV";
            this.btnTIMKIEM_TENCV.Size = new System.Drawing.Size(37, 37);
            this.btnTIMKIEM_TENCV.TabIndex = 29;
            this.btnTIMKIEM_TENCV.UseVisualStyleBackColor = false;
            this.btnTIMKIEM_TENCV.Click += new System.EventHandler(this.btnTIMKIEM_TENCV_Click);
            // 
            // btnTIMKIEM_MACV
            // 
            this.btnTIMKIEM_MACV.BackColor = System.Drawing.Color.Transparent;
            this.btnTIMKIEM_MACV.Image = ((System.Drawing.Image)(resources.GetObject("btnTIMKIEM_MACV.Image")));
            this.btnTIMKIEM_MACV.Location = new System.Drawing.Point(411, 96);
            this.btnTIMKIEM_MACV.Name = "btnTIMKIEM_MACV";
            this.btnTIMKIEM_MACV.Size = new System.Drawing.Size(37, 37);
            this.btnTIMKIEM_MACV.TabIndex = 28;
            this.btnTIMKIEM_MACV.UseVisualStyleBackColor = false;
            this.btnTIMKIEM_MACV.Click += new System.EventHandler(this.btnTIMKIEM_MACV_Click);
            // 
            // txtTENCV
            // 
            this.txtTENCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTENCV.Location = new System.Drawing.Point(663, 104);
            this.txtTENCV.Name = "txtTENCV";
            this.txtTENCV.Size = new System.Drawing.Size(333, 29);
            this.txtTENCV.TabIndex = 27;
            // 
            // txtMACV
            // 
            this.txtMACV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMACV.Location = new System.Drawing.Point(59, 104);
            this.txtMACV.Name = "txtMACV";
            this.txtMACV.Size = new System.Drawing.Size(333, 29);
            this.txtMACV.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(642, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Chức vụ:";
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXOA.Location = new System.Drawing.Point(760, 248);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(94, 35);
            this.btnXOA.TabIndex = 32;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSUA.Location = new System.Drawing.Point(541, 248);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(94, 35);
            this.btnSUA.TabIndex = 31;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTHEM.Location = new System.Drawing.Point(323, 248);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(94, 35);
            this.btnTHEM.TabIndex = 30;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // FrmCHUCVU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnTIMKIEM_TENCV);
            this.Controls.Add(this.btnTIMKIEM_MACV);
            this.Controls.Add(this.txtTENCV);
            this.Controls.Add(this.txtMACV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCHUCVU";
            this.Text = "FrmCHUCVU";
            this.Load += new System.EventHandler(this.FrmCHUCVU_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CHUCVU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_CHUCVU;
        private System.Windows.Forms.Button btnTIMKIEM_TENCV;
        private System.Windows.Forms.Button btnTIMKIEM_MACV;
        private System.Windows.Forms.TextBox txtTENCV;
        private System.Windows.Forms.TextBox txtMACV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEM;
    }
}