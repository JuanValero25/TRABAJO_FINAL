using System;
using System.Collections.Generic;

namespace BE
{

    public class Curso : Entidad
    {
        public string Nombre { get; set; }

        public string MateriaID { get; set; }

        public List<string> ProfesoresID { get; set; }

        public DateTime fechaInicio { get; set; }
        public DateTime fechaFinalizacion { get; set; }

        public Decimal limiteEstudiantes { get; set; }

        public Decimal estudiantesInscritos { get; set; }

        public Decimal Precio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
