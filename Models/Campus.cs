using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Campus
    {
        public Campus()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdCampus { get; set; }
        public string NombreCampus { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
