using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CESTApp.Clases
{
    public class Usuario
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string nombreusuario;

        public string NombreUsuario
        {
            get { return nombreusuario; }
            set { nombreusuario = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string rol;
        
        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
