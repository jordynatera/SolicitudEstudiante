using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class PlanEstudio
    {
        public PlanEstudio()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdPlanEstudio { get; set; }
        public string NombrePlanEstudio { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
