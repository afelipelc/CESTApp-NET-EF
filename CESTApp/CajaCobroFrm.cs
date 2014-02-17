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
    public partial class CajaCobroFrm : Form
    {
        DBEntities BD = new DBEntities();
        private Servicio servicio;
        private int idservicio;

        public int IdServicio
        {
            get { return idservicio; }
            set { idservicio = value; }
        }

        private bool registropago;
        private decimal importe;


        public CajaCobroFrm()
        {
            InitializeComponent();
        }

        private void CajaCobroFrm_Load(object sender, EventArgs e)
        {
            ////Cargar todos los datos del servicio
            CargarServicio();
            SendKeys.Send("{TAB}");
            ////SendKeys.Send("{TAB}");
        }

        //Metodos agregados
        private void CargarServicio()
        {
            servicio = BD.Servicio.Where(s => s.Id == this.idservicio).FirstOrDefault();

            if (servicio != null)
            {
                if (servicio.Pagado == false)
                {
                    //llenar los controles con los datos del servicio

                    //datos generales
                    this.IdServicioTxt.Text = servicio.Id.ToString();
                    this.FechaServicioDtp.Value = servicio.Fecha;

                    //datos del paciente
                    this.NombrePacienteTxt.Text = servicio.Paciente.Nombre.TrimEnd() + " " + servicio.Paciente.Apellidos.TrimEnd();
                    this.LugarResidenciaPacienteTxt.Text = servicio.Paciente.LugarResidencia.Nombre;

                    //Estudios a cobrar
                    //this.EstudiosACobrarDtg.DataSource = servicio.DetallesServicio;
                    List<Estudio> estudios = new List<Estudio>();
                    foreach (DetalleServicio detalle in servicio.DetalleServicio)
                        estudios.Add(detalle.Estudio);
                    //no hay estudios reales, se simularan algunos
                    this.EstudiosACobrarDtg.DataSource = estudios;

                    //calcular el importe
                    importe = estudios.Sum(est => est.Costo);
                    this.ImporteTotalLbl.Text = String.Format("{0:C}", importe);
                }
                else
                    MessageBox.Show("El servicio seleccionado ya está pagado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontró el servicio seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool ServicioPagado()
        {
            return this.registropago;
        }

        private void EstudiosACobrarDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.EstudiosACobrarDtg.DataSource != null && this.EstudiosACobrarDtg.Rows.Count > 0)
            {
                this.EstudiosACobrarDtg.Columns[4].DefaultCellStyle.Format = "c";
                this.EstudiosACobrarDtg.Columns[5].Visible = false;
                this.EstudiosACobrarDtg.Columns[6].Visible = false;
            }
        }

        private void SuPagoDTxt_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            //{
            //    ValidarPago();
            //}

            if (e.KeyCode == Keys.Enter)
            {
                RegistrarPago();
            }
        }

        private void ValidarPago()
        {
            decimal sucambio = this.SuPagoDTxt.Value - importe;
            if (sucambio >= 0)
            {
                this.SuCambioLbl.Text = String.Format("{0:C}", sucambio);
                this.ResgistrarServicioBtn.Enabled = true;
                this.NotaLbl.Text = "";
            }
            else
            {
                this.ResgistrarServicioBtn.Enabled = false;
                this.SuCambioLbl.Text = "$ 0.00";
                this.NotaLbl.Text = "El pago es inferior al total a cobrar.";
            }
        }

        //Metodo que registra el pago del servicio
        private void RegistrarPago()
        {
            if (this.ResgistrarServicioBtn.Enabled)
            {
                if (MessageBox.Show("¿Confirma registrar el pago del servicio?", "Centro de estudios", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    //this.ResgistrarServicioBtn.Focus();
                    //MessageBox.Show("Registrando el pago");
                    servicio.EstadoServicio = BD.EstadoServicio.Where(est => est.Nombre == "En atención").FirstOrDefault();
                    servicio.Pagado = true;
                    BD.SaveChanges();

                    MessageBox.Show("El pago del servicio ha sido registrado.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.registropago = true;
                    this.Close();
                }

            }
        }

        private void SuPagoDTxt_TextChanged(object sender, EventArgs e)
        {
            ValidarPago();
        }

        private void ResgistrarServicioBtn_Click(object sender, EventArgs e)
        {
            RegistrarPago();
        }


    }
}
