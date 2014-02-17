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
    public partial class EstudiosARealizarFrm : Form
    {
        DBEntities BD = new DBEntities();

        public EstudiosARealizarFrm()
        {
            InitializeComponent();
        }

        private void EstudiosARealizarFrm_Load(object sender, EventArgs e)
        {
            this.EstudiosDtg.DataSource = BD.Estudio.Where(est => est.Activo == true).ToList();

            this.EstudiosDtg.ClearSelection(); //inicia sin ningun elemento seleccionado
        }

        public List<Estudio> EstudiosSeleccionados()
        {
            List<Estudio> estudiosseleccionados = new List<Estudio>();

            foreach (DataGridViewRow fila in this.EstudiosDtg.SelectedRows)
                estudiosseleccionados.Add((Estudio)fila.DataBoundItem);

            return estudiosseleccionados;
        }

        private void CategoriaCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EstudiosDtg.DataSource = null;

            //mostrar los los Estudios que corresponden a la categoria seleccionada o Todos
            switch (this.CategoriaCmb.Text)
            {
                case "Todos":
                    var estudiosactivos = BD.Estudio.Where(est => est.Activo == true).ToList();
                    this.EstudiosDtg.DataSource = estudiosactivos;
                    break;
                case "Tomografía":
                    //cargar la lista de estudios a mostrar
                    var estudiostoms = BD.Estudio.Where(est => est.Categoria == "Tomografía" && est.Activo == true).ToList();
                    this.EstudiosDtg.DataSource = estudiostoms;
                    break;
                case "Radiografía":
                    //cargar la lista de estudios a mostrar
                    var estudiosrads = BD.Estudio.Where(est => est.Categoria == "Radiografía" && est.Activo == true).ToList();
                    this.EstudiosDtg.DataSource = estudiosrads;
                    break;
                case "Ultrasonido":
                    //cargar la lista de estudios a mostrar
                    var estudiosult = BD.Estudio.Where(est => est.Categoria == "Ultrasonido" && est.Activo == true).ToList();
                    this.EstudiosDtg.DataSource = estudiosult;
                    break;
            }
        }

        private void EstudiosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.EstudiosDtg.DataSource != null && this.EstudiosDtg.Rows.Count > 0)
                this.EstudiosDtg.Columns[4].DefaultCellStyle.Format = "c";

            if (this.EstudiosDtg.Columns.Count > 0)
            {
                this.EstudiosDtg.Columns[5].Visible = false;
                this.EstudiosDtg.Columns[6].Visible = false;
            }
        }

        //Seleccionar varias filas con clic
        List<int> filasseleccionadas = new List<int>();
        public void SeleccionarFilas(int actual)
        {
            //var fila =  from f in filasseleccionadas where f == actual select f;
            int fila = 0;
            fila = filasseleccionadas.Find(val => val == actual + 1);
            if (fila != 0)
            {
                filasseleccionadas.Remove(fila);
                this.EstudiosDtg.Rows[fila - 1].Selected = false;
            }
            else
                filasseleccionadas.Add(actual + 1);

            foreach (int filaselec in filasseleccionadas)
                this.EstudiosDtg.Rows[filaselec - 1].Selected = true;

        }

        private void EstudiosDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFilas(this.EstudiosDtg.CurrentRow.Index);
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Seleccionados: " + this.EstudiosDtg.SelectedRows.Count);
            this.Close();
        }
    }
}
