using BE;
using System.Collections.Generic;
namespace Servicios
{
    public abstract class Componente : Entidad
    {
        public string name { get; set; }

        public Componente(string name)
        {
            this.name = name;
        }

        public Componente()

        {
        }


        public abstract void agregarHijo(Componente c);
        public abstract List<Componente> ObtenerHijos();

    }
}
