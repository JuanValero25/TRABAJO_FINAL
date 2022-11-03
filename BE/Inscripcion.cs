using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Inscripcion : Entidad
    {
        public DateTime FechaDeInscripcion { get; set; }
        public string AlumnoID { get; set; }
        public string AulaID { get; set; }

    }
}
