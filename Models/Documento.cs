using System;
using System.Collections.Generic;

#nullable disable

namespace SolicitudEstudiante.Models
{
    public partial class Documento
    {
        public int IdDocumento { get; set; }
        public int IdEstudiante { get; set; }
        public string CopiaCedula { get; set; }
        public string Foto { get; set; }
        public string RecordNotas { get; set; }
        public string KardexAcademico { get; set; }
        public string HojaRotacionInternado { get; set; }
        public string CarnetEstudiante { get; set; }
        public string FormRegTemaInves { get; set; }
        public string RecibodePago { get; set; }

        public virtual Estudiante IdEstudianteNavigation { get; set; }
    }
}
