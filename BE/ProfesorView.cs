using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class ProfesorView
    {
        public string ID { get; set; }
        public string nombre_apellido { get; set; }

        public ProfesorView(string iD, string nombre_apellido)
        {
            ID = iD;
            this.nombre_apellido = nombre_apellido;
        }

        public ProfesorView()
        {
        }
    }
}
