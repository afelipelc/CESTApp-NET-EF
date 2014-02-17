using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class MedicoCanalizador
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

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private int cedula;

        public int CedulaProfesional
        {
            get { return cedula; }
            set { cedula = value; }
        }
        
    }
}
