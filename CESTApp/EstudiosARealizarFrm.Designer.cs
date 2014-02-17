namespace CESTApp
{
    partial class EstudiosARealizarFrm
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
            this.label2 = new System.Windows.Forms.Label();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CategoriaCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EstudiosDtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Haga clic sobre los estudios que van a realizar al paciente para seleccionarlo, d" +
                "espúes  en Aceptar.";
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AceptarBtn.Location = new System.Drawing.Point(319, 275);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 11;
            this.AceptarBtn.Text = "&Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(400, 275);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 12;
            this.CancelarBtn.Text = "&Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // CategoriaCmb
            // 
            this.CategoriaCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoriaCmb.FormattingEnabled = true;
            this.CategoriaCmb.Items.AddRange(new object[] {
            "Todos",
            "Tomografía",
            "Radiografía",
            "Ultrasonido"});
            this.CategoriaCmb.Location = new System.Drawing.Point(71, 277);
            this.CategoriaCmb.Name = "CategoriaCmb";
            this.CategoriaCmb.Size = new System.Drawing.Size(101, 21);
            this.CategoriaCmb.TabIndex = 8;
            this.CategoriaCmb.Text = "Todos";
            this.CategoriaCmb.SelectedIndexChanged += new System.EventHandler(this.CategoriaCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtrar por:";
            // 
            // EstudiosDtg
            // 
            this.EstudiosDtg.AllowUserToResizeRows = false;
            this.EstudiosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EstudiosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EstudiosDtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EstudiosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiosDtg.Location = new System.Drawing.Point(12, 25);
            this.EstudiosDtg.Name = "EstudiosDtg";
            this.EstudiosDtg.ReadOnly = true;
            this.EstudiosDtg.RowHeadersVisible = false;
            this.EstudiosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstudiosDtg.Size = new System.Drawing.Size(465, 237);
            this.EstudiosDtg.TabIndex = 9;
            this.EstudiosDtg.DataSourceChanged += new System.EventHandler(this.EstudiosDtg_DataSourceChanged);
            this.EstudiosDtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EstudiosDtg_CellClick);
            // 
            // EstudiosARealizarFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 307);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.CategoriaCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EstudiosDtg);
            this.Name = "EstudiosARealizarFrm";
            this.Text = "Seleccionar estudios";
            this.Load += new System.EventHandler(this.EstudiosARealizarFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.ComboBox CategoriaCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EstudiosDtg;
    }
}