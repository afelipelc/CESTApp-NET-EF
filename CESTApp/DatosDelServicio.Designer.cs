namespace CESTApp
{
    partial class DatosDelServicio
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
            this.label3 = new System.Windows.Forms.Label();
            this.NombrePacienteTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EstudiosDtg = new System.Windows.Forms.DataGridView();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).BeginInit();
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
            this.groupBox1.TabIndex = 2;
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
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.NombrePacienteTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 57);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // NombrePacienteTxt
            // 
            this.NombrePacienteTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NombrePacienteTxt.Enabled = false;
            this.NombrePacienteTxt.Location = new System.Drawing.Point(97, 22);
            this.NombrePacienteTxt.Name = "NombrePacienteTxt";
            this.NombrePacienteTxt.Size = new System.Drawing.Size(426, 20);
            this.NombrePacienteTxt.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.EstudiosDtg);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 209);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estudios";
            // 
            // EstudiosDtg
            // 
            this.EstudiosDtg.AllowUserToResizeRows = false;
            this.EstudiosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EstudiosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiosDtg.Enabled = false;
            this.EstudiosDtg.Location = new System.Drawing.Point(9, 19);
            this.EstudiosDtg.MultiSelect = false;
            this.EstudiosDtg.Name = "EstudiosDtg";
            this.EstudiosDtg.ReadOnly = true;
            this.EstudiosDtg.RowHeadersVisible = false;
            this.EstudiosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstudiosDtg.Size = new System.Drawing.Size(514, 184);
            this.EstudiosDtg.TabIndex = 7;
            this.EstudiosDtg.DataSourceChanged += new System.EventHandler(this.EstudiosDtg_DataSourceChanged);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarBtn.Location = new System.Drawing.Point(460, 354);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelarBtn.TabIndex = 5;
            this.CancelarBtn.Text = "&Cerrar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // DatosDelServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(554, 396);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatosDelServicio";
            this.ShowInTaskbar = false;
            this.Text = "DatosDelServicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker FechaServicioDtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdServicioTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombrePacienteTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView EstudiosDtg;
        private System.Windows.Forms.Button CancelarBtn;
    }
}