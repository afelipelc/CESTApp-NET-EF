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
    public partial class GestionPacientesFrm : Form
    {
        DBEntities BD = new DBEntities();

        public GestionPacientesFrm()
        {
            InitializeComponent();
        }

        private void GestionPacientesFrm_Load(object sender, EventArgs e)
        {

            this.PacientesDtg.DataSource = BD.Paciente.Select(p => new { p.Id, p.Nombre, p.Apellidos, p.Edad, p.Sexo, LugarResidencia = p.LugarResidencia.Nombre }).ToList();  //BD.Paciente.ToList();
                    
            this.FiltrarLugarResidenciaCmb.DataSource = BD.LugarResidencia.ToList();           
            this.FiltrarLugarResidenciaCmb.DisplayMember = "Nombre"; //indicar que propiedad debe mostrarse como texto en la lista
            

        }

        private void FiltrarLugarResidenciaCmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.FiltrarLugarResidenciaCmb.SelectedValue != null)
            {
                LugarResidencia lugar = (LugarResidencia)this.FiltrarLugarResidenciaCmb.SelectedItem;
                //MessageBox.Show("Seleccionado > "+ lugar.Nombre);
                //Aqui se debe filtrar la lista
                if (lugar.Nombre != "Todos los lugares")
                {
                    var listafiltrada = BD.Paciente.Where(p => p.LugarResidencia == lugar).Select(p => new { p.Id, p.Nombre, p.Apellidos, p.Edad, p.Sexo, LugarResidencia = p.LugarResidencia.Nombre }).ToList();

                    this.PacientesDtg.DataSource = null;
                    this.PacientesDtg.DataSource = listafiltrada;
                }
                else
                {
                    this.PacientesDtg.DataSource = null;
                    this.PacientesDtg.DataSource = BD.Paciente.Select(p => new { p.Id, p.Nombre, p.Apellidos, p.Edad, p.Sexo, LugarResidencia = p.LugarResidencia.Nombre }).ToList();
                }
            }
        }

        private void PacientesDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //recuperar objeto Paciente por medio del valor del ID de la Columna 0
            //Paciente verpaciente = BD.Paciente.Where(p => p.Id == Convert.ToInt32(this.PacientesDtg.CurrentRow.Cells[0].Value.ToString())).FirstOrDefault();
            int idpaciente = (int)this.PacientesDtg.CurrentRow.Cells[0].Value;
            
            EstudiosRealizadosAPacienteFrm estudiosdelpaciente = new EstudiosRealizadosAPacienteFrm();
            estudiosdelpaciente.IdPaciente = idpaciente;
            estudiosdelpaciente.ShowDialog();
        }

        private void FiltrarLugarResidenciaCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
