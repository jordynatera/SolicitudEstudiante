using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Identificacion
    {
        public Identificacion()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdIdentificacion { get; set; }
        public string NombreIdentificacion { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
