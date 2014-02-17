namespace CESTApp.Reportes
{
    partial class ReporteEstudiosFrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EstudiosRealizadosRptv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DatosEstudiosRealizadosBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstudiosRealizadosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudiosRealizadosRptv
            // 
            this.EstudiosRealizadosRptv.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DatosRepEstudios";
            reportDataSource2.Value = this.DatosEstudiosRealizadosBS;
            this.EstudiosRealizadosRptv.LocalReport.DataSources.Add(reportDataSource2);
            this.EstudiosRealizadosRptv.LocalReport.ReportEmbeddedResource = "CESTApp.Reportes.EstudiosRpt.rdlc";
            this.EstudiosRealizadosRptv.Location = new System.Drawing.Point(0, 0);
            this.EstudiosRealizadosRptv.Name = "EstudiosRealizadosRptv";
            this.EstudiosRealizadosRptv.Size = new System.Drawing.Size(462, 346);
            this.EstudiosRealizadosRptv.TabIndex = 0;
            // 
            // DatosEstudiosRealizadosBS
            // 
            this.DatosEstudiosRealizadosBS.DataSource = typeof(CESTApp.EstudiosRealizados_Result);
            // 
            // ReporteEstudiosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 346);
            this.Controls.Add(this.EstudiosRealizadosRptv);
            this.Name = "ReporteEstudiosFrm";
            this.ShowInTaskbar = false;
            this.Text = "Reporte de Estudios realizados.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteEstudiosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosEstudiosRealizadosBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EstudiosRealizadosRptv;
        private System.Windows.Forms.BindingSource DatosEstudiosRealizadosBS;
    }
}