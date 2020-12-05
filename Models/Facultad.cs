using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Facultad
    {
        public Facultad()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdFacultad { get; set; }
        public string NombreFacultad { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
