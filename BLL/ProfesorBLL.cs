using BE;
using MPP;
using System.Collections.Generic;
namespace BLL
{
    public class ProfesorBLL
    {

        ProfesorXMLMPP profXMLMPP = new ProfesorXMLMPP();



        public void saveProfesor(Profesor prof)
        {

            profXMLMPP.Save(prof);
        }

        public Profesor getProfesor(string ID)
        {

            return profXMLMPP.Get(ID);
        }

        public List<Profesor> getAll()
        {

            return profXMLMPP.GetAll();
        }

        public void EliminarProf(Profesor prof)
        {
            profXMLMPP.Delete(prof);
        }

    }
}
