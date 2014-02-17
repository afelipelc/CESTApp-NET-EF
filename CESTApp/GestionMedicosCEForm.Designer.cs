namespace CESTApp
{
    partial class GestionMedicosCEForm
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
            this.ListaMedicosDtg = new System.Windows.Forms.DataGridView();
            this.NuevoMedicoBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaMedicosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaMedicosDtg
            // 
            this.ListaMedicosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaMedicosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaMedicosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaMedicosDtg.Location = new System.Drawing.Point(12, 12);
            this.ListaMedicosDtg.Name = "ListaMedicosDtg";
            this.ListaMedicosDtg.ReadOnly = true;
            this.ListaMedicosDtg.RowHeadersVisible = false;
            this.ListaMedicosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaMedicosDtg.Size = new System.Drawing.Size(477, 214);
            this.ListaMedicosDtg.TabIndex = 0;
            this.ListaMedicosDtg.DataSourceChanged += new System.EventHandler(this.ListaMedicosDtg_DataSourceChanged);
            this.ListaMedicosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaMedicosDtg_CellDoubleClick);
            // 
            // NuevoMedicoBtn
            // 
            this.NuevoMedicoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoMedicoBtn.Location = new System.Drawing.Point(363, 241);
            this.NuevoMedicoBtn.Name = "NuevoMedicoBtn";
            this.NuevoMedicoBtn.Size = new System.Drawing.Size(126, 26);
            this.NuevoMedicoBtn.TabIndex = 1;
            this.NuevoMedicoBtn.Text = "Agregar &nuevo médico";
            this.NuevoMedicoBtn.UseVisualStyleBackColor = true;
            this.NuevoMedicoBtn.Click += new System.EventHandler(this.NuevoMedicoBtn_Click);
            // 
            // GestionMedicosCEForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 279);
            this.Controls.Add(this.NuevoMedicoBtn);
            this.Controls.Add(this.ListaMedicosDtg);
            this.Name = "GestionMedicosCEForm";
            this.Text = "Gestión de Médicos del Centro de Estudios";
            this.Load += new System.EventHandler(this.GestionMedicosCEForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaMedicosDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaMedicosDtg;
        private System.Windows.Forms.Button NuevoMedicoBtn;
    }
}