namespace CESTApp
{
    partial class GestionMedicosCanalizadoresFrm
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
            this.MedicosCanalizadoresDtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MedicosCanalizadoresDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // MedicosCanalizadoresDtg
            // 
            this.MedicosCanalizadoresDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MedicosCanalizadoresDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MedicosCanalizadoresDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicosCanalizadoresDtg.Location = new System.Drawing.Point(12, 12);
            this.MedicosCanalizadoresDtg.Name = "MedicosCanalizadoresDtg";
            this.MedicosCanalizadoresDtg.ReadOnly = true;
            this.MedicosCanalizadoresDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicosCanalizadoresDtg.Size = new System.Drawing.Size(357, 229);
            this.MedicosCanalizadoresDtg.TabIndex = 0;
            this.MedicosCanalizadoresDtg.DataSourceChanged += new System.EventHandler(this.MedicosCanalizadoresDtg_DataSourceChanged);
            this.MedicosCanalizadoresDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicosCanalizadoresDtg_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Doble clic sobre el médico para visualizar los estudios que ha solicitado.";
            // 
            // GestionMedicosCanalizadoresFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedicosCanalizadoresDtg);
            this.Name = "GestionMedicosCanalizadoresFrm";
            this.Text = "Gestión de médicos canalizadores";
            this.Load += new System.EventHandler(this.GestionMedicosCanalizadoresFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicosCanalizadoresDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MedicosCanalizadoresDtg;
        private System.Windows.Forms.Label label1;
    }
}