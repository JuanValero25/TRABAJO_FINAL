using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Role : Componente
    {
        private List<Componente> hijos = new List<Componente>();

        public Role(string name) : base(name)
        {
        }

        public override void agregarHijo(Componente c)
        {
            hijos.Add(c);
        }

        public override List<Componente> ObtenerHijos()
        {
            return hijos;
        }
    }
}
