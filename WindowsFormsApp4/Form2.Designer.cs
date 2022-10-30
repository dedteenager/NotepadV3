namespace WindowsFormsApp4
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.imgAbout = new System.Windows.Forms.PictureBox();
            this.txtAbout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbCopyR = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyR)).BeginInit();
            this.SuspendLayout();
            // 
            // imgAbout
            // 
            this.imgAbout.Image = ((System.Drawing.Image)(resources.GetObject("imgAbout.Image")));
            this.imgAbout.Location = new System.Drawing.Point(16, 15);
            this.imgAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgAbout.Name = "imgAbout";
            this.imgAbout.Size = new System.Drawing.Size(157, 148);
            this.imgAbout.TabIndex = 1;
            this.imgAbout.TabStop = false;
            // 
            // txtAbout
            // 
            this.txtAbout.AutoSize = true;
            this.txtAbout.Location = new System.Drawing.Point(181, 43);
            this.txtAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAbout.Name = "txtAbout";
            this.txtAbout.Size = new System.Drawing.Size(200, 16);
            this.txtAbout.TabIndex = 2;
            this.txtAbout.Text = "Простой текстовый редактор";
            this.txtAbout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtAbout.Click += new System.EventHandler(this.txtAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOTEPAD MEGA++ V 2.0";
            // 
            // pbCopyR
            // 
            this.pbCopyR.Image = ((System.Drawing.Image)(resources.GetObject("pbCopyR.Image")));
            this.pbCopyR.Location = new System.Drawing.Point(274, 81);
            this.pbCopyR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCopyR.Name = "pbCopyR";
            this.pbCopyR.Size = new System.Drawing.Size(68, 63);
            this.pbCopyR.TabIndex = 4;
            this.pbCopyR.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(419, 176);
            this.Controls.Add(this.pbCopyR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAbout);
            this.Controls.Add(this.imgAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAbout";
            this.Text = "О программе";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCopyR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAbout;
        private System.Windows.Forms.Label txtAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCopyR;
    }
}