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
    public partial class GestionMedicosCEForm : Form
    {
       DBEntities BD = new DBEntities();
        public GestionMedicosCEForm()
        {
            InitializeComponent();
        }

        private void NuevoMedicoBtn_Click(object sender, EventArgs e)
        {
            using (BD = new DBEntities())
            {
                DatosMedicoCEForm datosmedico = new DatosMedicoCEForm();
                datosmedico.ShowDialog();

                if (datosmedico.IngresoDatos())
                {
                    this.ListaMedicosDtg.DataSource = null;
                    this.ListaMedicosDtg.DataSource = BD.MedicoCE.ToList();
                }
            }
        }

        private void ListaMedicosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (BD = new DBEntities())
            {
                //recuperar objeto
                int idmedicoeditar = (int)this.ListaMedicosDtg.CurrentRow.Cells[0].Value;
                //MedicoCE medicoeditar = (MedicoCE)this.ListaMedicosDtg.CurrentRow.DataBoundItem;

                DatosMedicoCEForm datosmedico = new DatosMedicoCEForm();
                //datosmedico.Medico = medicoeditar;
                datosmedico.Idmedico = idmedicoeditar;

                datosmedico.ShowDialog();

                if (datosmedico.IngresoDatos())
                {
                    this.ListaMedicosDtg.DataSource = null;
                    this.ListaMedicosDtg.DataSource = BD.MedicoCE.ToList();
                }
            }

        }

        private void GestionMedicosCEForm_Load(object sender, EventArgs e)
        {
            this.ListaMedicosDtg.DataSource = BD.MedicoCE.ToList();
        }

        private void ListaMedicosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.ListaMedicosDtg.Columns.Count > 0)
            {
                this.ListaMedicosDtg.Columns[5].Visible = false;
                this.ListaMedicosDtg.Columns[6].Visible = false;
                this.ListaMedicosDtg.Columns[7].Visible = false;
            }
        }
    }
}