using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//librerias para utilizar sesiones
using System.Threading;
using System.Security.Principal;

namespace CESTApp
{
    public partial class ServiciosMedicoCEFrm : Form
    {
        DBEntities BD = new DBEntities();
        int idusuario;

        public ServiciosMedicoCEFrm()
        {
            InitializeComponent();
        }

        private string Texto()
        {
            return "hola";
        }
        private void ServiciosMedicoCEFrm_Load(object sender, EventArgs e)
        {
            //comprobar usuario
            if (!Thread.CurrentPrincipal.IsInRole("Administrador") && !Thread.CurrentPrincipal.IsInRole("Medico"))
            {
                MessageBox.Show("No tiene privilegios para utilizar este modulo", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
            idusuario = BD.Usuario.Where( u => u.NombreUsuario.Trim() == Thread.CurrentPrincipal.Identity.Name).Select( us => us.Id).FirstOrDefault();

            if (idusuario == 0)
            {
                MessageBox.Show("Error al intentar cargar los servicios asignados, reportelo al administrador.", "Centro de estudios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            CargarServicios();
            
        }

        private void RegistrarDiagnosticoBtn_Click(object sender, EventArgs e)
        {
            CapturarDiagnostico();
        }

        private void ServiciosMedicoCEFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                Application.Exit();
            }
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ServiciosAsignadosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CapturarDiagnostico();
        }

        private void CargarServicios()
        {
            BD = new DBEntities();
            this.ServiciosAsignadosDtg.DataSource = null;
                        //cargar todos los servicios asignados al medico actual (el que entro como usuario)
            var medico = BD.UsuarioMedico.Where(u => u.IdUsuario == idusuario).FirstOrDefault();
            if (medico != null)
            {
                //mostrar el nombre del medico
                this.NombreMedicoTxt.Text = medico.MedicoCE.Nombre.TrimEnd() + " " + medico.MedicoCE.Apellidos.TrimEnd();

                //var serviciosasignados = BD.Servicio.Where(s => s.IdMedicoResponsable == medico.IdMedico && s.EstadoServicio == BD.EstadoServicio.Where(es => es.Nombre == "En atención").FirstOrDefault()).ToList();
                var serviciosasignados = BD.Servicio.Where(s => s.IdMedicoResponsable == medico.IdMedico &&
                    s.EstadoServicio == BD.EstadoServicio.Where(es => es.Nombre == "En atención").FirstOrDefault())
                    .Select(s => new
                    {
                        Id = s.Id,
                        Paciente = s.Paciente.Nombre.TrimEnd() + " " + s.Paciente.Apellidos.TrimEnd(),
                        Solicito = s.MedicoCanalizador.Nombre.TrimEnd() + " " + s.MedicoCanalizador.Apellidos.TrimEnd(),
                        Fecha = s.Fecha
                    })
                    .ToList();
                if (serviciosasignados.Count > 0)
                {
                    this.ServiciosAsignadosDtg.DataSource = serviciosasignados;

                    //    foreach (Servicio servicio in serviciosasignados)
                    //    {

                    //        string estudiosserv = "";

                    //        foreach (string estudio in servicio.DetalleServicio.Select(d => d.Estudio.Nombre))
                    //            estudiosserv += estudio.TrimEnd() + " | ";

                    //        this.ServiciosAsignadosDtg.Rows.Add(servicio.Id, servicio.Paciente.Nombre.TrimEnd() + " " + servicio.Paciente.Apellidos, estudiosserv, servicio.Fecha.ToShortDateString());

                    //        //this.ServiciosAsignadosDtg.Rows[this.ServiciosAsignadosDtg.Rows.Count - 1].Cells[2].Value
                    //        //DataGridViewComboBoxCell celda = (DataGridViewComboBoxCell)this.ServiciosAsignadosDtg.Rows[this.ServiciosAsignadosDtg.Rows.Count - 1].Cells[2];
                    //        //MessageBox.Show(servicio.DetalleServicio.ToList().Count.ToString());
                    //        //celda.DataSource = servicio.DetalleServicio.ToList();
                    //        //celda.DisplayMember = "Id";


                    //        //this.ServiciosAsignadosDtg.Rows.Add(new DataGridViewComboBoxCell {DataSource= servicio.DetalleServicio.Select(d => d.Estudio.Nombre).ToList()}
                    //        //this.ServiciosAsignadosDtg.DataSource = serviciosasignados;
                    //    }

                }
                else
                    this.InfoLbl.Text = "Ningún servicio asignado.";
            }
        }

        private void CapturarDiagnostico()
        {
            if (this.ServiciosAsignadosDtg.Rows.Count > 0)
            {
                int idservicio = (int)this.ServiciosAsignadosDtg.CurrentRow.Cells[0].Value;
                CapturarDiagnosticoFrm capturardiagnostico = new CapturarDiagnosticoFrm();
                capturardiagnostico.IdServicio = idservicio;
                capturardiagnostico.ShowDialog();

                CargarServicios();
            }
        }

        private void ServiciosAsignadosDtg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CapturarDiagnostico();
        }

        private void ServiciosAtencioBtn_Click(object sender, EventArgs e)
        {
            ServiciosEnAtencionFrm serviciosatencion = new ServiciosEnAtencionFrm();
            serviciosatencion.ShowDialog();
        }
        
    }
}
