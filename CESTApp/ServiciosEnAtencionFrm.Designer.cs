namespace CESTApp
{
    partial class ServiciosEnAtencionFrm
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
            this.ListaServiciosDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaServiciosDtg.Location = new System.Drawing.Point(12, 12);
            this.ListaServiciosDtg.MultiSelect = false;
            this.ListaServiciosDtg.Name = "ListaServiciosDtg";
            this.ListaServiciosDtg.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaServiciosDtg.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaServiciosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaServiciosDtg.Size = new System.Drawing.Size(491, 264);
            this.ListaServiciosDtg.TabIndex = 1;
            this.ListaServiciosDtg.DataSourceChanged += new System.EventHandler(this.ListaServiciosDtg_DataSourceChanged);
            this.ListaServiciosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaServiciosDtg_CellDoubleClick);
            this.ListaServiciosDtg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListaServiciosDtg_KeyDown);
            this.ListaServiciosDtg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListaServiciosDtg_KeyPress);
            // 
            // ServiciosEnAtencionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 288);
            this.Controls.Add(this.ListaServiciosDtg);
            this.Name = "ServiciosEnAtencionFrm";
            this.Text = "Servicios que están siendo atendidos.";
            this.Load += new System.EventHandler(this.ServiciosEnAtencionFrm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ServiciosEnAtencionFrm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ListaServiciosDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaServiciosDtg;
    }
}