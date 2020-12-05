using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Contacto
    {
        public Contacto()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdContacto { get; set; }
        public string NombreContacto { get; set; }
        public int NumeroContacto { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
