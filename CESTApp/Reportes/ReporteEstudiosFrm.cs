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
    public partial class ReporteEstudiosFrm : Form
    {
        public ReporteEstudiosFrm()
        {
            InitializeComponent();
        }

        private string tituloinforme;

        public string TituloInforme
        {
            //get { return titulo; }
            set { tituloinforme = value; }
        }

        public List<EstudiosRealizados_Result> DatosInforme
        {
            set
            {
                this.DatosEstudiosRealizadosBS.DataSource = value;
            }
        }

        private void ReporteEstudiosFrm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Titulo", this.tituloinforme);

            this.EstudiosRealizadosRptv.LocalReport.SetParameters(parametros);

            this.EstudiosRealizadosRptv.RefreshReport();
        }
    }
}
