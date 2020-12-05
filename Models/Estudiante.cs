using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Estudiante
    {
        public Estudiante()
        {
            Documentos = new HashSet<Documento>();
        }

        public int MatriculaEst { get; set; }
        public int? IdPersona { get; set; }
        public int IdCampus { get; set; }
        public int? IdFacultad { get; set; }
        public int? IdEscuela { get; set; }
        public int? IdCarrera { get; set; }
        public int? IdTipoSolicitud { get; set; }
        public int? IdPlanEstudio { get; set; }

        public virtual Campus IdCampusNavigation { get; set; }
        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Escuela IdEscuelaNavigation { get; set; }
        public virtual Facultad IdFacultadNavigation { get; set; }
        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual PlanEstudio IdPlanEstudioNavigation { get; set; }
        public virtual TipoSolicitud IdTipoSolicitudNavigation { get; set; }
        public virtual ICollection<Documento> Documentos { get; set; }
    }
}
