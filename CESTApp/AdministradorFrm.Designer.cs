namespace CESTApp
{
    partial class AdministradorFrm
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
            this.MpStp = new System.Windows.Forms.MenuStrip();
            this.módulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recepciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosEnAtenciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaCobroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosCanalizadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEstudiosAsignadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MpStp.SuspendLayout();
            this.SuspendLayout();
            // 
            // MpStp
            // 
            this.MpStp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.módulosToolStripMenuItem,
            this.administrarToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MpStp.Location = new System.Drawing.Point(0, 0);
            this.MpStp.Name = "MpStp";
            this.MpStp.Size = new System.Drawing.Size(463, 24);
            this.MpStp.TabIndex = 0;
            this.MpStp.Text = "menuStrip1";
            // 
            // módulosToolStripMenuItem
            // 
            this.módulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recepciónToolStripMenuItem,
            this.serviciosEnAtenciónToolStripMenuItem,
            this.cajaCobroToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.médicosCanalizadoresToolStripMenuItem,
            this.mEstudiosAsignadosToolStripMenuItem});
            this.módulosToolStripMenuItem.Name = "módulosToolStripMenuItem";
            this.módulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.módulosToolStripMenuItem.Text = "Módulos";
            // 
            // recepciónToolStripMenuItem
            // 
            this.recepciónToolStripMenuItem.Name = "recepciónToolStripMenuItem";
            this.recepciónToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.recepciónToolStripMenuItem.Text = "Recepción";
            this.recepciónToolStripMenuItem.Click += new System.EventHandler(this.recepciónToolStripMenuItem_Click);
            // 
            // serviciosEnAtenciónToolStripMenuItem
            // 
            this.serviciosEnAtenciónToolStripMenuItem.Name = "serviciosEnAtenciónToolStripMenuItem";
            this.serviciosEnAtenciónToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.serviciosEnAtenciónToolStripMenuItem.Text = "Servicios en atención";
            this.serviciosEnAtenciónToolStripMenuItem.Click += new System.EventHandler(this.serviciosEnAtenciónToolStripMenuItem_Click);
            // 
            // cajaCobroToolStripMenuItem
            // 
            this.cajaCobroToolStripMenuItem.Name = "cajaCobroToolStripMenuItem";
            this.cajaCobroToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.cajaCobroToolStripMenuItem.Text = "Caja cobro";
            this.cajaCobroToolStripMenuItem.Click += new System.EventHandler(this.cajaCobroToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // médicosCanalizadoresToolStripMenuItem
            // 
            this.médicosCanalizadoresToolStripMenuItem.Name = "médicosCanalizadoresToolStripMenuItem";
            this.médicosCanalizadoresToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.médicosCanalizadoresToolStripMenuItem.Text = "Médicos canalizadores";
            this.médicosCanalizadoresToolStripMenuItem.Click += new System.EventHandler(this.médicosCanalizadoresToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiosToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // estudiosToolStripMenuItem
            // 
            this.estudiosToolStripMenuItem.Name = "estudiosToolStripMenuItem";
            this.estudiosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estudiosToolStripMenuItem.Text = "Estudios";
            this.estudiosToolStripMenuItem.Click += new System.EventHandler(this.estudiosToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.médicosToolStripMenuItem.Text = "Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // mEstudiosAsignadosToolStripMenuItem
            // 
            this.mEstudiosAsignadosToolStripMenuItem.Name = "mEstudiosAsignadosToolStripMenuItem";
            this.mEstudiosAsignadosToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mEstudiosAsignadosToolStripMenuItem.Text = "Mis estudios asignados";
            this.mEstudiosAsignadosToolStripMenuItem.Click += new System.EventHandler(this.mEstudiosAsignadosToolStripMenuItem_Click);
            // 
            // AdministradorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 299);
            this.Controls.Add(this.MpStp);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MpStp;
            this.Name = "AdministradorFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministradorFrm_FormClosing);
            this.Load += new System.EventHandler(this.AdministradorFrm_Load);
            this.MpStp.ResumeLayout(false);
            this.MpStp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MpStp;
        private System.Windows.Forms.ToolStripMenuItem módulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recepciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosEnAtenciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaCobroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosCanalizadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEstudiosAsignadosToolStripMenuItem;
    }
}