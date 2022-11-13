using BE;
using MPP;
using System.Collections.Generic;
namespace BLL
{
    public class MateriaBLL
    {

        MateriaXMLMPP mpp = new MateriaXMLMPP();


        public void SaveMateria(Materia materia)
        {
            mpp.Save(materia);


        }

        public Materia Get(string ID)
        {
            return mpp.Get(ID);
        }

        public List<Materia> getAllMaterias()
        {

            return mpp.GetAll();
        }

        public void EliminarMateria(Materia materia)
        {

            mpp.Delete(materia);
        }


    }
}
