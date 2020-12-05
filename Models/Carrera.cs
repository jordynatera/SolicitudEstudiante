using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdCarrera { get; set; }
        public string NombreCarrera { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
