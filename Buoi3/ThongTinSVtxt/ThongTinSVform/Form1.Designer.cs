namespace ThongTinSVform
{
    partial class Form1
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
            this.thongTinSVtxt1 = new ThongTinSVtxt.ThongTinSVtxt();
            this.SuspendLayout();
            // 
            // thongTinSVtxt1
            // 
            this.thongTinSVtxt1.Location = new System.Drawing.Point(0, 0);
            this.thongTinSVtxt1.Name = "thongTinSVtxt1";
            this.thongTinSVtxt1.Size = new System.Drawing.Size(374, 149);
            this.thongTinSVtxt1.TabIndex = 0;
            this.thongTinSVtxt1.Load += new System.EventHandler(this.thongTinSVtxt1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 154);
            this.Controls.Add(this.thongTinSVtxt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ThongTinSVtxt.ThongTinSVtxt thongTinSVtxt1;
    }
}

