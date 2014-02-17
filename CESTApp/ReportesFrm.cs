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

using CESTApp.Reportes;

namespace CESTApp
{
    public partial class ReportesFrm : Form
    {
        DBEntities BD = new DBEntities();
        //arreglo temporal de a;os
       // int[] anios = { 2005, 2009, 2007, 2008, 2006 };
        private string showreporte;
        ReporteIngresosFrm reporteingresos;
        ReporteServiciosFrm reporteservicios;
        ReporteEstudiosFrm reporteestudios;
        public ReportesFrm()
        {
            InitializeComponent();
        }

        private void FormaReporteCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.GenerarReportePorCmb.SelectedIndex)
            {
                case 0: //Selecciono reporte por Dia o semana -> habilitar el primer dtp para que seleccione el dia
                    OcultarControlesReporte();
                    this.PrimeraFechaDtp.Visible = true;
                    this.PrimeraFechaDtp.Enabled = true;
                    this.DelLbl.Visible = true;
                    this.PrimeraFechaDtp.Focus();
                    ToolTip tooltipdia = new ToolTip();
                    tooltipdia.ShowAlways = true;
                    tooltipdia.SetToolTip(this.PrimeraFechaDtp, "Elija el DÍA del que quiere generar el reporte.");
                    break;

                case 1: //Selecciono reporte por Semana -> habilitar el primer dtp para que seleccione el dia de la semana
                    OcultarControlesReporte();
                    this.PrimeraFechaDtp.Visible = true;
                    this.PrimeraFechaDtp.Enabled = true;
                    this.DelLbl.Visible = true;
                    this.PrimeraFechaDtp.Focus();
                    ToolTip tooltipsemana = new ToolTip();
                    tooltipsemana.ShowAlways = true;
                    tooltipsemana.SetToolTip(this.PrimeraFechaDtp, "Haga clic sobre cualquier dia de la SEMANA para la que quiere generar el reporte.");
                    break;

                case 2:  //selecciono mes, --> Habilitar el combo de meses
                    OcultarControlesReporte();
                    this.ReporteMesCmb.Enabled = true;
                    this.ReporteMesCmb.Visible = true;
                    this.DelLbl.Visible = true;
                    this.ReporteMesCmb.Focus();
                    ToolTip tooltipmes = new ToolTip();
                    tooltipmes.ShowAlways = true;
                    tooltipmes.SetToolTip(this.ReporteMesCmb, "Seleccione el MES del cuál que quiere generar el reporte.");
                    break;

                case 3: // Selecciono año, --> Habilitar el combo de años
                    OcultarControlesReporte();
                    this.ReporteAnioCmb.Enabled = true;
                    this.ReporteAnioCmb.Visible = true;
                    this.DelLbl.Visible = true;
                    this.ReporteAnioCmb.Focus();
                    ToolTip tooltipanio = new ToolTip();
                    tooltipanio.ShowAlways = true;
                    tooltipanio.SetToolTip(this.ReporteAnioCmb, "Seleccione el AÑO del cuál que quiere generar el reporte.");
                    break;

                case 4: //Selecciono Rango de fechas, --> Habilitar dtp de segunda fecha
                    OcultarControlesReporte();
                    this.PrimeraFechaDtp.Visible = true;
                    this.PrimeraFechaDtp.Enabled = true;
                    this.SegundaFechaDtp.Visible = true;
                    this.SegundaFechaDtp.Enabled = true;
                    this.DelLbl.Visible = true;
                    this.AlLbl.Visible = true;

                    ToolTip tooltipfechas = new ToolTip();
                    tooltipfechas.ShowAlways = true;
                    tooltipfechas.SetToolTip(this.PrimeraFechaDtp, "Seleccione el día inicial del rango de fechas para generar el reporte.");
                    tooltipfechas.SetToolTip(this.SegundaFechaDtp, "Seleccione el día final del rango de fechas para generar el reporte.");
                    break;

            }
           
        }

        private void FormaReporteCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void TipoReporteCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ReporteMesCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ReporteAnioCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void OcultarControlesReporte()
        {
            this.PrimeraFechaDtp.Enabled = false;
            this.PrimeraFechaDtp.Visible = false;
            this.SegundaFechaDtp.Enabled = false;
            this.SegundaFechaDtp.Visible = false;
            this.ReporteMesCmb.Enabled = false;
            this.ReporteMesCmb.Visible = false;
            this.ReporteAnioCmb.Enabled = false;
            this.ReporteAnioCmb.Visible = false;
            this.AlLbl.Visible = false;
            this.DelLbl.Visible = false;
        }

        private void ReportesFrm_Load(object sender, EventArgs e)
        {
            //comprobar si es Administrador
            if (!Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                MessageBox.Show("No tiene privilegios para utilizar este modulo", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }


            if (BD.Servicio.FirstOrDefault() != null)
            {
                DateTime primerafecha = BD.Servicio.Min(s => s.Fecha);
                DateTime ultimafecha = BD.Servicio.Max(s => s.Fecha);

                //cargar los a;os
                //var aniosordenados = anios.OrderByDescending(a => a);
                //foreach (int anio in aniosordenados)
                for (int i = primerafecha.Date.Year; i <= ultimafecha.Date.Year; i++)
                    this.ReporteAnioCmb.Items.Add(i);
            }
        }

        private void ImprimirReporteBtn_Click(object sender, EventArgs e)
        {
            //ReporteIngresosFrm vistarepingresos = new ReporteIngresosFrm();
            //vistarepingresos.ShowDialog();
            switch (showreporte)
            {
                case "ingresos":                   
                    reporteingresos.ShowDialog();
                    //reporteingresos.Dispose();
                    //reporteingresos = null;
                    break;

                case "servicios":

                    reporteservicios.ShowDialog();
                    //reporteservicios.Dispose();
                    //reporteservicios = null;
                    break;
                case "estudios":
                    reporteestudios.ShowDialog();
                    //reporteestudios.Dispose();
                    //reporteestudios = null;
                    break;
                default:
                    MessageBox.Show("No se ha generado ningún reporte.");
                    break;
            }
        }

        private void GenerarInformeBtn_Click(object sender, EventArgs e)
        {
            if (this.TipoReporteCmb.Text == "")
            {
                MessageBox.Show("Seleccione el tipo de reporte a generar.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.GenerarReportePorCmb.Text == "")
            {
                MessageBox.Show("Seleccione la forma en como quiere generar el reporte.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if((this.GenerarReportePorCmb.Text == "Mes" && this.ReporteMesCmb.Text=="") || (this.GenerarReportePorCmb.Text == "Año" &&  this.ReporteAnioCmb.Text == ""))
            {
                MessageBox.Show("Seleccione el mes o año del cual quiere generar el reporte.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.IngresosDtg.DataSource = null;
            GenerarInforme(this.TipoReporteCmb.Text, this.GenerarReportePorCmb.Text);
        }

        private void GenerarInforme(string tipoinforme, string generarpor)
        {
            switch (tipoinforme)
            {
                case "Ingresos económicos":
                    //formreporte = new ReporteIngresosFrm();
                    switch (generarpor)
                    {
                        case "Día":
                            IngresosEconomicos(this.PrimeraFechaDtp.Value, "d");
                            break;
                        case "Semana":
                                  IngresosEconomicos(this.PrimeraFechaDtp.Value, "s");
                            break;                      
                            //MessageBox.Show("inicia: "+this.PrimeraFechaDtp.Value.AddDays(-numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)).Date.ToShortDateString()
                            //    + " :: termina: " + this.PrimeraFechaDtp.Value.AddDays(6 - numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)).Date.ToShortDateString());
                           //MessageBox.Show(this.PrimeraFechaDtp.Value.AddDays(-1).Date
                            //DayOfWeek dia = this.PrimeraFechaDtp.Value.Date.DayOfWeek;
                            //IngresosEconomicos(this.PrimeraFechaDtp.Value, "d");
                            //break;

                        case "Mes":
                            //MessageBox.Show(this.ReporteMesCmb.SelectedIndex.ToString());
                            IngresosEconomicosMes(this.ReporteMesCmb.SelectedIndex + 1);
                            break;
                        case "Año":
                            IngresosEconomicos(Convert.ToInt16(this.ReporteAnioCmb.Text));
                            break;
                        case "Rango de Fechas":
                            IngresosFechas(this.PrimeraFechaDtp.Value, this.SegundaFechaDtp.Value);
                            break;
                    }
                    break;

                case "Servicios prestados":
                    switch (generarpor)
                    {
                        case "Día":
                           ServiciosPrestados(this.PrimeraFechaDtp.Value, this.PrimeraFechaDtp.Value);
                            break;
                        case "Semana":
                            ServiciosPrestados(this.PrimeraFechaDtp.Value.AddDays(-numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)),
                                this.PrimeraFechaDtp.Value.AddDays(6 -numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)));
                            break;
                        case "Mes":                            
                            ServiciosPrestados(this.ReporteMesCmb.SelectedIndex + 1);
                            break;

                        case "Año":
                            ServiciosPrestadosAnio(Convert.ToInt16(this.ReporteAnioCmb.Text));
                            break;
                        case "Rango de Fechas":
                            ServiciosPrestados(this.PrimeraFechaDtp.Value, this.SegundaFechaDtp.Value);
                            break;
                    }
                    break;

                case "Estudios realizados":
                    switch (generarpor)
                    {
                        case "Día":
                            EstudiosRealizados(this.PrimeraFechaDtp.Value, this.PrimeraFechaDtp.Value);
                            break;
                        case "Semana":
                            EstudiosRealizados(this.PrimeraFechaDtp.Value.AddDays(-numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)),
                                this.PrimeraFechaDtp.Value.AddDays(6 - numdiasemana(this.PrimeraFechaDtp.Value.DayOfWeek)));
                            break;
                        case "Mes":
                            EstudiosRealizados(this.ReporteMesCmb.SelectedIndex + 1);
                            break;
                        case "Año":
                            EstudiosRealizadosAnio(Convert.ToInt16(this.ReporteAnioCmb.Text));
                            break;
                        case "Rango de Fechas":
                            EstudiosRealizados(this.PrimeraFechaDtp.Value, this.SegundaFechaDtp.Value);
                            break;
                    }
                    break;
            }

        }

        //generar informes economicos

        //informe de ingreso total por año
        private void IngresosEconomicos(int year)
        {
            //var ingresos = BD.Servicio.Where(s => s.Fecha.Year == year && s.Pagado == true).Select(s => new { Fecha = s.Fecha, IngresoTotal = s.DetalleServicio.Sum(d => d.Precio) });

            var totalingresos = BD.Servicio.Where(s => s.Fecha.Year == year && s.Pagado == true).Sum(s => s.DetalleServicio.Sum(d => d.Precio));
            //var ingresos = BD.Servicio.Where(s => s.Fecha.Year == year && s.Pagado == true).GroupBy(s => s.Fecha.Year);
            //decimal sumatotal = ingresos.Sum(ing => ing.IngresoTotal);                     

            List<IngresoAnio> ingresos = new List<IngresoAnio>();
            ingresos.Add(new IngresoAnio { Año=year,Ingreso=totalingresos });
            
            //this.IngresosDtg.DataSource = null;
            this.IngresosDtg.DataSource = ingresos;

            this.IngresosDtg.Columns[1].DefaultCellStyle.Format = "c";
        }

        /// <summary>
        /// Metodo que obtiene todos los ingresos econimicos por dia o semana
        /// </summary>
        /// <param name="fecha">Especifica la semana completa</param>
        /// <param name="por">Especifica si el informe se genera por dia (d) o semana (s)</param>
        private void IngresosEconomicos(DateTime fecha, string por)
        {
            switch (por)
            {
                case "d":
                    var ingresosdeldia = BD.IngresosFechas(fecha.Date,fecha.Date).ToList();
                    //this.IngresosDtg.DataSource = null;
                    this.IngresosDtg.DataSource = ingresosdeldia;
                    reporteingresos = new ReporteIngresosFrm();
                    reporteingresos.DatosInforme = ingresosdeldia;
                    reporteingresos.TituloInforme = "del día " + fecha.ToShortDateString();

                    showreporte = "ingresos";

                    break;
                case "s":
                    var ingresossemana = BD.IngresosFechas(fecha.AddDays(-numdiasemana(fecha.DayOfWeek)), fecha.AddDays(6 - numdiasemana(fecha.DayOfWeek))).ToList();
                    //this.IngresosDtg.DataSource = null;
                    this.IngresosDtg.DataSource = ingresossemana;

                    reporteingresos = new ReporteIngresosFrm();
                    reporteingresos.DatosInforme = ingresossemana;
                    //reporteingresos.TituloInforme = "ososoosososos";
                    reporteingresos.TituloInforme = "de la semana del " + fecha.AddDays(-numdiasemana(fecha.DayOfWeek)).ToShortDateString() +
                        " al " + fecha.AddDays(6 - numdiasemana(fecha.DayOfWeek)).ToShortDateString();
                    showreporte = "ingresos";

                    break;
            }
            this.IngresosDtg.Columns[1].DefaultCellStyle.Format = "c";
        }

        private void IngresosEconomicosMes(int mes)
        {
            DateTime tiempo = DateTime.Now;
            int diasmes = DateTime.DaysInMonth(tiempo.Year, mes);

            DateTime inicio = Convert.ToDateTime("01/" + mes + "/" + tiempo.Year);
            DateTime fin = Convert.ToDateTime(diasmes+"/" + mes + "/" + tiempo.Year);

           IngresosFechas(inicio, fin);           
        }

        private void IngresosFechas(DateTime inicio, DateTime fin)
        {
            var ingresos = BD.IngresosFechas(inicio, fin).ToList();
            this.IngresosDtg.DataSource = ingresos;

           //reporteingresos = new ReporteIngresosFrm();
           reporteingresos = new ReporteIngresosFrm();
           reporteingresos.DatosInforme = ingresos;
           reporteingresos.TituloInforme = "del " + inicio.ToShortDateString() +
               " al " + fin.ToShortDateString();
           showreporte = "ingresos";


            this.IngresosDtg.Columns[1].DefaultCellStyle.Format = "c";
        }

        private int numdiasemana(DayOfWeek dia)
        {
            switch (dia)
            {
                case DayOfWeek.Sunday:
                    return 0;
                case DayOfWeek.Monday:
                    return 1;
                case DayOfWeek.Tuesday:
                    return 2;
                case DayOfWeek.Wednesday:
                    return 3;
                case DayOfWeek.Thursday:
                    return 4;
                case DayOfWeek.Friday:
                    return 5;
                case DayOfWeek.Saturday:
                    return 6;
                default:
                    return 0;
            }
        }

        private void ServiciosPrestados(DateTime inicio, DateTime fin)
        {
            var servicios = BD.ServiciosPrestados(inicio, fin).ToList();
            this.IngresosDtg.DataSource = servicios;
            this.IngresosDtg.Columns[5].DefaultCellStyle.Format = "c";

            reporteservicios = new ReporteServiciosFrm();
            reporteservicios.DatosInforme = servicios;
            reporteservicios.TituloInforme = "del " + inicio.ToShortDateString() +
                " al " + fin.ToShortDateString();
            showreporte = "servicios";

        }
        private void ServiciosPrestados(int mes)
        {
            DateTime tiempo = DateTime.Now;
            int diasmes = DateTime.DaysInMonth(tiempo.Year, mes);

            DateTime inicio = Convert.ToDateTime("01/" + mes + "/" + tiempo.Year);
            DateTime fin = Convert.ToDateTime(diasmes + "/" + mes + "/" + tiempo.Year);

            ServiciosPrestados(inicio, fin);           
        }
        private void ServiciosPrestadosAnio(int anio)
        {           
            DateTime inicio = Convert.ToDateTime("01/01/" + anio);
            DateTime fin = Convert.ToDateTime("31/12/" + anio);

            ServiciosPrestados(inicio, fin);
        }

        private void EstudiosRealizados(DateTime inicio, DateTime fin)
        {
            var estudios = BD.EstudiosRealizados(inicio, fin).ToList();
            this.IngresosDtg.DataSource = estudios;

            reporteestudios = new ReporteEstudiosFrm();
            reporteestudios.DatosInforme = estudios;
            reporteestudios.TituloInforme = "del " + inicio.ToShortDateString() +
                " al " + fin.ToShortDateString();
            showreporte = "estudios";
        }
        private void EstudiosRealizados(int mes)
        {
            DateTime tiempo = DateTime.Now;
            int diasmes = DateTime.DaysInMonth(tiempo.Year, mes);

            DateTime inicio = Convert.ToDateTime("01/" + mes + "/" + tiempo.Year);
            DateTime fin = Convert.ToDateTime(diasmes + "/" + mes + "/" + tiempo.Year);

            EstudiosRealizados(inicio, fin);           
        }
        private void EstudiosRealizadosAnio(int anio)
        {
            DateTime inicio = Convert.ToDateTime("01/01/" + anio);
            DateTime fin = Convert.ToDateTime("31/12/" + anio);

            EstudiosRealizados(inicio, fin);
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportesFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reporteingresos != null)
            {
                reporteingresos.Dispose();
                reporteingresos = null;
            }
            if (reporteestudios != null)
            {
                reporteestudios.Dispose();
                reporteestudios = null;
            }
            if (reporteservicios != null)
            {
                reporteservicios.Dispose();
                reporteservicios = null;
            }
        }
    }
}
