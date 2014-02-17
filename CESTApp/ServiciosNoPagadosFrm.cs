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
    public partial class ServiciosNoPagadosFrm : Form
    {
        DBEntities BD = new DBEntities();

        public ServiciosNoPagadosFrm()
        {
            InitializeComponent();
        }

        private void ServiciosNoPagadosFrm_Load(object sender, EventArgs e)
        {
            //comprobar usuario
            if (!Thread.CurrentPrincipal.IsInRole("Administrador") && !Thread.CurrentPrincipal.IsInRole("Caja"))
            {               
                MessageBox.Show("No tiene privilegios para utilizar este modulo", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

             ////cargar la lista de servicios no pagados al grid
            ////cargar la lista con datos especificos
            //var servnopagados = listaservicios.Where(s => s.Pagado == false).Select(s => new { Id = s.Id, Paciente = s.Paciente.Nombre + " " + s.Paciente.Apellidos, Fecha = s.Fecha, Importe = 100.00m }).ToList();
            this.ListaServiciosDtg.DataSource = BD.Servicio.Where(s => s.Pagado == false).Select(s => new { Id = s.Id, Paciente = s.Paciente.Nombre.TrimEnd() + " " 
                + s.Paciente.Apellidos.TrimEnd(), Fecha = s.Fecha, Importe = s.DetalleServicio.Sum(d => d.Precio) }).ToList();
        }

        private void ListaServiciosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CobrarServicio();
        }

        private void ListaServiciosDtg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CobrarServicio();
        }

        //Metodo para abrir la ventana de cobro
        private void CobrarServicio()
        {
            using (BD = new DBEntities())
            {
                if (this.ListaServiciosDtg.Rows.Count > 0)
                {
                    int idserv = (int)this.ListaServiciosDtg.CurrentRow.Cells[0].Value;
                    if (idserv != 0)
                    {
                        CajaCobroFrm caja = new CajaCobroFrm();
                        caja.IdServicio = idserv;

                        caja.ShowDialog();

                        if (caja.ServicioPagado())
                        {
                            //volver a cargar todos los servicios desde la BD
                            this.ListaServiciosDtg.DataSource = null;
                            this.ListaServiciosDtg.DataSource = BD.Servicio.Where(s => s.Pagado == false).Select(s => new { Id = s.Id, Paciente = s.Paciente.Nombre.TrimEnd() + " " + s.Paciente.Apellidos.TrimEnd(), Fecha = s.Fecha, Importe = s.DetalleServicio.Sum(d => d.Precio) }).ToList();                        
                        }
                    }
                }
            }
        }

        private void ListaServiciosDtg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.Handled = true;
        }

        private void ListaServiciosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.ListaServiciosDtg.DataSource != null && this.ListaServiciosDtg.Rows.Count > 0)
                this.ListaServiciosDtg.Columns[3].DefaultCellStyle.Format = "c";
        }

        private void ServiciosNoPagadosFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                Application.Exit();
            }
        }
    }
}