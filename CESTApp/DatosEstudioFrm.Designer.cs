namespace CESTApp
{
    partial class DatosEstudioFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NombreTxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.EstadoChk = new System.Windows.Forms.CheckBox();
            this.CategoriaCmb = new System.Windows.Forms.ComboBox();
            this.CerrarBtn = new System.Windows.Forms.Button();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CostoDTxt = new MisControles.DecimalTextBox();
            this.IdTxt = new MisControles.NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Costo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Estado:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(84, 38);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(172, 20);
            this.NombreTxt.TabIndex = 0;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(84, 64);
            this.DescripcionTxt.Multiline = true;
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(172, 54);
            this.DescripcionTxt.TabIndex = 1;
            // 
            // EstadoChk
            // 
            this.EstadoChk.AutoSize = true;
            this.EstadoChk.Checked = true;
            this.EstadoChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EstadoChk.Location = new System.Drawing.Point(84, 177);
            this.EstadoChk.Name = "EstadoChk";
            this.EstadoChk.Size = new System.Drawing.Size(56, 17);
            this.EstadoChk.TabIndex = 4;
            this.EstadoChk.Text = "Activo";
            this.EstadoChk.UseVisualStyleBackColor = true;
            // 
            // CategoriaCmb
            // 
            this.CategoriaCmb.FormattingEnabled = true;
            this.CategoriaCmb.Items.AddRange(new object[] {
            "Tomografía",
            "Radiografía",
            "Ultrasonido"});
            this.CategoriaCmb.Location = new System.Drawing.Point(84, 124);
            this.CategoriaCmb.Name = "CategoriaCmb";
            this.CategoriaCmb.Size = new System.Drawing.Size(100, 21);
            this.CategoriaCmb.TabIndex = 2;
            this.CategoriaCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoriaCmb_KeyPress);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CerrarBtn.Location = new System.Drawing.Point(181, 212);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(75, 23);
            this.CerrarBtn.TabIndex = 6;
            this.CerrarBtn.Text = "&Cerrar";
            this.CerrarBtn.UseVisualStyleBackColor = true;
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(100, 212);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 5;
            this.AceptarBtn.Text = "&Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CostoDTxt
            // 
            this.CostoDTxt.Location = new System.Drawing.Point(84, 151);
            this.CostoDTxt.Name = "CostoDTxt";
            this.CostoDTxt.NumeroDecimales = ((short)(2));
            this.CostoDTxt.Size = new System.Drawing.Size(100, 20);
            this.CostoDTxt.TabIndex = 3;
            this.CostoDTxt.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // IdTxt
            // 
            this.IdTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IdTxt.Enabled = false;
            this.IdTxt.Location = new System.Drawing.Point(84, 12);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(100, 20);
            this.IdTxt.TabIndex = 9;
            this.IdTxt.Value = 0;
            // 
            // DatosEstudioFrm
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CerrarBtn;
            this.ClientSize = new System.Drawing.Size(273, 248);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.CostoDTxt);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.CerrarBtn);
            this.Controls.Add(this.CategoriaCmb);
            this.Controls.Add(this.EstadoChk);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(289, 286);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(289, 286);
            this.Name = "DatosEstudioFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del estudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NombreTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.CheckBox EstadoChk;
        private System.Windows.Forms.ComboBox CategoriaCmb;
        private System.Windows.Forms.Button CerrarBtn;
        private System.Windows.Forms.Button AceptarBtn;
        private MisControles.DecimalTextBox CostoDTxt;
        private MisControles.NumericTextBox IdTxt;
    }
}