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
    public partial class GestionEstudiosFrm : Form
    {
        DBEntities BD = new DBEntities();


        public GestionEstudiosFrm()
        {
            InitializeComponent();
        }

        private void NuevoEstudioBtn_Click(object sender, EventArgs e)
        {
            //Cargar la ventana de datos del estudio
            //primero creamos instancia del Form
            DatosEstudioFrm ventanadedatos = new DatosEstudioFrm();
            //mostrarlo como cuadro de dialogo

            ventanadedatos.ShowDialog();

            //comprobar que el usuario ingreso datos
            if (ventanadedatos.LlenoDatos())
            {
                //limpiar el datasource del datagrid
                this.EstudiosDtg.DataSource = null;
                //asignar nuevamente la lista de estudios al datagrid
                this.EstudiosDtg.DataSource = BD.Estudio.ToList();
            }
        }

        private void EstudiosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (BD = new DBEntities())
            {
                //cuando el usuario presione doble clic sobre un registro
                //abrir la ventana para editar datos

                //recuperar el objeto de la fila seleccionada
                //Estudio estudioeditar = (Estudio)this.EstudiosDtg.SelectedRows[0].DataBoundItem;
                int estudioeditar = (int)this.EstudiosDtg.CurrentRow.Cells[0].Value;
                //crear instancia de la ventana de datos
                DatosEstudioFrm ventanadatos = new DatosEstudioFrm();

                //asignar el objeto recuperado a la propiedad Estudio de la ventana de datos

                //ventanadatos.IdEstudio = estudioeditar.Id;
                ventanadatos.IdEstudio = estudioeditar;
                ventanadatos.ShowDialog();
                //comprobar que el usuario ingreso datos
                if (ventanadatos.LlenoDatos())
                {                    
                    //limpiar el datasource del datagrid                
                    this.EstudiosDtg.DataSource = null;
                    //asignar nuevamente la lista de estudios al datagrid
                    this.EstudiosDtg.DataSource = BD.Estudio.ToList();
                }
            }
        }

        private void GestEstudiosFrm_Load(object sender, EventArgs e)
        {

            this.EstudiosDtg.DataSource = BD.Estudio.ToList();

            CrearToolTip();
        }

        private void CategoriaCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EstudiosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.EstudiosDtg.DataSource != null && this.EstudiosDtg.Rows.Count > 0)
                this.EstudiosDtg.Columns[4].DefaultCellStyle.Format = "c";

            if (this.EstudiosDtg.Columns.Count > 0)
                this.EstudiosDtg.Columns[6].Visible = false;
        }

        private void EstudiosDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //Cambiar el estado del estudio seleccionado
            //comprobar que se este haciendo clic sobre la columna de Activo (Checkbox)
            if (this.EstudiosDtg.Columns[this.EstudiosDtg.CurrentCell.ColumnIndex].HeaderText == "Activo")
            {
                //recuperar el objeto que lleno la fila actual
                int cambiarestudio = (int)this.EstudiosDtg.CurrentRow.Cells[0].Value;
                var estudio = BD.Estudio.Where(est => est.Id == cambiarestudio).FirstOrDefault();
                if (estudio.Activo == true)
                    estudio.Activo = false;
                else
                    estudio.Activo = true;               

                BD.SaveChanges();                
                //Actualizar el datagrid
                this.EstudiosDtg.DataSource = null;
                this.EstudiosDtg.DataSource = BD.Estudio.ToList();
            }
        }

        private void CategoriaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {           
            //mostrar los los Estudios que corresponden a la categoria seleccionada o Todos
            switch (this.CategoriaCmb.Text)
            {
                case "Todos":
                    this.EstudiosDtg.DataSource = BD.Estudio.ToList();
                    break;
                case "Tomografía":
                    //cargar la lista de estudios a mostrar
                    var estudiostoms = BD.Estudio.Where(est => est.Categoria == "Tomografía").ToList();
                    this.EstudiosDtg.DataSource = estudiostoms;
                    break;
                case "Radiografía":
                    //cargar la lista de estudios a mostrar
                    var estudiosrads = BD.Estudio.Where(est => est.Categoria == "Radiografía").ToList();
                    this.EstudiosDtg.DataSource = estudiosrads;
                    break;
                case "Ultrasonido":
                    //cargar la lista de estudios a mostrar
                    var estudiosult = BD.Estudio.Where(est => est.Categoria == "Ultrasonido").ToList();
                    this.EstudiosDtg.DataSource = estudiosult;
                    break;
            }
        }

        private void GestEstudiosFrm_KeyUp(object sender, KeyEventArgs e)
        {

            //si presiono Ctrl+N
            //if (e.KeyCode == Keys.N && (e.Control))
            //    NuevoEstudioBtn_Click(null, EventArgs.Empty);

            if (e.Control) //Si presiona Ctrl, pasar a verificar la comprobacion
            {
                switch (e.KeyCode) //obtener la tecla presionana
                {
                    case Keys.N: //si presiona la tecla N
                        NuevoEstudioBtn_Click(NuevoEstudioBtn, EventArgs.Empty); //incovar al click del boton Nuevo
                        break;
                }

            }
               
        }

        //Metodo que crea y establece el tooltip a los controles
        private void CrearToolTip()
        {
            ToolTip tooltip = new ToolTip();
            //tooltip.AutoPopDelay = 5000;
            //tooltip.InitialDelay = 500;
            //tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;
            tooltip.SetToolTip(NuevoEstudioBtn, "Registre un nuevo estudio. (Ctrl+N, Alt+N)");
            tooltip.SetToolTip(CategoriaCmb, "Puede mostrar los estudios por categoria.");
        }

    }
}
