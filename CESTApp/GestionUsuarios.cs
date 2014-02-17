using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//agregamos el uso de
using System.Data.Objects;
using System.Data.Objects.DataClasses;
//para poder usar el data entity model

namespace CESTApp
{
    public partial class GestionUsuarios : Form
    {
        DBEntities BD= new DBEntities();
        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void NuevoUsuarioBtn_Click(object sender, EventArgs e)
        {
            DatosUsuarioFrm ventanadatos = new DatosUsuarioFrm();
            ventanadatos.ShowDialog();

            if (ventanadatos.IngresoDatos())
            {
                //BD.SaveChanges();
                //this.usuarios.Add(ventanadatos.Usuario);

                this.ListaUsuariosDtg.DataSource = null;
                this.ListaUsuariosDtg.DataSource = BD.Usuario.ToList();
            }
        }

        private void ListaUsuariosDtg_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.ListaUsuariosDtg.Columns.Count > 0)
            {
                this.ListaUsuariosDtg.Columns[4].Visible = false;
                this.ListaUsuariosDtg.Columns[6].Visible = false;
                this.ListaUsuariosDtg.Columns[7].Visible = false;
            }

        }

        private void ListaUsuariosDtg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (BD = new DBEntities())
            {
                if (this.ListaUsuariosDtg.Rows.Count > 0)
                {
                    int idusuario = (int)this.ListaUsuariosDtg.CurrentRow.Cells[0].Value;
                    if (idusuario != 0)
                    {
                        DatosUsuarioFrm ventanadatos = new DatosUsuarioFrm();
                        ventanadatos.Idusuario = idusuario;
                        ventanadatos.ShowDialog();

                        if (ventanadatos.IngresoDatos())
                        {
                            this.ListaUsuariosDtg.DataSource = null;
                            this.ListaUsuariosDtg.DataSource = BD.Usuario.ToList();
                        }
                    }
                }
            }
        }

        private void ListaUsuariosDtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.ListaUsuariosDtg.Columns[this.ListaUsuariosDtg.CurrentCell.ColumnIndex].HeaderText == "Activo")
            {
                using (BD = new DBEntities())
                {
                    Usuario editarusuario = (Usuario)this.ListaUsuariosDtg.CurrentRow.DataBoundItem;

                    var usuario = BD.Usuario.Where(u => u.Id == editarusuario.Id).FirstOrDefault();
                    if (editarusuario.Activo == true)
                        usuario.Activo = false;
                    else
                        usuario.Activo = true;

                    //this.ListaUsuariosDtg.Refresh();

                    BD.SaveChanges();

                    this.ListaUsuariosDtg.DataSource = null;
                    this.ListaUsuariosDtg.DataSource = BD.Usuario.ToList();
                }
            }
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            this.ListaUsuariosDtg.DataSource = BD.Usuario.ToList();
        }
    }
}
