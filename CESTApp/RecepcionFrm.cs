using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Globalization;

//librerias para utilizar sesiones
using System.Threading;
using System.Security.Principal;

namespace CESTApp
{
    public partial class RecepcionFrm : Form
    {
        DBEntities BD = new DBEntities();

        //variables para almacenar el numero de eventos ejecutados por los cmb
        private int cambiosindexpaccmb = 0;
        private int cambiosindexmccmb = 0;

        //variables auxiliares para almacenar id seleccionados
        private int idpaciente;
        private int idmedicocana;
        private int idlugar;
        private int idmedresp;
        private string textocombopaciente;
        private string textocombomedican;


        private List<Estudio> estudiosarealizar = new List<Estudio>(); //estudios ya en la lista

        public RecepcionFrm()
        {
            InitializeComponent();
        }

        private void RecepcionFrm_Load(object sender, EventArgs e)
        {

            //comprobar usuario
            if (!Thread.CurrentPrincipal.IsInRole("Administrador") && !Thread.CurrentPrincipal.IsInRole("Recepcion"))
            {
                MessageBox.Show("No tiene privilegios para utilizar este modulo", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            var medicosresp = BD.MedicoCE.Select(m => new AuxPersona { Id = m.Id, Nombre = m.Nombre.TrimEnd() + " " + m.Apellidos.TrimEnd() }).ToList();
            ////cargar los medicos del crentro al combo     
            medicosresp.Insert(0, new AuxPersona { Id = 0, Nombre = "" });
            this.MedicoResponsableCmb.DataSource = medicosresp;
            this.MedicoResponsableCmb.DisplayMember = "Nombre";
            

            ////cargar la lista de lugares de residencia
            // this.lugaresresidencia.Insert(0, new LugarResidencia { Id = 0, Nombre = "" });
            var listalugares = BD.LugarResidencia.ToList();
            listalugares.Insert(0, new LugarResidencia { Id = 0, Nombre = "" });
            this.LugarResidenciaPacienteCmb.DataSource = listalugares;
            this.LugarResidenciaPacienteCmb.DisplayMember = "Nombre";
        }


        private void NombrePacienteCmb_TextChanged(object sender, EventArgs e)
        {
            if (this.NombrePacienteCmb.Text.Length <= 3)
            {
                this.NombrePacienteCmb.DataSource = null;
                this.cambiosindexmccmb = 0;
                this.idpaciente = 0;
            }
            
            if(this.NombrePacienteCmb.Text != "")
                this.NombrePacienteCmb.Text= CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.NombrePacienteCmb.Text);
        }


        private void NombrePacienteCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;

            //Console.WriteLine(this.NombrePacienteCmb.Text);
            textocombopaciente = this.NombrePacienteCmb.Text;
            if (e.KeyChar.ToString() == " " )
            {
                //var pacientes = listapacientes.Where(p => p.Nombre.Contains(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.NombrePacienteCmb.Text.ToLower()))).Select(p => new { Nombre = p.Nombre + " " + p.Apellidos, p.Id}).ToList();
                //List<AuxPaciente> pacientes = (List<AuxPaciente>) listapacientes.Where(p => p.Nombre.Contains(this.NombrePacienteCmb.Text)).Select(p => new  AuxPaciente { Nombre = p.Nombre + " " + p.Apellidos, Id = p.Id}).ToList();
                var pacientes = BD.Paciente.Where(p => p.Nombre.Contains(this.NombrePacienteCmb.Text)).Select(p => new AuxPersona { Id = p.Id, Nombre = p.Nombre.TrimEnd() + " " + p.Apellidos.TrimEnd() }).ToList();
                if (pacientes.Count > 0)
                {
                    this.NombrePacienteCmb.DataSource = null;
                    this.NombrePacienteCmb.DataSource = pacientes;
                    this.NombrePacienteCmb.DisplayMember = "Nombre";
                }else
                    e.Handled=true;
                
                this.NombrePacienteCmb.Focus();
                this.NombrePacienteCmb.Text = textocombopaciente + " ";
            }

            SendKeys.Send("{END}");
        }


        //Procesar objeto AuxPaciente seleccionado en el combo
        private void CargarDatosPacienteSeleccionado()
        {
            using (BD = new DBEntities())
            {
                //AuxPaciente seleccionado = (AuxPaciente)this.NombrePacienteCmb.SelectedItem;
                AuxPersona seleccionado = (AuxPersona)this.NombrePacienteCmb.SelectedItem;
                if (seleccionado != null)
                {
                    //cargar los datos completos del paciente
                    Paciente pacienteseleccionado = BD.Paciente.Where(p => p.Id == seleccionado.Id).FirstOrDefault();
                    if (pacienteseleccionado != null)
                    {
                        //limpiar el datasource del combo
                        this.NombrePacienteCmb.DataSource = null;

                        this.NombrePacienteCmb.Text = pacienteseleccionado.Nombre.TrimEnd();
                        this.ApellidosPacienteTxt.Text = pacienteseleccionado.Apellidos.TrimEnd();
                        this.EdadPacientePacienteNTxt.Value = pacienteseleccionado.Edad;
                        this.LugarResidenciaPacienteCmb.Text = pacienteseleccionado.LugarResidencia.Nombre.TrimEnd();
                        this.idlugar = pacienteseleccionado.LugarResidencia.Id;

                        if (pacienteseleccionado.Sexo == "H")
                            this.SexoHombrePacienteRbtn.Checked = true;

                        if (pacienteseleccionado.Sexo == "M")
                            this.SexoMujerPacienteRbtn.Checked = true;

                        //guardar el id del paciente seleccionado
                        this.idpaciente = pacienteseleccionado.Id;
                    }
                }
            }
        }

        private void NombrePacienteCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cambiosindexpaccmb++;
            //Console.WriteLine("Paso selectec changed > " + this.NombrePacienteCmb.Text);
            if (this.cambiosindexpaccmb > 2)
            {
                //despues de que se cargo la lista
                //y se agrego el texto que tenia antes el cmb de cargar la lista
                //pasar a recoger el objeto seleccionado
                CargarDatosPacienteSeleccionado();

                this.NombreMedicoCanalizadorCmb.Focus();

            }

            //Console.WriteLine(cambiosindexcmb);
        }

        private void ApellidosPacienteTxt_TextChanged(object sender, EventArgs e)
        {
            this.ApellidosPacienteTxt.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.ApellidosPacienteTxt.Text);
            SendKeys.Send("{END}");
        }        

        private void LugarResidenciaPacienteCmb_TextChanged(object sender, EventArgs e)
        {
            if(this.LugarResidenciaPacienteCmb.Text.Length <=2)
                this.idlugar = 0;

        }

        private void LugarResidenciaPacienteCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            LugarResidencia lugarseleccionado = (LugarResidencia)this.LugarResidenciaPacienteCmb.SelectedItem;

            if (lugarseleccionado != null && lugarseleccionado.Id != 0)
                this.idlugar = lugarseleccionado.Id;

        }

        private void NombreMedicoCanalizadorCmb_TextChanged(object sender, EventArgs e)
        {
            if (this.NombreMedicoCanalizadorCmb.Text.Length <= 2)
            {
                this.NombreMedicoCanalizadorCmb.DataSource = null;
                this.cambiosindexmccmb = 0;
                this.idmedicocana = 0;
            }

            if(this.NombreMedicoCanalizadorCmb.Text != "" )
            this.NombreMedicoCanalizadorCmb.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.NombreMedicoCanalizadorCmb.Text);
        }

        private void NombreMedicoCanalizadorCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //no permitir numeros en el nombre
                e.Handled = true;

            //Console.WriteLine(this.NombrePacienteCmb.Text);
            this.textocombomedican = this.NombreMedicoCanalizadorCmb.Text;
            if (e.KeyChar.ToString() == " ")
            {
                BD = new DBEntities();
                //var medicoscan = this.medicoscanalizadores.Where(m => m.Nombre.Contains(this.NombreMedicoCanalizadorCmb.Text)).ToList();
                var medicoscan = BD.MedicoCanalizador.Where(m => m.Nombre.Contains(this.NombreMedicoCanalizadorCmb.Text)).Select(nm => new AuxPersona { Id = nm.Id, Nombre = nm.Nombre.TrimEnd() + " " + nm.Apellidos.TrimEnd() }).ToList();
                if (medicoscan.Count > 0)
                {
                    e.Handled = true;
                    //this.NombreMedicoCanalizadorCmb.DataSource = null;
                    this.NombreMedicoCanalizadorCmb.DataSource = medicoscan;
                    this.NombreMedicoCanalizadorCmb.DisplayMember = "Nombre";

                }
                else
                    e.Handled = true;

                this.NombreMedicoCanalizadorCmb.Focus();
                this.NombreMedicoCanalizadorCmb.Text = textocombomedican + " ";
            }

            SendKeys.Send("{END}");
        }

        private void NombreMedicoCanalizadorCmb_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cambiosindexmccmb++;
            //Console.WriteLine("Paso selectec changed > " + this.NombrePacienteCmb.Text);
            if (this.cambiosindexmccmb > 2)
            {
                //despues de que se cargo la lista
                //y se agrego el texto que tenia antes el cmb de cargar la lista
                //pasar a recoger el objeto seleccionado
                //MedicoCanalizador medicoselec = (MedicoCanalizador) this.NombreMedicoCanalizadorCmb.SelectedItem;
                AuxPersona medicoselec = (AuxPersona)this.NombreMedicoCanalizadorCmb.SelectedItem;
                if (medicoselec != null && medicoselec.Id != 0)
                {
                    //cargar los datos reales del medico canalizador
                    MedicoCanalizador medicoseleccionado = BD.MedicoCanalizador.Where(m => m.Id == medicoselec.Id).FirstOrDefault();
                    if (medicoseleccionado != null)
                    {
                        //limpiar el datasource del combo
                        this.NombreMedicoCanalizadorCmb.DataSource = null;

                        this.idmedicocana = medicoseleccionado.Id; //almacenar el id del medico seleccionado

                        this.NombreMedicoCanalizadorCmb.Text = medicoseleccionado.Nombre.TrimEnd();
                        this.ApellidosMedicoCanalizadorTxt.Text = medicoseleccionado.Apellidos.TrimEnd();
                        this.CedulaMedicCanNtxt.Value = medicoseleccionado.CedulaProfesional;

                        this.AgregarEstudioBtn.Focus();
                    }
                }
            }
        }


        private void ResgistrarServicioBtn_Click(object sender, EventArgs e)
        {
            this.FechaServicioDtp.Value = DateTime.Now;

            //validaciones de datos
            if (this.NombrePacienteCmb.Text.Trim() == "" || this.ApellidosPacienteTxt.Text.Trim() == ""
                || this.LugarResidenciaPacienteCmb.Text.Trim() == "" || this.EdadPacientePacienteNTxt.Value == 0)
            {
                MessageBox.Show("Ingrese todos los datos del paciente.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.NombreMedicoCanalizadorCmb.Text.Trim() == "" || this.ApellidosMedicoCanalizadorTxt.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese los datos del médico que canalizó al paciente.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.MedicoResponsableCmb.Text == "")
            {
                MessageBox.Show("Seleccione el médico del centro de estudios que atenderá al paciente.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.estudiosarealizar.Count <= 0)
            {
                MessageBox.Show("Seleccione los estudios a realizar al paciente.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Confirma registrar el servicio?", "Centro de estudios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //el usuario ha confirmado el registro, procedemos a crear el servicio

                //empezamos por crear el servicio
                Servicio nuevoservicio = new Servicio();
                nuevoservicio.Fecha = this.FechaServicioDtp.Value;

                /////////////////paciente
                Paciente paciente;
                if (this.idpaciente != 0)                  //si el usuario seleciono un paciente, recuperar el objeto de la BD                
                    paciente = BD.Paciente.Where(p => p.Id == this.idpaciente).FirstOrDefault();
                else
                    paciente = new Paciente();                    
                //pasar todos los datos del form al objeto
                paciente.Nombre = this.NombrePacienteCmb.Text;
                paciente.Apellidos = this.ApellidosPacienteTxt.Text;
                paciente.Edad = (byte)this.EdadPacientePacienteNTxt.Value;
                if (this.SexoHombrePacienteRbtn.Checked)
                    paciente.Sexo = "H";
                if (this.SexoMujerPacienteRbtn.Checked)
                    paciente.Sexo = "M";

                ///////////Lugar residencia
                LugarResidencia lugarresidencia;
                if (idlugar != 0)
                    lugarresidencia = BD.LugarResidencia.Where(l => l.Id == this.idlugar).FirstOrDefault();
                else
                    lugarresidencia = new LugarResidencia();

                //llenar el lugar de residencia
                lugarresidencia.Nombre = this.LugarResidenciaPacienteCmb.Text;
                //asignar el lugar de residencia al paciente
                paciente.LugarResidencia = lugarresidencia;


                /////////////Medico canalizador
                MedicoCanalizador medicocan;
                if (idmedicocana != 0)
                    medicocan = BD.MedicoCanalizador.Where(m => m.Id == this.idmedicocana).FirstOrDefault();
                else
                    medicocan = new MedicoCanalizador();

                medicocan.Nombre = this.NombreMedicoCanalizadorCmb.Text;
                medicocan.Apellidos = this.ApellidosMedicoCanalizadorTxt.Text;
                medicocan.CedulaProfesional = this.CedulaMedicCanNtxt.Value;

                //MedicoCE medicoresponsable;
                //if(this.MedicoResponsableCmb.SelectedItem

                ////////////////////// Agregar el resto de los datos al servicio
                nuevoservicio.Paciente = paciente;
                nuevoservicio.MedicoCanalizador = medicocan;
                nuevoservicio.IdMedicoResponsable = this.idmedresp;
                nuevoservicio.EstadoServicio = BD.EstadoServicio.Where(est => est.Nombre.TrimEnd() == "No atendido").FirstOrDefault();

                //crear los detalles del servicio <- agregar los estudios a realizar

                foreach (Estudio estudio in this.estudiosarealizar)
                    nuevoservicio.DetalleServicio.Add(new DetalleServicio { IdEstudio = estudio.Id, Precio = estudio.Costo, Servicio = nuevoservicio });

                BD.AddToServicio(nuevoservicio);
                BD.SaveChanges();


                MessageBox.Show("El servicio ha sido registrado correctamente.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();

            }

            Console.WriteLine("Paciente seleccionado: " + this.idpaciente);
            LugarResidencia lugarseleccionado = (LugarResidencia)this.LugarResidenciaPacienteCmb.SelectedItem;

            if (lugarseleccionado != null && lugarseleccionado.Id != 0)
                Console.WriteLine("Lugar seleccionado: " + lugarseleccionado.Nombre);
            else
                Console.WriteLine("Lugar escrito: " + this.LugarResidenciaPacienteCmb.Text);

            Console.WriteLine("Id lugar seleccionado: " + this.idlugar);

            Console.WriteLine("Id medico can seleccionado: " + this.idmedicocana);
        }

        private void LimpiarControles()
        {
            this.IdServicioTxt.Value = 0;
            this.NombrePacienteCmb.Text = "";
            this.ApellidosPacienteTxt.Text = "";
            this.EdadPacientePacienteNTxt.Text = "";
            this.SexoHombrePacienteRbtn.Checked = false;
            this.SexoMujerPacienteRbtn.Checked = false;
            this.LugarResidenciaPacienteCmb.Text = "";
            this.NombreMedicoCanalizadorCmb.Text = "";
            this.ApellidosMedicoCanalizadorTxt.Text = "";
            this.CedulaMedicCanNtxt.Text = "";
            this.estudiosarealizar.Clear();
            this.EstudiosARealizarDtg.DataSource = null;
            this.ImporteTotalLbl.Text = "$ 0.00";
            this.NombrePacienteCmb.Focus();
            this.MedicoResponsableCmb.Text = "";

            BD = new DBEntities();
            //using (BD = new DBEntities())
            //{
                ////cargar la lista de lugares de residencia
                // this.lugaresresidencia.Insert(0, new LugarResidencia { Id = 0, Nombre = "" });
                var listalugares = BD.LugarResidencia.ToList();
                listalugares.Insert(0, new LugarResidencia { Id = 0, Nombre = "" });
                this.LugarResidenciaPacienteCmb.DataSource = null;
                this.LugarResidenciaPacienteCmb.DataSource = listalugares;
                this.LugarResidenciaPacienteCmb.DisplayMember = "Nombre";
            //}
            //BD = new DBEntities();

        }
        private void AgregarEstudioBtn_Click(object sender, EventArgs e)
        {
            EstudiosARealizarFrm ventanaestudios = new EstudiosARealizarFrm();
            ventanaestudios.ShowDialog();

            if (ventanaestudios.EstudiosSeleccionados().Count > 0)
            {
                //cargar los estudios seleccionados a nuestra lista
                foreach (Estudio estudio in ventanaestudios.EstudiosSeleccionados())
                {
                    var buscarestudio = estudiosarealizar.Where(est => est.Id == estudio.Id).FirstOrDefault();

                    if (buscarestudio == null)
                        estudiosarealizar.Add(estudio);
                }

                this.EstudiosARealizarDtg.DataSource = null;
                this.EstudiosARealizarDtg.DataSource = estudiosarealizar;
            }
        }

        private void EstudiosARealizarDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.EstudiosARealizarDtg.DataSource != null && this.EstudiosARealizarDtg.Rows.Count > 0)
            {
                this.EstudiosARealizarDtg.Columns[4].DefaultCellStyle.Format = "c";
                this.EstudiosARealizarDtg.Columns[5].Visible = false;
                this.EstudiosARealizarDtg.Columns[6].Visible = false;

                //calcular importe total
                decimal total = estudiosarealizar.Sum(est => est.Costo);
                this.ImporteTotalLbl.Text = String.Format("{0:C}", total);
            }
        }

        private void EstudiosARealizarDtg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //if (this.EstudiosARealizarDtg.Rows.Count > 0 && this.EstudiosARealizarDtg.SelectedRows.Count > 0)
                //    this.EstudiosARealizarDtg.Rows.Remove(this.EstudiosARealizarDtg.CurrentRow);
                if (this.EstudiosARealizarDtg.CurrentRow != null)
                {
                    this.estudiosarealizar.Remove((Estudio)this.EstudiosARealizarDtg.CurrentRow.DataBoundItem);

                    this.EstudiosARealizarDtg.DataSource = null;
                    this.EstudiosARealizarDtg.DataSource = estudiosarealizar;
                }
            }
        }

        private void EliminarEstudioBtn_Click(object sender, EventArgs e)
        {
            if (this.EstudiosARealizarDtg.CurrentRow != null)
            {
                this.estudiosarealizar.Remove((Estudio)this.EstudiosARealizarDtg.CurrentRow.DataBoundItem);

                this.EstudiosARealizarDtg.DataSource = null;
                this.EstudiosARealizarDtg.DataSource = estudiosarealizar;
            }
        }

        private void MedicoResponsableCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ApellidosPacienteTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) //no permitir numeros en el nombre
                e.Handled = true;
        }

        private void MedicoResponsableCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuxPersona seleccionado = (AuxPersona)this.MedicoResponsableCmb.SelectedItem;
            if (seleccionado != null && seleccionado.Id > 0)
                this.idmedresp = seleccionado.Id;
        }

        private void ApellidosMedicoCanalizadorTxt_TextChanged(object sender, EventArgs e)
        {
            if (this.ApellidosMedicoCanalizadorTxt.Text != "")
            {
                this.ApellidosMedicoCanalizadorTxt.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(this.ApellidosMedicoCanalizadorTxt.Text);
                SendKeys.Send("{END}");
            }
        }

        private void CancelarServicioBtn_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void RecepcionFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                Application.Exit();
            }
        }

    }
}
