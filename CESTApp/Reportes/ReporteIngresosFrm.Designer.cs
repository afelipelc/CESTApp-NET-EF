namespace CESTApp.Reportes
{
    partial class ReporteIngresosFrm
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
            this.DatosIngresosBS = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteIngresosRpt = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DatosIngresosBS)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosIngresosBS
            // 
            this.DatosIngresosBS.DataSource = typeof(CESTApp.IngresosDia_Result);
            // 
            // ReporteIngresosRpt
            // 
            this.ReporteIngresosRpt.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Datos";
            reportDataSource1.Value = this.DatosIngresosBS;
            this.ReporteIngresosRpt.LocalReport.DataSources.Add(reportDataSource1);
            this.ReporteIngresosRpt.LocalReport.ReportEmbeddedResource = "CESTApp.Reportes.IngresosRpt.rdlc";
            this.ReporteIngresosRpt.Location = new System.Drawing.Point(0, 0);
            this.ReporteIngresosRpt.Name = "ReporteIngresosRpt";
            this.ReporteIngresosRpt.Size = new System.Drawing.Size(490, 318);
            this.ReporteIngresosRpt.TabIndex = 0;
            // 
            // ReporteIngresosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 318);
            this.Controls.Add(this.ReporteIngresosRpt);
            this.Name = "ReporteIngresosFrm";
            this.ShowInTaskbar = false;
            this.Text = "Reporte de Ingresos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReporteIngresosFrm_FormClosing);
            this.Load += new System.EventHandler(this.ReporteIngresosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosIngresosBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource DatosIngresosBS;
        private Microsoft.Reporting.WinForms.ReportViewer ReporteIngresosRpt;
    }
}