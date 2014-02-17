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
    public partial class CapturarDiagnosticoFrm : Form
    {
        DBEntities BD = new DBEntities();
        private Servicio servicio;
        private int idservicio;

        public int IdServicio
        {
            get { return idservicio; }
            set { idservicio = value;
            CargarDatos();
            }
        }
        private void CargarDatos()
        {
            servicio = BD.Servicio.Where(s => s.Id == this.idservicio).FirstOrDefault();
            if (servicio != null)
            {
                this.NombrePacienteTxt.Text = servicio.Paciente.Nombre.TrimEnd() + " " + this.servicio.Paciente.Apellidos.TrimEnd();
                this.MedicoCanalizadorTxt.Text = servicio.MedicoCanalizador.Nombre.TrimEnd() + " " + this.servicio.MedicoCanalizador.Apellidos.TrimEnd();
                this.LugarFechaLbl.Text = "XLugar. A " + servicio.Fecha.ToLongDateString();
                this.MedicoRemitenteLbl.Text = servicio.MedicoCE.Nombre.TrimEnd() + " " + servicio.MedicoCE.Apellidos.TrimEnd();

                var diagnostico = servicio.Diagnostico.FirstOrDefault();
                if (diagnostico != null)
                    this.ContenidoDiagnosticoTxt.Text = diagnostico.Resultado;

                SendKeys.Send("{END}");
            }
                
        }

        public CapturarDiagnosticoFrm()
        {
            InitializeComponent();
        }

        private void CapturarDiagnosticoFrm_Resize(object sender, EventArgs e)
        {
            CentrarEtiquetas();
        }
        
        //reubicar etiquetas al centro del form
        private void CentrarEtiquetas()
        {
            //alinear las etiquetas al centro del form
            Point posicion = new Point();

            //atentamente
            posicion.X = this.Width / 2 - this.AtentamenteLbl.Width / 2;
            posicion.Y = this.AtentamenteLbl.Location.Y;
            this.AtentamenteLbl.Location = posicion;

            //lugar y fecha
            posicion.X = this.Width / 2 - this.LugarFechaLbl.Width / 2;
            posicion.Y = this.LugarFechaLbl.Location.Y;

            this.LugarFechaLbl.Location = posicion;
            //medico remitente
            posicion.X = this.Width / 2 - this.MedicoRemitenteLbl.Width / 2;
            posicion.Y = this.MedicoRemitenteLbl.Location.Y;
            this.MedicoRemitenteLbl.Location = posicion;
        }

        private void GuardarDiagnostico()
        {
            var diagnostico = servicio.Diagnostico.FirstOrDefault();
            if (diagnostico == null)
            {
                servicio.Diagnostico.Add(new Diagnostico { Servicio = servicio, Resultado = this.ContenidoDiagnosticoTxt.Text });
            }
            else
                diagnostico.Resultado = this.ContenidoDiagnosticoTxt.Text;

            BD.SaveChanges();

            this.InfoLbl.Text = "Resultado guardado.";
        }
        private void DetallesServicioBtn_Click(object sender, EventArgs e)
        {
            if (this.idservicio != 0)
            {
                DatosDelServicio detalles = new DatosDelServicio();
                detalles.IdServicio = idservicio;
                detalles.ShowDialog();
                this.ContenidoDiagnosticoTxt.Focus();
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            GuardarDiagnostico();
        }

        private void ContenidoDiagnosticoTxt_TextChanged(object sender, EventArgs e)
        {
            this.InfoLbl.Text = "";
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            GuardarDiagnostico();
        }

        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            if (this.ContenidoDiagnosticoTxt.Text != "")
            {
                if (MessageBox.Show("Confirma imprimir el diagnóstico.", "Centro de estudios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //se guardan los cambios del diagnostico
                    GuardarDiagnostico();

                   //se imprime el documento
                    ImprimirDiagnosticoFrm imprimir = new ImprimirDiagnosticoFrm();
                    imprimir.Destinatario = this.MedicoCanalizadorTxt.Text;
                    imprimir.Paciente = this.NombrePacienteTxt.Text;
                    imprimir.Remitente = this.MedicoRemitenteLbl.Text;                    
                    imprimir.LugarFecha = this.LugarFechaLbl.Text;
                    imprimir.Resultado = this.ContenidoDiagnosticoTxt.Text;
                    imprimir.ShowDialog();
                    imprimir.Dispose();
                    //se marca el servicio como atendido
                    servicio.EstadoServicio = BD.EstadoServicio.Where(est => est.Nombre == "Atendido").FirstOrDefault();
                    BD.SaveChanges();

                    MessageBox.Show("El servicio se ha marcado como ATENDIDO", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
            else
                MessageBox.Show("Debe capturar el diagnóstico.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


    }
}
