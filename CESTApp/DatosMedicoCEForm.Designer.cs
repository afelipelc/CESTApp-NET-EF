namespace CESTApp
{
    partial class DatosMedicoCEForm
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
            this.ApellidosTxt = new System.Windows.Forms.TextBox();
            this.EspecialidadCargoTxt = new System.Windows.Forms.TextBox();
            this.DeptoTomografiaChk = new System.Windows.Forms.CheckBox();
            this.DeptoRadiografiaChk = new System.Windows.Forms.CheckBox();
            this.DeptoUltrasonidoChk = new System.Windows.Forms.CheckBox();
            this.AceptarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.CedulaNTxt = new MisControles.NumericTextBox();
            this.IdTxt = new MisControles.NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Área(s):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Especialidad o Cargo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cédula profesional:";
            // 
            // NombreTxt
            // 
            this.NombreTxt.Location = new System.Drawing.Point(128, 35);
            this.NombreTxt.Name = "NombreTxt";
            this.NombreTxt.Size = new System.Drawing.Size(154, 20);
            this.NombreTxt.TabIndex = 0;
            // 
            // ApellidosTxt
            // 
            this.ApellidosTxt.Location = new System.Drawing.Point(128, 61);
            this.ApellidosTxt.Name = "ApellidosTxt";
            this.ApellidosTxt.Size = new System.Drawing.Size(154, 20);
            this.ApellidosTxt.TabIndex = 2;
            // 
            // EspecialidadCargoTxt
            // 
            this.EspecialidadCargoTxt.Location = new System.Drawing.Point(128, 160);
            this.EspecialidadCargoTxt.Name = "EspecialidadCargoTxt";
            this.EspecialidadCargoTxt.Size = new System.Drawing.Size(154, 20);
            this.EspecialidadCargoTxt.TabIndex = 6;
            // 
            // DeptoTomografiaChk
            // 
            this.DeptoTomografiaChk.AutoSize = true;
            this.DeptoTomografiaChk.Location = new System.Drawing.Point(128, 89);
            this.DeptoTomografiaChk.Name = "DeptoTomografiaChk";
            this.DeptoTomografiaChk.Size = new System.Drawing.Size(81, 17);
            this.DeptoTomografiaChk.TabIndex = 3;
            this.DeptoTomografiaChk.Text = "Tomografía";
            this.DeptoTomografiaChk.UseVisualStyleBackColor = true;
            this.DeptoTomografiaChk.Click += new System.EventHandler(this.DeptoTomografiaChk_Click);
            // 
            // DeptoRadiografiaChk
            // 
            this.DeptoRadiografiaChk.AutoSize = true;
            this.DeptoRadiografiaChk.Location = new System.Drawing.Point(128, 112);
            this.DeptoRadiografiaChk.Name = "DeptoRadiografiaChk";
            this.DeptoRadiografiaChk.Size = new System.Drawing.Size(82, 17);
            this.DeptoRadiografiaChk.TabIndex = 4;
            this.DeptoRadiografiaChk.Text = "Radiografía";
            this.DeptoRadiografiaChk.UseVisualStyleBackColor = true;
            this.DeptoRadiografiaChk.Click += new System.EventHandler(this.DeptoRadiografiaChk_Click);
            // 
            // DeptoUltrasonidoChk
            // 
            this.DeptoUltrasonidoChk.AutoSize = true;
            this.DeptoUltrasonidoChk.Location = new System.Drawing.Point(128, 135);
            this.DeptoUltrasonidoChk.Name = "DeptoUltrasonidoChk";
            this.DeptoUltrasonidoChk.Size = new System.Drawing.Size(79, 17);
            this.DeptoUltrasonidoChk.TabIndex = 5;
            this.DeptoUltrasonidoChk.Text = "Ultrasonido";
            this.DeptoUltrasonidoChk.UseVisualStyleBackColor = true;
            this.DeptoUltrasonidoChk.Click += new System.EventHandler(this.DeptoUltrasonidoChk_Click);
            // 
            // AceptarBtn
            // 
            this.AceptarBtn.Location = new System.Drawing.Point(126, 219);
            this.AceptarBtn.Name = "AceptarBtn";
            this.AceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarBtn.TabIndex = 8;
            this.AceptarBtn.Text = "Aceptar";
            this.AceptarBtn.UseVisualStyleBackColor = true;
            this.AceptarBtn.Click += new System.EventHandler(this.AceptarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarBtn.Location = new System.Drawing.Point(207, 219);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            // 
            // CedulaNTxt
            // 
            this.CedulaNTxt.Location = new System.Drawing.Point(128, 186);
            this.CedulaNTxt.Name = "CedulaNTxt";
            this.CedulaNTxt.Size = new System.Drawing.Size(73, 20);
            this.CedulaNTxt.TabIndex = 7;
            this.CedulaNTxt.Value = 0;
            // 
            // IdTxt
            // 
            this.IdTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IdTxt.Enabled = false;
            this.IdTxt.Location = new System.Drawing.Point(128, 9);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(79, 20);
            this.IdTxt.TabIndex = 11;
            this.IdTxt.Value = 0;
            // 
            // DatosMedicoCEForm
            // 
            this.AcceptButton = this.AceptarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelarBtn;
            this.ClientSize = new System.Drawing.Size(294, 254);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.CedulaNTxt);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.AceptarBtn);
            this.Controls.Add(this.DeptoUltrasonidoChk);
            this.Controls.Add(this.DeptoRadiografiaChk);
            this.Controls.Add(this.DeptoTomografiaChk);
            this.Controls.Add(this.EspecialidadCargoTxt);
            this.Controls.Add(this.ApellidosTxt);
            this.Controls.Add(this.NombreTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 292);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 292);
            this.Name = "DatosMedicoCEForm";
            this.Text = "Datos del Médico";
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
        private System.Windows.Forms.TextBox ApellidosTxt;
        private System.Windows.Forms.TextBox EspecialidadCargoTxt;
        private System.Windows.Forms.CheckBox DeptoTomografiaChk;
        private System.Windows.Forms.CheckBox DeptoRadiografiaChk;
        private System.Windows.Forms.CheckBox DeptoUltrasonidoChk;
        private System.Windows.Forms.Button AceptarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private MisControles.NumericTextBox CedulaNTxt;
        private MisControles.NumericTextBox IdTxt;
    }
}