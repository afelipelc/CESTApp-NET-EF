namespace CESTApp.Reportes
{
    partial class ImprimirDiagnosticoFrm
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
            this.DiagnosticoRptv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // DiagnosticoRptv
            // 
            this.DiagnosticoRptv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiagnosticoRptv.LocalReport.ReportEmbeddedResource = "CESTApp.Reportes.DiagnosticoRpt.rdlc";
            this.DiagnosticoRptv.Location = new System.Drawing.Point(0, 0);
            this.DiagnosticoRptv.Name = "DiagnosticoRptv";
            this.DiagnosticoRptv.Size = new System.Drawing.Size(416, 266);
            this.DiagnosticoRptv.TabIndex = 0;
            // 
            // ImprimirDiagnosticoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 266);
            this.Controls.Add(this.DiagnosticoRptv);
            this.Name = "ImprimirDiagnosticoFrm";
            this.ShowInTaskbar = false;
            this.Text = "ImprimirDiagnosticoFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ImprimirDiagnosticoFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer DiagnosticoRptv;
    }
}