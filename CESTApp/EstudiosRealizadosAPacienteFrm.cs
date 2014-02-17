using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CESTApp.Reportes;
namespace CESTApp
{
    public partial class EstudiosRealizadosAPacienteFrm : Form
    {
        DBEntities BD = new DBEntities();

        private int idpaciente;

        public int IdPaciente
        {
            get { return idpaciente; }
            set { idpaciente = value;
            CargarEstudiosPaciente();
            }
        }

        private void CargarEstudiosPaciente()
        {
            var paciente = BD.Paciente.Where(p => p.Id == idpaciente).FirstOrDefault();
            if (paciente != null)
            {
                //cargar los datos del paciente a los txt
                this.IdTxt.Text = paciente.Id.ToString();
                this.NombreTxt.Text = paciente.Nombre.TrimEnd();
                this.ApellidosTxt.Text = paciente.Apellidos.TrimEnd();
                this.EdadTxt.Text = paciente.Edad.ToString();
                this.SexoTxt.Text = paciente.Sexo;
                this.LugarResidenciaTxt.Text = paciente.LugarResidencia.Nombre.TrimEnd();

                //cargar todos los estudios realizados
                //var serviciospaciente = BD.Servicio.Where(s => s.Paciente == paciente);
                //List<Estudio> estudiosrealizados = new List<Estudio>();
               
                //int num = 0;
                //foreach (Servicio servicio in BD.Servicio.Where(s => s.IdPaciente == paciente.Id && s.EstadoServicio.Nombre.Trim() == "Atendido"))
                //{
                //    num++;
                //    foreach (DetalleServicio detalle in servicio.DetalleServicio)
                //        this.EstudiosRealizadosDtg.Rows.Add(num, detalle.Estudio.Nombre.TrimEnd(), detalle.Estudio.Categoria.TrimEnd(), servicio.Id, servicio.Fecha.ToLongDateString());
                //        //estudiosrealizados.Add(detalle.Estudio);
                //}


                var detalles = BD.DetalleServicio.Where(d => d.Servicio.IdPaciente == paciente.Id && d.Servicio.EstadoServicio.Nombre.Trim() == "Atendido")
                    .Select(
                    d => new { 
                        Id_Servicio = d.IdServicio, 
                        Estudio = d.Estudio.Nombre.Trim(), 
                        Categoria = d.Estudio.Categoria.Trim(), 
                        Fecha = d.Servicio.Fecha 
                    }).ToList();

                this.EstudiosRealizadosDtg.DataSource = detalles;

                //if (estudiosrealizados.Count > 0)
                //    this.EstudiosRealizadosDtg.DataSource = estudiosrealizados;

            }
        }
        public EstudiosRealizadosAPacienteFrm()
        {
            InitializeComponent();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstudiosRealizadosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.EstudiosRealizadosDtg.Rows.Count > 0)
            {
                int idservicio = (int)this.EstudiosRealizadosDtg.CurrentRow.Cells[0].Value;
                var servicio = BD.Servicio.Where(s => s.Id == idservicio).FirstOrDefault();
                if (servicio != null)
                {
                    //MessageBox.Show("Se mostrará el diagnostico del estudio realizado que corresponde al servicio id: " + idservicio);
                    ImprimirDiagnosticoFrm imprimir = new ImprimirDiagnosticoFrm();
                    imprimir.Destinatario = servicio.MedicoCanalizador.Nombre.Trim() + " "+ servicio.MedicoCanalizador.Apellidos.Trim();
                    imprimir.Paciente = servicio.Paciente.Nombre.Trim() + " " + servicio.Paciente.Apellidos.Trim();
                    imprimir.Remitente = servicio.MedicoCE.Nombre.Trim() + " " + servicio.MedicoCE.Apellidos.Trim();
                    imprimir.LugarFecha = "X Lugar. A " + servicio.Fecha.ToLongDateString();
                    imprimir.Resultado = servicio.Diagnostico.FirstOrDefault().Resultado;
                    imprimir.ShowDialog();
                    imprimir.Dispose();
                }
            }
        }
    }
}
