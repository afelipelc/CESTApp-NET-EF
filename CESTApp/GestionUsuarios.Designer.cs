namespace CESTApp
{
    partial class GestionUsuarios
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
            this.NuevoUsuarioBtn = new System.Windows.Forms.Button();
            this.ListaUsuariosDtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuariosDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoUsuarioBtn
            // 
            this.NuevoUsuarioBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NuevoUsuarioBtn.Location = new System.Drawing.Point(340, 281);
            this.NuevoUsuarioBtn.Name = "NuevoUsuarioBtn";
            this.NuevoUsuarioBtn.Size = new System.Drawing.Size(126, 26);
            this.NuevoUsuarioBtn.TabIndex = 3;
            this.NuevoUsuarioBtn.Text = "Agregar &nuevo usuario";
            this.NuevoUsuarioBtn.UseVisualStyleBackColor = true;
            this.NuevoUsuarioBtn.Click += new System.EventHandler(this.NuevoUsuarioBtn_Click);
            // 
            // ListaUsuariosDtg
            // 
            this.ListaUsuariosDtg.AllowUserToAddRows = false;
            this.ListaUsuariosDtg.AllowUserToDeleteRows = false;
            this.ListaUsuariosDtg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ListaUsuariosDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaUsuariosDtg.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ListaUsuariosDtg.Location = new System.Drawing.Point(12, 12);
            this.ListaUsuariosDtg.Name = "ListaUsuariosDtg";
            this.ListaUsuariosDtg.ReadOnly = true;
            this.ListaUsuariosDtg.RowHeadersVisible = false;
            this.ListaUsuariosDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListaUsuariosDtg.Size = new System.Drawing.Size(454, 263);
            this.ListaUsuariosDtg.TabIndex = 2;
            this.ListaUsuariosDtg.DataSourceChanged += new System.EventHandler(this.ListaUsuariosDtg_DataSourceChanged);
            this.ListaUsuariosDtg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaUsuariosDtg_CellClick);
            this.ListaUsuariosDtg.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaUsuariosDtg_CellDoubleClick);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 319);
            this.Controls.Add(this.NuevoUsuarioBtn);
            this.Controls.Add(this.ListaUsuariosDtg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestión de Usuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuariosDtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NuevoUsuarioBtn;
        private System.Windows.Forms.DataGridView ListaUsuariosDtg;
    }
}