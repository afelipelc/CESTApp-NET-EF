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
    public partial class GestionMedicosCanalizadoresFrm : Form
    {
        DBEntities BD = new DBEntities();

        public GestionMedicosCanalizadoresFrm()
        {
            InitializeComponent();
        }

        private void GestionMedicosCanalizadoresFrm_Load(object sender, EventArgs e)
        {
            var medicos = BD.MedicoCanalizador.ToList();
            foreach (MedicoCanalizador medico in medicos)
            {
                medico.Nombre = medico.Nombre.TrimEnd();
                medico.Apellidos = medico.Apellidos.TrimEnd();
            }
            //this.MedicosCanalizadoresDtg.DataSource = BD.MedicoCanalizador.ToList();
            this.MedicosCanalizadoresDtg.DataSource = medicos;
        }

        private void MedicosCanalizadoresDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           //mostrar la lista de estudios solicitados por este medico

            //antes recuperar el objeto MedicoCanalizador
            int idmedicomostrar = (int)this.MedicosCanalizadoresDtg.CurrentRow.Cells[0].Value;

            MessageBox.Show("Se mostrarán los estudios solicitados por el médico: " + idmedicomostrar);

            EstudiosMedicoCanalizadorFrm ventanaestudios = new EstudiosMedicoCanalizadorFrm();
            ventanaestudios.ShowDialog();
        }

        private void MedicosCanalizadoresDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.MedicosCanalizadoresDtg.Columns.Count > 0)
                this.MedicosCanalizadoresDtg.Columns[4].Visible = false;
        }
    }
}
