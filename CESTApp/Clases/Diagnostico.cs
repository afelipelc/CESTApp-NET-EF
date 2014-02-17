using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class Diagnostico
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

        private string resultado;

        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }

    }
}
