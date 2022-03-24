namespace Buoi3
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
            this.digital_Clock1 = new DigitalClock.Digital_Clock();
            this.thietKeLogin1 = new ThietKeLogin.ThietKeLogin();
            this.SuspendLayout();
            // 
            // digital_Clock1
            // 
            this.digital_Clock1.Location = new System.Drawing.Point(38, 134);
            this.digital_Clock1.Name = "digital_Clock1";
            this.digital_Clock1.Size = new System.Drawing.Size(150, 62);
            this.digital_Clock1.TabIndex = 1;
            // 
            // thietKeLogin1
            // 
            this.thietKeLogin1.Location = new System.Drawing.Point(2, 2);
            this.thietKeLogin1.Name = "thietKeLogin1";
            this.thietKeLogin1.Size = new System.Drawing.Size(225, 143);
            this.thietKeLogin1.TabIndex = 0;
            this.thietKeLogin1.Load += new System.EventHandler(this.thietKeLogin1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 207);
            this.Controls.Add(this.digital_Clock1);
            this.Controls.Add(this.thietKeLogin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ThietKeLogin.ThietKeLogin thietKeLogin1;
        private DigitalClock.Digital_Clock digital_Clock1;
    }
}

