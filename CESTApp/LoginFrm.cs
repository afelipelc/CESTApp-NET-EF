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
    public partial class LoginFrm : Form
    {
        DBEntities BD = new DBEntities();
       
        Usuario buscarusuario = new Usuario();
        
        //identidad general (No usuario windows)
        private GenericIdentity Identidad;
        //usuario general (no windows)
        private GenericPrincipal usuarioapp;
        //List<string> Roles;


        public LoginFrm()
        {
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (this.NombreUsuarioTxt.Text == "")
            {
                MessageBox.Show("Ingrese su nombre de usuario.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.NombreUsuarioTxt.Focus();
                return;
            }

            if (this.PasswordTxt.Text == "")
            {
                MessageBox.Show("Ingrese su contraseña.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.PasswordTxt.Focus();
                return;
            }


            //ValidarDatos(this.NombreUsuarioTxt.Text.
            //MessageBox.Show(this.NombreUsuarioTxt.Text.GetHashCode().ToString());

            if (ValidarDatos(this.NombreUsuarioTxt.Text, this.PasswordTxt.Text))
            {
                CargarModulo();
                this.NombreUsuarioTxt.Text = "";
                this.PasswordTxt.Text = "";
                this.Enabled = false;
                this.Visible = false;
                this.ShowInTaskbar = false;
            }
            else
            {
                MessageBox.Show("Nombre de usuario y contraseña incorrectos.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NombreUsuarioTxt.Text = "";
                this.PasswordTxt.Text = "";
                this.NombreUsuarioTxt.Focus();
            }
        }

        //Metodo que verificara que los datos sean correctos
        private bool ValidarDatos(string usuario, string contrasena)
        {
            buscarusuario = null;
            buscarusuario = BD.Usuario.Where(u => u.NombreUsuario == usuario && u.Password == contrasena).FirstOrDefault();

            if (buscarusuario != null)
            {
                //registrar la identidad
                Identidad = new GenericIdentity(buscarusuario.NombreUsuario.Trim());   
                //Identidad = new GenericIdentity("afelipelc");   

                //registrar roles
                //foreach(Rol rol in buscarusuario.Rol)
                //{
                //    Roles.Add(rol.Nombre.Trim());
                //}

                //var rolesusr = BD.Rol.Where(r => r.IdUsuario == buscarusuario.Id).Select( rs => rs.Nombre.Trim()).ToList();
                //string[] rols = new string[2] { "Administrador", "Consultas" };
                //crear el usuario
                //usuarioapp = new GenericPrincipal(Identidad, Roles.ToArray());
                usuarioapp = new GenericPrincipal(Identidad,buscarusuario.Rol.Select(r => r.Nombre.Trim()).ToArray());
                
                //enlazar el usuario con la aplicacion
                Thread.CurrentPrincipal = usuarioapp;

                return true;
            }
            else
                return false;           
        }

        //MostrarVentana dependiendo del rol
        private void CargarModulo()
        {
            if (buscarusuario.Activo == true)
            {
                //MessageBox.Show("Bienvenido...", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Rol rol;

                //administrador
                rol = buscarusuario.Rol.Where(r => r.Nombre.Trim() == "Administrador").FirstOrDefault();
                if (rol != null)
                {
                    AdministradorFrm administrador = new AdministradorFrm();
                    this.Hide();
                    administrador.Show();
                    //this.Close();
                    return;
                }

                //medico
                rol = buscarusuario.Rol.Where(r => r.Nombre.Trim() == "Medico").FirstOrDefault();
                if (rol != null)
                {
                    ServiciosMedicoCEFrm serviciosmedico = new ServiciosMedicoCEFrm();
                    this.Hide();
                    serviciosmedico.Show();
                    //this.Close();
                    return;
                }

                //Cajera
                rol = buscarusuario.Rol.Where(r => r.Nombre.Trim() == "Caja").FirstOrDefault();
                if (rol != null)
                {
                    ServiciosNoPagadosFrm caja = new ServiciosNoPagadosFrm();
                    this.Hide();
                    caja.Show();
                    //this.Close();
                    return;
                }

                //Recepcion
                rol = buscarusuario.Rol.Where(r => r.Nombre.Trim() == "Recepcion").FirstOrDefault();
                if (rol != null)
                {
                    RecepcionFrm recepcion = new RecepcionFrm();
                    this.Hide();
                    recepcion.Show();
                    //this.Close();
                    return;
                } 
             
                if(rol == null)
                    MessageBox.Show("No tiene ningún privilegio en la aplicación.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("No tiene privilegios de acceso a la aplicación.", "Centro de estudios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.NombreUsuarioTxt.Text = "";
                this.PasswordTxt.Text = "";
                this.NombreUsuarioTxt.Focus();
            }
        }

        private void RegistrarSesion()
        {

        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {            
            try
            {
                BD.Connection.Open();
                BD.Connection.Close();
            }
            catch (EntityException)
            {
                MessageBox.Show("No se pudo conectar al servidor de base de datos. \nVerifique que el servidor esta correctamente instalado e iniciado. \nVerifique que la base de datos se encuentra en la carpeta de la aplicación. \nLa aplicación se cerrará, contacte al proveedor del sistema.", "Error grave relacionado con la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

           
        }

    }
}
