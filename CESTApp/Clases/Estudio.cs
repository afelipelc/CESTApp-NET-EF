using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class Estudio
    {
       //campos de la clase
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
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private decimal costo;

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }
        private bool activo;

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

       
        //propiedades
        
    }
}
