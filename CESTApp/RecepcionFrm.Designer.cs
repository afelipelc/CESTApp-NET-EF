namespace CESTApp
{
    partial class RecepcionFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecepcionFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IdServicioTxt = new MisControles.NumericTextBox();
            this.FechaServicioDtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LugarResidenciaPacienteCmb = new System.Windows.Forms.ComboBox();
            this.NombrePacienteCmb = new System.Windows.Forms.ComboBox();
            this.SexoMujerPacienteRbtn = new System.Windows.Forms.RadioButton();
            this.SexoHombrePacienteRbtn = new System.Windows.Forms.RadioButton();
            this.EdadPacientePacienteNTxt = new MisControles.NumericTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ApellidosPacienteTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ImporteTotalLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.EliminarEstudioBtn = new System.Windows.Forms.Button();
            this.AgregarEstudioBtn = new System.Windows.Forms.Button();
            this.EstudiosARealizarDtg = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MedicoResponsableCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ResgistrarServicioBtn = new System.Windows.Forms.Button();
            this.CancelarServicioBtn = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ApellidosMedicoCanalizadorTxt = new System.Windows.Forms.TextBox();
            this.NombreMedicoCanalizadorCmb = new System.Windows.Forms.ComboBox();
            this.CedulaMedicCanNtxt = new MisControles.NumericTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosARealizarDtg)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IdServicioTxt);
            this.groupBox1.Controls.Add(this.FechaServicioDtp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 51);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales del servicio";
            // 
            // IdServicioTxt
            // 
            this.IdServicioTxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.IdServicioTxt.Enabled = false;
            this.IdServicioTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdServicioTxt.Location = new System.Drawing.Point(97, 20);
            this.IdServicioTxt.Name = "IdServicioTxt";
            this.IdServicioTxt.Size = new System.Drawing.Size(100, 23);
            this.IdServicioTxt.TabIndex = 16;
            this.IdServicioTxt.Value = 0;
            // 
            // FechaServicioDtp
            // 
            this.FechaServicioDtp.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.FechaServicioDtp.CustomFormat = "dd/mm/yyyy H:mm tt";
            this.FechaServicioDtp.Enabled = false;
            this.FechaServicioDtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaServicioDtp.Location = new System.Drawing.Point(307, 23);
            this.FechaServicioDtp.Name = "FechaServicioDtp";
            this.FechaServicioDtp.Size = new System.Drawing.Size(194, 20);
            this.FechaServicioDtp.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha y hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id de servicio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LugarResidenciaPacienteCmb);
            this.groupBox2.Controls.Add(this.NombrePacienteCmb);
            this.groupBox2.Controls.Add(this.SexoMujerPacienteRbtn);
            this.groupBox2.Controls.Add(this.SexoHombrePacienteRbtn);
            this.groupBox2.Controls.Add(this.EdadPacientePacienteNTxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ApellidosPacienteTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del paciente:";
            // 
            // LugarResidenciaPacienteCmb
            // 
            this.LugarResidenciaPacienteCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.LugarResidenciaPacienteCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.LugarResidenciaPacienteCmb.FormattingEnabled = true;
            this.LugarResidenciaPacienteCmb.Location = new System.Drawing.Point(352, 56);
            this.LugarResidenciaPacienteCmb.Name = "LugarResidenciaPacienteCmb";
            this.LugarResidenciaPacienteCmb.Size = new System.Drawing.Size(149, 21);
            this.LugarResidenciaPacienteCmb.TabIndex = 5;
            this.LugarResidenciaPacienteCmb.SelectedValueChanged += new System.EventHandler(this.LugarResidenciaPacienteCmb_SelectedValueChanged);
            this.LugarResidenciaPacienteCmb.TextChanged += new System.EventHandler(this.LugarResidenciaPacienteCmb_TextChanged);
            // 
            // NombrePacienteCmb
            // 
            this.NombrePacienteCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombrePacienteCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombrePacienteCmb.FormattingEnabled = true;
            this.NombrePacienteCmb.Location = new System.Drawing.Point(57, 27);
            this.NombrePacienteCmb.Name = "NombrePacienteCmb";
            this.NombrePacienteCmb.Size = new System.Drawing.Size(140, 21);
            this.NombrePacienteCmb.TabIndex = 0;
            this.NombrePacienteCmb.SelectedValueChanged += new System.EventHandler(this.NombrePacienteCmb_SelectedValueChanged);
            this.NombrePacienteCmb.TextChanged += new System.EventHandler(this.NombrePacienteCmb_TextChanged);
            this.NombrePacienteCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombrePacienteCmb_KeyPress);
            // 
            // SexoMujerPacienteRbtn
            // 
            this.SexoMujerPacienteRbtn.AutoSize = true;
            this.SexoMujerPacienteRbtn.Location = new System.Drawing.Point(127, 57);
            this.SexoMujerPacienteRbtn.Name = "SexoMujerPacienteRbtn";
            this.SexoMujerPacienteRbtn.Size = new System.Drawing.Size(51, 17);
            this.SexoMujerPacienteRbtn.TabIndex = 4;
            this.SexoMujerPacienteRbtn.TabStop = true;
            this.SexoMujerPacienteRbtn.Text = "Mujer";
            this.SexoMujerPacienteRbtn.UseVisualStyleBackColor = true;
            // 
            // SexoHombrePacienteRbtn
            // 
            this.SexoHombrePacienteRbtn.AutoSize = true;
            this.SexoHombrePacienteRbtn.Location = new System.Drawing.Point(59, 56);
            this.SexoHombrePacienteRbtn.Name = "SexoHombrePacienteRbtn";
            this.SexoHombrePacienteRbtn.Size = new System.Drawing.Size(62, 17);
            this.SexoHombrePacienteRbtn.TabIndex = 3;
            this.SexoHombrePacienteRbtn.TabStop = true;
            this.SexoHombrePacienteRbtn.Text = "Hombre";
            this.SexoHombrePacienteRbtn.UseVisualStyleBackColor = true;
            // 
            // EdadPacientePacienteNTxt
            // 
            this.EdadPacientePacienteNTxt.Location = new System.Drawing.Point(460, 27);
            this.EdadPacientePacienteNTxt.MaxLength = 3;
            this.EdadPacientePacienteNTxt.Name = "EdadPacientePacienteNTxt";
            this.EdadPacientePacienteNTxt.Size = new System.Drawing.Size(41, 20);
            this.EdadPacientePacienteNTxt.TabIndex = 2;
            this.EdadPacientePacienteNTxt.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lugar de residencia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // ApellidosPacienteTxt
            // 
            this.ApellidosPacienteTxt.Location = new System.Drawing.Point(261, 27);
            this.ApellidosPacienteTxt.Name = "ApellidosPacienteTxt";
            this.ApellidosPacienteTxt.Size = new System.Drawing.Size(152, 20);
            this.ApellidosPacienteTxt.TabIndex = 1;
            this.ApellidosPacienteTxt.TextChanged += new System.EventHandler(this.ApellidosPacienteTxt_TextChanged);
            this.ApellidosPacienteTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ApellidosPacienteTxt_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ImporteTotalLbl);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.EliminarEstudioBtn);
            this.groupBox3.Controls.Add(this.AgregarEstudioBtn);
            this.groupBox3.Controls.Add(this.EstudiosARealizarDtg);
            this.groupBox3.Location = new System.Drawing.Point(12, 249);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(517, 175);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estudios a realizar e importe del servicio";
            // 
            // ImporteTotalLbl
            // 
            this.ImporteTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteTotalLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.ImporteTotalLbl.Location = new System.Drawing.Point(363, 130);
            this.ImporteTotalLbl.Name = "ImporteTotalLbl";
            this.ImporteTotalLbl.Size = new System.Drawing.Size(151, 25);
            this.ImporteTotalLbl.TabIndex = 2;
            this.ImporteTotalLbl.Text = "$ 0.00";
            this.ImporteTotalLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Importe Total:";
            // 
            // EliminarEstudioBtn
            // 
            this.EliminarEstudioBtn.Location = new System.Drawing.Point(112, 133);
            this.EliminarEstudioBtn.Name = "EliminarEstudioBtn";
            this.EliminarEstudioBtn.Size = new System.Drawing.Size(163, 23);
            this.EliminarEstudioBtn.TabIndex = 11;
            this.EliminarEstudioBtn.Text = "&Eliminar estudio seleccionado";
            this.EliminarEstudioBtn.UseVisualStyleBackColor = true;
            this.EliminarEstudioBtn.Click += new System.EventHandler(this.EliminarEstudioBtn_Click);
            // 
            // AgregarEstudioBtn
            // 
            this.AgregarEstudioBtn.Location = new System.Drawing.Point(9, 133);
            this.AgregarEstudioBtn.Name = "AgregarEstudioBtn";
            this.AgregarEstudioBtn.Size = new System.Drawing.Size(97, 23);
            this.AgregarEstudioBtn.TabIndex = 9;
            this.AgregarEstudioBtn.Text = "&Agregar estudio";
            this.AgregarEstudioBtn.UseVisualStyleBackColor = true;
            this.AgregarEstudioBtn.Click += new System.EventHandler(this.AgregarEstudioBtn_Click);
            // 
            // EstudiosARealizarDtg
            // 
            this.EstudiosARealizarDtg.AllowUserToResizeRows = false;
            this.EstudiosARealizarDtg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EstudiosARealizarDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiosARealizarDtg.Location = new System.Drawing.Point(9, 19);
            this.EstudiosARealizarDtg.Name = "EstudiosARealizarDtg";
            this.EstudiosARealizarDtg.ReadOnly = true;
            this.EstudiosARealizarDtg.RowHeadersVisible = false;
            this.EstudiosARealizarDtg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EstudiosARealizarDtg.Size = new System.Drawing.Size(502, 108);
            this.EstudiosARealizarDtg.TabIndex = 10;
            this.EstudiosARealizarDtg.DataSourceChanged += new System.EventHandler(this.EstudiosARealizarDtg_DataSourceChanged);
            this.EstudiosARealizarDtg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EstudiosARealizarDtg_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MedicoResponsableCmb);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(12, 430);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(517, 51);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Médico que realizará los estudios";
            // 
            // MedicoResponsableCmb
            // 
            this.MedicoResponsableCmb.FormattingEnabled = true;
            this.MedicoResponsableCmb.Location = new System.Drawing.Point(81, 20);
            this.MedicoResponsableCmb.Name = "MedicoResponsableCmb";
            this.MedicoResponsableCmb.Size = new System.Drawing.Size(332, 21);
            this.MedicoResponsableCmb.TabIndex = 12;
            this.MedicoResponsableCmb.SelectedIndexChanged += new System.EventHandler(this.MedicoResponsableCmb_SelectedIndexChanged);
            this.MedicoResponsableCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MedicoResponsableCmb_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Médico:";
            // 
            // ResgistrarServicioBtn
            // 
            this.ResgistrarServicioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResgistrarServicioBtn.Location = new System.Drawing.Point(319, 487);
            this.ResgistrarServicioBtn.Name = "ResgistrarServicioBtn";
            this.ResgistrarServicioBtn.Size = new System.Drawing.Size(129, 30);
            this.ResgistrarServicioBtn.TabIndex = 13;
            this.ResgistrarServicioBtn.Text = "&Registrar Servicio";
            this.ResgistrarServicioBtn.UseVisualStyleBackColor = true;
            this.ResgistrarServicioBtn.Click += new System.EventHandler(this.ResgistrarServicioBtn_Click);
            // 
            // CancelarServicioBtn
            // 
            this.CancelarServicioBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelarServicioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarServicioBtn.Location = new System.Drawing.Point(454, 487);
            this.CancelarServicioBtn.Name = "CancelarServicioBtn";
            this.CancelarServicioBtn.Size = new System.Drawing.Size(75, 30);
            this.CancelarServicioBtn.TabIndex = 14;
            this.CancelarServicioBtn.Text = "&Cancelar";
            this.CancelarServicioBtn.UseVisualStyleBackColor = true;
            this.CancelarServicioBtn.Click += new System.EventHandler(this.CancelarServicioBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ApellidosMedicoCanalizadorTxt);
            this.groupBox5.Controls.Add(this.NombreMedicoCanalizadorCmb);
            this.groupBox5.Controls.Add(this.CedulaMedicCanNtxt);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(12, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(517, 82);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos del Médico canalizador";
            // 
            // ApellidosMedicoCanalizadorTxt
            // 
            this.ApellidosMedicoCanalizadorTxt.Location = new System.Drawing.Point(65, 50);
            this.ApellidosMedicoCanalizadorTxt.Name = "ApellidosMedicoCanalizadorTxt";
            this.ApellidosMedicoCanalizadorTxt.Size = new System.Drawing.Size(264, 20);
            this.ApellidosMedicoCanalizadorTxt.TabIndex = 7;
            this.ApellidosMedicoCanalizadorTxt.TextChanged += new System.EventHandler(this.ApellidosMedicoCanalizadorTxt_TextChanged);
            // 
            // NombreMedicoCanalizadorCmb
            // 
            this.NombreMedicoCanalizadorCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreMedicoCanalizadorCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombreMedicoCanalizadorCmb.FormattingEnabled = true;
            this.NombreMedicoCanalizadorCmb.Location = new System.Drawing.Point(65, 23);
            this.NombreMedicoCanalizadorCmb.Name = "NombreMedicoCanalizadorCmb";
            this.NombreMedicoCanalizadorCmb.Size = new System.Drawing.Size(264, 21);
            this.NombreMedicoCanalizadorCmb.TabIndex = 6;
            this.NombreMedicoCanalizadorCmb.SelectedValueChanged += new System.EventHandler(this.NombreMedicoCanalizadorCmb_SelectedValueChanged);
            this.NombreMedicoCanalizadorCmb.TextChanged += new System.EventHandler(this.NombreMedicoCanalizadorCmb_TextChanged);
            this.NombreMedicoCanalizadorCmb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreMedicoCanalizadorCmb_KeyPress);
            // 
            // CedulaMedicCanNtxt
            // 
            this.CedulaMedicCanNtxt.Location = new System.Drawing.Point(442, 23);
            this.CedulaMedicCanNtxt.MaxLength = 9;
            this.CedulaMedicCanNtxt.Name = "CedulaMedicCanNtxt";
            this.CedulaMedicCanNtxt.Size = new System.Drawing.Size(59, 20);
            this.CedulaMedicCanNtxt.TabIndex = 8;
            this.CedulaMedicCanNtxt.Value = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Cedula profesional:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Apellidos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nombre:";
            // 
            // RecepcionFrm
            // 
            this.AcceptButton = this.ResgistrarServicioBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 525);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.CancelarServicioBtn);
            this.Controls.Add(this.ResgistrarServicioBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecepcionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recepción del centro de estudios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RecepcionFrm_FormClosing);
            this.Load += new System.EventHandler(this.RecepcionFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiosARealizarDtg)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ApellidosPacienteTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton SexoMujerPacienteRbtn;
        private System.Windows.Forms.RadioButton SexoHombrePacienteRbtn;
        private MisControles.NumericTextBox EdadPacientePacienteNTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox MedicoResponsableCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ResgistrarServicioBtn;
        private System.Windows.Forms.Button CancelarServicioBtn;
        private System.Windows.Forms.Button EliminarEstudioBtn;
        private System.Windows.Forms.Button AgregarEstudioBtn;
        private System.Windows.Forms.DataGridView EstudiosARealizarDtg;
        private System.Windows.Forms.Label ImporteTotalLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox NombrePacienteCmb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private MisControles.NumericTextBox CedulaMedicCanNtxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox LugarResidenciaPacienteCmb;
        private System.Windows.Forms.ComboBox NombreMedicoCanalizadorCmb;
        private System.Windows.Forms.DateTimePicker FechaServicioDtp;
        private System.Windows.Forms.TextBox ApellidosMedicoCanalizadorTxt;
        private System.Windows.Forms.Label label10;
        private MisControles.NumericTextBox IdServicioTxt;
    }
}