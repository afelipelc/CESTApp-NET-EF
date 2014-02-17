using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CESTApp
{
    public partial class DatosDelServicio : Form
    {
        private int idservicio;

        public int IdServicio
        {
            get { return idservicio; }
            set { idservicio = value;
            CargarDatosServicio();
            }
        }


        public DatosDelServicio()
        {
            InitializeComponent();
        }

        private void CargarDatosServicio()
        {
            if (this.idservicio != 0)
            {
                using (DBEntities BD = new DBEntities())
                {
                    var servicio = BD.Servicio.Where(s => s.Id == this.idservicio).FirstOrDefault();
                    if (servicio != null)
                    {
                        this.IdServicioTxt.Text = servicio.Id.ToString();
                        this.FechaServicioDtp.Value = servicio.Fecha;
                        this.NombrePacienteTxt.Text = servicio.Paciente.Nombre.TrimEnd() + " " + servicio.Paciente.Apellidos;

                        List<Estudio> estudios = new List<Estudio>();
                        foreach (DetalleServicio detalle in servicio.DetalleServicio)
                            estudios.Add(detalle.Estudio);

                        this.EstudiosDtg.DataSource = estudios;
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar cargar los datos del servicio.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }
                }
            }

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EstudiosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.EstudiosDtg.Columns.Count > 0)
            {
                this.EstudiosDtg.Columns[4].Visible = false;
                this.EstudiosDtg.Columns[5].Visible = false;
                this.EstudiosDtg.Columns[6].Visible = false;
            }
        }
    }
}
