using System.Collections.Generic;

namespace Servicios
{
    public class Role : Componente
    {
        private List<Componente> hijos = new List<Componente>();

        public Role(string name) : base(name)
        {
        }

        public Role()
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
