using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CESTApp.Clases
{
    public class Servicio
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Paciente paciente;

        public Paciente Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        private MedicoCanalizador medicocanalizador;

        public MedicoCanalizador MedicoCanalizador
        {
            get { return medicocanalizador; }
            set { medicocanalizador = value; }
        }

        private MedicoCE medicoresponsable;

        public MedicoCE MedicoResponsable
        {
            get { return medicoresponsable; }
            set { medicoresponsable = value; }
        }

        private EstadoServicio estado;

        public EstadoServicio Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private bool pagado;

        public bool Pagado
        {
            get { return pagado; }
            set { pagado = value; }
        }
    }
}
