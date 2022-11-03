using MPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
namespace BLL
{
   public class ProfesorBLL
    {

        ProfesorXMLMPP profXMLMPP = new ProfesorXMLMPP();



        public void saveProfesor(Profesor prof) {

            profXMLMPP.Save(prof);
        }

        public Profesor getProfesor(string ID) {

            return profXMLMPP.Get(ID);
        }

        public List<Profesor> getAll() {

            return profXMLMPP.GetAll();
        }

        public void EliminarProf(Profesor prof) {
            profXMLMPP.Delete(prof);
        }

    }
}
