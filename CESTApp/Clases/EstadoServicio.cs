using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class EstadoServicio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
