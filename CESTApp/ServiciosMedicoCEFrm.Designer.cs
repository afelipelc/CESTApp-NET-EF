namespace CESTApp
{
    partial class ServiciosMedicoCEFrm
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
            this.NombreMedicoTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServiciosAsignadosDtg = new System.Windows.Forms.DataGridView();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.RegistrarDiagnosticoBtn = new System.Windows.Forms.Button();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.ServiciosAtencioBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosAsignadosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Médico:";
            // 
            // NombreMedicoTxt
            // 
            this.NombreMedicoTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.NombreMedicoTxt.Enabled = false;
            this.NombreMedicoTxt.Location = new System.Drawing.Point(84, 15);
            this.NombreMedicoTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NombreMedicoTxt.Name = "NombreMedicoTxt";
            this.NombreMedicoTxt.Size = new System.Drawing.Size(496, 23);
            this.NombreMedicoTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ServiciosAsignadosDtg);
            this.groupBox1.Location = new System.Drawing.Point(13, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(577, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de servicios que tiene asignados";
            // 
            // ServiciosAsignadosDtg
            // 
            this.ServiciosAsignadosDtg.AllowUserToAddRows = false;
            this.ServiciosAsignadosDtg.AllowUserToDeleteRows = false;
            this.ServiciosAsignadosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiciosAsignadosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ServiciosAsignadosDtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServiciosAsignadosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiciosAsignadosDtg.Location = new System.Drawing.Point(8, 23);
            this.ServiciosAsignadosDtg.Margin = new System.Windows.Forms.Padding(4);
            this.ServiciosAsignadosDtg.Name = "ServiciosAsignadosDtg";
            this.ServiciosAsignadosDtg.ReadOnly = true;
            this.ServiciosAsignadosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiciosAsignadosDtg.Size = new System.Drawing.Size(559, 319);
            this.ServiciosAsignadosDtg.TabIndex = 0;
            this.ServiciosAsignadosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiciosAsignadosDtg_CellDoubleClick);
            this.ServiciosAsignadosDtg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServiciosAsignadosDtg_KeyPress);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(512, 410);
            this.CerrarBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(68, 28);
            this.CerrarBtn.TabIndex = 3;
            this.CerrarBtn.Text = "&Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // RegistrarDiagnosticoBtn
            // 
            this.RegistrarDiagnosticoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrarDiagnosticoBtn.Location = new System.Drawing.Point(355, 410);
            this.RegistrarDiagnosticoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarDiagnosticoBtn.Name = "RegistrarDiagnosticoBtn";
            this.RegistrarDiagnosticoBtn.Size = new System.Drawing.Size(149, 28);
            this.RegistrarDiagnosticoBtn.TabIndex = 3;
            this.RegistrarDiagnosticoBtn.Text = "Capturar diagnóstico";
            this.RegistrarDiagnosticoBtn.UseVisualStyleBackColor = true;
            this.RegistrarDiagnosticoBtn.Click += new System.EventHandler(this.RegistrarDiagnosticoBtn_Click);
            // 
            // InfoLbl
            // 
            this.InfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.ForeColor = System.Drawing.Color.Red;
            this.InfoLbl.Location = new System.Drawing.Point(13, 416);
            this.InfoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(0, 17);
            this.InfoLbl.TabIndex = 0;
            // 
            // ServiciosAtencioBtn
            // 
            this.ServiciosAtencioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ServiciosAtencioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiciosAtencioBtn.Location = new System.Drawing.Point(197, 410);
            this.ServiciosAtencioBtn.Name = "ServiciosAtencioBtn";
            this.ServiciosAtencioBtn.Size = new System.Drawing.Size(151, 28);
            this.ServiciosAtencioBtn.TabIndex = 4;
            this.ServiciosAtencioBtn.Text = "Servicios en atención";
            this.ServiciosAtencioBtn.UseVisualStyleBackColor = true;
            this.ServiciosAtencioBtn.Click += new System.EventHandler(this.ServiciosAtencioBtn_Click);
            // 
            // ServiciosMedicoCEFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.ServiciosAtencioBtn);
            this.Controls.Add(this.RegistrarDiagnosticoBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NombreMedicoTxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(620, 488);
            this.Name = "ServiciosMedicoCEFrm";
            this.Text = "Servicios asignados de los que no se ha emitido diagnóstico.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiciosMedicoCEFrm_FormClosing);
            this.Load += new System.EventHandler(this.ServiciosMedicoCEFrm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiciosAsignadosDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreMedicoTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ServiciosAsignadosDtg;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button RegistrarDiagnosticoBtn;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Button ServiciosAtencioBtn;
    }
}