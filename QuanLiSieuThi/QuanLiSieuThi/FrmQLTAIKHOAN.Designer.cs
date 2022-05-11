
namespace QuanLiSieuThi
{
    partial class FrmQLTAIKHOAN
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
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTENTAIKHOAN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid_QLTK = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_QLTK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMATKHAU.Location = new System.Drawing.Point(531, 158);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Size = new System.Drawing.Size(356, 29);
            this.txtMATKHAU.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(513, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Mật khẩu";
            // 
            // txtTENTAIKHOAN
            // 
            this.txtTENTAIKHOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTENTAIKHOAN.Location = new System.Drawing.Point(160, 158);
            this.txtTENTAIKHOAN.Name = "txtTENTAIKHOAN";
            this.txtTENTAIKHOAN.Size = new System.Drawing.Size(313, 29);
            this.txtTENTAIKHOAN.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(141, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên tài khoản";
            // 
            // btnXOA
            // 
            this.btnXOA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXOA.Location = new System.Drawing.Point(638, 226);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(162, 35);
            this.btnXOA.TabIndex = 35;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = false;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnSUA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSUA.Location = new System.Drawing.Point(419, 226);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(162, 35);
            this.btnSUA.TabIndex = 34;
            this.btnSUA.Text = "Đổi mật khẩu";
            this.btnSUA.UseVisualStyleBackColor = false;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTHEM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTHEM.Location = new System.Drawing.Point(201, 226);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(162, 35);
            this.btnTHEM.TabIndex = 33;
            this.btnTHEM.Text = "Thêm tài khoản";
            this.btnTHEM.UseVisualStyleBackColor = false;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGrid_QLTK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 400);
            this.panel1.TabIndex = 36;
            // 
            // dataGrid_QLTK
            // 
            this.dataGrid_QLTK.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid_QLTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_QLTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_QLTK.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_QLTK.Name = "dataGrid_QLTK";
            this.dataGrid_QLTK.Size = new System.Drawing.Size(1200, 400);
            this.dataGrid_QLTK.TabIndex = 0;
            this.dataGrid_QLTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_QLTK_CellContentClick);
            // 
            // FrmQLTAIKHOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTENTAIKHOAN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLTAIKHOAN";
            this.Text = "FrmQLTAIKHOAN";
            this.Load += new System.EventHandler(this.FrmQLTAIKHOAN_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_QLTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTENTAIKHOAN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGrid_QLTK;
    }
}