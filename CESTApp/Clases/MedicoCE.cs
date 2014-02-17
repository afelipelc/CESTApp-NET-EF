using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class MedicoCE
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
        private List<Area>areas;

        public List<Area> Areas
        {
            get { return areas; }
            set { areas = value; }
        }
        private string especialidad_cargo;

        public string EspecialidadOCargo
        {
            get { return especialidad_cargo; }
            set { especialidad_cargo = value; }
        }
        private int cedulap;

        public int CedulaProfesional
        {
            get { return cedulap; }
            set { cedulap = value; }
        }

    }
}
