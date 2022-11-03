using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Curso : Entidad
    {
        public string Nombre { get; set; }

        public string MateriaID { get; set; }

        public List<string> ProfesoresID { get; set; }

        public Decimal Precio { get; set; }
    }
}
