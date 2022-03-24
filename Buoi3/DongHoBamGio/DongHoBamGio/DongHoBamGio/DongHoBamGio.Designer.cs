namespace DongHoBamGio
{
    partial class DongHoBamGio
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
            this.components = new System.ComponentModel.Container();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.buttonLap = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelS = new System.Windows.Forms.Label();
            this.labelMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(25, 57);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 1;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // buttonLap
            // 
            this.buttonLap.Location = new System.Drawing.Point(106, 57);
            this.buttonLap.Name = "buttonLap";
            this.buttonLap.Size = new System.Drawing.Size(75, 23);
            this.buttonLap.TabIndex = 2;
            this.buttonLap.Text = "Lap";
            this.buttonLap.UseVisualStyleBackColor = true;
            this.buttonLap.Click += new System.EventHandler(this.buttonLap_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelS.Location = new System.Drawing.Point(6, 7);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(111, 47);
            this.labelS.TabIndex = 4;
            this.labelS.Text = "0:0:0";
            this.labelS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMS
            // 
            this.labelMS.AutoSize = true;
            this.labelMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.labelMS.Location = new System.Drawing.Point(123, 7);
            this.labelMS.Name = "labelMS";
            this.labelMS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMS.Size = new System.Drawing.Size(43, 47);
            this.labelMS.TabIndex = 5;
            this.labelMS.Text = "0";
            this.labelMS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DongHoBamGio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMS);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.buttonLap);
            this.Controls.Add(this.buttonStartStop);
            this.Name = "DongHoBamGio";
            this.Size = new System.Drawing.Size(202, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.Button buttonLap;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelMS;
    }
}
