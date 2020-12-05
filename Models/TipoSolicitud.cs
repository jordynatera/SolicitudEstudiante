using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class TipoSolicitud
    {
        public TipoSolicitud()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdTipoSolicitud { get; set; }
        public string NombreServicio { get; set; }

        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
