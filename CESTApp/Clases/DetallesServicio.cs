using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class DetallesServicio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private Servicio servicio;

        public Servicio Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        private Estudio estudio;

        public Estudio Estudio
        {
            get { return estudio; }
            set { estudio = value; }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }        
    }
}
