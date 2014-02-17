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
    public partial class ImprimirDiagnosticoFrm : Form
    {        
        private string remitente;
        public string Remitente
        {
            set { remitente = value;           
            }
        }
        private string destinatario;
        public string Destinatario
        {            
            set { destinatario = value;                 
            }
        }
        private string paciente;
        public string Paciente
        {
            set { paciente = value;
            }
        }
        
        private string lugarfecha;
        public string LugarFecha
        {
            set { lugarfecha = value;                 
            }
        }

        private string resultado;
        public string Resultado
        {
            set { resultado = value;                 
            }
        }

        public ImprimirDiagnosticoFrm()
        {
            InitializeComponent();
        }

        private void ImprimirDiagnosticoFrm_Load(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[5];
            parametros[0] = new ReportParameter("Remitente", remitente);
            parametros[1] = new ReportParameter("Destinatario", destinatario);
            parametros[2] = new ReportParameter("Paciente", paciente);           
            parametros[3] = new ReportParameter("LugarFecha", lugarfecha);
            parametros[4] = new ReportParameter("Resultado", resultado);

            this.DiagnosticoRptv.LocalReport.SetParameters(parametros);
            this.DiagnosticoRptv.RefreshReport();

            //DiagnosticoRptv.PrintDialog();
        }
    }
}
