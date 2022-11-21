using System;

namespace BE
{
    public class Inscripcion : Entidad
    {
        public DateTime FechaDeInscripcion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string AlumnoID { get; set; }
        public string CursoID { get; set; }

        public int notaFinal { get; set; }

        public int notaCursada { get; set; }

        public string cursadaEstado { get; set; }

    }
}
