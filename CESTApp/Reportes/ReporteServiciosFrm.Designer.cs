namespace CESTApp.Reportes
{
    partial class ReporteServiciosFrm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DatosServiciosPrestadosBS = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteServiciosRptv = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DatosServiciosPrestadosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosServiciosPrestadosBS
            // 
            this.DatosServiciosPrestadosBS.DataSource = typeof(CESTApp.ServiciosPrestados_Result);
            // 
            // ReporteServiciosRptv
            // 
            this.ReporteServiciosRptv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosServicios";
            reportDataSource1.Value = this.DatosServiciosPrestadosBS;
            this.ReporteServiciosRptv.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteServiciosRptv.LocalReport.ReportEmbeddedResource = "CESTApp.Reportes.ServiciosRpt.rdlc";
            this.ReporteServiciosRptv.Location = new System.Drawing.Point(0, 0);
            this.ReporteServiciosRptv.Name = "ReporteServiciosRptv";
            this.ReporteServiciosRptv.Size = new System.Drawing.Size(514, 423);
            this.ReporteServiciosRptv.TabIndex = 0;
            // 
            // ReporteServiciosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 423);
            this.Controls.Add(this.ReporteServiciosRptv);
            this.Name = "ReporteServiciosFrm";
            this.ShowInTaskbar = false;
            this.Text = "Reporte de Servicios prestados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteServiciosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosServiciosPrestadosBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReporteServiciosRptv;
        private System.Windows.Forms.BindingSource DatosServiciosPrestadosBS;
    }
}