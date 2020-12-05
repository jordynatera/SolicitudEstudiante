using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Estudiantes = new HashSet<Estudiante>();
        }

        public int IdPersona { get; set; }
        public int IdSexo { get; set; }
        public int IdNacionalidad { get; set; }
        public int IdContacto { get; set; }
        public int IdIdentificacion { get; set; }
        public string PriNomEst { get; set; }
        public string SegNomEst { get; set; }
        public string PriApeEst { get; set; }
        public string SegApeEst { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int NumIdPersona { get; set; }

        public virtual Contacto IdContactoNavigation { get; set; }
        public virtual Identificacion IdIdentificacionNavigation { get; set; }
        public virtual Nacionalidad IdNacionalidadNavigation { get; set; }
        public virtual Sexo IdSexoNavigation { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
    }
}
