using Abstraction;
using System.Collections.Generic;

namespace Servicios
{
    public class Permiso : Componente
    {
        public bool enable { get; set; }
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
