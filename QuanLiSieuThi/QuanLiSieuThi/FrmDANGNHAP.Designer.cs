
namespace QuanLiSieuThi
{
    partial class FrmDANGNHAP
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTENDANGNHAP = new System.Windows.Forms.TextBox();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDANGNHAP = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.cbSHOWPASS = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(197, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(197, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // txtTENDANGNHAP
            // 
            this.txtTENDANGNHAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTENDANGNHAP.Location = new System.Drawing.Point(244, 118);
            this.txtTENDANGNHAP.MaxLength = 32;
            this.txtTENDANGNHAP.Name = "txtTENDANGNHAP";
            this.txtTENDANGNHAP.Size = new System.Drawing.Size(310, 31);
            this.txtTENDANGNHAP.TabIndex = 4;
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMATKHAU.Location = new System.Drawing.Point(244, 190);
            this.txtMATKHAU.MaxLength = 32;
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.PasswordChar = '*';
            this.txtMATKHAU.Size = new System.Drawing.Size(310, 31);
            this.txtMATKHAU.TabIndex = 5;
            this.txtMATKHAU.TextChanged += new System.EventHandler(this.txtMATKHAU_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.panel1.Location = new System.Drawing.Point(629, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 378);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 360);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // btnDANGNHAP
            // 
            this.btnDANGNHAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDANGNHAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnDANGNHAP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDANGNHAP.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDANGNHAP.ForeColor = System.Drawing.Color.Black;
            this.btnDANGNHAP.Location = new System.Drawing.Point(244, 288);
            this.btnDANGNHAP.Margin = new System.Windows.Forms.Padding(2);
            this.btnDANGNHAP.Name = "btnDANGNHAP";
            this.btnDANGNHAP.Size = new System.Drawing.Size(139, 41);
            this.btnDANGNHAP.TabIndex = 7;
            this.btnDANGNHAP.Text = "Đăng nhập";
            this.btnDANGNHAP.UseVisualStyleBackColor = false;
            this.btnDANGNHAP.Click += new System.EventHandler(this.btn_login_2_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTHOAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.btnTHOAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTHOAT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.ForeColor = System.Drawing.Color.Black;
            this.btnTHOAT.Location = new System.Drawing.Point(415, 288);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(2);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(139, 41);
            this.btnTHOAT.TabIndex = 8;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = false;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click_1);
            // 
            // cbSHOWPASS
            // 
            this.cbSHOWPASS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSHOWPASS.AutoSize = true;
            this.cbSHOWPASS.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSHOWPASS.ForeColor = System.Drawing.Color.Black;
            this.cbSHOWPASS.Location = new System.Drawing.Point(297, 243);
            this.cbSHOWPASS.Margin = new System.Windows.Forms.Padding(2);
            this.cbSHOWPASS.Name = "cbSHOWPASS";
            this.cbSHOWPASS.Size = new System.Drawing.Size(165, 26);
            this.cbSHOWPASS.TabIndex = 6;
            this.cbSHOWPASS.Text = "Hiển thị mật khẩu";
            this.cbSHOWPASS.UseVisualStyleBackColor = true;
            this.cbSHOWPASS.CheckedChanged += new System.EventHandler(this.cbSHOWPASS_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 31);
            this.label3.TabIndex = 79;
            this.label3.Text = "Phần mềm quản lý siêu thị";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLiSieuThi.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(32, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Version 3.3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(50, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 25);
            this.label5.TabIndex = 82;
            this.label5.Text = "Nhóm 3";
            // 
            // FrmDANGNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSHOWPASS);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnDANGNHAP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.txtTENDANGNHAP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmDANGNHAP";
            this.Text = "FrmDANGNHAP";
            this.Load += new System.EventHandler(this.FrmDANGNHAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTENDANGNHAP;
        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDANGNHAP;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.CheckBox cbSHOWPASS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}