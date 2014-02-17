namespace CESTApp
{
    partial class ReportesFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GenerarInformeBtn = new System.Windows.Forms.Button();
            this.ReporteAnioCmb = new System.Windows.Forms.ComboBox();
            this.ReporteMesCmb = new System.Windows.Forms.ComboBox();
            this.SegundaFechaDtp = new System.Windows.Forms.DateTimePicker();
            this.PrimeraFechaDtp = new System.Windows.Forms.DateTimePicker();
            this.GenerarReportePorCmb = new System.Windows.Forms.ComboBox();
            this.TipoReporteCmb = new System.Windows.Forms.ComboBox();
            this.DelLbl = new System.Windows.Forms.Label();
            this.AlLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IngresosDtg = new System.Windows.Forms.DataGridView();
            this.ImprimirReporteBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.GenerarInformeBtn);
            this.groupBox1.Controls.Add(this.ReporteAnioCmb);
            this.groupBox1.Controls.Add(this.ReporteMesCmb);
            this.groupBox1.Controls.Add(this.SegundaFechaDtp);
            this.groupBox1.Controls.Add(this.PrimeraFechaDtp);
            this.groupBox1.Controls.Add(this.GenerarReportePorCmb);
            this.groupBox1.Controls.Add(this.TipoReporteCmb);
            this.groupBox1.Controls.Add(this.DelLbl);
            this.groupBox1.Controls.Add(this.AlLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generar reportes";
            // 
            // GenerarInformeBtn
            // 
            this.GenerarInformeBtn.Location = new System.Drawing.Point(602, 20);
            this.GenerarInformeBtn.Name = "GenerarInformeBtn";
            this.GenerarInformeBtn.Size = new System.Drawing.Size(65, 23);
            this.GenerarInformeBtn.TabIndex = 5;
            this.GenerarInformeBtn.Text = "Generar";
            this.GenerarInformeBtn.UseVisualStyleBackColor = true;
            this.GenerarInformeBtn.Click += new System.EventHandler(this.GenerarInformeBtn_Click);
            // 
            // ReporteAnioCmb
            // 
            this.ReporteAnioCmb.Enabled = false;
            this.ReporteAnioCmb.FormattingEnabled = true;
            this.ReporteAnioCmb.Location = new System.Drawing.Point(398, 21);
            this.ReporteAnioCmb.Name = "ReporteAnioCmb";
            this.ReporteAnioCmb.Size = new System.Drawing.Size(81, 21);
            this.ReporteAnioCmb.TabIndex = 3;
            this.ReporteAnioCmb.Visible = false;
            this.ReporteAnioCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReporteAnioCmb_KeyPress);
            // 
            // ReporteMesCmb
            // 
            this.ReporteMesCmb.Enabled = false;
            this.ReporteMesCmb.FormattingEnabled = true;
            this.ReporteMesCmb.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.ReporteMesCmb.Location = new System.Drawing.Point(398, 22);
            this.ReporteMesCmb.Name = "ReporteMesCmb";
            this.ReporteMesCmb.Size = new System.Drawing.Size(81, 21);
            this.ReporteMesCmb.TabIndex = 3;
            this.ReporteMesCmb.Visible = false;
            this.ReporteMesCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReporteMesCmb_KeyPress);
            // 
            // SegundaFechaDtp
            // 
            this.SegundaFechaDtp.Enabled = false;
            this.SegundaFechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.SegundaFechaDtp.Location = new System.Drawing.Point(506, 22);
            this.SegundaFechaDtp.Name = "SegundaFechaDtp";
            this.SegundaFechaDtp.Size = new System.Drawing.Size(81, 20);
            this.SegundaFechaDtp.TabIndex = 4;
            this.SegundaFechaDtp.Visible = false;
            // 
            // PrimeraFechaDtp
            // 
            this.PrimeraFechaDtp.Enabled = false;
            this.PrimeraFechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PrimeraFechaDtp.Location = new System.Drawing.Point(398, 22);
            this.PrimeraFechaDtp.Name = "PrimeraFechaDtp";
            this.PrimeraFechaDtp.Size = new System.Drawing.Size(81, 20);
            this.PrimeraFechaDtp.TabIndex = 2;
            this.PrimeraFechaDtp.Visible = false;
            // 
            // GenerarReportePorCmb
            // 
            this.GenerarReportePorCmb.FormattingEnabled = true;
            this.GenerarReportePorCmb.Items.AddRange(new object[] {
            "Día",
            "Semana",
            "Mes",
            "Año",
            "Rango de Fechas"});
            this.GenerarReportePorCmb.Location = new System.Drawing.Point(239, 22);
            this.GenerarReportePorCmb.Name = "GenerarReportePorCmb";
            this.GenerarReportePorCmb.Size = new System.Drawing.Size(126, 21);
            this.GenerarReportePorCmb.TabIndex = 1;
            this.GenerarReportePorCmb.SelectedIndexChanged += new System.EventHandler(this.FormaReporteCmb_SelectedIndexChanged);
            this.GenerarReportePorCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormaReporteCmb_KeyPress);
            // 
            // TipoReporteCmb
            // 
            this.TipoReporteCmb.FormattingEnabled = true;
            this.TipoReporteCmb.Items.AddRange(new object[] {
            "Ingresos económicos",
            "Servicios prestados",
            "Estudios realizados"});
            this.TipoReporteCmb.Location = new System.Drawing.Point(80, 22);
            this.TipoReporteCmb.Name = "TipoReporteCmb";
            this.TipoReporteCmb.Size = new System.Drawing.Size(121, 21);
            this.TipoReporteCmb.TabIndex = 0;
            this.TipoReporteCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoReporteCmb_KeyPress);
            // 
            // DelLbl
            // 
            this.DelLbl.AutoSize = true;
            this.DelLbl.Location = new System.Drawing.Point(371, 25);
            this.DelLbl.Name = "DelLbl";
            this.DelLbl.Size = new System.Drawing.Size(19, 13);
            this.DelLbl.TabIndex = 0;
            this.DelLbl.Text = "de";
            this.DelLbl.Visible = false;
            // 
            // AlLbl
            // 
            this.AlLbl.AutoSize = true;
            this.AlLbl.Location = new System.Drawing.Point(485, 25);
            this.AlLbl.Name = "AlLbl";
            this.AlLbl.Size = new System.Drawing.Size(15, 13);
            this.AlLbl.TabIndex = 0;
            this.AlLbl.Text = "al";
            this.AlLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes de:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.IngresosDtg);
            this.groupBox2.Location = new System.Drawing.Point(12, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(675, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // IngresosDtg
            // 
            this.IngresosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IngresosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosDtg.Location = new System.Drawing.Point(6, 19);
            this.IngresosDtg.Name = "IngresosDtg";
            this.IngresosDtg.Size = new System.Drawing.Size(661, 298);
            this.IngresosDtg.TabIndex = 0;
            // 
            // ImprimirReporteBtn
            // 
            this.ImprimirReporteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImprimirReporteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImprimirReporteBtn.Location = new System.Drawing.Point(430, 453);
            this.ImprimirReporteBtn.Name = "ImprimirReporteBtn";
            this.ImprimirReporteBtn.Size = new System.Drawing.Size(164, 27);
            this.ImprimirReporteBtn.TabIndex = 2;
            this.ImprimirReporteBtn.Text = "&Preparar para Imprimir";
            this.ImprimirReporteBtn.UseVisualStyleBackColor = true;
            this.ImprimirReporteBtn.Click += new System.EventHandler(this.ImprimirReporteBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarBtn.Location = new System.Drawing.Point(603, 453);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(76, 27);
            this.CerrarBtn.TabIndex = 2;
            this.CerrarBtn.Text = "&Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.ForeColor = System.Drawing.Color.Yellow;
            this.InfoLbl.Location = new System.Drawing.Point(18, 460);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(55, 13);
            this.InfoLbl.TabIndex = 3;
            this.InfoLbl.Text = "                ";
            // 
            // ReportesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(695, 484);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.ImprimirReporteBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(711, 522);
            this.Name = "ReportesFrm";
            this.ShowInTaskbar = false;
            this.Text = "Generar reportes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReportesFrm_FormClosing);
            this.Load += new System.EventHandler(this.ReportesFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IngresosDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TipoReporteCmb;
        private System.Windows.Forms.DateTimePicker SegundaFechaDtp;
        private System.Windows.Forms.DateTimePicker PrimeraFechaDtp;
        private System.Windows.Forms.ComboBox GenerarReportePorCmb;
        private System.Windows.Forms.Label DelLbl;
        private System.Windows.Forms.Label AlLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerarInformeBtn;
        private System.Windows.Forms.ComboBox ReporteAnioCmb;
        private System.Windows.Forms.ComboBox ReporteMesCmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView IngresosDtg;
        private System.Windows.Forms.Button ImprimirReporteBtn;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Label InfoLbl;
    }
}