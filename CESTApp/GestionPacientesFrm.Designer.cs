namespace CESTApp
{
    partial class GestionPacientesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPacientesFrm));
            this.PacientesDtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarLugarResidenciaCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FiltrarDesdeDtp = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.FiltrarHastaDtp = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PacientesDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // PacientesDtg
            // 
            this.PacientesDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PacientesDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.PacientesDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PacientesDtg.Location = new System.Drawing.Point(12, 68);
            this.PacientesDtg.Name = "PacientesDtg";
            this.PacientesDtg.ReadOnly = true;
            this.PacientesDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PacientesDtg.Size = new System.Drawing.Size(492, 211);
            this.PacientesDtg.TabIndex = 0;
            this.PacientesDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PacientesDtg_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mostrar pacientes que viven en:";
            // 
            // FiltrarLugarResidenciaCmb
            // 
            this.FiltrarLugarResidenciaCmb.FormattingEnabled = true;
            this.FiltrarLugarResidenciaCmb.Items.AddRange(new object[] {
            "Todos"});
            this.FiltrarLugarResidenciaCmb.Location = new System.Drawing.Point(177, 15);
            this.FiltrarLugarResidenciaCmb.Name = "FiltrarLugarResidenciaCmb";
            this.FiltrarLugarResidenciaCmb.Size = new System.Drawing.Size(225, 21);
            this.FiltrarLugarResidenciaCmb.TabIndex = 2;
            this.FiltrarLugarResidenciaCmb.Text = "Todos los lugares";
            this.FiltrarLugarResidenciaCmb.SelectionChangeCommitted += new System.EventHandler(this.FiltrarLugarResidenciaCmb_SelectionChangeCommitted);
            this.FiltrarLugarResidenciaCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FiltrarLugarResidenciaCmb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Por estudios realizados entre el";
            // 
            // FiltrarDesdeDtp
            // 
            this.FiltrarDesdeDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FiltrarDesdeDtp.Location = new System.Drawing.Point(177, 42);
            this.FiltrarDesdeDtp.Name = "FiltrarDesdeDtp";
            this.FiltrarDesdeDtp.Size = new System.Drawing.Size(95, 20);
            this.FiltrarDesdeDtp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "y el";
            // 
            // FiltrarHastaDtp
            // 
            this.FiltrarHastaDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FiltrarHastaDtp.Location = new System.Drawing.Point(307, 42);
            this.FiltrarHastaDtp.Name = "FiltrarHastaDtp";
            this.FiltrarHastaDtp.Size = new System.Drawing.Size(95, 20);
            this.FiltrarHastaDtp.TabIndex = 4;
            // 
            // GestionPacientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 286);
            this.Controls.Add(this.FiltrarHastaDtp);
            this.Controls.Add(this.FiltrarDesdeDtp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FiltrarLugarResidenciaCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PacientesDtg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionPacientesFrm";
            this.Text = "Gestión de Pacientes";
            this.Load += new System.EventHandler(this.GestionPacientesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PacientesDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PacientesDtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarLugarResidenciaCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FiltrarDesdeDtp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FiltrarHastaDtp;
    }
}