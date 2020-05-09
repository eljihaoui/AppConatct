using Microsoft.Reporting.WinForms;

namespace AppConatct.WinForms
{
    partial class frmPrint
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
            this.ReportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewer1
            // 
            this.ReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.ReportViewer1.Name = "ReportViewer";
            this.ReportViewer1.Size = new System.Drawing.Size(396, 246);
            this.ReportViewer1.TabIndex = 0;
            // 
           
            // 
            // frmPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 628);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrint";
            this.Text = "frmPrint";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer1;
        public ReportViewer Rpv { get => this.ReportViewer1; set => this.ReportViewer1 = value; }
    }
}