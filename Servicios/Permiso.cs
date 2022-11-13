using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Permiso : Componente
    {
        public Permiso(string name) : base(name)
        {
        }

        public override void agregarHijo(Componente c)
        {
         // como permiso no tiene hijos 
        }

        public override List<Componente> ObtenerHijos()
        {
            return null;
        }
    }
}
