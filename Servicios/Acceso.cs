using Abstraction;
using System.Collections.Generic;

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
