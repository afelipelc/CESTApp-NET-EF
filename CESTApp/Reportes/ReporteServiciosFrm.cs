using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
namespace CESTApp.Reportes
{
    public partial class ReporteServiciosFrm : Form
    {
        private string tituloinforme;

        public string TituloInforme
        {
            get { return tituloinforme; }
            set { tituloinforme = value; }
        }

        public List<ServiciosPrestados_Result> DatosInforme
        {
            set { this.DatosServiciosPrestadosBS.DataSource = value; }
        }

        public ReporteServiciosFrm()
        {
            InitializeComponent();
        }

        private void ReporteServiciosFrm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Titulo", this.tituloinforme);

            this.ReporteServiciosRptv.LocalReport.SetParameters(parametros);

            this.ReporteServiciosRptv.RefreshReport();
        }
    }
}
