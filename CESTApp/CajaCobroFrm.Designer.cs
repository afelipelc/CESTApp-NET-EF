namespace CESTApp
{
    partial class CajaCobroFrm
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
            this.FechaServicioDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.IdServicioTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LugarResidenciaPacienteTxt = new System.Windows.Forms.TextBox();
            this.NombrePacienteTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EstudiosACobrarDtg = new System.Windows.Forms.DataGridView();
            this.ImporteTotalLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.ResgistrarServicioBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SuPagoDTxt = new MisControles.DecimalTextBox();
            this.SuCambioLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NotaLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosACobrarDtg)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaServicioDtp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.IdServicioTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales del servicio";
            // 
            // FechaServicioDtp
            // 
            this.FechaServicioDtp.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.FechaServicioDtp.CustomFormat = "dd/mm/yyyy H:mm tt";
            this.FechaServicioDtp.Enabled = false;
            this.FechaServicioDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaServicioDtp.Location = new System.Drawing.Point(371, 20);
            this.FechaServicioDtp.Name = "FechaServicioDtp";
            this.FechaServicioDtp.Size = new System.Drawing.Size(152, 20);
            this.FechaServicioDtp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha y hora:";
            // 
            // IdServicioTxt
            // 
            this.IdServicioTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IdServicioTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdServicioTxt.Enabled = false;
            this.IdServicioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdServicioTxt.Location = new System.Drawing.Point(97, 19);
            this.IdServicioTxt.Name = "IdServicioTxt";
            this.IdServicioTxt.ReadOnly = true;
            this.IdServicioTxt.Size = new System.Drawing.Size(120, 26);
            this.IdServicioTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id de servicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LugarResidenciaPacienteTxt);
            this.groupBox2.Controls.Add(this.NombrePacienteTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 78);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lugar de residencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // LugarResidenciaPacienteTxt
            // 
            this.LugarResidenciaPacienteTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LugarResidenciaPacienteTxt.Enabled = false;
            this.LugarResidenciaPacienteTxt.Location = new System.Drawing.Point(115, 45);
            this.LugarResidenciaPacienteTxt.Name = "LugarResidenciaPacienteTxt";
            this.LugarResidenciaPacienteTxt.ReadOnly = true;
            this.LugarResidenciaPacienteTxt.Size = new System.Drawing.Size(408, 20);
            this.LugarResidenciaPacienteTxt.TabIndex = 1;
            // 
            // NombrePacienteTxt
            // 
            this.NombrePacienteTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NombrePacienteTxt.Enabled = false;
            this.NombrePacienteTxt.Location = new System.Drawing.Point(115, 19);
            this.NombrePacienteTxt.Name = "NombrePacienteTxt";
            this.NombrePacienteTxt.ReadOnly = true;
            this.NombrePacienteTxt.Size = new System.Drawing.Size(408, 20);
            this.NombrePacienteTxt.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EstudiosACobrarDtg);
            this.groupBox3.Location = new System.Drawing.Point(12, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estudios a cobrar";
            // 
            // EstudiosACobrarDtg
            // 
            this.EstudiosACobrarDtg.AllowUserToResizeRows = false;
            this.EstudiosACobrarDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EstudiosACobrarDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiosACobrarDtg.Enabled = false;
            this.EstudiosACobrarDtg.Location = new System.Drawing.Point(9, 19);
            this.EstudiosACobrarDtg.MultiSelect = false;
            this.EstudiosACobrarDtg.Name = "EstudiosACobrarDtg";
            this.EstudiosACobrarDtg.ReadOnly = true;
            this.EstudiosACobrarDtg.RowHeadersVisible = false;
            this.EstudiosACobrarDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstudiosACobrarDtg.Size = new System.Drawing.Size(514, 124);
            this.EstudiosACobrarDtg.TabIndex = 7;
            this.EstudiosACobrarDtg.DataSourceChanged += new System.EventHandler(this.EstudiosACobrarDtg_DataSourceChanged);
            // 
            // ImporteTotalLbl
            // 
            this.ImporteTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTotalLbl.ForeColor = System.Drawing.Color.Blue;
            this.ImporteTotalLbl.Location = new System.Drawing.Point(6, 56);
            this.ImporteTotalLbl.Name = "ImporteTotalLbl";
            this.ImporteTotalLbl.Size = new System.Drawing.Size(205, 37);
            this.ImporteTotalLbl.TabIndex = 2;
            this.ImporteTotalLbl.Text = "$ 0.00";
            this.ImporteTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total a cobrar:";
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBtn.Location = new System.Drawing.Point(438, 448);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelarBtn.TabIndex = 2;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // ResgistrarServicioBtn
            // 
            this.ResgistrarServicioBtn.Enabled = false;
            this.ResgistrarServicioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResgistrarServicioBtn.Location = new System.Drawing.Point(303, 448);
            this.ResgistrarServicioBtn.Name = "ResgistrarServicioBtn";
            this.ResgistrarServicioBtn.Size = new System.Drawing.Size(129, 30);
            this.ResgistrarServicioBtn.TabIndex = 1;
            this.ResgistrarServicioBtn.Text = "&Registrar Pago";
            this.ResgistrarServicioBtn.UseVisualStyleBackColor = true;
            this.ResgistrarServicioBtn.Click += new System.EventHandler(this.ResgistrarServicioBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SuPagoDTxt);
            this.groupBox4.Controls.Add(this.ImporteTotalLbl);
            this.groupBox4.Controls.Add(this.SuCambioLbl);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 316);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(529, 112);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del cobro";
            // 
            // SuPagoDTxt
            // 
            this.SuPagoDTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuPagoDTxt.Location = new System.Drawing.Point(217, 56);
            this.SuPagoDTxt.Name = "SuPagoDTxt";
            this.SuPagoDTxt.NumeroDecimales = ((short)(2));
            this.SuPagoDTxt.Size = new System.Drawing.Size(121, 38);
            this.SuPagoDTxt.TabIndex = 0;
            this.SuPagoDTxt.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.SuPagoDTxt.TextChanged += new System.EventHandler(this.SuPagoDTxt_TextChanged);
            this.SuPagoDTxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SuPagoDTxt_KeyUp);
            // 
            // SuCambioLbl
            // 
            this.SuCambioLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuCambioLbl.ForeColor = System.Drawing.Color.Green;
            this.SuCambioLbl.Location = new System.Drawing.Point(344, 56);
            this.SuCambioLbl.Name = "SuCambioLbl";
            this.SuCambioLbl.Size = new System.Drawing.Size(179, 37);
            this.SuCambioLbl.TabIndex = 2;
            this.SuCambioLbl.Text = "$ 0.00";
            this.SuCambioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(377, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Su cambio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Su pago:";
            // 
            // NotaLbl
            // 
            this.NotaLbl.AutoSize = true;
            this.NotaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotaLbl.ForeColor = System.Drawing.Color.Red;
            this.NotaLbl.Location = new System.Drawing.Point(12, 457);
            this.NotaLbl.Name = "NotaLbl";
            this.NotaLbl.Size = new System.Drawing.Size(84, 17);
            this.NotaLbl.TabIndex = 15;
            this.NotaLbl.Text = "                   ";
            // 
            // CajaCobroFrm
            // 
            this.AcceptButton = this.ResgistrarServicioBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(554, 487);
            this.Controls.Add(this.NotaLbl);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ResgistrarServicioBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CajaCobroFrm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja de Cobro";
            this.Load += new System.EventHandler(this.CajaCobroFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosACobrarDtg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaServicioDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdServicioTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label ImporteTotalLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView EstudiosACobrarDtg;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Button ResgistrarServicioBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LugarResidenciaPacienteTxt;
        private System.Windows.Forms.TextBox NombrePacienteTxt;
        private System.Windows.Forms.GroupBox groupBox4;
        private MisControles.DecimalTextBox SuPagoDTxt;
        private System.Windows.Forms.Label SuCambioLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NotaLbl;
    }
}