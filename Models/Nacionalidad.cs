using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Nacionalidad
    {
        public Nacionalidad()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdNacionalidad { get; set; }
        public string NombreNacionalidad { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
