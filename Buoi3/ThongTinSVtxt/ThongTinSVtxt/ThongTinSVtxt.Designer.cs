namespace ThongTinSVtxt
{
    partial class ThongTinSVtxt
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textMaSV = new System.Windows.Forms.TextBox();
            this.textTenSV = new System.Windows.Forms.TextBox();
            this.textMaLop = new System.Windows.Forms.TextBox();
            this.textNgaySinh = new System.Windows.Forms.TextBox();
            this.textGioiTinh = new System.Windows.Forms.TextBox();
            this.textCMND = new System.Windows.Forms.TextBox();
            this.buttonNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CMND:";
            // 
            // textMaSV
            // 
            this.textMaSV.Location = new System.Drawing.Point(89, 12);
            this.textMaSV.Name = "textMaSV";
            this.textMaSV.Size = new System.Drawing.Size(100, 20);
            this.textMaSV.TabIndex = 6;
            this.textMaSV.TextChanged += new System.EventHandler(this.textMaSV_TextChanged);
            this.textMaSV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMaSV_KeyDown);
            // 
            // textTenSV
            // 
            this.textTenSV.Location = new System.Drawing.Point(89, 38);
            this.textTenSV.Name = "textTenSV";
            this.textTenSV.Size = new System.Drawing.Size(100, 20);
            this.textTenSV.TabIndex = 7;
            // 
            // textMaLop
            // 
            this.textMaLop.Location = new System.Drawing.Point(89, 64);
            this.textMaLop.Name = "textMaLop";
            this.textMaLop.Size = new System.Drawing.Size(100, 20);
            this.textMaLop.TabIndex = 8;
            // 
            // textNgaySinh
            // 
            this.textNgaySinh.Location = new System.Drawing.Point(261, 12);
            this.textNgaySinh.Name = "textNgaySinh";
            this.textNgaySinh.Size = new System.Drawing.Size(100, 20);
            this.textNgaySinh.TabIndex = 9;
            // 
            // textGioiTinh
            // 
            this.textGioiTinh.Location = new System.Drawing.Point(261, 38);
            this.textGioiTinh.Name = "textGioiTinh";
            this.textGioiTinh.Size = new System.Drawing.Size(100, 20);
            this.textGioiTinh.TabIndex = 10;
            // 
            // textCMND
            // 
            this.textCMND.Location = new System.Drawing.Point(261, 64);
            this.textCMND.Name = "textCMND";
            this.textCMND.Size = new System.Drawing.Size(100, 20);
            this.textCMND.TabIndex = 11;
            // 
            // buttonNhap
            // 
            this.buttonNhap.Location = new System.Drawing.Point(214, 108);
            this.buttonNhap.Name = "buttonNhap";
            this.buttonNhap.Size = new System.Drawing.Size(75, 23);
            this.buttonNhap.TabIndex = 12;
            this.buttonNhap.Text = "Nhập từ file";
            this.buttonNhap.UseVisualStyleBackColor = true;
            this.buttonNhap.Click += new System.EventHandler(this.buttonNhap_Click);
            // 
            // ThongTinSVtxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNhap);
            this.Controls.Add(this.textCMND);
            this.Controls.Add(this.textGioiTinh);
            this.Controls.Add(this.textNgaySinh);
            this.Controls.Add(this.textMaLop);
            this.Controls.Add(this.textTenSV);
            this.Controls.Add(this.textMaSV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinSVtxt";
            this.Size = new System.Drawing.Size(374, 149);
            this.Load += new System.EventHandler(this.ThongTinSVtxt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMaSV;
        private System.Windows.Forms.TextBox textTenSV;
        private System.Windows.Forms.TextBox textMaLop;
        private System.Windows.Forms.TextBox textNgaySinh;
        private System.Windows.Forms.TextBox textGioiTinh;
        private System.Windows.Forms.TextBox textCMND;
        private System.Windows.Forms.Button buttonNhap;
    }
}
