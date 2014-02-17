namespace CESTApp
{
    partial class DatosUsuarioFrm
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
            this.NombreUsrTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ActivoChk = new System.Windows.Forms.CheckBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.RePasswordTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new MisControles.NumericTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ApellidosTxt = new System.Windows.Forms.TextBox();
            this.UsuarioMedicoChk = new System.Windows.Forms.CheckBox();
            this.MedicoCmb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RolMedicoChk = new System.Windows.Forms.CheckBox();
            this.RolCajaChk = new System.Windows.Forms.CheckBox();
            this.RolRecepcionistaChk = new System.Windows.Forms.CheckBox();
            this.RolAdministradorChk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NombreUsrTxt
            // 
            this.NombreUsrTxt.Location = new System.Drawing.Point(15, 140);
            this.NombreUsrTxt.Name = "NombreUsrTxt";
            this.NombreUsrTxt.Size = new System.Drawing.Size(172, 20);
            this.NombreUsrTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(15, 179);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(172, 20);
            this.PasswordTxt.TabIndex = 6;
            // 
            // ActivoChk
            // 
            this.ActivoChk.AutoSize = true;
            this.ActivoChk.Checked = true;
            this.ActivoChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ActivoChk.Location = new System.Drawing.Point(16, 249);
            this.ActivoChk.Name = "ActivoChk";
            this.ActivoChk.Size = new System.Drawing.Size(95, 17);
            this.ActivoChk.TabIndex = 8;
            this.ActivoChk.Text = "Usuario Activo";
            this.ActivoChk.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(217, 259);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 13;
            this.AceptarBtn.Text = "&Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(298, 259);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 14;
            this.CerrarBtn.Text = "&Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // RePasswordTxt
            // 
            this.RePasswordTxt.Location = new System.Drawing.Point(15, 223);
            this.RePasswordTxt.Name = "RePasswordTxt";
            this.RePasswordTxt.PasswordChar = '*';
            this.RePasswordTxt.Size = new System.Drawing.Size(172, 20);
            this.RePasswordTxt.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(15, 101);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(175, 20);
            this.NombreTxt.TabIndex = 3;
            // 
            // IdTxt
            // 
            this.IdTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdTxt.Enabled = false;
            this.IdTxt.Location = new System.Drawing.Point(37, 12);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(100, 20);
            this.IdTxt.TabIndex = 0;
            this.IdTxt.Value = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Apellidos:";
            // 
            // ApellidosTxt
            // 
            this.ApellidosTxt.Location = new System.Drawing.Point(201, 101);
            this.ApellidosTxt.Name = "ApellidosTxt";
            this.ApellidosTxt.Size = new System.Drawing.Size(172, 20);
            this.ApellidosTxt.TabIndex = 4;
            // 
            // UsuarioMedicoChk
            // 
            this.UsuarioMedicoChk.AutoSize = true;
            this.UsuarioMedicoChk.Location = new System.Drawing.Point(15, 38);
            this.UsuarioMedicoChk.Name = "UsuarioMedicoChk";
            this.UsuarioMedicoChk.Size = new System.Drawing.Size(138, 17);
            this.UsuarioMedicoChk.TabIndex = 1;
            this.UsuarioMedicoChk.Text = "El usuario es un médico";
            this.UsuarioMedicoChk.UseVisualStyleBackColor = true;
            this.UsuarioMedicoChk.CheckedChanged += new System.EventHandler(this.UsuarioMedicoChk_CheckedChanged);
            // 
            // MedicoCmb
            // 
            this.MedicoCmb.Enabled = false;
            this.MedicoCmb.FormattingEnabled = true;
            this.MedicoCmb.Location = new System.Drawing.Point(12, 61);
            this.MedicoCmb.Name = "MedicoCmb";
            this.MedicoCmb.Size = new System.Drawing.Size(361, 21);
            this.MedicoCmb.TabIndex = 2;
            this.MedicoCmb.SelectedIndexChanged += new System.EventHandler(this.MedicoCmb_SelectedIndexChanged);
            this.MedicoCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedicoCmb_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RolMedicoChk);
            this.groupBox1.Controls.Add(this.RolCajaChk);
            this.groupBox1.Controls.Add(this.RolRecepcionistaChk);
            this.groupBox1.Controls.Add(this.RolAdministradorChk);
            this.groupBox1.Location = new System.Drawing.Point(201, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles:";
            // 
            // RolMedicoChk
            // 
            this.RolMedicoChk.AutoSize = true;
            this.RolMedicoChk.Location = new System.Drawing.Point(10, 88);
            this.RolMedicoChk.Name = "RolMedicoChk";
            this.RolMedicoChk.Size = new System.Drawing.Size(61, 17);
            this.RolMedicoChk.TabIndex = 12;
            this.RolMedicoChk.Text = "Médico";
            this.RolMedicoChk.UseVisualStyleBackColor = true;
            this.RolMedicoChk.Click += new System.EventHandler(this.RolMedicoChk_Click);
            // 
            // RolCajaChk
            // 
            this.RolCajaChk.AutoSize = true;
            this.RolCajaChk.Location = new System.Drawing.Point(10, 65);
            this.RolCajaChk.Name = "RolCajaChk";
            this.RolCajaChk.Size = new System.Drawing.Size(47, 17);
            this.RolCajaChk.TabIndex = 11;
            this.RolCajaChk.Text = "Caja";
            this.RolCajaChk.UseVisualStyleBackColor = true;
            this.RolCajaChk.Click += new System.EventHandler(this.RolCajaChk_Click);
            // 
            // RolRecepcionistaChk
            // 
            this.RolRecepcionistaChk.AutoSize = true;
            this.RolRecepcionistaChk.Location = new System.Drawing.Point(10, 42);
            this.RolRecepcionistaChk.Name = "RolRecepcionistaChk";
            this.RolRecepcionistaChk.Size = new System.Drawing.Size(94, 17);
            this.RolRecepcionistaChk.TabIndex = 10;
            this.RolRecepcionistaChk.Text = "Recepcionista";
            this.RolRecepcionistaChk.UseVisualStyleBackColor = true;
            this.RolRecepcionistaChk.Click += new System.EventHandler(this.RolRecepcionistaChk_Click);
            // 
            // RolAdministradorChk
            // 
            this.RolAdministradorChk.AutoSize = true;
            this.RolAdministradorChk.Location = new System.Drawing.Point(10, 19);
            this.RolAdministradorChk.Name = "RolAdministradorChk";
            this.RolAdministradorChk.Size = new System.Drawing.Size(89, 17);
            this.RolAdministradorChk.TabIndex = 9;
            this.RolAdministradorChk.Text = "Administrador";
            this.RolAdministradorChk.UseVisualStyleBackColor = true;
            this.RolAdministradorChk.Click += new System.EventHandler(this.RolAdministradorChk_Click);
            // 
            // DatosUsuarioFrm
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(388, 290);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MedicoCmb);
            this.Controls.Add(this.UsuarioMedicoChk);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.ActivoChk);
            this.Controls.Add(this.RePasswordTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ApellidosTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.NombreUsrTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(404, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(404, 328);
            this.Name = "DatosUsuarioFrm";
            this.Text = "Datos de Usuario";
            this.Load += new System.EventHandler(this.DatosUsuarioFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreUsrTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.CheckBox ActivoChk;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RePasswordTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreTxt;
        private MisControles.NumericTextBox IdTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ApellidosTxt;
        private System.Windows.Forms.CheckBox UsuarioMedicoChk;
        private System.Windows.Forms.ComboBox MedicoCmb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox RolMedicoChk;
        private System.Windows.Forms.CheckBox RolCajaChk;
        private System.Windows.Forms.CheckBox RolRecepcionistaChk;
        private System.Windows.Forms.CheckBox RolAdministradorChk;
    }
}