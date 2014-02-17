namespace CESTApp
{
    partial class CapturarDiagnosticoFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MedicoCanalizadorTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ContenidoDiagnosticoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NombrePacienteTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MedicoRemitenteLbl = new System.Windows.Forms.Label();
            this.LugarFechaLbl = new System.Windows.Forms.Label();
            this.AtentamenteLbl = new System.Windows.Forms.Label();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.ImprimirBtn = new System.Windows.Forms.Button();
            this.DetallesServicioBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dr.";
            // 
            // MedicoCanalizadorTxt
            // 
            this.MedicoCanalizadorTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.MedicoCanalizadorTxt.Enabled = false;
            this.MedicoCanalizadorTxt.Location = new System.Drawing.Point(77, 23);
            this.MedicoCanalizadorTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MedicoCanalizadorTxt.Name = "MedicoCanalizadorTxt";
            this.MedicoCanalizadorTxt.Size = new System.Drawing.Size(398, 23);
            this.MedicoCanalizadorTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Presente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "(Resultado del diagnóstico)";
            // 
            // ContenidoDiagnosticoTxt
            // 
            this.ContenidoDiagnosticoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ContenidoDiagnosticoTxt.Location = new System.Drawing.Point(10, 101);
            this.ContenidoDiagnosticoTxt.Multiline = true;
            this.ContenidoDiagnosticoTxt.Name = "ContenidoDiagnosticoTxt";
            this.ContenidoDiagnosticoTxt.Size = new System.Drawing.Size(554, 186);
            this.ContenidoDiagnosticoTxt.TabIndex = 4;
            this.ContenidoDiagnosticoTxt.TextChanged += new System.EventHandler(this.ContenidoDiagnosticoTxt_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.NombrePacienteTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 56);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del paciente:";
            // 
            // NombrePacienteTxt
            // 
            this.NombrePacienteTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NombrePacienteTxt.Enabled = false;
            this.NombrePacienteTxt.Location = new System.Drawing.Point(77, 23);
            this.NombrePacienteTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NombrePacienteTxt.Name = "NombrePacienteTxt";
            this.NombrePacienteTxt.Size = new System.Drawing.Size(398, 23);
            this.NombrePacienteTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.MedicoRemitenteLbl);
            this.groupBox2.Controls.Add(this.LugarFechaLbl);
            this.groupBox2.Controls.Add(this.AtentamenteLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.MedicoCanalizadorTxt);
            this.groupBox2.Controls.Add(this.ContenidoDiagnosticoTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 384);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contenido del resultado a emitir:";
            // 
            // MedicoRemitenteLbl
            // 
            this.MedicoRemitenteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicoRemitenteLbl.AutoSize = true;
            this.MedicoRemitenteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicoRemitenteLbl.Location = new System.Drawing.Point(174, 353);
            this.MedicoRemitenteLbl.Name = "MedicoRemitenteLbl";
            this.MedicoRemitenteLbl.Size = new System.Drawing.Size(141, 17);
            this.MedicoRemitenteLbl.TabIndex = 5;
            this.MedicoRemitenteLbl.Text = "Médico que remite";
            // 
            // LugarFechaLbl
            // 
            this.LugarFechaLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LugarFechaLbl.AutoSize = true;
            this.LugarFechaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LugarFechaLbl.Location = new System.Drawing.Point(190, 328);
            this.LugarFechaLbl.Name = "LugarFechaLbl";
            this.LugarFechaLbl.Size = new System.Drawing.Size(109, 17);
            this.LugarFechaLbl.TabIndex = 5;
            this.LugarFechaLbl.Text = "Lugar. Fecha.";
            // 
            // AtentamenteLbl
            // 
            this.AtentamenteLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AtentamenteLbl.AutoSize = true;
            this.AtentamenteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtentamenteLbl.Location = new System.Drawing.Point(195, 303);
            this.AtentamenteLbl.Name = "AtentamenteLbl";
            this.AtentamenteLbl.Size = new System.Drawing.Size(99, 17);
            this.AtentamenteLbl.TabIndex = 5;
            this.AtentamenteLbl.Text = "Atentamente";
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(460, 468);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(114, 47);
            this.CerrarBtn.TabIndex = 7;
            this.CerrarBtn.Text = "Cerrar sin emitir resultado";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GuardarBtn.Location = new System.Drawing.Point(12, 468);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(114, 47);
            this.GuardarBtn.TabIndex = 7;
            this.GuardarBtn.Text = "Guardar diagnóstico";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // ImprimirBtn
            // 
            this.ImprimirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ImprimirBtn.Location = new System.Drawing.Point(340, 468);
            this.ImprimirBtn.Name = "ImprimirBtn";
            this.ImprimirBtn.Size = new System.Drawing.Size(114, 47);
            this.ImprimirBtn.TabIndex = 7;
            this.ImprimirBtn.Text = "Imprmir resultado";
            this.ImprimirBtn.UseVisualStyleBackColor = true;
            this.ImprimirBtn.Click += new System.EventHandler(this.ImprimirBtn_Click);
            // 
            // DetallesServicioBtn
            // 
            this.DetallesServicioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetallesServicioBtn.Location = new System.Drawing.Point(132, 468);
            this.DetallesServicioBtn.Name = "DetallesServicioBtn";
            this.DetallesServicioBtn.Size = new System.Drawing.Size(114, 47);
            this.DetallesServicioBtn.TabIndex = 7;
            this.DetallesServicioBtn.Text = "Ver datos del servicio";
            this.DetallesServicioBtn.UseVisualStyleBackColor = true;
            this.DetallesServicioBtn.Click += new System.EventHandler(this.DetallesServicioBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.ForeColor = System.Drawing.Color.Orange;
            this.InfoLbl.Location = new System.Drawing.Point(265, 483);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(0, 17);
            this.InfoLbl.TabIndex = 8;
            // 
            // CapturarDiagnosticoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(600, 524);
            this.Controls.Add(this.ImprimirBtn);
            this.Controls.Add(this.DetallesServicioBtn);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.InfoLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(529, 495);
            this.Name = "CapturarDiagnosticoFrm";
            this.Text = "Capturar resultados de estudios realizados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.CapturarDiagnosticoFrm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedicoCanalizadorTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ContenidoDiagnosticoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NombrePacienteTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.Button ImprimirBtn;
        private System.Windows.Forms.Button DetallesServicioBtn;
        private System.Windows.Forms.Label MedicoRemitenteLbl;
        private System.Windows.Forms.Label LugarFechaLbl;
        private System.Windows.Forms.Label AtentamenteLbl;
        private System.Windows.Forms.Label InfoLbl;
    }
}