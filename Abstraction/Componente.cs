using System.Collections.Generic;

namespace Abstraction
{
    public abstract class Componente
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
