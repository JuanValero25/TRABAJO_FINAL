using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPP;
using BE;
namespace BLL
{
    public class MateriaBLL
    {

        MateriaXMLMPP mpp = new MateriaXMLMPP();


        public void SaveMateria(Materia materia) {
            mpp.Save(materia);


        }

        public Materia Get(string ID) {
            return mpp.Get(ID);
        }

        public List<Materia> getAllMaterias() {

            return mpp.GetAll();
        }

        public void EliminarMateria(Materia materia) {

            mpp.Delete(materia);
        }


    }
}
