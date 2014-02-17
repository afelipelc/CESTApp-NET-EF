namespace CESTApp
{
    partial class ServiciosNoPagadosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListaServiciosDtg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.CobrarBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaServiciosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaServiciosDtg
            // 
            this.ListaServiciosDtg.AllowUserToResizeRows = false;
            this.ListaServiciosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaServiciosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaServiciosDtg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListaServiciosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaServiciosDtg.Location = new System.Drawing.Point(12, 36);
            this.ListaServiciosDtg.MultiSelect = false;
            this.ListaServiciosDtg.Name = "ListaServiciosDtg";
            this.ListaServiciosDtg.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaServiciosDtg.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaServiciosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaServiciosDtg.Size = new System.Drawing.Size(625, 290);
            this.ListaServiciosDtg.TabIndex = 0;
            this.ListaServiciosDtg.DataSourceChanged += new System.EventHandler(this.ListaServiciosDtg_DataSourceChanged);
            this.ListaServiciosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaServiciosDtg_CellDoubleClick);
            this.ListaServiciosDtg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaServiciosDtg_KeyDown);
            this.ListaServiciosDtg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListaServiciosDtg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Presione doble clic sobre el servicio a cobrar, o seleccione el servicio y haga c" +
                "lic en Cobrar.";
            // 
            // SalirBtn
            // 
            this.SalirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBtn.Location = new System.Drawing.Point(551, 340);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(86, 34);
            this.SalirBtn.TabIndex = 2;
            this.SalirBtn.Text = "&Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // CobrarBtn
            // 
            this.CobrarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CobrarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CobrarBtn.Location = new System.Drawing.Point(319, 340);
            this.CobrarBtn.Name = "CobrarBtn";
            this.CobrarBtn.Size = new System.Drawing.Size(226, 34);
            this.CobrarBtn.TabIndex = 2;
            this.CobrarBtn.Text = "&Cobrar servicio seleccionado";
            this.CobrarBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Ver servicios en atención";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ServiciosNoPagadosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CobrarBtn);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaServiciosDtg);
            this.MinimumSize = new System.Drawing.Size(669, 426);
            this.Name = "ServiciosNoPagadosFrm";
            this.Text = "Servicios No pagados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServiciosNoPagadosFrm_FormClosing);
            this.Load += new System.EventHandler(this.ServiciosNoPagadosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaServiciosDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaServiciosDtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Button CobrarBtn;
        private System.Windows.Forms.Button button1;
    }
}