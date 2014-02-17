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
    public partial class AdministradorFrm : Form
    {
        private Form ventanaactual = new Form();

        public AdministradorFrm()
        {
            InitializeComponent();
        }

        private void AbrirVentana(Form NuevaVentana)
        {
            if (ventanaactual != null)
                ventanaactual.Close();

            this.ventanaactual = NuevaVentana;
            NuevaVentana.MdiParent = this;
            
            NuevaVentana.WindowState = FormWindowState.Maximized;
            //NuevaVentana.ShowIcon = false;
            NuevaVentana.Show();
        }

        private void recepciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecepcionFrm recepcion = new RecepcionFrm();        
            AbrirVentana(recepcion);
          
        }

        private void serviciosEnAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {         
            ServiciosEnAtencionFrm atencionservicios = new ServiciosEnAtencionFrm();
            AbrirVentana(atencionservicios);            
        }

        private void cajaCobroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiciosNoPagadosFrm cajacobro = new ServiciosNoPagadosFrm();
            AbrirVentana(cajacobro);
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPacientesFrm pacientes = new GestionPacientesFrm();
            AbrirVentana(pacientes);
        }

        private void médicosCanalizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMedicosCanalizadoresFrm medicoscanalizadores = new GestionMedicosCanalizadoresFrm();
            AbrirVentana(medicoscanalizadores);
        }

        private void estudiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionEstudiosFrm estudios = new GestionEstudiosFrm();
            AbrirVentana(estudios);
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionMedicosCEForm medicoscentro = new GestionMedicosCEForm();
            AbrirVentana(medicoscentro);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuarios usuarios = new GestionUsuarios();
            AbrirVentana(usuarios);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesFrm reportes = new ReportesFrm();
            AbrirVentana(reportes);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdministradorFrm_Load(object sender, EventArgs e)
        {
            //comprobar si es Administrador
            if (!Thread.CurrentPrincipal.IsInRole("Administrador"))
            {
                MessageBox.Show("No tiene privilegios para utilizar este modulo", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void AdministradorFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ventanaactual != null)
            {
                ventanaactual.Close();
                ventanaactual.Dispose();
            }
            Application.Exit();
        }

        private void mEstudiosAsignadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiciosMedicoCEFrm misservicios = new ServiciosMedicoCEFrm();
            AbrirVentana(misservicios);
        }

    }
}
