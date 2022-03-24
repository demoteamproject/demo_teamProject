namespace DHBGform
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
            this.dongHoBamGio1 = new DongHoBamGio.DongHoBamGio();
            this.SuspendLayout();
            // 
            // dongHoBamGio1
            // 
            this.dongHoBamGio1.Location = new System.Drawing.Point(0, 0);
            this.dongHoBamGio1.Name = "dongHoBamGio1";
            this.dongHoBamGio1.Size = new System.Drawing.Size(212, 96);
            this.dongHoBamGio1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 96);
            this.Controls.Add(this.dongHoBamGio1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DongHoBamGio.DongHoBamGio dongHoBamGio1;

    }
}

