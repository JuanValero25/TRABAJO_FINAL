using Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Acceso : Componente
    {
        private List<Componente> hijos = new List<Componente>();

        public Acceso(string name) : base(name)
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
