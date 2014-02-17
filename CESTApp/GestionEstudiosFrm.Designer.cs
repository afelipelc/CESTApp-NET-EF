namespace CESTApp
{
    partial class GestionEstudiosFrm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.EstudiosDtg = new System.Windows.Forms.DataGridView();
            this.NuevoEstudioBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoriaCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // EstudiosDtg
            // 
            this.EstudiosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudiosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EstudiosDtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EstudiosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiosDtg.Location = new System.Drawing.Point(12, 44);
            this.EstudiosDtg.Name = "EstudiosDtg";
            this.EstudiosDtg.ReadOnly = true;
            this.EstudiosDtg.RowHeadersVisible = false;
            this.EstudiosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstudiosDtg.Size = new System.Drawing.Size(504, 223);
            this.EstudiosDtg.TabIndex = 2;
            this.EstudiosDtg.DataSourceChanged += new System.EventHandler(this.EstudiosDtg_DataSourceChanged);
            this.EstudiosDtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiosDtg_CellClick);
            this.EstudiosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiosDtg_CellDoubleClick);
            // 
            // NuevoEstudioBtn
            // 
            this.NuevoEstudioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoEstudioBtn.Location = new System.Drawing.Point(423, 12);
            this.NuevoEstudioBtn.Name = "NuevoEstudioBtn";
            this.NuevoEstudioBtn.Size = new System.Drawing.Size(93, 23);
            this.NuevoEstudioBtn.TabIndex = 0;
            this.NuevoEstudioBtn.Text = "&Nuevo Estudio";
            this.NuevoEstudioBtn.UseVisualStyleBackColor = true;
            this.NuevoEstudioBtn.Click += new System.EventHandler(this.NuevoEstudioBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtrar por:";
            // 
            // CategoriaCmb
            // 
            this.CategoriaCmb.FormattingEnabled = true;
            this.CategoriaCmb.Items.AddRange(new object[] {
            "Todos",
            "Tomografía",
            "Radiografía",
            "Ultrasonido"});
            this.CategoriaCmb.Location = new System.Drawing.Point(71, 14);
            this.CategoriaCmb.Name = "CategoriaCmb";
            this.CategoriaCmb.Size = new System.Drawing.Size(101, 21);
            this.CategoriaCmb.TabIndex = 1;
            this.CategoriaCmb.Text = "Todos";
            this.CategoriaCmb.SelectedIndexChanged += new System.EventHandler(this.CategoriaCmb_SelectedIndexChanged);
            this.CategoriaCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoriaCmb_KeyPress);
            // 
            // GestEstudiosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 279);
            this.Controls.Add(this.CategoriaCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoEstudioBtn);
            this.Controls.Add(this.EstudiosDtg);
            this.KeyPreview = true;
            this.Name = "GestEstudiosFrm";
            this.Text = "Gestión de estudios";
            this.Load += new System.EventHandler(this.GestEstudiosFrm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GestEstudiosFrm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EstudiosDtg;
        private System.Windows.Forms.Button NuevoEstudioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoriaCmb;
    }
}

