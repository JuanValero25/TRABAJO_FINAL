using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AulaNotas: Entidad
    {

        public string AulaID { get; set; }
        public string Alumno_ID { get; set; }
        public string Nota { get; set; }
        public DateTime Fecha { get; set; }

    }
}
