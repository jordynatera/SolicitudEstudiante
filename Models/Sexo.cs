using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Sexo
    {
        public Sexo()
        {
            Personas = new HashSet<Persona>();
        }

        public int IdSexo { get; set; }
        public string NombreSexo { get; set; }

        public virtual ICollection<Persona> Personas { get; set; }
    }
}
