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
    public partial class ServiciosEnAtencionFrm : Form
    {
        DBEntities BD = new DBEntities();

        public ServiciosEnAtencionFrm()
        {
            InitializeComponent();
        }

        private void ServiciosEnAtencionFrm_Load(object sender, EventArgs e)
        {
            //crear los estados de los servicios para simular funcionamiento           
            //cargar la lista con datos especificos
            //var servnopagados = BD.Servicio.Where(s => s.EstadoServicio == BD.EstadoServicio.Where(est => est.Nombre == "En atención").FirstOrDefault()).Select(s => new { Id = s.Id, Paciente = s.Paciente.Nombre + " " + s.Paciente.Apellidos, Fecha = s.Fecha, Importe = 100.00m }).ToList();
            this.ListaServiciosDtg.DataSource = BD.Servicio.Where(s => s.EstadoServicio == BD.EstadoServicio.Where(est => 
                est.Nombre == "En atención").FirstOrDefault()).Select(s => new { Id = s.Id, Paciente = s.Paciente.Nombre.TrimEnd() + " " + 
                    s.Paciente.Apellidos.TrimEnd(), Medico = s.MedicoCE.Nombre.TrimEnd() + " " + s.MedicoCE.Apellidos.TrimEnd(), 
                    Fecha = s.Fecha, Importe = s.DetalleServicio.Sum(d => d.Precio) }).ToList(); ;
        }

        private void ListaServiciosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VerDatosServicio();
        }


        //Metodo para abrir la ventana de detalles
        private void VerDatosServicio()
        {
            if (this.ListaServiciosDtg.Rows.Count > 0)
            {
                int idserv = (int)this.ListaServiciosDtg.CurrentRow.Cells[0].Value;
                if (idserv != 0)
                {
                    DatosDelServicio ventanadatos = new DatosDelServicio();
                    ventanadatos.IdServicio = idserv;

                    ventanadatos.ShowDialog();
                    
                }
            }
        }

        private void ListaServiciosDtg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                VerDatosServicio();
        }

        private void ListaServiciosDtg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
        }

        private void ServiciosEnAtencionFrm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void ListaServiciosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.ListaServiciosDtg.DataSource != null && this.ListaServiciosDtg.Rows.Count > 0)
                this.ListaServiciosDtg.Columns[4].DefaultCellStyle.Format = "c";
        }

    }
}
