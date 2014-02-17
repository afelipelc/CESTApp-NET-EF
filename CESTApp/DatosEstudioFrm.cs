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
    public partial class DatosEstudioFrm : Form
    {
        DBEntities BD = new DBEntities();
        private Estudio estudio; //campo que almacene un objeto de la clase Estudio

        //public Estudio Estudio
        //{
        //    get { return estudio; }
        //    set { estudio = value; LlenarControles(); }
        //}

        private int idestudio;

        public int IdEstudio
        {
            get { return idestudio; }
            set
            {
                idestudio = value;
                //mandar a llenar los controles
                LlenarControles();
            }
        }

        //almacenar un valor que indique que el usuario ingreso o no ingreso datos
        private bool ingresodatos;

        public DatosEstudioFrm()
        {
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            //comprobar que se ingresaron todos los datos
            //con un if else
            if (this.NombreTxt.Text != "" && this.DescripcionTxt.Text != ""
                && this.CategoriaCmb.Text != "" && this.CostoDTxt.Text != "")
            {
                this.ingresodatos = true; //indicamos que SI se llenaron los datos
                //llenar el objeto
                LlenarObjeto(); //incovamos al metodo que llena el objeto
                this.Close(); //cerramos la ventana
            }
            else
                MessageBox.Show("Ingrese todos los datos");
        }


        //Metodo que llene los datos del objeto
        private void LlenarObjeto()
        {

            //comprobar que el objeto de la clase Estudio este inicializado
            //Cuando se crea un nuevo estudio, el objeto no esta inicializado
            if (estudio == null) //si es nulo, inicializarlo
            {
                Estudio nuevoestudio = new Estudio();

                //pasar los valores de los controles al objeto
                nuevoestudio.Nombre = this.NombreTxt.Text;
                nuevoestudio.Descripcion = this.DescripcionTxt.Text;
                nuevoestudio.Categoria = this.CategoriaCmb.Text;
                nuevoestudio.Costo = this.CostoDTxt.Value;
                nuevoestudio.Activo = this.EstadoChk.Checked;

                BD.AddToEstudio(nuevoestudio);
                BD.SaveChanges();
            }
            else
            {
                //pasar los valores de los controles al objeto
                estudio.Id = this.IdTxt.Value;
                estudio.Nombre = this.NombreTxt.Text;
                estudio.Descripcion = this.DescripcionTxt.Text;
                estudio.Categoria = this.CategoriaCmb.Text;
                estudio.Costo = this.CostoDTxt.Value;
                estudio.Activo = this.EstadoChk.Checked;

                BD.SaveChanges();
            }

            
        }

        //Metodo que llene los controles con los datos del objeto
        private void LlenarControles()
        {
            estudio = BD.Estudio.Where(e => e.Id == idestudio).FirstOrDefault();
            if (estudio != null)
            {
                this.IdTxt.Text = estudio.Id.ToString();
                this.NombreTxt.Text = estudio.Nombre.TrimEnd();
                this.DescripcionTxt.Text = estudio.Descripcion.TrimEnd();
                this.CategoriaCmb.Text = estudio.Categoria.TrimEnd();
                this.CostoDTxt.Value = estudio.Costo;
                this.EstadoChk.Checked = estudio.Activo;
            }
        }

        //Metodo que indica si el usuario ingreso datos
        public bool LlenoDatos()
        {
            //devolver si el usuario ingreso o no ingreso datos
            return this.ingresodatos;
        }


        private void CategoriaCmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
