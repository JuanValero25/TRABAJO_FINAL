using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Materia : Entidad
    {
        public string Nombre {get;set;}

        public string Codigo { get; set; }

        public Decimal precio { get; set; }

        public MateriaView toView() {

            return new MateriaView
            {
                ID = this.ID,
                nombre = this.Nombre

            };
        }

    }
}
