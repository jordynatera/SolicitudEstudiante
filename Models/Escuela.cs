using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Escuela
    {
        public Escuela()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdEscuela { get; set; }
        public string NombreEscuela { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
