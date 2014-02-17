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
    public partial class ReporteIngresosFrm : Form
    {
        //DBEntities BD = new DBEntities();
        //private List<IngresosFechas_Result> datosinforme = new List<IngresosFechas_Result>();

        public List<IngresosFechas_Result> DatosInforme
        {
            //get { return datosinforme; }
            set { //datosinforme = value;
            this.DatosIngresosBS.DataSource = value;            
            }
        }

        private string tituloinforme;

        public string TituloInforme
        {
            get { return tituloinforme; }
            set { tituloinforme = value; }
        }


        public ReporteIngresosFrm()
        {
            InitializeComponent();
        }

        private void ReporteIngresosFrm_Load(object sender, EventArgs e)
        {

            
            //this.DatosReporte.DataSource = BD.IngresosDia(DateTime.Now);
            
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Titulo", this.tituloinforme);

            this.ReporteIngresosRpt.LocalReport.SetParameters(parametros);

            this.ReporteIngresosRpt.RefreshReport();
        }

        private void ReporteIngresosFrm_FormClosing(object sender, FormClosingEventArgs e)
        {           
            //this.DatosReporte.DataSource = null;
            //this.Close();          
        }
    }
}
