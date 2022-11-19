using System;

namespace BE
{
    public class Inscripcion : Entidad
    {
        public DateTime FechaDeInscripcion { get; set; }
        public string AlumnoID { get; set; }
        public string CursoID { get; set; }

    }
}
